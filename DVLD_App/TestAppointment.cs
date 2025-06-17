using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_App.Properties;
using DVLD_BusinessLayer;

namespace DVLD_App
{
    public partial class TestAppointment : Form
    {
        public enum EnTestTypes { vision = 1, theory = 2, practical = 3 };
        EnTestTypes testTypes;
        public delegate void ShowInformation(int id);
        public event ShowInformation info;

        public delegate void RefreshApplicationList();
        public event RefreshApplicationList refreshApplicationList;

        int _id;
        int tryCount = 0;

        ScheduleTest.EnEnumTest _schedule_test;
        TakeTest.EnEnumTest _take_test;
        public TestAppointment(int id, EnTestTypes test)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            testTypes = test;
            _id = id;
        }


        private void VisionTestAppointment_Load(object sender, EventArgs e)
        {
            info += showApplicationDetailuc1.ShowDetails;
            info.Invoke(_id);
            AppointmentList();

        }

        public void AppointmentList()
        {
            DataTable appointmentList;
            switch (testTypes)
            {
                case EnTestTypes.vision:
                    appointmentList = GetAppointmentInformationListBusinessLayerClass.GetAppointmentList(_id, 1);
                    dgvAppointmentList.DataSource = appointmentList;
                    lbTitle.Text = "Vision Test Appointment";
                    pbTitle.Image = Resources.eye;
                    _schedule_test = ScheduleTest.EnEnumTest.visionTest;
                    _take_test = TakeTest.EnEnumTest.visionTest;

                    break;
                case EnTestTypes.theory:
                    appointmentList = GetAppointmentInformationListBusinessLayerClass.GetAppointmentList(_id, 2);
                    dgvAppointmentList.DataSource = appointmentList;
                    lbTitle.Text = "Theorical Test Appointment";
                    pbTitle.Image = Resources.test;
                    _schedule_test = ScheduleTest.EnEnumTest.theroyTest;
                    _take_test = TakeTest.EnEnumTest.theroyTest;

                    break;
                case EnTestTypes.practical:
                    appointmentList = GetAppointmentInformationListBusinessLayerClass.GetAppointmentList(_id, 3);
                    dgvAppointmentList.DataSource = appointmentList;
                    lbTitle.Text = "Practical Test Appointment";
                    pbTitle.Image = Resources.driver__2_;
                    _schedule_test = ScheduleTest.EnEnumTest.practicalTest;
                    _take_test = TakeTest.EnEnumTest.practicalTest;

                    break;
                default:
                    break;
            }
            lbAppointmentListCount.Text = dgvAppointmentList.RowCount.ToString();
            foreach (DataGridViewRow row in dgvAppointmentList.Rows)
            {
                if (Convert.ToByte(row.Cells["isLocked"].Value) != 0)
                {
                    tryCount++;

                }
                else
                {
                    btnAppointment.Enabled = false;
                }
            }

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ScheduleTest visionTest = new ScheduleTest(_id, _schedule_test, ScheduleTest.EnAddUpdate.add, tryCount);
            visionTest.refreshlist += AppointmentList;
            visionTest.ShowDialog();
          
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentList.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dgvAppointmentList.CurrentRow.Cells[0].Value);
                ScheduleTest visionTest = new ScheduleTest(appointmentId, _id, _schedule_test, ScheduleTest.EnAddUpdate.update, tryCount);
                visionTest.refreshlist += AppointmentList;
                visionTest.ShowDialog();
            }

        }

        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            int appointmentId = Convert.ToInt32(dgvAppointmentList.CurrentRow.Cells[0].Value);
            TakeTest test = new TakeTest(appointmentId, _id, _take_test, tryCount);
            test.refreshlist += AppointmentList;
            test.ShowDialog();
        }

        private void TestAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshApplicationList.Invoke();
        }

        private void dgvAppointmentList_SelectionChanged(object sender, EventArgs e)
        {
            if (Convert.ToByte(dgvAppointmentList.CurrentRow.Cells[3].Value) == 0)
            {
                cmsAppointments.Enabled = true;
            }
            else
            {
                cmsAppointments.Enabled = false;
            }
        }
    }
}
