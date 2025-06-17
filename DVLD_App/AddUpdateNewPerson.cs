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
    public partial class AddUpdateNewPerson : Form
    {
        public delegate void RefreshPeopleList();
        public event RefreshPeopleList RefreshList;
        public AddUpdateNewPerson()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            addNewPersonuc1.Mood = AddNewPersonUC.enMood.Add;
        }

        public AddUpdateNewPerson(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            DataTable dataTable = FullPersonDetailBusinessLayerClass.FullPersonDetail(id);
            lbTitle.Text = "Update Person Information";
            DataRow row = dataTable.Rows[0];

            if (row != null)
            {
                addNewPersonuc1.Mood = AddNewPersonUC.enMood.Update;

                addNewPersonuc1.ID = Convert.ToInt32(row["PersonID"]);
                addNewPersonuc1.NaitonalID = row["NationalNo"]?.ToString();
                addNewPersonuc1.FirstName = row["FirstName"]?.ToString();
                addNewPersonuc1.SecondName = row["SecondName"]?.ToString();
                addNewPersonuc1.ThirdName = row["ThirdName"]?.ToString();
                addNewPersonuc1.LastName = row["LastName"]?.ToString();
                addNewPersonuc1.Address = row["Address"]?.ToString();
                addNewPersonuc1.Email = row["Email"]?.ToString();
                addNewPersonuc1.Phone = row["Phone"]?.ToString();
                addNewPersonuc1.Gendor = Convert.ToByte(row["Gendor"]?.ToString());
                addNewPersonuc1.BirthDate = Convert.ToDateTime(row["DateOfBirth"]).Date;
                addNewPersonuc1.CountryId = Convert.ToInt32(row["NationalityCountryID"]?.ToString());
                addNewPersonuc1.ImgPath = row["ImagePath"]?.ToString();


            }
        }
        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            addNewPersonuc1.close += CloseForm;
            RefreshList += AddNewUser.BypassRefresh;
            RefreshList += NewUpdateDrivingLicenseApplication.BypassRefresh;

        }

        public void CloseForm()
        {
            this.Close();
        }

        private void AddNewPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshList.Invoke();
        }

      
    }
}
