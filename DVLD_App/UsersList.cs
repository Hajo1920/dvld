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
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }
        public delegate void RefreshMainCountDelegate();

        public event RefreshMainCountDelegate Refresh;

        private void UsersList_Load(object sender, EventArgs e)
        {

            ListUser();

        }

        public void ListUser()
        {
            cbFilter.Items.Add("None");
            cbFilter.SelectedIndex = 0;
            DataView dataView = UsersListBusinessLayerClass.ListUsers().DefaultView;
            foreach (DataColumn filterName in dataView.Table.Columns)
            {
                cbFilter.Items.Add(filterName.ColumnName);
            }

            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsersList.DataSource = dataView;
            dgvUsersList.Columns["isActive"].ReadOnly = false;

        }



        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser newUser = new AddNewUser();
            newUser.refresh += ListUser;
            cbFilter.Items.Clear();
            newUser.ShowDialog();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = UsersListBusinessLayerClass.ListUsers().DefaultView;
            if (cbFilter.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                dgvUsersList.DataSource = dataView;

            }
            else
            {
                tbFilter.Visible = true;
                tbFilter.Focus();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = UsersListBusinessLayerClass.ListUsers().DefaultView;
            if (tbFilter.Text == "")
            {
                dgvUsersList.DataSource = dv;
            }
            else
            {



                if (cbFilter.SelectedIndex != cbFilter.Items.Count - 1)
                {

                    
                    dv.RowFilter = $"{cbFilter.SelectedItem.ToString()} = '{tbFilter.Text}'";

                }
                else
                {
                    dv.RowFilter = $"{cbFilter.SelectedItem.ToString()} = {Convert.ToInt32(tbFilter.Text)}";
                }

                dgvUsersList.DataSource = dv;


            }
        }

        private void UsersList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Refresh.Invoke();
        }
    }
}
