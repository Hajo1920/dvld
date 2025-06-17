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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_App
{
    public partial class UpdateLocalDrivingLicenseApplication : Form
    {
        int _id;
        DataTable table = AddNewLocalLicenseApplicationBusinessLayerClass.LicenseClassesList();
        public delegate void RefreshList();
        public static event RefreshList refreshList;
        public UpdateLocalDrivingLicenseApplication(int id)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateLocalLicenseApplicationBusinessLayerClass.UpdateLocalLicenseApplication(GetApplicationDetailBusinessLayerClass.GetApplicationID(_id), Convert.ToDateTime(lbApplicationDate.Text), Convert.ToInt32(cbLicenseClasses.SelectedIndex + 1), 1, DateTime.Now,Convert.ToDecimal(lbApplicationFee.Text), Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0])))
            {

                MessageBox.Show("Application Updated Successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            DataView rowView = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationDetailById(_id).DefaultView;

            DataRow userNamerow = UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0];

            if (rowView.Count > 0)
            {
                lbApplicationID.Text = rowView[0][0].ToString();
                lbApplicationDate.Text = rowView[0][4].ToString();
                lbCreatedBy.Text = userNamerow["UserName"].ToString();

                foreach (DataRow row in table.Rows)
                {
                    cbLicenseClasses.Items.Add(row["ClassName"]);
                }

                cbLicenseClasses.SelectedIndex = 0;


            }

        }

        private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = table.Rows[cbLicenseClasses.SelectedIndex];
            lbApplicationFee.Text = Convert.ToInt32(row["ClassFees"]).ToString();
        }

        private void UpdateLocalDrivingLicenseApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshList.Invoke();
        }
    }
}
