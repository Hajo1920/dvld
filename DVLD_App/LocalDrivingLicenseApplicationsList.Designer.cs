namespace DVLD_App
{
    partial class LocalDrivingLicenseApplicationsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseApplicationsList));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddNewApplication = new Guna.UI2.WinForms.Guna2Button();
            dgvApplicationsList = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsApplicationProperties = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            tsmShowApplicationDetail = new ToolStripMenuItem();
            tsmEditApplication = new ToolStripMenuItem();
            tsmDeleteApplication = new ToolStripMenuItem();
            tsmCancelApplication = new ToolStripMenuItem();
            tsmScheduleTests = new ToolStripMenuItem();
            tsmScheduleTestVision = new ToolStripMenuItem();
            tsmScheduleTestTheory = new ToolStripMenuItem();
            tsmScheduleTestPractical = new ToolStripMenuItem();
            tsmIssueDrivingLicense = new ToolStripMenuItem();
            tsmShowLicense = new ToolStripMenuItem();
            tsmShowPersonLicenseHistory = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationsList).BeginInit();
            cmsApplicationProperties.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(220, 74);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(597, 52);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Local Driving License Applications";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(439, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(143, 72);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
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
            cbFilter.Location = new Point(108, 163);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbFilter.Size = new Size(244, 36);
            cbFilter.TabIndex = 2;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2HtmlLabel2.Location = new Point(10, 171);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(58, 19);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Filter By:";
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
            tbFilter.Location = new Point(379, 163);
            tbFilter.Name = "tbFilter";
            tbFilter.PasswordChar = '\0';
            tbFilter.PlaceholderText = "";
            tbFilter.SelectedText = "";
            tbFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbFilter.Size = new Size(236, 36);
            tbFilter.TabIndex = 4;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // btnAddNewApplication
            // 
            btnAddNewApplication.CustomizableEdges = customizableEdges7;
            btnAddNewApplication.DisabledState.BorderColor = Color.DarkGray;
            btnAddNewApplication.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNewApplication.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNewApplication.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNewApplication.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddNewApplication.ForeColor = Color.White;
            btnAddNewApplication.Location = new Point(889, 163);
            btnAddNewApplication.Name = "btnAddNewApplication";
            btnAddNewApplication.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddNewApplication.Size = new Size(160, 36);
            btnAddNewApplication.TabIndex = 5;
            btnAddNewApplication.Text = "Add New Application";
            btnAddNewApplication.Click += btnAddNewApplication_Click;
            // 
            // dgvApplicationsList
            // 
            dgvApplicationsList.AllowUserToAddRows = false;
            dgvApplicationsList.AllowUserToDeleteRows = false;
            dgvApplicationsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dgvApplicationsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvApplicationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvApplicationsList.ColumnHeadersHeight = 30;
            dgvApplicationsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvApplicationsList.ContextMenuStrip = cmsApplicationProperties;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvApplicationsList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvApplicationsList.Dock = DockStyle.Bottom;
            dgvApplicationsList.GridColor = Color.FromArgb(187, 220, 242);
            dgvApplicationsList.Location = new Point(0, 249);
            dgvApplicationsList.Name = "dgvApplicationsList";
            dgvApplicationsList.ReadOnly = true;
            dgvApplicationsList.RowHeadersVisible = false;
            dgvApplicationsList.Size = new Size(1125, 298);
            dgvApplicationsList.TabIndex = 6;
            dgvApplicationsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvApplicationsList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvApplicationsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvApplicationsList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvApplicationsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvApplicationsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvApplicationsList.ThemeStyle.BackColor = Color.White;
            dgvApplicationsList.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvApplicationsList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvApplicationsList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvApplicationsList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvApplicationsList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvApplicationsList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvApplicationsList.ThemeStyle.HeaderStyle.Height = 30;
            dgvApplicationsList.ThemeStyle.ReadOnly = true;
            dgvApplicationsList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvApplicationsList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApplicationsList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvApplicationsList.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvApplicationsList.ThemeStyle.RowsStyle.Height = 25;
            dgvApplicationsList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvApplicationsList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // cmsApplicationProperties
            // 
            cmsApplicationProperties.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cmsApplicationProperties.ImageScalingSize = new Size(46, 46);
            cmsApplicationProperties.Items.AddRange(new ToolStripItem[] { tsmShowApplicationDetail, tsmEditApplication, tsmDeleteApplication, tsmCancelApplication, tsmScheduleTests, tsmIssueDrivingLicense, tsmShowLicense, tsmShowPersonLicenseHistory });
            cmsApplicationProperties.Name = "cmsApplicationProperties";
            cmsApplicationProperties.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsApplicationProperties.RenderStyle.BorderColor = Color.Gainsboro;
            cmsApplicationProperties.RenderStyle.ColorTable = null;
            cmsApplicationProperties.RenderStyle.RoundedEdges = true;
            cmsApplicationProperties.RenderStyle.SelectionArrowColor = Color.White;
            cmsApplicationProperties.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsApplicationProperties.RenderStyle.SelectionForeColor = Color.White;
            cmsApplicationProperties.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsApplicationProperties.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsApplicationProperties.Size = new Size(400, 442);
            cmsApplicationProperties.Opening += cmsApplicationProperties_Opening;
            // 
            // tsmShowApplicationDetail
            // 
            tsmShowApplicationDetail.Image = (Image)resources.GetObject("tsmShowApplicationDetail.Image");
            tsmShowApplicationDetail.Name = "tsmShowApplicationDetail";
            tsmShowApplicationDetail.Size = new Size(399, 52);
            tsmShowApplicationDetail.Text = "Show Application Detail";
            tsmShowApplicationDetail.Click += showApplicationDetailToolStripMenuItem_Click;
            // 
            // tsmEditApplication
            // 
            tsmEditApplication.Image = (Image)resources.GetObject("tsmEditApplication.Image");
            tsmEditApplication.Name = "tsmEditApplication";
            tsmEditApplication.Size = new Size(399, 52);
            tsmEditApplication.Text = "Edit Application";
            tsmEditApplication.Click += tsmEditApplication_Click;
            // 
            // tsmDeleteApplication
            // 
            tsmDeleteApplication.Image = (Image)resources.GetObject("tsmDeleteApplication.Image");
            tsmDeleteApplication.Name = "tsmDeleteApplication";
            tsmDeleteApplication.Size = new Size(399, 52);
            tsmDeleteApplication.Text = "Delete Application";
            tsmDeleteApplication.Click += tsmDeleteApplication_Click;
            // 
            // tsmCancelApplication
            // 
            tsmCancelApplication.Image = (Image)resources.GetObject("tsmCancelApplication.Image");
            tsmCancelApplication.ImageAlign = ContentAlignment.MiddleLeft;
            tsmCancelApplication.Name = "tsmCancelApplication";
            tsmCancelApplication.Size = new Size(399, 52);
            tsmCancelApplication.Text = "Cancel Application";
            tsmCancelApplication.Click += tsmCancelApplication_Click;
            // 
            // tsmScheduleTests
            // 
            tsmScheduleTests.DropDownItems.AddRange(new ToolStripItem[] { tsmScheduleTestVision, tsmScheduleTestTheory, tsmScheduleTestPractical });
            tsmScheduleTests.Image = (Image)resources.GetObject("tsmScheduleTests.Image");
            tsmScheduleTests.Name = "tsmScheduleTests";
            tsmScheduleTests.Size = new Size(399, 52);
            tsmScheduleTests.Text = "Schedule Tests";
            // 
            // tsmScheduleTestVision
            // 
            tsmScheduleTestVision.Image = (Image)resources.GetObject("tsmScheduleTestVision.Image");
            tsmScheduleTestVision.Name = "tsmScheduleTestVision";
            tsmScheduleTestVision.Size = new Size(313, 52);
            tsmScheduleTestVision.Text = "Schedule Vision Test";
            tsmScheduleTestVision.Click += tsmScheduleTestVision_Click;
            // 
            // tsmScheduleTestTheory
            // 
            tsmScheduleTestTheory.Image = (Image)resources.GetObject("tsmScheduleTestTheory.Image");
            tsmScheduleTestTheory.Name = "tsmScheduleTestTheory";
            tsmScheduleTestTheory.Size = new Size(313, 52);
            tsmScheduleTestTheory.Text = "Schedule Theory Test";
            tsmScheduleTestTheory.Click += tsmScheduleTestTheory_Click;
            // 
            // tsmScheduleTestPractical
            // 
            tsmScheduleTestPractical.Image = (Image)resources.GetObject("tsmScheduleTestPractical.Image");
            tsmScheduleTestPractical.Name = "tsmScheduleTestPractical";
            tsmScheduleTestPractical.Size = new Size(313, 52);
            tsmScheduleTestPractical.Text = "Schedule Practical Test";
            tsmScheduleTestPractical.Click += tsmScheduleTestPractical_Click;
            // 
            // tsmIssueDrivingLicense
            // 
            tsmIssueDrivingLicense.Image = (Image)resources.GetObject("tsmIssueDrivingLicense.Image");
            tsmIssueDrivingLicense.Name = "tsmIssueDrivingLicense";
            tsmIssueDrivingLicense.Size = new Size(399, 52);
            tsmIssueDrivingLicense.Text = "Issue Driving License (First time)";
            tsmIssueDrivingLicense.Click += tsmIssueDrivingLicense_Click;
            // 
            // tsmShowLicense
            // 
            tsmShowLicense.Image = (Image)resources.GetObject("tsmShowLicense.Image");
            tsmShowLicense.Name = "tsmShowLicense";
            tsmShowLicense.Size = new Size(399, 52);
            tsmShowLicense.Text = "Show License";
            tsmShowLicense.Click += tsmShowLicense_Click;
            // 
            // tsmShowPersonLicenseHistory
            // 
            tsmShowPersonLicenseHistory.Image = (Image)resources.GetObject("tsmShowPersonLicenseHistory.Image");
            tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            tsmShowPersonLicenseHistory.Size = new Size(399, 52);
            tsmShowPersonLicenseHistory.Text = "Show Person License History";
            tsmShowPersonLicenseHistory.Click += tsmShowPersonLicenseHistory_Click;
            // 
            // LocalDrivingLicenseApplicationsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 547);
            Controls.Add(dgvApplicationsList);
            Controls.Add(btnAddNewApplication);
            Controls.Add(tbFilter);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(cbFilter);
            Controls.Add(guna2PictureBox1);
            Controls.Add(guna2HtmlLabel1);
            Name = "LocalDrivingLicenseApplicationsList";
            Text = "LocalDrivingLicenseApplicationsList";
            FormClosing += LocalDrivingLicenseApplicationsList_FormClosing;
            Load += LocalDrivingLicenseApplicationsList_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationsList).EndInit();
            cmsApplicationProperties.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNewApplication;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplicationsList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsApplicationProperties;
        private ToolStripMenuItem tsmShowApplicationDetail;
        private ToolStripMenuItem tsmEditApplication;
        private ToolStripMenuItem tsmDeleteApplication;
        private ToolStripMenuItem tsmCancelApplication;
        private ToolStripMenuItem tsmScheduleTests;
        private ToolStripMenuItem tsmIssueDrivingLicense;
        private ToolStripMenuItem tsmShowLicense;
        private ToolStripMenuItem tsmShowPersonLicenseHistory;
        private ToolStripMenuItem tsmScheduleTestVision;
        private ToolStripMenuItem tsmScheduleTestTheory;
        private ToolStripMenuItem tsmScheduleTestPractical;
    }
}