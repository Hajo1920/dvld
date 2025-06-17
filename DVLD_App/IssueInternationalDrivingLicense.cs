using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD;
using DVLD_BusinessLayer;
using static DVLD_App.FindPersonUC;

namespace DVLD_App
{
    public partial class IssueInternationalDrivingLicense : Form
    {
        public IssueInternationalDrivingLicense()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        public delegate void SendApplicationID(int id, string mood);
        public event SendApplicationID sendId;
        int currentUserId = Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]);
        int ApplicationId = 0;
        int LDLId = 0;
        int personId;
        int driverId;
        int internationalLicenseId;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            linkShowLicense.Enabled = false;

            lbApplicationDate.Text = DateTime.Today.ToString();
            lbIssueDate.Text = DateTime.Today.ToString();
            lbFee.Text = "50";
            lbCreatedBy.Text = UsersListBusinessLayerClass.GetUserNameByUserId(currentUserId);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            int licenseId = Convert.ToInt32(tbFilter.Text);
            if ((internationalLicenseId = AddApplicationAndIssueInternationalLicenseBusinessLayerClass.AddApplicationAndIssueInternationalLicense(personId, driverId, licenseId, 3, 6, 3, DateTime.Now, DateTime.Now.AddYears(5), 20, true, currentUserId)) != -1)
            {
                MessageBox.Show($"New international license issued with ID={internationalLicenseId}\n for Driver with ID={driverId} Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                linkShowLicense.Enabled = true;
                lbInternatioanlLicenseID.Text = internationalLicenseId.ToString();
                btnIssue.Enabled = false;
            }
            else
            {
                MessageBox.Show($"Error: Process failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int licenseId = Convert.ToInt32(tbFilter.Text);
            sendId += driverLicenseInfouc1.Load_data;

            try
            {

                DataRow row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationById(licenseId).Rows[0];
                if (Convert.ToInt32(row_LicenseDetail[3]) != 3)
                {
                    MessageBox.Show($"to issue international license\nLocal license must be only \nClass 3 - Ordinary driving license", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(Convert.ToInt32(row_LicenseDetail[1])).Rows[0];
                    int ldlID = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationIdByApplicationID(Convert.ToInt32(row_applicationDetail[0]));
                    sendId.Invoke(ldlID, "Active");
                    personId = Convert.ToInt32(row_applicationDetail[1]);
                    
                    driverId = Convert.ToInt32(row_LicenseDetail[2]);
               
                    btnIssue.Enabled = true;
                    lbLocalLicenseID.Text = licenseId.ToString();
                    ApplicationId = Convert.ToInt32(row_applicationDetail[0]);
                    LDLId = ldlID;
                    if ((internationalLicenseId = CheckLInternationalLicenseExistByLicenseIdBusinessLayerClass.CheckLInternationalLicenseExistByLicenseId(licenseId)) != -1)
                    {
                        MessageBox.Show($"This license owner already have an existing international license !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbInternatioanlLicenseID.Text = internationalLicenseId.ToString();
                        btnIssue.Enabled = false;
                        linkShowLicense.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void linkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowInternationalLicenseInformation showInternationalLicense = new ShowInternationalLicenseInformation(internationalLicenseId);
            showInternationalLicense.ShowDialog();
        }
    }
}
