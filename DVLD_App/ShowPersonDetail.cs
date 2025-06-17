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
    public partial class ShowPersonDetail : Form
    {
        public delegate void ListPersonInfo(int id);
        public event ListPersonInfo personInfo;

        int _id;

        public ShowPersonDetail(int PersonID)
        {
            InitializeComponent();
         
            _id = PersonID;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void ShowPersonDetail_Load(object sender, EventArgs e)
        {
            personInfo += personInfouc1.ShowPersonInfo;
            personInfo.Invoke(_id);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personInfouc1_Load(object sender, EventArgs e)
        {

        }
    }
}
