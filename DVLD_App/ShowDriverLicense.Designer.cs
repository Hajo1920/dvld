namespace DVLD_App
{
    partial class ShowDriverLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDriverLicense));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            driverLicenseInfouc2 = new DriverLicenseInfoUC();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(83, 27);
            label1.Name = "label1";
            label1.Size = new Size(498, 51);
            label1.TabIndex = 1;
            label1.Text = "Driver License Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(723, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            btnClose.Location = new Point(812, 475);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(109, 33);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // driverLicenseInfouc2
            // 
            driverLicenseInfouc2.BorderStyle = BorderStyle.FixedSingle;
            driverLicenseInfouc2.Location = new Point(38, 127);
            driverLicenseInfouc2.Name = "driverLicenseInfouc2";
            driverLicenseInfouc2.Size = new Size(955, 332);
            driverLicenseInfouc2.TabIndex = 22;
            // 
            // ShowDriverLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 524);
            Controls.Add(driverLicenseInfouc2);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ShowDriverLicense";
            Text = "ShowDriverLicense";
            Load += ShowDriverLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private DriverLicenseInfoUC driverLicenseInfouc2;
    }
}