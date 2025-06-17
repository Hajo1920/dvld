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
    public partial class AddNewPersonUC : UserControl
    {
       public enum enMood { Update=0, Add=1};

        int NewPersonID = 0;
        int CountryID = 1;

        public delegate void CloseForm();
        public event CloseForm close;

      
        public AddNewPersonUC()
        {
            InitializeComponent();
            
           
        }
        public int ID { set; get; }

        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }
        public byte Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string NaitonalID { set; get; }
        public int CountryId { set; get; }
        public string ImgPath { set; get; }

        public enMood Mood;

        byte _gendor;
        string ImagePath = "";

       
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbPerson.Image = Resources.man;
            _gendor = 0;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbPerson.Image = Resources.woman;
            _gendor = 1;
        }

        private void AddNewPersonUC_Load(object sender, EventArgs e)
        {
            
            DataTable countries = PeopleListBusinessClass.CountryList();
            foreach (DataRow filterName in countries.Rows)
            {
                cbCountries.Items.Add(filterName["CountryName"]);
            }
            cbCountries.SelectedIndex = 0;

            if (Mood == enMood.Add)
            {

                lbPersonID.Text = "??";
                tbNationalID.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbThirdName.Text = "";
                tbLastName.Text = "";
                tbAddress.Text = "";
                tbPhone.Text = "";
                tbEmail.Text = "";
                dtpBirthDate.Value = DateTime.Now;
                rbMale.Checked = true;

            }
            else if (Mood == enMood.Update)
            {
                lbPersonID.Text = ID.ToString();
                tbNationalID.Text = NaitonalID;
                tbFirstName.Text = FirstName;
                tbSecondName.Text = SecondName;
                tbThirdName.Text = ThirdName;
                tbLastName.Text = LastName;
                tbAddress.Text = Address;
                tbPhone.Text = Phone;
                tbEmail.Text = Email;
                dtpBirthDate.Value = BirthDate.Date;
                if (Gendor == 0)
                {
                    rbMale.Checked = true;

                }
                else rbFemale.Checked = true;
                if (!string.IsNullOrEmpty(ImgPath) && File.Exists(ImgPath))
                {
                    try
                    {
                        pbPerson.Image = new Bitmap(ImgPath);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
                else
                {
                    pbPerson.Image = null;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to cancel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                close.Invoke();
            }

        }

        private bool _AddNewPerson()
        {
            DateTime birthdate = dtpBirthDate.Value;
            NewPersonID = AddNewPersonBusinessLayerClass.AddNewPersonRecord(tbFirstName.Text.ToString(), tbSecondName.Text.ToString(), tbThirdName.Text.ToString(), tbLastName.Text.ToString(), tbNationalID.Text.ToString(), tbEmail.Text.ToString(), tbPhone.Text.ToString(), birthdate, CountryID, tbAddress.Text, _gendor, ImagePath);

            return NewPersonID != -1;
        }

        private bool _UpdatePerson()
        {
            DateTime birthdate = dtpBirthDate.Value;
            return UpdatePersonBusinessLayerClass.UpdatePerson(Convert.ToInt32(lbPersonID.Text), tbNationalID.Text.ToString(), tbFirstName.Text.ToString(), tbSecondName.Text.ToString(), tbThirdName.Text.ToString(), tbLastName.Text.ToString(), birthdate, tbEmail.Text.ToString(), tbPhone.Text.ToString(), _gendor, tbAddress.Text.ToString(), CountryId, ImagePath);
        }

        public bool Save()
        {
            switch (Mood)
            {
                case enMood.Add:
                    return _AddNewPerson();

                case enMood.Update:

                    return _UpdatePerson();

            }
            return false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                if (Mood == enMood.Add)
                {
                    lbPersonID.Text = NewPersonID.ToString();
                    MessageBox.Show("Person Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Person Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void linkLabelSetPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                ImagePath = filePath;
                pbPerson.Image = new Bitmap(ImagePath);

            }
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountries.SelectedItem != null)
            {
                CountryID = AddNewPersonBusinessLayerClass.GetCountryId(cbCountries.SelectedItem.ToString());
            }
        }
    }
}
