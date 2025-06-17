namespace DVLD_App
{
    partial class ShortUserInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbUserId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbIsActive = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(123, 33);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(71, 30);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "UserID:";
            // 
            // lbUserId
            // 
            lbUserId.BackColor = Color.Transparent;
            lbUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbUserId.Location = new Point(215, 36);
            lbUserId.Name = "lbUserId";
            lbUserId.Size = new Size(10, 23);
            lbUserId.TabIndex = 1;
            lbUserId.Text = "?";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            guna2HtmlLabel2.Location = new Point(668, 33);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(89, 30);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Is Active:";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            guna2HtmlLabel3.Location = new Point(332, 33);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(106, 30);
            guna2HtmlLabel3.TabIndex = 3;
            guna2HtmlLabel3.Text = "UserName:";
            // 
            // lbUserName
            // 
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbUserName.Location = new Point(463, 36);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(10, 23);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "?";
            // 
            // lbIsActive
            // 
            lbIsActive.BackColor = Color.Transparent;
            lbIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbIsActive.Location = new Point(784, 37);
            lbIsActive.Name = "lbIsActive";
            lbIsActive.Size = new Size(10, 23);
            lbIsActive.TabIndex = 5;
            lbIsActive.Text = "?";
            // 
            // ShortUserInfoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbIsActive);
            Controls.Add(lbUserName);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(lbUserId);
            Controls.Add(guna2HtmlLabel1);
            Name = "ShortUserInfoUC";
            Size = new Size(888, 89);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUserId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbIsActive;
    }
}
