namespace DVLD_App
{
    partial class IssueDrivingLicense
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
            showApplicationDetailuc1 = new ShowApplicationDetailUC();
            label1 = new Label();
            tbNote = new Guna.UI2.WinForms.Guna2TextBox();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnIssue = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // showApplicationDetailuc1
            // 
            showApplicationDetailuc1.Location = new Point(3, 6);
            showApplicationDetailuc1.Name = "showApplicationDetailuc1";
            showApplicationDetailuc1.Size = new Size(972, 433);
            showApplicationDetailuc1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(28, 448);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "Note:";
            // 
            // tbNote
            // 
            tbNote.CustomizableEdges = customizableEdges1;
            tbNote.DefaultText = "";
            tbNote.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbNote.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbNote.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbNote.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbNote.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbNote.Font = new Font("Segoe UI", 9F);
            tbNote.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbNote.Location = new Point(90, 453);
            tbNote.Name = "tbNote";
            tbNote.PasswordChar = '\0';
            tbNote.PlaceholderText = "";
            tbNote.SelectedText = "";
            tbNote.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbNote.Size = new Size(556, 114);
            tbNote.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Tomato;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(698, 541);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(109, 33);
            btnClose.TabIndex = 22;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // btnIssue
            // 
            btnIssue.CustomizableEdges = customizableEdges5;
            btnIssue.DisabledState.BorderColor = Color.DarkGray;
            btnIssue.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIssue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIssue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIssue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIssue.ForeColor = Color.White;
            btnIssue.Location = new Point(848, 541);
            btnIssue.Name = "btnIssue";
            btnIssue.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnIssue.Size = new Size(109, 33);
            btnIssue.TabIndex = 21;
            btnIssue.Text = "Issue";
            btnIssue.Click += btnIssue_Click;
            // 
            // IssueDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 587);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(tbNote);
            Controls.Add(label1);
            Controls.Add(showApplicationDetailuc1);
            Name = "IssueDrivingLicense";
            Text = "IssueDrivingLicense";
            FormClosing += IssueDrivingLicense_FormClosing;
            Load += IssueDrivingLicense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ShowApplicationDetailUC showApplicationDetailuc1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbNote;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
    }
}