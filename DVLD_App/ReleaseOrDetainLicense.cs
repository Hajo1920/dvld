using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_App
{
    public partial class ReleaseOrDetainLicense : Form
    {
        public delegate void SendApplicationID(int id, string mood);
        public event SendApplicationID sendId;

        public delegate void RefreshList();
        public event RefreshList refreshlist;

        public enum EnMood { Detain = 0, Release = 1 };
        public EnMood mood;

        int currentUserId = Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]);
        int ApplicationId = 0;
        int personId;
        int driverId;
        int _licenseId = 0;
        int LDLAppId;

        public ReleaseOrDetainLicense(EnMood processMood)
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            mood = processMood;
        }

        public ReleaseOrDetainLicense(int licenseId, EnMood processMood)
        {
            InitializeComponent();
            tbFilter.Text = licenseId.ToString();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _licenseId = licenseId;
            mood = processMood;

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetainLicense_Load(object sender, EventArgs e)
        {
            btnDetain.Enabled = false;
            linkShowLicense.Enabled = false;
            linkShowLicenseHistory.Enabled = false;

            lbCreatedBy.Text = UsersListBusinessLayerClass.GetUserNameByUserId(currentUserId);

            switch (mood)
            {
                case EnMood.Detain:
                    lbTitle.Text = "Detain License";
                    lbDetainDate.Text = DateTime.Today.ToString();
                    btnDetain.Text = "Detain";
                    break;
                case EnMood.Release:
                    lbTitle.Text = "Release License";
                    tbFineFee.Visible = false;
                    lbTitleFineFee.Visible = false;
                    lbTitleDetainDate.Text = "Release Date:";
                    lbDetainDate.Text = DateTime.Today.ToString();
                    btnDetain.Text = "Release";

                    if (_licenseId != 0)
                    {
                        btnSearch.PerformClick();
                    }
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text))
            {
                errorProvider1.SetError(tbFilter, "License input is required !");
            }
            else
            {
                errorProvider1.Clear();
                int licenseId = Convert.ToInt32(tbFilter.Text);
                sendId += driverLicenseInfouc1.Load_data;

                try
                {

                    DataRow row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationById(licenseId).Rows[0];
                    DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(Convert.ToInt32(row_LicenseDetail[1])).Rows[0];
                    int ldlID = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationIdByApplicationID(Convert.ToInt32(row_applicationDetail[0]));
                    LDLAppId = ldlID;
                    sendId.Invoke(ldlID, "Active");
                    personId = Convert.ToInt32(row_applicationDetail[1]);
                    driverId = Convert.ToInt32(row_LicenseDetail[2]);
                    int detainId = DetainLicenseBusinessLayerClass.GetDetainIdUsingLicenseId(licenseId);
                    switch (mood)
                    {
                        case EnMood.Detain:
                            if (detainId != -1)
                            {
                                btnDetain.Enabled = false;
                                lbDetainId.Text = detainId.ToString();
                                MessageBox.Show($"This license is currently detained and not released yet !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else btnDetain.Enabled = true;
                            break;
                        case EnMood.Release:
                            if (detainId != -1)
                            {

                                lbDetainId.Text = detainId.ToString();
                                btnDetain.Enabled = true;

                            }
                            else
                            {
                                MessageBox.Show($"This license is not detained !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnDetain.Enabled = false;
                            }
                            break;
                    }


                    linkShowLicense.Enabled = true;
                    linkShowLicenseHistory.Enabled = true;
                    lbLicenseId.Text = licenseId.ToString();
                    ApplicationId = Convert.ToInt32(row_applicationDetail[0]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void linkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowDriverLicense showInternationalLicense = new ShowDriverLicense(LDLAppId, "Active");
            showInternationalLicense.ShowDialog();
        }

        private void linkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ApplicationId != 0)
            {
                ShowPersonLicenseHistory licenseHistory = new ShowPersonLicenseHistory(ApplicationId);
                licenseHistory.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Error: No Application ID provided currently!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (mood == EnMood.Detain && string.IsNullOrEmpty(tbFineFee.Text))
            {
                errorProvider1.SetError(tbFineFee, "Fine fee is required !");
            }
            else
            {
                errorProvider1.Clear();
                string processName = mood == EnMood.Detain ? "detain" : "release";
                DialogResult result = MessageBox.Show($"Are you sure want to {processName} this license ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int detainId;
                    int licenseId = Convert.ToInt32(tbFilter.Text);
                    switch (mood)
                    {
                        case EnMood.Detain:
                            if ((detainId = DetainLicenseBusinessLayerClass.DetainLocalLicense(licenseId, DateTime.Now, Convert.ToDecimal(tbFineFee.Text), currentUserId, false, Convert.ToDateTime("9999-12-30"), 0, 0)) != -1)
                            {
                                MessageBox.Show($"License with ID={licenseId} detained successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lbDetainId.Text = detainId.ToString();
                                btnDetain.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show($"Error: Detain process failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case EnMood.Release:
                            DataRow row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationById(licenseId).Rows[0];
                            if (ReleaseDetainedLicenseBusinessLayerClass.ReleaseDetainedLocalLicense(licenseId, true, DateTime.Now, currentUserId, Convert.ToInt32(row_LicenseDetail[1])))
                            {
                                MessageBox.Show($"License with ID={licenseId} released successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnDetain.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show($"Error: Release process failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }
                }
            }
           
        }

        private void DetainLicense_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshlist.Invoke();
        }

       
    }
}
