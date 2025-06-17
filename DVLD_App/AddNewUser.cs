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
    public partial class AddNewUser : Form
    {
        public delegate void RefreshUsers();
        public event RefreshUsers refresh;

        public AddNewUser()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }
        int _id = 0;

        public void GetId(int id)
        {
            _id = id;
            btnNext.Enabled = true;
            panelHolder.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            panelHolder.Enabled = false;
            findPersonuc1.sendid += GetId;
            personInfouc1.ID = _id;
            findPersonuc1.sendid += personInfouc1.ShowPersonInfo;
            findPersonuc1.revealLink += personInfouc1.RevealLink;
           

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            TabControl.SelectedIndex = 1;
        }

        private void tab2_Click(object sender, EventArgs e)
        {

        }

        public static void BypassRefresh()
        {    // ^ ^   
            // ("."_)-----------\
            //     ---|---|------\
            //        |   |       \
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckPersonIsUserBusinessLayerClass.CheckPersonIsUser(_id))
                {
                    if (boxUserName.Text != "" && boxPassword.Text != "")
                    {
                        if (boxPassword.Text == boxConfirmPassword.Text)
                        {
                            int userId = AddNewUserBusinessLayerClass.AddNewSystemUser(_id, boxUserName.Text, boxPassword.Text, activeCheckBox.Checked);
                            lbID.Text = userId.ToString();
                            MessageBox.Show("New user successfly registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("This person is already a system user !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            refresh.Invoke();
        }
    }
}
