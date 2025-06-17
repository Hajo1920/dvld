namespace DVLD_App
{
    partial class ShowApplicationDetails
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
            showApplicationDetailuc1 = new ShowApplicationDetailUC();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // showApplicationDetailuc1
            // 
            showApplicationDetailuc1.Location = new Point(3, 3);
            showApplicationDetailuc1.Name = "showApplicationDetailuc1";
            showApplicationDetailuc1.Size = new Size(1024, 444);
            showApplicationDetailuc1.TabIndex = 0;
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
            btnClose.Location = new Point(741, 468);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(135, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // ShowApplicationDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 527);
            Controls.Add(btnClose);
            Controls.Add(showApplicationDetailuc1);
            Name = "ShowApplicationDetails";
            Text = "ShowApplicationDetails";
            Load += ShowApplicationDetails_Load;
            ResumeLayout(false);
        }

        #endregion

        private ShowApplicationDetailUC showApplicationDetailuc1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}