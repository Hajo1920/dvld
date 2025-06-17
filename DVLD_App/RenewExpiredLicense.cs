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
    public partial class RenewExpiredLicense : Form
    {
        public delegate void SendApplicationID(int id, string mood);
        public event SendApplicationID sendId;


        int currentUserId = Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]);
        int ApplicationId = 0;
        int personId;
        int driverId;
        int _licenseId = 0;
        int LDLAppId;
        int licenseClassId;

        public RenewExpiredLicense()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenewExpiredLicense_Load(object sender, EventArgs e)
        {
            btnRenew.Enabled = false;
            linkShowLicenseHistory.Enabled = false;
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
                    _licenseId = Convert.ToInt32(row_LicenseDetail[0]);
                    licenseClassId = Convert.ToInt32(row_applicationDetail[3]);
                    sendId.Invoke(ldlID, "Active");
                    personId = Convert.ToInt32(row_applicationDetail[1]);
                    driverId = Convert.ToInt32(row_LicenseDetail[2]);
                    linkShowLicenseHistory.Enabled = true;
                    ApplicationId = Convert.ToInt32(row_applicationDetail[0]);
                    DateTime expireDate = Convert.ToDateTime(row_LicenseDetail[5]);

                    if (expireDate > DateTime.Now)
                    {
                        btnRenew.Enabled = false;
                        lbLicenseStatus.Text = "Valied";
                        lbLicenseStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        btnRenew.Enabled = true;
                        lbLicenseStatus.Text = "Expired";
                        lbLicenseStatus.ForeColor = Color.Red;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure want to renew this license ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                

                int validityLength = GetLicenseValidityLengthBusinessLayerClass.GetLicenseValidityLengthByLicenseClassID(licenseClassId);
                if (RenewExpiredLicenseBusinessLayerClass.RenewExpiredLicense(_licenseId, DateTime.Now, DateTime.Now.AddYears(validityLength))){
                    MessageBox.Show($"License renewed successfully! \n IssueDate: {DateTime.Now}\n ExpireDate: {DateTime.Now.AddYears(validityLength)}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbFilter.Text = _licenseId.ToString();
                    btnSearch.PerformClick();
                }
                else
                {
                    MessageBox.Show($"Error: License renew process failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

