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
using DVLD_DataLayer;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_App
{
    public partial class NewUpdateDrivingLicenseApplication : Form
    {

        public delegate void RefreshUsers();
        public event RefreshUsers refresh;

        public enum EnumRefreshMood { yes = 1, no = 0 }
        EnumRefreshMood refreshMood;

        public delegate void RefreshList();
        public static event RefreshList refreshList;

        int personId;
        DataTable table = AddNewLocalLicenseApplicationBusinessLayerClass.LicenseClassesList();
        public NewUpdateDrivingLicenseApplication(EnumRefreshMood mood)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            refreshMood = mood;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetId(int id)
        {
            personId = id;
            btnNext.Enabled = true;
            panelHolder.Enabled = true;
            setUserName();

        }
        void setUserName()
        {
            DataRow userNamerow = UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0];
            lbCreatedBy.Text = userNamerow["UserName"].ToString();
        }

        public static void BypassRefresh() { }

        private void NewDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            panelHolder.Enabled = false;
            findPersonuc1.sendid += GetId;
            personInfouc1.ID = personId;
            findPersonuc1.sendid += personInfouc1.ShowPersonInfo;
            findPersonuc1.revealLink += personInfouc1.RevealLink;
            lbApplicationDate.Text = DateTime.Now.ToString();


            foreach (DataRow row in table.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);
            }

            cbLicenseClasses.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
        }

        private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRow row = table.Rows[cbLicenseClasses.SelectedIndex];
            lbApplicationFee.Text = Convert.ToInt32(row["ClassFees"]).ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            int driverId = GetDriverIdByPersonIdBusinessLayerClass.GetDriverIdByPersonId(personId);
            DataTable license_table = GetLicenseInformationByIdDataLayerClass.GetLicenseHistoryInformationById(driverId);

            
            if (CheckApplicationClassExistByPersonAndClassIdBusinessLayerClass.CheckApplicationClassExist(personId, cbLicenseClasses.SelectedIndex + 1) == false) {
                int applicationId = AddNewLocalLicenseApplicationBusinessLayerClass.AddNewLocalDrivingApplication(personId, Convert.ToDateTime(lbApplicationDate.Text), Convert.ToInt32(cbLicenseClasses.SelectedIndex + 1), 1, 1, Convert.ToDateTime(lbApplicationDate.Text), Convert.ToDecimal(lbApplicationFee.Text), Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]));

                if (applicationId != -1)
                {
                    lbApplicationID.Text = applicationId.ToString();
                    MessageBox.Show("Application Added Successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You have already similar class application !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void NewUpdateDrivingLicenseApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(refreshMood == EnumRefreshMood.yes)
            {
                refreshList.Invoke();
            }
        }
    }
}
