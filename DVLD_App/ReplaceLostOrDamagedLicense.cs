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

namespace DVLD_App
{
    public partial class ReplaceLostOrDamagedLicense : Form
    {


        public ReplaceLostOrDamagedLicense()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        public delegate void SendApplicationID(int id, string mood);
        public event SendApplicationID sendId;
        int ApplicationId = 0;
        int LDLId = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int licenseId = Convert.ToInt32(tbFilter.Text);
            sendId += driverLicenseInfouc1.Load_data;

            try
            {

                DataRow row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationById(licenseId).Rows[0];
                DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(Convert.ToInt32(row_LicenseDetail[1])).Rows[0];
                int ldlID = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationIdByApplicationID(Convert.ToInt32(row_applicationDetail[0]));
                sendId.Invoke(ldlID, "Active");
                btnIssue.Enabled = true;
                lbOldLicenseID.Text = licenseId.ToString();
                ApplicationId = Convert.ToInt32(row_applicationDetail[0]);
                LDLId = ldlID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceLostOrDamagedLicense_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            int currentUserId = Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]);
            rbLost.Checked = true;
            lbApplicationDate.Text = DateTime.Today.ToString();
            lbCreatedBy.Text = UsersListBusinessLayerClass.GetUserNameByUserId(currentUserId);
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lbApplicationFee.Text = "10";
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lbApplicationFee.Text = "5";
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int newLicenseId;
            int licenseId = Convert.ToInt32(tbFilter.Text);
            DataRow row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationById(licenseId).Rows[0];
            DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(Convert.ToInt32(row_LicenseDetail[1])).Rows[0];
            int personId = Convert.ToInt32(row_applicationDetail[1]);
            int licenseClassId = Convert.ToInt32(row_applicationDetail[3]);
            int driverId = Convert.ToInt32(row_LicenseDetail[2]);
            DateTime issueDate = Convert.ToDateTime(row_LicenseDetail[4]);
            DateTime expireDate = Convert.ToDateTime(row_LicenseDetail[5]);
            if ((newLicenseId = AddDriverAndIssueDrivingLicenseBusinessLayerClass.AddLicenseReplacementForExistingDriver(driverId, Convert.ToInt32(row_applicationDetail[0]), licenseClassId, issueDate, expireDate, Convert.ToString(row_LicenseDetail[6]), Convert.ToDecimal(lbApplicationFee.Text), true, 2, Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]))) != -1 && UpdateActiveStatusForLicenseByIdBusinessLayerClass.UpdateActiveStatusForLicenseById(licenseId, false))
            {
                MessageBox.Show($"New license issued with ID={newLicenseId} Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbNewLicenseID.Text = newLicenseId.ToString();
                lbR_AppID.Text = Convert.ToString(row_LicenseDetail[1]);
               
            }
            else
            {
                MessageBox.Show($"Error: Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(LDLId != 0)
            {
                ShowDriverLicense showDriverLicense = new ShowDriverLicense(LDLId, "Active");
                showDriverLicense.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Error: No new license issued currently!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
