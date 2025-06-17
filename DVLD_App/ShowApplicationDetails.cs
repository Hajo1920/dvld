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
    public partial class ShowApplicationDetails : Form
    {

        public delegate void TransferId(int id);
        public event TransferId transId;

        int _ldl_id;
        public ShowApplicationDetails(int ldl_id)
        {
            InitializeComponent();
            _ldl_id = ldl_id;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowApplicationDetails_Load(object sender, EventArgs e)
        {
            transId += showApplicationDetailuc1.ShowDetails;
            transId.Invoke(_ldl_id);
        }
    }
}
