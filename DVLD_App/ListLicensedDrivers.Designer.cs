namespace DVLD_App
{
    partial class ListLicensedDrivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListLicensedDrivers));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            dgvDriversList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDriversList).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(412, 14);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(356, 52);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Licensed Drivers List";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(493, 72);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(186, 154);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            // 
            // dgvDriversList
            // 
            dgvDriversList.AllowUserToAddRows = false;
            dgvDriversList.AllowUserToDeleteRows = false;
            dgvDriversList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(194, 224, 244);
            dgvDriversList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDriversList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDriversList.ColumnHeadersHeight = 30;
            dgvDriversList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDriversList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDriversList.Dock = DockStyle.Bottom;
            dgvDriversList.GridColor = Color.FromArgb(187, 220, 242);
            dgvDriversList.Location = new Point(0, 322);
            dgvDriversList.Name = "dgvDriversList";
            dgvDriversList.ReadOnly = true;
            dgvDriversList.RowHeadersVisible = false;
            dgvDriversList.Size = new Size(1156, 290);
            dgvDriversList.TabIndex = 2;
            dgvDriversList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvDriversList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvDriversList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDriversList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDriversList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDriversList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDriversList.ThemeStyle.BackColor = Color.White;
            dgvDriversList.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvDriversList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvDriversList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDriversList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvDriversList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDriversList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDriversList.ThemeStyle.HeaderStyle.Height = 30;
            dgvDriversList.ThemeStyle.ReadOnly = true;
            dgvDriversList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvDriversList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDriversList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDriversList.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvDriversList.ThemeStyle.RowsStyle.Height = 25;
            dgvDriversList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvDriversList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // ListLicensedDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 612);
            Controls.Add(dgvDriversList);
            Controls.Add(guna2PictureBox1);
            Controls.Add(guna2HtmlLabel1);
            Name = "ListLicensedDrivers";
            Text = "ListLicensedDrivers";
            Load += ListLicensedDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDriversList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDriversList;
    }
}