using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_App
{
    public partial class LocalDrivingLicenseApplicationsList : Form
    {
        public delegate void RefreshMain();
        public event RefreshMain refreshMain;
        public LocalDrivingLicenseApplicationsList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            NewUpdateDrivingLicenseApplication ndla = new NewUpdateDrivingLicenseApplication(NewUpdateDrivingLicenseApplication.EnumRefreshMood.yes);
            ndla.ShowDialog();
        }



        private void LocalDrivingLicenseApplicationsList_Load(object sender, EventArgs e)
        {
            cmsApplicationProperties.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            ListApplications();
            UpdateLocalDrivingLicenseApplication.refreshList += ListApplications;
            NewUpdateDrivingLicenseApplication.refreshList += ListApplications;




        }

        public void ListApplications()
        {
            cbFilter.Items.Add("None");
            DataView dataView = LocalDrivingLicenseApplicationListBusinessLayerClass.LocalLicenseApplicationsList().DefaultView;
            foreach (DataColumn filterName in dataView.Table.Columns)
            {
                cbFilter.Items.Add(filterName.ColumnName);
            }
            cbFilter.SelectedIndex = 0;

            dgvApplicationsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvApplicationsList.DataSource = dataView;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = LocalDrivingLicenseApplicationListBusinessLayerClass.LocalLicenseApplicationsList().DefaultView;
            if (cbFilter.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                dgvApplicationsList.DataSource = dv;

            }
            else
            {
                tbFilter.Visible = true;
                tbFilter.Focus();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = LocalDrivingLicenseApplicationListBusinessLayerClass.LocalLicenseApplicationsList().DefaultView;
            if (tbFilter.Text == "")
            {
                dgvApplicationsList.DataSource = dv;
            }
            else
            {

                dv.RowFilter = $"{cbFilter.SelectedItem.ToString()}='{tbFilter.Text}'";

                dgvApplicationsList.DataSource = dv;
            }
        }

        private void showApplicationDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsList.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value);
                ShowApplicationDetails details = new ShowApplicationDetails(id);
                details.ShowDialog();
            }

        }

        private void cmsApplicationProperties_Opening(object sender, CancelEventArgs e)
        {

            switch (Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[5].Value))
            {

                case 1:
                    tsmEditApplication.Enabled = false;
                    tsmDeleteApplication.Enabled = false;
                    tsmCancelApplication.Enabled = false;
                    tsmScheduleTests.Enabled = false;

                    tsmShowLicense.Enabled = false;
                    tsmIssueDrivingLicense.Enabled = false;

                    tsmScheduleTests.Enabled = true;

                    tsmScheduleTestVision.Enabled = false;
                    tsmScheduleTestTheory.Enabled = true;
                    tsmScheduleTestPractical.Enabled = false;
                    return;
                case 2:
                    tsmEditApplication.Enabled = false;
                    tsmDeleteApplication.Enabled = false;
                    tsmCancelApplication.Enabled = false;
                    tsmScheduleTests.Enabled = false;

                    tsmShowLicense.Enabled = false;
                    tsmIssueDrivingLicense.Enabled = false;

                    tsmScheduleTests.Enabled = true;

                    tsmScheduleTestVision.Enabled = false;
                    tsmScheduleTestTheory.Enabled = false;
                    tsmScheduleTestPractical.Enabled = true;
                    break;

                case 3:
                    tsmEditApplication.Enabled = false;
                    tsmDeleteApplication.Enabled = false;
                    tsmCancelApplication.Enabled = false;
                    tsmScheduleTests.Enabled = false;
                    if (Convert.ToString(dgvApplicationsList.CurrentRow.Cells[6].Value) == "Completed")
                    {
                        tsmShowLicense.Enabled = true;
                        tsmIssueDrivingLicense.Enabled = false;
                    }
                    else
                    {
                        tsmShowLicense.Enabled = false;
                        tsmIssueDrivingLicense.Enabled = true;
                    }


                    break;

                default:

                    tsmEditApplication.Enabled = true;
                    tsmDeleteApplication.Enabled = true;
                    tsmCancelApplication.Enabled = true;
                    tsmScheduleTests.Enabled = true;

                    tsmScheduleTests.Enabled = true;

                    tsmScheduleTestVision.Enabled = true;
                    tsmScheduleTestTheory.Enabled = false;
                    tsmScheduleTestPractical.Enabled = false;

                    tsmShowLicense.Enabled = false;
                    tsmIssueDrivingLicense.Enabled = false;
                    return;



            }
        }

        private void tsmEditApplication_Click(object sender, EventArgs e)
        {

            UpdateLocalDrivingLicenseApplication update = new UpdateLocalDrivingLicenseApplication(Convert.ToInt32(dgvApplicationsList?.CurrentRow.Cells[0].Value));
            update.ShowDialog();

        }

        private void tsmDeleteApplication_Click(object sender, EventArgs e)
        {
            int id = GetApplicationDetailBusinessLayerClass.GetApplicationID(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value));

            DialogResult result = MessageBox.Show("Are you sure want to delete this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeleteLocalDrivingLicenseApplicationBusinessLayerClass.DeleteLocalDrivingLicenseApplication(id))
                {
                    MessageBox.Show("Application Deleted Successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListApplications();
                }
                else
                {
                    MessageBox.Show("Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {
            int id = GetApplicationDetailBusinessLayerClass.GetApplicationID(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value));
            DialogResult result = MessageBox.Show("Are you sure want to cancel the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (!DeleteLocalDrivingLicenseApplicationBusinessLayerClass.CheckApplicationIsCanceled(id))
                {

                    if (CancelLocalDrivingLicenseApplicationBusinessLayerClass.CancelLocalDrivingLicenseApplication(id, 2, DateTime.Now, Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0])))
                    {
                        MessageBox.Show("Application Canceled Successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListApplications();
                    }
                    else
                    {
                        MessageBox.Show("Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("This application is already canceled !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void tsmScheduleTestVision_Click(object sender, EventArgs e)
        {

            int id = GetApplicationDetailBusinessLayerClass.GetApplicationID(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value));
            if (!DeleteLocalDrivingLicenseApplicationBusinessLayerClass.CheckApplicationIsCanceled(id))
            {
                TestAppointment testAppointment = new TestAppointment(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value), TestAppointment.EnTestTypes.vision);
                testAppointment.refreshApplicationList += ListApplications;
                testAppointment.ShowDialog();

            }
            else
            {
                MessageBox.Show("Appointment is not allowed in canceled application !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmScheduleTestTheory_Click(object sender, EventArgs e)
        {
            int id = GetApplicationDetailBusinessLayerClass.GetApplicationID(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value));
            if (!DeleteLocalDrivingLicenseApplicationBusinessLayerClass.CheckApplicationIsCanceled(id))
            {
                TestAppointment testAppointment = new TestAppointment(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value), TestAppointment.EnTestTypes.theory);
                testAppointment.refreshApplicationList += ListApplications;
                testAppointment.ShowDialog();

            }
            else
            {
                MessageBox.Show("Appointment is not allowed in canceled application !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmScheduleTestPractical_Click(object sender, EventArgs e)
        {
            int id = GetApplicationDetailBusinessLayerClass.GetApplicationID(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value));
            if (!DeleteLocalDrivingLicenseApplicationBusinessLayerClass.CheckApplicationIsCanceled(id))
            {
                TestAppointment testAppointment = new TestAppointment(Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value), TestAppointment.EnTestTypes.practical);
                testAppointment.refreshApplicationList += ListApplications;
                testAppointment.ShowDialog();

            }
            else
            {
                MessageBox.Show("Appointment is not allowed for canceled application !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value);
            IssueDrivingLicense issue = new IssueDrivingLicense(id);
            issue.refreshList += ListApplications;
            issue.ShowDialog();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value);
            ShowDriverLicense show = new ShowDriverLicense(id, "Any");
            show.ShowDialog();
        }
        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvApplicationsList.CurrentRow.Cells[0].Value);
            ShowPersonLicenseHistory licenseHistory = new ShowPersonLicenseHistory(id);
            licenseHistory.ShowDialog();
        }
        private void LocalDrivingLicenseApplicationsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshMain.Invoke();
        }

       
    }
}

     
