namespace DVLD_App
{
    partial class UsersList
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersList));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvUsersList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(521, 55);
            label1.Name = "label1";
            label1.Size = new Size(329, 51);
            label1.TabIndex = 0;
            label1.Text = "System Users List";
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.CustomizableEdges = customizableEdges1;
            btnAddNewUser.DisabledState.BorderColor = Color.DarkGray;
            btnAddNewUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNewUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNewUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNewUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddNewUser.ForeColor = Color.White;
            btnAddNewUser.Location = new Point(979, 64);
            btnAddNewUser.Margin = new Padding(3, 2, 3, 2);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddNewUser.Size = new Size(127, 42);
            btnAddNewUser.TabIndex = 2;
            btnAddNewUser.Text = "Add New User";
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(633, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Transparent;
            cbFilter.CustomizableEdges = customizableEdges3;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilter.Font = new Font("Segoe UI", 10F);
            cbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cbFilter.ItemHeight = 30;
            cbFilter.Location = new Point(60, 51);
            cbFilter.Margin = new Padding(3, 2, 3, 2);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbFilter.Size = new Size(177, 36);
            cbFilter.TabIndex = 4;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // tbFilter
            // 
            tbFilter.CustomizableEdges = customizableEdges5;
            tbFilter.DefaultText = "";
            tbFilter.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFilter.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFilter.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFilter.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFilter.Font = new Font("Segoe UI", 9F);
            tbFilter.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFilter.Location = new Point(242, 51);
            tbFilter.Name = "tbFilter";
            tbFilter.PasswordChar = '\0';
            tbFilter.PlaceholderText = "";
            tbFilter.SelectedText = "";
            tbFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbFilter.Size = new Size(207, 36);
            tbFilter.TabIndex = 5;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(12, 59);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(35, 17);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Filter:";
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dgvUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsersList.ColumnHeadersHeight = 30;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsersList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsersList.Dock = DockStyle.Bottom;
            dgvUsersList.GridColor = Color.FromArgb(187, 220, 242);
            dgvUsersList.Location = new Point(0, 147);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.RowHeadersVisible = false;
            dgvUsersList.Size = new Size(1199, 191);
            dgvUsersList.TabIndex = 7;
            dgvUsersList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvUsersList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvUsersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsersList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsersList.ThemeStyle.BackColor = Color.White;
            dgvUsersList.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvUsersList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvUsersList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsersList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvUsersList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUsersList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsersList.ThemeStyle.HeaderStyle.Height = 30;
            dgvUsersList.ThemeStyle.ReadOnly = false;
            dgvUsersList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvUsersList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsersList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsersList.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvUsersList.ThemeStyle.RowsStyle.Height = 25;
            dgvUsersList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvUsersList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 338);
            Controls.Add(dgvUsersList);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(tbFilter);
            Controls.Add(cbFilter);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddNewUser);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsersList";
            Text = "UsersList";
            FormClosing += UsersList_FormClosing;
            Load += UsersList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersList;
    }
}