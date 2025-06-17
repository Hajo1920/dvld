using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_App;
using DVLD_BusinessLayer;

namespace DVLD
{
    public partial class Main : Form
    {

        public delegate void CloseDelegate();

        public event CloseDelegate close;

        public delegate void ShowDelegate();

        public event ShowDelegate show;

        public enum EnTermination { exit = 0, show = 1 };
        EnTermination _mood = EnTermination.exit;

        public static int currentUserPersonId;


        public Main(int userID)
        {
            currentUserPersonId = userID;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            RetriveCount();
        }

        public void RetriveCount()
        {

            lbPeopleCount.Text = TableRecordCountBusinessLayerClass.TotalPeopleCount().ToString();
            lbDriversCount.Text = TableRecordCountBusinessLayerClass.TotalDriversCount().ToString();
            lbUsersCount.Text = TableRecordCountBusinessLayerClass.TotalUsersCount().ToString();
            lbPendingApplications.Text = TableRecordCountBusinessLayerClass.TotalPendingApplications().ToString();
            lbTotalDetainedLicenses.Text = TableRecordCountBusinessLayerClass.TotalDetainedLicenses().ToString();
            lbTotalInternationalLicenses.Text = TableRecordCountBusinessLayerClass.TotalInternationalLicenses().ToString();
        }




        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close != null)
            {
                close?.Invoke();
            }
        }

       

        private void mtsPeople_Click(object sender, EventArgs e)
        {
            PeopleList peopleList = new PeopleList();
            peopleList.Refresh += RetriveCount;
            peopleList.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentUserPersonId = -1;
            _mood = EnTermination.show;

            if (_mood == EnTermination.exit) close?.Invoke();
            else show?.Invoke();
            this.Hide();

        }



        private void mstUsers_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList();
            usersList.Refresh += RetriveCount;
            usersList.ShowDialog();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUserInfo userInfo = new CurrentUserInfo(currentUserPersonId);
            userInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUserUtilities currentUserUtilities = new CurrentUserUtilities(currentUserPersonId);
            currentUserUtilities.ShowDialog();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUpdateDrivingLicenseApplication app = new NewUpdateDrivingLicenseApplication(NewUpdateDrivingLicenseApplication.EnumRefreshMood.no);
            app.ShowDialog();
        }

        private void localLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationsList list = new LocalDrivingLicenseApplicationsList();
            list.refreshMain += RetriveCount;
            list.ShowDialog();
        }

        private void mtsDrivers_Click(object sender, EventArgs e)
        {
            ListLicensedDrivers list = new ListLicensedDrivers();
            list.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceLostOrDamagedLicense replacement = new ReplaceLostOrDamagedLicense();
            replacement.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalDrivingLicense international = new IssueInternationalDrivingLicense();
            international.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseOrDetainLicense detain = new ReleaseOrDetainLicense(ReleaseOrDetainLicense.EnMood.Detain);
            detain.refreshlist += RetriveCount;
            detain.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainedAndReleasedLicensesList detainedLicenses = new DetainedAndReleasedLicensesList();
            detainedLicenses.refresh += RetriveCount;
            detainedLicenses.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseOrDetainLicense release = new ReleaseOrDetainLicense(ReleaseOrDetainLicense.EnMood.Release);
            release.refreshlist += RetriveCount;
            release.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestAndApplicationTypes manageTestAndApplicationTypes = new ManageTestAndApplicationTypes(1);
            manageTestAndApplicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestAndApplicationTypes manageTestAndApplicationTypes = new ManageTestAndApplicationTypes(0);
            manageTestAndApplicationTypes.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewExpiredLicense renewExpiredLicense = new RenewExpiredLicense();
            renewExpiredLicense.ShowDialog();
        }

        
    }
}
