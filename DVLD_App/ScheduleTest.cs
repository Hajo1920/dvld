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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_App
{
    public partial class ScheduleTest : Form
    {
        public delegate void RefreshAppointmentList();
        public event RefreshAppointmentList refreshlist;

        public enum EnEnumTest { visionTest = 1, theroyTest = 2, practicalTest = 3 }; 
         EnEnumTest enSchedul;

        public enum EnAddUpdate { add = 1, update = 2 };
        EnAddUpdate enAddUpdate;

        int _id;
        int _trial;
        int appId;
        int _testType;
        public ScheduleTest(int id, EnEnumTest shedul, EnAddUpdate addUpdate, int trial)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _id = id;
            _trial = trial;
            enSchedul = shedul;
            enAddUpdate = addUpdate;
        }

        public ScheduleTest(int appointmentId, int id, EnEnumTest shedul, EnAddUpdate addUpdate, int trial)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            appId = appointmentId;
            _id = id;
            _trial = trial;
            enSchedul = shedul;
            enAddUpdate = addUpdate;
            
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            DataRow row_ldlApplicationDetail = LocalDrivingLicenseApplicationListBusinessLayerClass.GetLocalDrivingLicenseApplicationDetailById(_id).Rows[0];
            switch (enSchedul)
            {
                case EnEnumTest.visionTest:
                    lbTitle.Text = "Schedul Vision Test";
                    pbTitleImage.Image = Resources.eye;
                    lbFees.Text = "10";
                    _testType = 1;
                    break;
                case EnEnumTest.theroyTest:
                    lbTitle.Text = "Schedul Theorical Test";
                    pbTitleImage.Image = Resources.test;
                    lbFees.Text = "20";
                    _testType = 2;
                    break;
                case EnEnumTest.practicalTest:
                    lbTitle.Text = "Schedul Practical Test";
                    pbTitleImage.Image = Resources.driver__2_;
                    lbFees.Text = "30";
                    _testType = 3;
                    break;
                default:
                    break;

            }
            dtpAppointmentDate.MinDate = DateTime.Now;
            lbLDLAppID.Text = row_ldlApplicationDetail[0].ToString();
            lbLicenseClass.Text = row_ldlApplicationDetail[1].ToString();
            lbName.Text = row_ldlApplicationDetail[3].ToString();
            lbTrial.Text = _trial.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(enAddUpdate == EnAddUpdate.add)
            {
                int appointmentId = ScheduleAppointmentBusinessLayerClass.BookTestAppointment(_testType, _id, dtpAppointmentDate.Value, Convert.ToDecimal(lbFees.Text), Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0]), false);

                if (appointmentId != -1)
                {
                    MessageBox.Show("Appointment booked successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Appointment booking failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (UpdateScheduledAppointmentBusinessLayerClass.UpdateBookedAppointment(appId, dtpAppointmentDate.Value, Convert.ToInt32(UsersListBusinessLayerClass.GetUserByPersonId(Main.currentUserPersonId).Rows[0][0])))
                {
                    MessageBox.Show("Booked appointment updated successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Appointment update failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ScheduleTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshlist.Invoke();
        }
    }
}
