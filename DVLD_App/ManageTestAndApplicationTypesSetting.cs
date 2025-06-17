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
    public partial class ManageTestAndApplicationTypesSetting : Form
    {

        public delegate void RefreshList();
        public event RefreshList refreshlist;
        public enum EnMood { TestTypes = 0, ApplicationTypes = 1 };
        public EnMood enMood;

        string _title;
        string _description;
        string _fee;
        int _id;

        public ManageTestAndApplicationTypesSetting(EnMood mood, int id, string title, string fee)
        {
            enMood = mood;
            InitializeComponent();
            _title = title;
            _fee = fee;
            _id = id;


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        public ManageTestAndApplicationTypesSetting(EnMood mood, int id, string title, string fee, string description)
        {
            enMood = mood;
            InitializeComponent();
            _title = title;
            _fee = fee;
            _id = id;
            _description = description;


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void ManageTestAndApplicationTypesSetting_Load(object sender, EventArgs e)
        {
            switch (enMood)
            {
                case EnMood.TestTypes:
                    lbTitle.Text = "Manage Test Types Setting";
                    lbDescription.Visible = true;
                    tbDescription.Visible = true;
                    tbDescription.Multiline = true;
                    tbDescription.WordWrap = true;
                    tbDescription.Text = _description;
                    LoadTypes();
                    break;
                case EnMood.ApplicationTypes:
                    lbTitle.Text = "Manage Application Types Setting";
                    lbDescription.Visible = false;
                    tbDescription.Visible = false;
                    LoadTypes();
                    break;
            }
        }


        public void LoadTypes()
        {
            tbTitle.Text = _title;
            tbFee.Text = _fee;
            lbTypeID.Text = _id.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (enMood)
            {
                case EnMood.TestTypes:
                   if(string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbDescription.Text) || string.IsNullOrEmpty(tbFee.Text))
                    {
                        errorProvider1.SetError(btnSave, "Please fill all the text boxes !");
                    }
                    else
                    {
                        if (ManageTestTypesBusinessLayerClass.UpdateTestTypesSetting(_id, tbTitle.Text, tbDescription.Text, Convert.ToDecimal(tbFee.Text)))
                        {
                            MessageBox.Show("Setting updated successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Error: Process failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case EnMood.ApplicationTypes:
                    if (string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbFee.Text))
                    {
                        errorProvider1.SetError(btnSave, "Please fill all the text boxes !");
                    }
                    else
                    {
                        if (ManageApplicationTypesBusinessLayerClass.UpdateApplicationTypesSetting(_id, tbTitle.Text, Convert.ToDecimal(tbFee.Text)))
                        {
                            MessageBox.Show("Setting updated successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Error: Process failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                     
                    break;
            }
        }

        private void ManageTestAndApplicationTypesSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshlist.Invoke();
        }
    }
}
