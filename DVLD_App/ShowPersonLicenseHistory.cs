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
    public partial class ShowPersonLicenseHistory : Form
    {
        public delegate void ListPersonInfo(int id);
        public event ListPersonInfo personInfo;

        int _id;
        public ShowPersonLicenseHistory(int applicationId)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            _id = applicationId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            
            DataRow row_applicationDetail = GetApplicationDetailBusinessLayerClass.GetApplicationDetailById(_id).Rows[0];
            DataRow row_personInfo = FullPersonDetailBusinessLayerClass.FullPersonDetail(Convert.ToInt32(row_applicationDetail[1])).Rows[0];
            int personId = Convert.ToInt32(row_personInfo[0]);
            int driverId = GetDriverIdByPersonIdBusinessLayerClass.GetDriverIdByPersonId(Convert.ToInt32(personId));
            personInfo += personInfouc1.ShowPersonInfo;
            personInfo.Invoke(personId);
            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInternational.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLocal.DataSource = GetLicenseInformationByIdBusinessLayerClass.GetLicenseHistoryInformationById(driverId);
            dgvInternational.DataSource = GetInternationalLicenseHistoryInformationByIdBusinessLayerClass.GetInternationalLicenseHistoryInformationById(driverId);
        }
    }
}
