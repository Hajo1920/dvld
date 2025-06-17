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
    public partial class ShortUserInfoUC : UserControl
    {

        public ShortUserInfoUC()
        {
            InitializeComponent();
          
        }

        public void ShowUserInfo(int id)
        {
            DataRow row = UsersListBusinessLayerClass.GetUserByPersonId(id).Rows[0];

            lbUserId.Text = row["UserID"].ToString();
            lbUserName.Text = row["UserName"].ToString();
            lbIsActive.Text = row["isActive"].ToString() == "True" ? "Yes" : "No";
        }

       
    }
}
