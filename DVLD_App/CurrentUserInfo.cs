using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_App
{
    public partial class CurrentUserInfo : Form
    {
        public delegate void ListUserInfo(int id);
        public event ListUserInfo userInfo;

        int _id;
        public CurrentUserInfo(int userId)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            _id = userId;
            userInfo += currentUserInformationuc1.ID_Bridge;
            
        }

        private void CurrentUserInfo_Load(object sender, EventArgs e)
        {
            userInfo.Invoke(_id);
        }
    }
}
