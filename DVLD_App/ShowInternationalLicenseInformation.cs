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
    public partial class ShowInternationalLicenseInformation : Form
    {
        int _internationalId;
        public delegate void SendId(int id);
        public event SendId eventSendId;
        public ShowInternationalLicenseInformation(int id)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _internationalId = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInternationalLicenseInformation_Load(object sender, EventArgs e)
        {
            eventSendId += driverInternationalLicenseInfouc1.Load_Data;
            eventSendId.Invoke(_internationalId);
        }
    }
}
