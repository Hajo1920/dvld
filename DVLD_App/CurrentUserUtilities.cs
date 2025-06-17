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
using DVLD_DataLayer;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_App
{
    public partial class CurrentUserUtilities : Form
    {
        public delegate void ListUserInfo(int id);
        public event ListUserInfo userInfo;
        int _id;
        public CurrentUserUtilities(int personId)
        {
            InitializeComponent();
            _id = personId;
            userInfo += currentUserInformationuc1.ID_Bridge;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrentUserUtilities_Load(object sender, EventArgs e)
        {
            userInfo.Invoke(_id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text != string.Empty && tbNewPassword.Text != string.Empty && tbCurrentPassword.Text != string.Empty)
            {
                string hashed_pass = PassHasherBussinesLayer.Hash(tbCurrentPassword.Text);
                if (UpdateUserPasswordDataLayerClass.CheckCurrentPasswordCorrect(_id, hashed_pass))
                {

                    if (tbNewPassword.Text == tbConfirmPassword.Text)
                    {

                        if (UpdateUserPasswordBusinessLayerClass.UpdateCurrentUserPassword(_id, tbNewPassword.Text))
                        {
                            MessageBox.Show("User Password Successfuly Changed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confrimation password does not much!\n Please Try Again..", "Confirm Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Password! \n Please try again..", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
            {
                MessageBox.Show("Please fill all the boxes correctly !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
