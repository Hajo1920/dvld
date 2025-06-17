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
    public partial class ListLicensedDrivers : Form
    {
        public ListLicensedDrivers()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void ListLicensedDrivers_Load(object sender, EventArgs e)
        {
            dgvDriversList.DataSource = DriversListBusinessLayerClass.ListDrivers();
        }
    }
}
