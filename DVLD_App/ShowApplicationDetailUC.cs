using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_App
{
    public partial class ShowApplicationDetailUC : UserControl
    {

        int applicationId;
        int personId;
        public ShowApplicationDetailUC()
        {
            InitializeComponent();
        }

        public void ShowDetails(int Id)
        {
            applicationId = Id;
            DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(applicationId).Rows[0];
            DataRow row_ldlApplicationDetail = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationDetailById(applicationId).Rows[0];
            personId = Convert.ToInt32(row_applicationDetail[1]);

            lbLDLApplicationID.Text = row_ldlApplicationDetail[0].ToString();
            lbAppliedForLicense.Text = row_ldlApplicationDetail[1].ToString();
            lbPassedTests.Text = row_ldlApplicationDetail[5].ToString()+ "/3";


            lbApplicationID.Text = row_applicationDetail[0].ToString();
            lbApplicationStatus.Text = row_ldlApplicationDetail[6].ToString();
            lbFee.Text = Convert.ToInt32(row_applicationDetail[7]).ToString();
            lbApplicationType.Text = GetApplicationDetailBusinessLayerClass.GetApplicationType(Convert.ToInt32(row_applicationDetail[4]));
            lbApplicantName.Text = row_ldlApplicationDetail[3].ToString();
            lbApplyDate.Text = row_applicationDetail[2].ToString();
            lbApplicationStatusDate.Text = row_applicationDetail[6].ToString();
            lbCreatedBy.Text = UsersListBusinessLayerClass.GetUserNameByUserId(Convert.ToInt32(row_applicationDetail[8]));


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetail detail = new ShowPersonDetail(personId);
            detail.ShowDialog();
        }
    }
}
