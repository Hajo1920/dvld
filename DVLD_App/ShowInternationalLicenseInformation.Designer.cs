namespace DVLD_App
{
    partial class ShowInternationalLicenseInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInternationalLicenseInformation));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            driverInternationalLicenseInfouc1 = new DriverInternationalLicenseInfoUC();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(280, 142);
            label1.Name = "label1";
            label1.Size = new Size(619, 51);
            label1.TabIndex = 0;
            label1.Text = "International License Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(528, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // driverInternationalLicenseInfouc1
            // 
            driverInternationalLicenseInfouc1.BorderStyle = BorderStyle.FixedSingle;
            driverInternationalLicenseInfouc1.Location = new Point(124, 196);
            driverInternationalLicenseInfouc1.Name = "driverInternationalLicenseInfouc1";
            driverInternationalLicenseInfouc1.Size = new Size(904, 332);
            driverInternationalLicenseInfouc1.TabIndex = 2;
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
            btnClose.Location = new Point(877, 553);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(109, 33);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // ShowInternationalLicenseInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 598);
            Controls.Add(btnClose);
            Controls.Add(driverInternationalLicenseInfouc1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ShowInternationalLicenseInformation";
            Text = "ShowInternationalLicenseInformation";
            Load += ShowInternationalLicenseInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DriverInternationalLicenseInfoUC driverInternationalLicenseInfouc1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}