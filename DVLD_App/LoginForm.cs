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
using DVLD_BusinessLayer;
using DVLD_DataLayer;
using Microsoft.Win32;

namespace DVLD
{
    public partial class LoginForm : Form
    {

        public delegate void CloseDelegate();

        public event CloseDelegate closeMain;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }



        private void HideForm()
        {
            this.Hide();
        }
        private void CloseForm()
        {

            this.Close();

        }
        private void ShowForm()
        {
           
            this.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashed_pass = PassHasherBussinesLayer.Hash(box2.Text.ToString());
            int userPersonId = LoginBusinessLayerClass.CheckLogin(box1.Text.ToString(), hashed_pass);
            Main frm = new Main(userPersonId);
            if (userPersonId != -1)
            {
                frm.close += CloseForm;
                frm.show += ShowForm;

               

                if (guna2CheckBox1.Checked)
                {
                    string username = UsersListBusinessLayerClass.GetUserNameByPersonId(userPersonId);
                    string password = box2.Text;
                   

                    string regPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_App";

                    try
                    {
                       

                        Registry.SetValue(regPath, "Username", username, RegistryValueKind.String);
                        Registry.SetValue(regPath, "Password", password, RegistryValueKind.String);

        

                    }
                    catch (Exception ex)
                    {

                        EventLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
                else if(!guna2CheckBox1.Checked)
                {
                    string keyPath = @"SOFTWARE\DVLD_App";
                    

                    try
                    {
                        // Open the registry key in read/write mode with explicit registry view
                        using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        {
                            using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                            {
                                if (key != null)
                                {
                                    // Delete the specified value
                                    key.DeleteValue("Username");
                                    key.DeleteValue("Password");                                   

                                }
                                else
                                {

                                    MessageBox.Show($"Error: Can't delete reg values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        EventLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                    catch (Exception ex)
                    {
                        EventLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    }

                }


                lbError.Text = "";
                HideForm();

                frm.Show();
            }
            else
            {
                lbError.Text = "Error: username or password is not correct !";

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string regPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_App";

            try
            {
                string username = Registry.GetValue(regPath, "Username", null) as string;
                string password = Registry.GetValue(regPath, "Password", null) as string;

                if (username != null && password != null)
                {
                    box1.Text = username;
                    box2.Text = password;
                    guna2CheckBox1.Checked = true;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e){
                if (!guna2CheckBox1.Checked) guna2CheckBox1.Text = "No";
                else guna2CheckBox1.Text = "Yes";
          }

    }
}
