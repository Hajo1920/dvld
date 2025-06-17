using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD;
using DVLD_App.Properties;
using DVLD_BusinessLayer;
using static DVLD_App.ScheduleTest;

namespace DVLD_App
{
    public partial class TakeTest : Form
    {
        public delegate void RefreshAppointmentList();
        public event RefreshAppointmentList refreshlist;

        public enum EnEnumTest { visionTest = 1, theroyTest = 2, practicalTest = 3 };
        EnEnumTest enSchedul;
        int _id;
        int _appointmentId;
        int _trial;
        bool TestResult = false;

        public TakeTest(int appointmentId, int id, EnEnumTest shedul, int trial)
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _id = id;
            _appointmentId = appointmentId;
            _trial = trial;
            enSchedul = shedul;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            switch (enSchedul)
            {
                case EnEnumTest.visionTest:
                    lbTitle.Text = "Take Scheduled Vision Test";
                    pbTitleImage.Image = Resources.eye;
                    lbFees.Text = "10";
                    break;
                case EnEnumTest.theroyTest:
                    lbTitle.Text = "Take Scheduled Theorical Test";
                    pbTitleImage.Image = Resources.test;
                    lbFees.Text = "20";
                    break;
                case EnEnumTest.practicalTest:
                    lbTitle.Text = "Take Scheduled Practical Test";
                    pbTitleImage.Image = Resources.driver__2_;
                    lbFees.Text = "30";
                    break;
                default:
                    break;

            }

            DataRow row_ldlApplicationDetail = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationDetailById(_id).Rows[0];
            lbLDLAppID.Text = row_ldlApplicationDetail[0].ToString();
            lbLicenseClass.Text = row_ldlApplicationDetail[1].ToString();
            lbName.Text = row_ldlApplicationDetail[3].ToString();
            lbTrial.Text = _trial.ToString();
            lbDate.Text = DateTime.Today.ToString();
            rbPass.Checked = true;

        }

        private void TakeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshlist.Invoke();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to confirm test result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int testId;
                if (UpdateScheduledAppointmentBusinessLayerClass.UpdateBookedAppointment(_appointmentId, true) && ( testId = TakeTestBusinessLayerClass.TakeTest(_appointmentId, TestResult, tbTestNote.Text, Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]))) != -1)
                {
                    lbTestID.Text = testId.ToString();
                    MessageBox.Show("Test result confirmed successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rbPass.Enabled = false;
                    rbFail.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Test confrimation failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {
            TestResult = true;
        }

        private void rbFail_CheckedChanged(object sender, EventArgs e)
        {
            TestResult = false;
        }
    }
}
