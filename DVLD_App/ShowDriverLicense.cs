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
    public partial class ShowDriverLicense : Form
    {
        public delegate void LoadLicenseData(int id, string showmood);
        public event LoadLicenseData load_data;

        int _id;
        string _showMood;
        public ShowDriverLicense(int id, string showMood)
        {
           
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _id = id;
            _showMood = showMood;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDriverLicense_Load(object sender, EventArgs e)
        {
            load_data += driverLicenseInfouc2.Load_data;
            load_data.Invoke(_id, _showMood);
        }
    }
}
