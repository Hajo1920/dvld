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
    public partial class FindPersonUC : UserControl
    {

        public delegate void SendId(int id);
        public event SendId sendid;
        public delegate void ListInfo(int id);
        public event ListInfo listinfo;
        public delegate void RevealLink();
        public event RevealLink revealLink;
        
        public FindPersonUC()
        {
            InitializeComponent();
        }
       
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                if (comboFind.SelectedIndex == 0)
                {
                    DataRow row = FullPersonDetailBusinessLayerClass.FullPersonDetail(Convert.ToInt32(boxFind.Text)).Rows[0];

                    id = Convert.ToInt32(row[0]);
                   

                }
                else
                {
                    DataRow row = FullPersonDetailBusinessLayerClass.FullPersonDetail(boxFind.Text).Rows[0];

                    id = Convert.ToInt32(row[0]);
    
                }

                sendid.Invoke(id);
                revealLink.Invoke();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            
        }

        public void Refresh()
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddUpdateNewPerson add = new AddUpdateNewPerson();
            add.RefreshList += Refresh;
            add.ShowDialog();
        }

        private void comboFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindPersonUC_Load(object sender, EventArgs e)
        {
            comboFind.Items.Add("PersonID");
            comboFind.Items.Add("National Number");
            comboFind.SelectedIndex = 0;
        }
    }
}
