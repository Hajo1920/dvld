namespace DVLD_App
{
    partial class ShowPersonLicenseHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            personInfouc1 = new PersonInfoUC();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            dgvLocal = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvInternational = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).BeginInit();
            guna2TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternational).BeginInit();
            SuspendLayout();
            // 
            // personInfouc1
            // 
            personInfouc1.Address = null;
            personInfouc1.BirthDate = new DateTime(0L);
            personInfouc1.BorderStyle = BorderStyle.FixedSingle;
            personInfouc1.Email = null;
            personInfouc1.FirstName = null;
            personInfouc1.Gendor = null;
            personInfouc1.ID = 0;
            personInfouc1.ImagePath = null;
            personInfouc1.LastName = null;
            personInfouc1.Location = new Point(33, 87);
            personInfouc1.NaitonalID = null;
            personInfouc1.Name = "personInfouc1";
            personInfouc1.Phone = null;
            personInfouc1.SecondName = null;
            personInfouc1.Size = new Size(932, 375);
            personInfouc1.TabIndex = 0;
            personInfouc1.ThirdName = null;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(366, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(288, 56);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "License History";
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Tomato;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(852, 663);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(109, 33);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // dgvLocal
            // 
            dgvLocal.AllowUserToAddRows = false;
            dgvLocal.AllowUserToDeleteRows = false;
            dgvLocal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dgvLocal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLocal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLocal.ColumnHeadersHeight = 30;
            dgvLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLocal.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLocal.Dock = DockStyle.Fill;
            dgvLocal.GridColor = Color.FromArgb(187, 220, 242);
            dgvLocal.Location = new Point(3, 3);
            dgvLocal.Name = "dgvLocal";
            dgvLocal.ReadOnly = true;
            dgvLocal.RowHeadersVisible = false;
            dgvLocal.Size = new Size(738, 169);
            dgvLocal.TabIndex = 0;
            dgvLocal.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvLocal.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvLocal.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvLocal.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvLocal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvLocal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvLocal.ThemeStyle.BackColor = Color.White;
            dgvLocal.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvLocal.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvLocal.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLocal.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvLocal.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvLocal.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvLocal.ThemeStyle.HeaderStyle.Height = 30;
            dgvLocal.ThemeStyle.ReadOnly = true;
            dgvLocal.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvLocal.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLocal.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvLocal.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvLocal.ThemeStyle.RowsStyle.Height = 25;
            dgvLocal.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvLocal.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Alignment = TabAlignment.Left;
            guna2TabControl1.Controls.Add(tabPage1);
            guna2TabControl1.Controls.Add(tabPage2);
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(33, 469);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(932, 183);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 34;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvLocal);
            tabPage1.Location = new Point(184, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(744, 175);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvInternational);
            tabPage2.Location = new Point(184, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(744, 175);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvInternational
            // 
            dgvInternational.AllowUserToAddRows = false;
            dgvInternational.AllowUserToDeleteRows = false;
            dgvInternational.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(194, 224, 244);
            dgvInternational.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInternational.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInternational.ColumnHeadersHeight = 30;
            dgvInternational.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvInternational.DefaultCellStyle = dataGridViewCellStyle6;
            dgvInternational.Dock = DockStyle.Fill;
            dgvInternational.GridColor = Color.FromArgb(187, 220, 242);
            dgvInternational.Location = new Point(3, 3);
            dgvInternational.Name = "dgvInternational";
            dgvInternational.ReadOnly = true;
            dgvInternational.RowHeadersVisible = false;
            dgvInternational.Size = new Size(738, 169);
            dgvInternational.TabIndex = 0;
            dgvInternational.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvInternational.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvInternational.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInternational.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInternational.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInternational.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInternational.ThemeStyle.BackColor = Color.White;
            dgvInternational.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvInternational.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvInternational.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInternational.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvInternational.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInternational.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInternational.ThemeStyle.HeaderStyle.Height = 30;
            dgvInternational.ThemeStyle.ReadOnly = true;
            dgvInternational.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvInternational.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInternational.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInternational.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvInternational.ThemeStyle.RowsStyle.Height = 25;
            dgvInternational.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvInternational.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // ShowPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 706);
            Controls.Add(guna2TabControl1);
            Controls.Add(btnClose);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(personInfouc1);
            Name = "ShowPersonLicenseHistory";
            Text = "ShowPersonLicenseHistory";
            Load += ShowPersonLicenseHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLocal).EndInit();
            guna2TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternational).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PersonInfoUC personInfouc1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLocal;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInternational;
    }
}