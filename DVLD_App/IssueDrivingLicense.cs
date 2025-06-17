using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD;
using DVLD_BusinessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_App
{
    public partial class IssueDrivingLicense : Form
    {
        public delegate void ShowInformation(int id);
        public event ShowInformation info;

        public delegate void RefreshApplicationList();
        public event RefreshApplicationList refreshList;
        int _id;
        int _personId;
        public IssueDrivingLicense(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            _id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int licenseId;
            
            DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(_id).Rows[0];
  
            
            int driverId;
            if ((driverId = GetDriverIdByPersonIdBusinessLayerClass.GetDriverIdByPersonId(Convert.ToInt32(row_applicationDetail[1]))) != -1)
            {


                int licenseClassId = Convert.ToInt32(row_applicationDetail[3]);

                int validityLength = GetLicenseValidityLengthBusinessLayerClass.GetLicenseValidityLengthByLicenseClassID(licenseClassId);

                if ((licenseId = AddDriverAndIssueDrivingLicenseBusinessLayerClass.AddLicenseReplacementForExistingDriver(driverId, Convert.ToInt32(row_applicationDetail[0]), licenseClassId, DateTime.Now, DateTime.Now.AddYears(validityLength), tbNote.Text, 20, true, 1, Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]))) != -1 && UpdateLicenseApplicationStatusBusinessLayerClass.UpdateLicenseApplicationStatus(Convert.ToInt32(row_applicationDetail[0]), 3))
                {
                    MessageBox.Show($"New license with LicenseID={licenseId} issued successfully for Driver with ID={driverId}", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"License issue Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                _personId = Convert.ToInt32(row_applicationDetail[1]);
                int licenseClassId = Convert.ToInt32(row_applicationDetail[3]);

                int validityLength = GetLicenseValidityLengthBusinessLayerClass.GetLicenseValidityLengthByLicenseClassID(licenseClassId);

                if ((licenseId = AddDriverAndIssueDrivingLicenseBusinessLayerClass.AddDriverAndIssueDrivingLicense(_personId, Convert.ToInt32(row_applicationDetail[0]), licenseClassId, DateTime.Now, DateTime.Now.AddYears(validityLength), tbNote.Text, 20, true, 1, Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]))) != -1 && UpdateLicenseApplicationStatusBusinessLayerClass.UpdateLicenseApplicationStatus(Convert.ToInt32(row_applicationDetail[0]), 3))
                {
                    MessageBox.Show($"New license with LicenseID={licenseId} issued successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"License issue Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



        }

        private void IssueDrivingLicense_Load(object sender, EventArgs e)
        {
            info += showApplicationDetailuc1.ShowDetails;
            info.Invoke(_id);
        }

        private void IssueDrivingLicense_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshList.Invoke();
        }
    }
}
