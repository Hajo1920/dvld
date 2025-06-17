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
    public partial class CurrentUserInformationUC : UserControl
    {
       public static int receivedId;
        public delegate void TransferId(int id);
        public event TransferId tranId;

        public CurrentUserInformationUC()
        {
            InitializeComponent();
            
        }

        public void ID_Bridge(int id)
        {
            receivedId = id;
            tranId += personInfouc1.ShowPersonInfo;
            tranId += currentUserInfouc1.ShowUserInfo;


            tranId.Invoke(receivedId);

        }

        private void CurrentUserInformationUC_Load(object sender, EventArgs e)
        {
            
        }
    }
}
