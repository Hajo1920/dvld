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

namespace DVLD
{
    public  partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        public delegate void CloseDelegate();

        public event CloseDelegate close;
        public event CloseDelegate hide;
        

        private void CloseApp()
        {
            if(close != null)
            {
                close?.Invoke();
            }
        }

        

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int userPersonId = LoginBusinessLayerClass.CheckLogin(box1.Text.ToString(), box2.Text.ToString());
            Main frm = new Main(userPersonId);
            if(userPersonId != -1)
            {
                if (hide != null)
                {
                    hide?.Invoke();
                }

                frm.close += CloseApp;
                frm.Show();
            }
            else
            {
                lbError.Text = "Error: username or password is not correct !";
            }


            
        }

     

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (close != null)
            {
                close?.Invoke();
            }
        }
    }
}
