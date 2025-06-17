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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
namespace DVLD_App
{
    public partial class PeopleList : Form
    {

        public delegate void RefreshMainCountDelegate();

        public event RefreshMainCountDelegate Refresh;

        public PeopleList()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void PeopleList_Load(object sender, EventArgs e)
        {
            cmsOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;

            

            ListPeople();


        }

        public void ListPeople()
        {
            comboFilter.Items.Add("None");
            comboFilter.SelectedIndex = 0;
            DataView dataView = PeopleListBusinessClass.PeopleList().DefaultView;
            foreach (DataColumn filterName in dataView.Table.Columns)
            {
                comboFilter.Items.Add(filterName.ColumnName);
            }

            dgvPeopleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPeopleList.DataSource = dataView;
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = PeopleListBusinessClass.PeopleList().DefaultView;
            if (comboFilter.SelectedIndex == 0)
            {
                textBoxFilter.Visible = false;
                dgvPeopleList.DataSource = dv;

            }
            else
            {
                textBoxFilter.Visible = true;
                textBoxFilter.Focus();
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {

            DataView dv = PeopleListBusinessClass.PeopleList().DefaultView;
            if (textBoxFilter.Text == "")
            {
                dgvPeopleList.DataSource = dv;
            }
            else
            {

                dv.RowFilter = $"{comboFilter.SelectedItem.ToString()}='{textBoxFilter.Text}'";

                dgvPeopleList.DataSource = dv;
            }
        }


        private void PeopleList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Refresh.Invoke();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateNewPerson newPerson = new AddUpdateNewPerson();
            newPerson.RefreshList += ListPeople;
            newPerson.ShowDialog();
        }

        private void viewPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentRow != null)
            {
                int personId = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value);
                ShowPersonDetail detail = new ShowPersonDetail(personId);
                
                detail.ShowDialog();
            }
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            AddUpdateNewPerson newPerson = new AddUpdateNewPerson();
            newPerson.RefreshList += ListPeople;
            comboFilter.Items.Clear();
            newPerson.ShowDialog();
        }

        private void editSelectedPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentRow != null)
            {
                int personId = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value);
                AddUpdateNewPerson updatePerson = new AddUpdateNewPerson(personId);
                updatePerson.RefreshList += ListPeople;
                updatePerson.ShowDialog();
            }
        }

        private void deleteSelectedPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this person ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeleteSelectedPersonBusinessLayerClass.DeletePerson(Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Person Deleted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListPeople();
                }
                else
                {
                    MessageBox.Show("Process Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Not Implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Not Implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
