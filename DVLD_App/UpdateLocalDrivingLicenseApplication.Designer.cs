namespace DVLD_App
{
    partial class UpdateLocalDrivingLicenseApplication
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHolder = new Guna.UI2.WinForms.Guna2Panel();
            cbLicenseClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            lbApplicationDate = new Label();
            lbApplicationFee = new Label();
            lbCreatedBy = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbApplicationID = new Label();
            label1 = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            panelHolder.SuspendLayout();
            SuspendLayout();
            // 
            // panelHolder
            // 
            panelHolder.Controls.Add(cbLicenseClasses);
            panelHolder.Controls.Add(lbApplicationDate);
            panelHolder.Controls.Add(lbApplicationFee);
            panelHolder.Controls.Add(lbCreatedBy);
            panelHolder.Controls.Add(label5);
            panelHolder.Controls.Add(label4);
            panelHolder.Controls.Add(label3);
            panelHolder.Controls.Add(label2);
            panelHolder.Controls.Add(lbApplicationID);
            panelHolder.Controls.Add(label1);
            panelHolder.CustomizableEdges = customizableEdges3;
            panelHolder.Location = new Point(6, 4);
            panelHolder.Name = "panelHolder";
            panelHolder.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelHolder.Size = new Size(616, 470);
            panelHolder.TabIndex = 1;
            // 
            // cbLicenseClasses
            // 
            cbLicenseClasses.BackColor = Color.Transparent;
            cbLicenseClasses.CustomizableEdges = customizableEdges1;
            cbLicenseClasses.DrawMode = DrawMode.OwnerDrawFixed;
            cbLicenseClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClasses.FocusedColor = Color.FromArgb(94, 148, 255);
            cbLicenseClasses.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbLicenseClasses.Font = new Font("Segoe UI", 10F);
            cbLicenseClasses.ForeColor = Color.FromArgb(68, 88, 112);
            cbLicenseClasses.ItemHeight = 30;
            cbLicenseClasses.Location = new Point(200, 146);
            cbLicenseClasses.Name = "cbLicenseClasses";
            cbLicenseClasses.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbLicenseClasses.Size = new Size(232, 36);
            cbLicenseClasses.TabIndex = 9;
            cbLicenseClasses.SelectedIndexChanged += cbLicenseClasses_SelectedIndexChanged;
            // 
            // lbApplicationDate
            // 
            lbApplicationDate.AutoSize = true;
            lbApplicationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbApplicationDate.Location = new Point(194, 84);
            lbApplicationDate.Name = "lbApplicationDate";
            lbApplicationDate.Size = new Size(24, 21);
            lbApplicationDate.TabIndex = 8;
            lbApplicationDate.Text = "??";
            // 
            // lbApplicationFee
            // 
            lbApplicationFee.AutoSize = true;
            lbApplicationFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbApplicationFee.Location = new Point(194, 216);
            lbApplicationFee.Name = "lbApplicationFee";
            lbApplicationFee.Size = new Size(24, 21);
            lbApplicationFee.TabIndex = 7;
            lbApplicationFee.Text = "??";
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbCreatedBy.Location = new Point(194, 276);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(24, 21);
            lbCreatedBy.TabIndex = 6;
            lbCreatedBy.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(54, 151);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 5;
            label5.Text = "License Class:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(29, 212);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 4;
            label4.Text = "Application Fee:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(70, 272);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 3;
            label3.Text = "Created By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 2;
            label2.Text = "Application Date:";
            // 
            // lbApplicationID
            // 
            lbApplicationID.AutoSize = true;
            lbApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbApplicationID.Location = new Point(194, 24);
            lbApplicationID.Name = "lbApplicationID";
            lbApplicationID.Size = new Size(24, 21);
            lbApplicationID.TabIndex = 1;
            lbApplicationID.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Application ID:";
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(379, 494);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(105, 38);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges7;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Tomato;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(508, 494);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnClose.Size = new Size(105, 38);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // UpdateLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 541);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(panelHolder);
            Name = "UpdateLocalDrivingLicenseApplication";
            Text = "UpdateLocalDrivingLicenseApplication";
            FormClosing += UpdateLocalDrivingLicenseApplication_FormClosing;
            Load += UpdateLocalDrivingLicenseApplication_Load;
            panelHolder.ResumeLayout(false);
            panelHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHolder;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClasses;
        private Label lbApplicationDate;
        private Label lbApplicationFee;
        private Label lbCreatedBy;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbApplicationID;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}