namespace DVLD_App
{
    partial class ShowPersonDetail
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
            personInfouc1 = new PersonInfoUC();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // personInfouc1
            // 
            personInfouc1.Address = null;
            personInfouc1.BirthDate = new DateTime(0L);
            personInfouc1.Email = null;
            personInfouc1.FirstName = null;
            personInfouc1.Gendor = null;
            personInfouc1.ID = 0;
            personInfouc1.ImagePath = null;
            personInfouc1.LastName = null;
            personInfouc1.Location = new Point(14, 16);
            personInfouc1.Margin = new Padding(3, 5, 3, 5);
            personInfouc1.NaitonalID = null;
            personInfouc1.Name = "personInfouc1";
            personInfouc1.Phone = null;
            personInfouc1.SecondName = null;
            personInfouc1.Size = new Size(1080, 496);
            personInfouc1.TabIndex = 0;
            personInfouc1.ThirdName = null;
            personInfouc1.Load += personInfouc1_Load;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Tomato;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(871, 520);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(139, 60);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // ShowPersonDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 591);
            Controls.Add(btnClose);
            Controls.Add(personInfouc1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowPersonDetail";
            Text = "ShowPersonDetail";
            Load += ShowPersonDetail_Load;
            ResumeLayout(false);
        }

        #endregion

        private PersonInfoUC personInfouc1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}