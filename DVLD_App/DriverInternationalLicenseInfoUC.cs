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
using DVLD_App.Properties;
using DVLD_BusinessLayer;

namespace DVLD_App
{
    public partial class DriverInternationalLicenseInfoUC : UserControl
    {
        public DriverInternationalLicenseInfoUC()
        {
            InitializeComponent();
        }

        public void Load_Data(int internationalId)
        {
          
            DataRow row_info = GetInternationalLicenseInformationByIdBusinessLayerClass.GetInternationalLicenseInformationById(internationalId).Rows[0];
            DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(Convert.ToInt32(row_info[1])).Rows[0];
            DataRow row_personInfo = FullPersonDetailBusinessLayerClass.FullPersonDetail(Convert.ToInt32(row_applicationDetail[1])).Rows[0];
            string name = row_personInfo[2].ToString() + " " + row_personInfo[3].ToString() + " " + row_personInfo[4].ToString() + " " + row_personInfo[5].ToString();

            lbName.Text = name;
            lbNationalNo.Text = row_personInfo[1].ToString();
            lbGendor.Text = row_personInfo[7].ToString() == "0" ? "Male" : "Female";
            lbBirthDate.Text = row_personInfo[6].ToString();
            lbInternationalLicenseId.Text = Convert.ToString(row_info[0]);
            lbApplicationID.Text = Convert.ToString(row_info[1]);
            lbDriverID.Text = Convert.ToString( row_info[2]);
            lbLicenseID.Text = Convert.ToString(row_info[3]);
            lbIssueDate.Text = Convert.ToString(row_info[4]);
            lbExpireDate.Text = Convert.ToString(row_info[5]);
            lbIsActive.Text = Convert.ToString(row_info[6]) == "True" ? "Yes" : "False";

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

        private void DriverInternationalLicenseInfoUC_Load(object sender, EventArgs e)
        {

        }
    }
}
