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
    public partial class DetainedAndReleasedLicensesList : Form
    {
        public delegate void RefreshList();
        public event RefreshList refresh;
        public DetainedAndReleasedLicensesList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }
       

        private void DetainedLicensesList_Load(object sender, EventArgs e)
        {
            List_Data();
        }
        public void List_Data()
        {
            DataView dataViewDetained = DetainedAndReleasedLicensesListBusinessLayerClass.DetainedLicenseList().DefaultView;
            DataView dataViewReleased = DetainedAndReleasedLicensesListBusinessLayerClass.ReleasedLicenseList().DefaultView;

            cbFilter.Items.Add("None");
            cbFilter.Items.Add("DetainID");
            cbFilter.Items.Add("LicenseID");

            cbFilter.SelectedIndex = 0;

            dgvDetained.DataSource = dataViewDetained;
            dgvReleased.DataSource = dataViewReleased;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataViewDetained = DetainedAndReleasedLicensesListBusinessLayerClass.DetainedLicenseList().DefaultView;
            DataView dataViewReleased = DetainedAndReleasedLicensesListBusinessLayerClass.ReleasedLicenseList().DefaultView;
            if (cbFilter.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                if (TabControlOne.SelectedTab == tabPage1 && dgvDetained.Rows.Count != 0) dgvDetained.DataSource = dataViewDetained;
                else if (dgvReleased.Rows.Count != 0) dgvReleased.DataSource = dataViewReleased;

            }
            else
            {

                tbFilter.Visible = true;
                tbFilter.Focus();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dataViewDetained = DetainedAndReleasedLicensesListBusinessLayerClass.DetainedLicenseList().DefaultView;
            DataView dataViewReleased = DetainedAndReleasedLicensesListBusinessLayerClass.ReleasedLicenseList().DefaultView;

            if (tbFilter.Text == "")
            {
                if (TabControlOne.SelectedTab == tabPage1 && dgvDetained.Rows.Count != 0) dgvDetained.DataSource = dataViewDetained;
                else if(dgvReleased.Rows.Count != 0) dgvReleased.DataSource = dataViewReleased;
            }
            else
            {



                if (cbFilter.SelectedIndex != cbFilter.Items.Count - 1)
                {

                    if (TabControlOne.SelectedTab == tabPage1 && dgvDetained.Rows.Count != 0)
                    {
                        dataViewDetained.RowFilter = $"{cbFilter.SelectedItem.ToString()} = '{tbFilter.Text}'";
                    }

                    else if (dgvReleased.Rows.Count != 0) { 
                        dataViewReleased.RowFilter = $"{cbFilter.SelectedItem.ToString()} = '{tbFilter.Text}'";
                    }


                }
                else
                {
                    if (TabControlOne.SelectedTab == tabPage1 && dgvDetained.Rows.Count != 0)
                    {
                        dataViewDetained.RowFilter = $"{cbFilter.SelectedItem.ToString()} = {Convert.ToInt32(tbFilter.Text)}";
                    }

                    else if (dgvReleased.Rows.Count != 0) {
                        dataViewReleased.RowFilter = $"{cbFilter.SelectedItem.ToString()} = {Convert.ToInt32(tbFilter.Text)}"; 
                    }

                }

                dgvDetained.DataSource = dataViewDetained;
                dgvReleased.DataSource = dataViewReleased;


            }
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            cbFilter.Items.Clear();
            ReleaseOrDetainLicense detain = new ReleaseOrDetainLicense(ReleaseOrDetainLicense.EnMood.Detain);
            detain.refreshlist += List_Data;
            detain.ShowDialog();
        }

        private void DetainedAndReleasedLicensesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            refresh.Invoke();
        }

        private void cmsShowLicenseDetail_Click(object sender, EventArgs e)
        {
            if (dgvDetained.CurrentRow != null) {

                int ldlID = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationIdByApplicationID(Convert.ToInt32(dgvDetained.CurrentRow.Cells[2].Value));
                ShowDriverLicense showDriverLicense = new ShowDriverLicense(Convert.ToInt32(ldlID), "Active");
                showDriverLicense.ShowDialog();
            }
        }

        private void cmsReleaseDetain_Click(object sender, EventArgs e)
        {
            if (dgvDetained.CurrentRow != null) {

                ReleaseOrDetainLicense releaseOrDetainLicense = new ReleaseOrDetainLicense(Convert.ToInt32(dgvDetained.CurrentRow.Cells[1].Value), ReleaseOrDetainLicense.EnMood.Release);
                releaseOrDetainLicense.refreshlist += List_Data;
                releaseOrDetainLicense.ShowDialog();
            }

        }
    }
}
