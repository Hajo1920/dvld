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
    public partial class ManageTestAndApplicationTypes : Form
    {
        byte _tabIndex;

        public ManageTestAndApplicationTypes(byte tabIndex)
        {
            InitializeComponent();
            _tabIndex = tabIndex;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageTestTypesAndLicenseClasses_Load(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = _tabIndex;
            LoadGridViews();
        }

        public void LoadGridViews()
        {
            dgvApplicationTypes.DataSource = ManageApplicationTypesBusinessLayerClass.GetApplicationTypes().DefaultView;
            dgvTestTypes.DataSource = ManageTestTypesBusinessLayerClass.GetTestTypes().DefaultView;
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (dgvApplicationTypes.Rows.Count > 0 && dgvTestTypes.Rows.Count > 0) {
                if (guna2TabControl1.SelectedIndex == 0) {
                    int id = Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value);
                    string title = dgvTestTypes.CurrentRow.Cells[1].Value.ToString();
                    string description = dgvTestTypes.CurrentRow.Cells[2].Value.ToString();
                    string fee = dgvTestTypes.CurrentRow.Cells[3].Value.ToString();

                    ManageTestAndApplicationTypesSetting manageTestAndApplicationTypesSetting = new ManageTestAndApplicationTypesSetting(ManageTestAndApplicationTypesSetting.EnMood.TestTypes, id, title, fee, description);
                    manageTestAndApplicationTypesSetting.refreshlist += LoadGridViews;
                    manageTestAndApplicationTypesSetting.ShowDialog();
                } else
                {
                    int id = Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value);
                    string title = dgvApplicationTypes.CurrentRow.Cells[1].Value.ToString();
                    string fee = dgvApplicationTypes.CurrentRow.Cells[2].Value.ToString();

                    ManageTestAndApplicationTypesSetting manageTestAndApplicationTypesSetting = new ManageTestAndApplicationTypesSetting(ManageTestAndApplicationTypesSetting.EnMood.ApplicationTypes, id, title, fee);
                    manageTestAndApplicationTypesSetting.refreshlist += LoadGridViews;
                    manageTestAndApplicationTypesSetting.ShowDialog();
                }
            }
        }
    }
}
