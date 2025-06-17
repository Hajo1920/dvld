namespace DVLD_App
{
    partial class PeopleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleList));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cmsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            viewPersonDetailToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editSelectedPersonToolStripMenuItem = new ToolStripMenuItem();
            deleteSelectedPersonToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            comboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            pictureBox1 = new PictureBox();
            textBoxFilter = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            dgvPeopleList = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).BeginInit();
            SuspendLayout();
            // 
            // cmsOptions
            // 
            cmsOptions.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmsOptions.ImageScalingSize = new Size(38, 38);
            cmsOptions.Items.AddRange(new ToolStripItem[] { viewPersonDetailToolStripMenuItem, addNewPersonToolStripMenuItem, editSelectedPersonToolStripMenuItem, deleteSelectedPersonToolStripMenuItem, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsOptions.Name = "cmsOptions";
            cmsOptions.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsOptions.RenderStyle.BorderColor = Color.Gainsboro;
            cmsOptions.RenderStyle.ColorTable = null;
            cmsOptions.RenderStyle.RoundedEdges = true;
            cmsOptions.RenderStyle.SelectionArrowColor = Color.White;
            cmsOptions.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsOptions.RenderStyle.SelectionForeColor = Color.White;
            cmsOptions.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsOptions.ShowCheckMargin = true;
            cmsOptions.Size = new Size(300, 268);
            // 
            // viewPersonDetailToolStripMenuItem
            // 
            viewPersonDetailToolStripMenuItem.Image = (Image)resources.GetObject("viewPersonDetailToolStripMenuItem.Image");
            viewPersonDetailToolStripMenuItem.Name = "viewPersonDetailToolStripMenuItem";
            viewPersonDetailToolStripMenuItem.Size = new Size(299, 44);
            viewPersonDetailToolStripMenuItem.Text = "View Person Detail";
            viewPersonDetailToolStripMenuItem.Click += viewPersonDetailToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = (Image)resources.GetObject("addNewPersonToolStripMenuItem.Image");
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(299, 44);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editSelectedPersonToolStripMenuItem
            // 
            editSelectedPersonToolStripMenuItem.Image = (Image)resources.GetObject("editSelectedPersonToolStripMenuItem.Image");
            editSelectedPersonToolStripMenuItem.Name = "editSelectedPersonToolStripMenuItem";
            editSelectedPersonToolStripMenuItem.Size = new Size(299, 44);
            editSelectedPersonToolStripMenuItem.Text = "Edit Selected Person";
            editSelectedPersonToolStripMenuItem.Click += editSelectedPersonToolStripMenuItem_Click;
            // 
            // deleteSelectedPersonToolStripMenuItem
            // 
            deleteSelectedPersonToolStripMenuItem.Image = (Image)resources.GetObject("deleteSelectedPersonToolStripMenuItem.Image");
            deleteSelectedPersonToolStripMenuItem.Name = "deleteSelectedPersonToolStripMenuItem";
            deleteSelectedPersonToolStripMenuItem.Size = new Size(299, 44);
            deleteSelectedPersonToolStripMenuItem.Text = "Delete Selected Person";
            deleteSelectedPersonToolStripMenuItem.Click += deleteSelectedPersonToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(299, 44);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(299, 44);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(616, 53);
            label1.Name = "label1";
            label1.Size = new Size(214, 47);
            label1.TabIndex = 1;
            label1.Text = "Peoples List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Filter By:";
            // 
            // comboFilter
            // 
            comboFilter.BackColor = Color.Transparent;
            comboFilter.CustomizableEdges = customizableEdges1;
            comboFilter.DrawMode = DrawMode.OwnerDrawFixed;
            comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            comboFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboFilter.Font = new Font("Segoe UI", 10F);
            comboFilter.ForeColor = Color.FromArgb(68, 88, 112);
            comboFilter.ItemHeight = 30;
            comboFilter.Location = new Point(88, 58);
            comboFilter.Margin = new Padding(3, 2, 3, 2);
            comboFilter.Name = "comboFilter";
            comboFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboFilter.Size = new Size(212, 36);
            comboFilter.TabIndex = 3;
            comboFilter.SelectedIndexChanged += comboFilter_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(669, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxFilter
            // 
            textBoxFilter.CustomizableEdges = customizableEdges3;
            textBoxFilter.DefaultText = "";
            textBoxFilter.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxFilter.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxFilter.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxFilter.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxFilter.Font = new Font("Segoe UI", 9F);
            textBoxFilter.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxFilter.Location = new Point(304, 58);
            textBoxFilter.Margin = new Padding(3, 4, 3, 4);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.PasswordChar = '\0';
            textBoxFilter.PlaceholderText = "Type Here..";
            textBoxFilter.SelectedText = "";
            textBoxFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxFilter.Size = new Size(236, 35);
            textBoxFilter.TabIndex = 6;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // btnAddPerson
            // 
            btnAddPerson.CustomizableEdges = customizableEdges5;
            btnAddPerson.DisabledState.BorderColor = Color.DarkGray;
            btnAddPerson.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddPerson.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddPerson.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddPerson.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddPerson.ForeColor = Color.White;
            btnAddPerson.Location = new Point(1039, 52);
            btnAddPerson.Margin = new Padding(3, 2, 3, 2);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddPerson.Size = new Size(107, 42);
            btnAddPerson.TabIndex = 7;
            btnAddPerson.Text = "Add Person";
            btnAddPerson.Click += btnAddPerson_Click_1;
            // 
            // dgvPeopleList
            // 
            dgvPeopleList.AllowUserToAddRows = false;
            dgvPeopleList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dgvPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPeopleList.ColumnHeadersHeight = 30;
            dgvPeopleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPeopleList.ContextMenuStrip = cmsOptions;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPeopleList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPeopleList.Dock = DockStyle.Bottom;
            dgvPeopleList.GridColor = Color.FromArgb(187, 220, 242);
            dgvPeopleList.Location = new Point(0, 135);
            dgvPeopleList.Name = "dgvPeopleList";
            dgvPeopleList.ReadOnly = true;
            dgvPeopleList.RowHeadersVisible = false;
            dgvPeopleList.Size = new Size(1199, 345);
            dgvPeopleList.TabIndex = 8;
            dgvPeopleList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvPeopleList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvPeopleList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPeopleList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPeopleList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPeopleList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPeopleList.ThemeStyle.BackColor = Color.White;
            dgvPeopleList.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvPeopleList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvPeopleList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPeopleList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPeopleList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPeopleList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPeopleList.ThemeStyle.HeaderStyle.Height = 30;
            dgvPeopleList.ThemeStyle.ReadOnly = true;
            dgvPeopleList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvPeopleList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPeopleList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPeopleList.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvPeopleList.ThemeStyle.RowsStyle.Height = 25;
            dgvPeopleList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvPeopleList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // PeopleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 480);
            Controls.Add(dgvPeopleList);
            Controls.Add(btnAddPerson);
            Controls.Add(textBoxFilter);
            Controls.Add(pictureBox1);
            Controls.Add(comboFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PeopleList";
            Text = "PeopleList";
            FormClosing += PeopleList_FormClosing;
            Load += PeopleList_Load;
            cmsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comboFilter;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFilter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOptions;
        private ToolStripMenuItem viewPersonDetailToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem editSelectedPersonToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedPersonToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPeopleList;
    }
}