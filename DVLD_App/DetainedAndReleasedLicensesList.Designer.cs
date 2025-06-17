namespace DVLD_App
{
    partial class DetainedAndReleasedLicensesList
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            cmsDetainedLicenses = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            cmsShowLicenseDetail = new ToolStripMenuItem();
            cmsReleaseDetain = new ToolStripMenuItem();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            btnDetainLicense = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            dgvDetained = new Guna.UI2.WinForms.Guna2DataGridView();
            TabControlOne = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvReleased = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsDetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetained).BeginInit();
            TabControlOne.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReleased).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(560, 59);
            label1.TabIndex = 0;
            label1.Text = "Manage Detained Licenses";
            // 
            // cmsDetainedLicenses
            // 
            cmsDetainedLicenses.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cmsDetainedLicenses.Items.AddRange(new ToolStripItem[] { cmsShowLicenseDetail, cmsReleaseDetain });
            cmsDetainedLicenses.Name = "cmsDetainedLicenses";
            cmsDetainedLicenses.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsDetainedLicenses.RenderStyle.BorderColor = Color.Gainsboro;
            cmsDetainedLicenses.RenderStyle.ColorTable = null;
            cmsDetainedLicenses.RenderStyle.RoundedEdges = true;
            cmsDetainedLicenses.RenderStyle.SelectionArrowColor = Color.White;
            cmsDetainedLicenses.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsDetainedLicenses.RenderStyle.SelectionForeColor = Color.White;
            cmsDetainedLicenses.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsDetainedLicenses.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsDetainedLicenses.Size = new Size(259, 64);
            // 
            // cmsShowLicenseDetail
            // 
            cmsShowLicenseDetail.Name = "cmsShowLicenseDetail";
            cmsShowLicenseDetail.Size = new Size(258, 30);
            cmsShowLicenseDetail.Text = "Show License Detail";
            cmsShowLicenseDetail.Click += cmsShowLicenseDetail_Click;
            // 
            // cmsReleaseDetain
            // 
            cmsReleaseDetain.Name = "cmsReleaseDetain";
            cmsReleaseDetain.Size = new Size(258, 30);
            cmsReleaseDetain.Text = "Release Detain";
            cmsReleaseDetain.Click += cmsReleaseDetain_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(-36, 34);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(35, 17);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "Filter:";
            // 
            // tbFilter
            // 
            tbFilter.CustomizableEdges = customizableEdges1;
            tbFilter.DefaultText = "";
            tbFilter.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFilter.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFilter.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFilter.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFilter.Font = new Font("Segoe UI", 9F);
            tbFilter.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFilter.Location = new Point(274, 153);
            tbFilter.Name = "tbFilter";
            tbFilter.PasswordChar = '\0';
            tbFilter.PlaceholderText = "";
            tbFilter.SelectedText = "";
            tbFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbFilter.Size = new Size(207, 36);
            tbFilter.TabIndex = 10;
            tbFilter.TextChanged += tbFilter_TextChanged;
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
            cbFilter.Location = new Point(92, 153);
            cbFilter.Margin = new Padding(3, 2, 3, 2);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbFilter.Size = new Size(177, 36);
            cbFilter.TabIndex = 9;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.CustomizableEdges = customizableEdges5;
            btnDetainLicense.DisabledState.BorderColor = Color.DarkGray;
            btnDetainLicense.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDetainLicense.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDetainLicense.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDetainLicense.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDetainLicense.ForeColor = Color.White;
            btnDetainLicense.Location = new Point(857, 153);
            btnDetainLicense.Margin = new Padding(3, 2, 3, 2);
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDetainLicense.Size = new Size(127, 42);
            btnDetainLicense.TabIndex = 8;
            btnDetainLicense.Text = "Detain License";
            btnDetainLicense.Click += btnDetainLicense_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(31, 159);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 13;
            label2.Text = "Filter:";
            // 
            // dgvDetained
            // 
            dgvDetained.AllowUserToAddRows = false;
            dgvDetained.AllowUserToDeleteRows = false;
            dgvDetained.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dgvDetained.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetained.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetained.ColumnHeadersHeight = 30;
            dgvDetained.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDetained.ContextMenuStrip = cmsDetainedLicenses;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDetained.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDetained.Dock = DockStyle.Fill;
            dgvDetained.GridColor = Color.FromArgb(187, 220, 242);
            dgvDetained.Location = new Point(3, 3);
            dgvDetained.Name = "dgvDetained";
            dgvDetained.ReadOnly = true;
            dgvDetained.RowHeadersVisible = false;
            dgvDetained.Size = new Size(793, 181);
            dgvDetained.TabIndex = 0;
            dgvDetained.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvDetained.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvDetained.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDetained.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDetained.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDetained.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDetained.ThemeStyle.BackColor = Color.White;
            dgvDetained.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvDetained.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvDetained.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetained.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvDetained.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDetained.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDetained.ThemeStyle.HeaderStyle.Height = 30;
            dgvDetained.ThemeStyle.ReadOnly = true;
            dgvDetained.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvDetained.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetained.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDetained.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvDetained.ThemeStyle.RowsStyle.Height = 25;
            dgvDetained.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvDetained.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // TabControlOne
            // 
            TabControlOne.Alignment = TabAlignment.Left;
            TabControlOne.Controls.Add(tabPage1);
            TabControlOne.Controls.Add(tabPage2);
            TabControlOne.ItemSize = new Size(180, 40);
            TabControlOne.Location = new Point(12, 248);
            TabControlOne.Name = "TabControlOne";
            TabControlOne.SelectedIndex = 0;
            TabControlOne.Size = new Size(987, 195);
            TabControlOne.TabButtonHoverState.BorderColor = Color.Empty;
            TabControlOne.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            TabControlOne.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            TabControlOne.TabButtonHoverState.ForeColor = Color.White;
            TabControlOne.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            TabControlOne.TabButtonIdleState.BorderColor = Color.Empty;
            TabControlOne.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            TabControlOne.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            TabControlOne.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            TabControlOne.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            TabControlOne.TabButtonSelectedState.BorderColor = Color.Empty;
            TabControlOne.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            TabControlOne.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            TabControlOne.TabButtonSelectedState.ForeColor = Color.White;
            TabControlOne.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            TabControlOne.TabButtonSize = new Size(180, 40);
            TabControlOne.TabIndex = 35;
            TabControlOne.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDetained);
            tabPage1.Location = new Point(184, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 187);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detained";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvReleased);
            tabPage2.Location = new Point(184, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 187);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Released";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvReleased
            // 
            dgvReleased.AllowUserToAddRows = false;
            dgvReleased.AllowUserToDeleteRows = false;
            dgvReleased.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(194, 224, 244);
            dgvReleased.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvReleased.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvReleased.ColumnHeadersHeight = 30;
            dgvReleased.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvReleased.DefaultCellStyle = dataGridViewCellStyle6;
            dgvReleased.Dock = DockStyle.Fill;
            dgvReleased.GridColor = Color.FromArgb(187, 220, 242);
            dgvReleased.Location = new Point(3, 3);
            dgvReleased.Name = "dgvReleased";
            dgvReleased.ReadOnly = true;
            dgvReleased.RowHeadersVisible = false;
            dgvReleased.Size = new Size(793, 181);
            dgvReleased.TabIndex = 0;
            dgvReleased.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvReleased.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvReleased.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReleased.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReleased.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReleased.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReleased.ThemeStyle.BackColor = Color.White;
            dgvReleased.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvReleased.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvReleased.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReleased.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvReleased.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReleased.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvReleased.ThemeStyle.HeaderStyle.Height = 30;
            dgvReleased.ThemeStyle.ReadOnly = true;
            dgvReleased.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvReleased.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReleased.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvReleased.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvReleased.ThemeStyle.RowsStyle.Height = 25;
            dgvReleased.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvReleased.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // DetainedAndReleasedLicensesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(TabControlOne);
            Controls.Add(label2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(tbFilter);
            Controls.Add(cbFilter);
            Controls.Add(btnDetainLicense);
            Controls.Add(label1);
            Name = "DetainedAndReleasedLicensesList";
            Text = "DetainedLicensesList";
            FormClosing += DetainedAndReleasedLicensesList_FormClosing;
            Load += DetainedLicensesList_Load;
            cmsDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetained).EndInit();
            TabControlOne.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReleased).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2Button btnDetainLicense;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsDetainedLicenses;
        private ToolStripMenuItem cmsShowLicenseDetail;
        private ToolStripMenuItem cmsReleaseDetain;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetained;
        private Guna.UI2.WinForms.Guna2TabControl TabControlOne;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReleased;
    }
}