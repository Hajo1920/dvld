namespace DVLD_App
{
    partial class TestAppointment
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAppointment));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            showApplicationDetailuc1 = new ShowApplicationDetailUC();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAppointment = new Guna.UI2.WinForms.Guna2Button();
            dgvAppointmentList = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsAppointments = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            tsmEdit = new ToolStripMenuItem();
            tsmTakeTest = new ToolStripMenuItem();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbAppointmentListCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pbTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentList).BeginInit();
            cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            SuspendLayout();
            // 
            // showApplicationDetailuc1
            // 
            showApplicationDetailuc1.Location = new Point(3, 58);
            showApplicationDetailuc1.Name = "showApplicationDetailuc1";
            showApplicationDetailuc1.Size = new Size(950, 429);
            showApplicationDetailuc1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(39, 490);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(116, 23);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Appointments:";
            // 
            // btnAppointment
            // 
            btnAppointment.CustomizableEdges = customizableEdges1;
            btnAppointment.DisabledState.BorderColor = Color.DarkGray;
            btnAppointment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAppointment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAppointment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAppointment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAppointment.ForeColor = Color.White;
            btnAppointment.Location = new Point(756, 486);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAppointment.Size = new Size(109, 37);
            btnAppointment.TabIndex = 2;
            btnAppointment.Text = "Appointment";
            btnAppointment.Click += btnAppointment_Click;
            // 
            // dgvAppointmentList
            // 
            dgvAppointmentList.AllowUserToAddRows = false;
            dgvAppointmentList.AllowUserToDeleteRows = false;
            dgvAppointmentList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dgvAppointmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAppointmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAppointmentList.ColumnHeadersHeight = 30;
            dgvAppointmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAppointmentList.ContextMenuStrip = cmsAppointments;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAppointmentList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAppointmentList.Dock = DockStyle.Bottom;
            dgvAppointmentList.GridColor = Color.FromArgb(187, 220, 242);
            dgvAppointmentList.Location = new Point(0, 532);
            dgvAppointmentList.Name = "dgvAppointmentList";
            dgvAppointmentList.ReadOnly = true;
            dgvAppointmentList.RowHeadersVisible = false;
            dgvAppointmentList.Size = new Size(981, 137);
            dgvAppointmentList.TabIndex = 3;
            dgvAppointmentList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            dgvAppointmentList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            dgvAppointmentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAppointmentList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAppointmentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAppointmentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAppointmentList.ThemeStyle.BackColor = Color.White;
            dgvAppointmentList.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            dgvAppointmentList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvAppointmentList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAppointmentList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAppointmentList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAppointmentList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAppointmentList.ThemeStyle.HeaderStyle.Height = 30;
            dgvAppointmentList.ThemeStyle.ReadOnly = true;
            dgvAppointmentList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            dgvAppointmentList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointmentList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAppointmentList.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvAppointmentList.ThemeStyle.RowsStyle.Height = 25;
            dgvAppointmentList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dgvAppointmentList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvAppointmentList.SelectionChanged += dgvAppointmentList_SelectionChanged;
            // 
            // cmsAppointments
            // 
            cmsAppointments.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cmsAppointments.Items.AddRange(new ToolStripItem[] { tsmEdit, tsmTakeTest });
            cmsAppointments.Name = "cmsAppointments";
            cmsAppointments.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsAppointments.RenderStyle.BorderColor = Color.Gainsboro;
            cmsAppointments.RenderStyle.ColorTable = null;
            cmsAppointments.RenderStyle.RoundedEdges = true;
            cmsAppointments.RenderStyle.SelectionArrowColor = Color.White;
            cmsAppointments.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsAppointments.RenderStyle.SelectionForeColor = Color.White;
            cmsAppointments.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsAppointments.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsAppointments.Size = new Size(164, 64);
            // 
            // tsmEdit
            // 
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(163, 30);
            tsmEdit.Text = "Edit";
            tsmEdit.Click += tsmEdit_Click;
            // 
            // tsmTakeTest
            // 
            tsmTakeTest.Name = "tsmTakeTest";
            tsmTakeTest.Size = new Size(163, 30);
            tsmTakeTest.Text = "Take Test";
            tsmTakeTest.Click += tsmTakeTest_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2HtmlLabel2.Location = new Point(437, 490);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(72, 23);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Records#";
            // 
            // lbAppointmentListCount
            // 
            lbAppointmentListCount.BackColor = Color.Transparent;
            lbAppointmentListCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbAppointmentListCount.Location = new Point(518, 492);
            lbAppointmentListCount.Name = "lbAppointmentListCount";
            lbAppointmentListCount.Size = new Size(15, 19);
            lbAppointmentListCount.TabIndex = 5;
            lbAppointmentListCount.Text = "??";
            // 
            // lbTitle
            // 
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lbTitle.Location = new Point(148, 4);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(356, 42);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Vision Test Appointments";
            // 
            // pbTitle
            // 
            pbTitle.CustomizableEdges = customizableEdges3;
            pbTitle.Image = (Image)resources.GetObject("pbTitle.Image");
            pbTitle.ImageRotate = 0F;
            pbTitle.Location = new Point(642, 3);
            pbTitle.Name = "pbTitle";
            pbTitle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pbTitle.Size = new Size(113, 49);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 7;
            pbTitle.TabStop = false;
            // 
            // TestAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 669);
            Controls.Add(pbTitle);
            Controls.Add(lbTitle);
            Controls.Add(lbAppointmentListCount);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(dgvAppointmentList);
            Controls.Add(btnAppointment);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(showApplicationDetailuc1);
            Name = "TestAppointment";
            Text = "VisionTestAppointment";
            FormClosing += TestAppointment_FormClosing;
            Load += VisionTestAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentList).EndInit();
            cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ShowApplicationDetailUC showApplicationDetailuc1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAppointment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointmentList;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbAppointmentListCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbTitle;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsAppointments;
        private ToolStripMenuItem tsmEdit;
        private ToolStripMenuItem tsmTakeTest;
    }
}