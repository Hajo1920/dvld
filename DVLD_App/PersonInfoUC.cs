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
    public partial class PersonInfoUC : UserControl
    {


        public PersonInfoUC()
        {
            InitializeComponent();
        }

        public int ID { set; get; }

        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }
        public string Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string NaitonalID { set; get; }
        public string ImagePath { set; get; }

        private void PersonInfoUC_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;

        }

        public void ShowPersonInfo(int id)
        {
            ID = id;
            DataTable table = FullPersonDetailBusinessLayerClass.FullPersonDetail(id);
            DataRow row = table.Rows[0];
            lbID.Text = id.ToString();
            lbFullName.Text = $"{row["FirstName"]} {row["SecondName"]} {row["ThirdName"]} {row["LastName"]}";
            lbNationalID.Text = $"{row["NationalNo"]}";
            lbBirthDate.Text = $"{row["DateOfBirth"]}".Substring(0, 10);
            lbAddress.Text = $"{row["Address"]}";
            lbEmail.Text = $"{row["Email"]}";
            lbPhone.Text = $"{row["Phone"]}";
            lbGendor.Text = row["Gendor"].ToString() == "0" ? "Male" : "Female";
            string imagePath = row["ImagePath"]?.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pictureBox1.Image = new Bitmap(imagePath);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {

                pictureBox1.Image = Resources.no_image1;
            }


            lbCountry.Text = GetCountryByIDBusinessLayer.GetCountryById(Convert.ToInt32(row["NationalityCountryID"]));

        }

        public void RevealLink()
        {
            linkLabel1.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateNewPerson update = new AddUpdateNewPerson(ID);
            update.ShowDialog();
        }
    }
}