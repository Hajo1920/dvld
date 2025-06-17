using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_App.Properties;
using DVLD_BusinessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_App
{
    public partial class DriverLicenseInfoUC : UserControl
    {

        string licenseShowMood;

        public DriverLicenseInfoUC()
        {
            InitializeComponent();

        }


        public void Load_data(int id, string mood)
        {
            licenseShowMood = mood;
            DataRow row_ldlApplicationDetail = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationDetailById(id).Rows[0];
            DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(id).Rows[0];

            DataRow row_LicenseDetail;
            switch (licenseShowMood)
            {
                case "Active":
                   row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationById(Convert.ToInt32(row_applicationDetail[0])).Rows[0];
                    lbLicenseID.Text = row_LicenseDetail[0].ToString();
                    lbIssueDate.Text = row_LicenseDetail[4].ToString();
                    lbNotes.Text = row_LicenseDetail[6] == null ? "No Notes" : row_LicenseDetail[6].ToString();
                    lbIsActive.Text = row_LicenseDetail[8].ToString() == "True" ? "Yes" : "No";
                    lbDriverID.Text = row_LicenseDetail[2].ToString();
                    lbExpireDate.Text = row_LicenseDetail[5].ToString();

                    switch (row_LicenseDetail[9].ToString())
                    {
                        case "1":
                            lbIssueReason.Text = "First Time License";
                            break;
                        case "2":
                            lbIssueReason.Text = "Lost/Damaged License Replacement";
                            break;
                        case "3":
                            lbIssueReason.Text = "Renewed License";
                            break;
                    }

                    break;
                case "Any":
                    row_LicenseDetail = GetLicenseInformationByIdBusinessLayerClass.GetLicenseInformationByIdWithoutIsActiveCheck(Convert.ToInt32(row_applicationDetail[0])).Rows[0];
                    lbLicenseID.Text = row_LicenseDetail[0].ToString();
                    lbIssueDate.Text = row_LicenseDetail[4].ToString();
                    lbNotes.Text = row_LicenseDetail[6] == null ? "No Notes" : row_LicenseDetail[6].ToString();
                    lbIsActive.Text = row_LicenseDetail[8].ToString() == "True" ? "Yes" : "No";
                    lbDriverID.Text = row_LicenseDetail[2].ToString();
                    lbExpireDate.Text = row_LicenseDetail[5].ToString();

                    switch (row_LicenseDetail[9].ToString())
                    {
                        case "1":
                            lbIssueReason.Text = "First Time License";
                            break;
                        case "2":
                            lbIssueReason.Text = "Lost/Damaged License Replacement";
                            break;
                        case "3":
                            lbIssueReason.Text = "Renewed License";
                            break;
                    }

                    break;
            }

            DataRow row_personInfo = FullPersonDetailBusinessLayerClass.FullPersonDetail(Convert.ToInt32(row_applicationDetail[1])).Rows[0];

            lbName.Text = row_ldlApplicationDetail[3].ToString();
            lbLicenseClass.Text = row_ldlApplicationDetail[1].ToString();
            lbNationalNo.Text = row_ldlApplicationDetail[2].ToString();
            lbBirthDate.Text = row_personInfo[6].ToString();
            lbGendor.Text = row_personInfo[7].ToString() == "1" ? "Female" : "Male";
            
            string imagePath = row_personInfo["ImagePath"]?.ToString();

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pbPersonPic.Image = new Bitmap(imagePath);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {

                pbPersonPic.Image = Resources.no_image1;
            }



        }

       
    }
}
