namespace DVLD_App
{
    partial class AddUpdateNewPerson
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
            lbTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            addNewPersonuc1 = new AddNewPersonUC();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbTitle.Location = new Point(399, 21);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(315, 47);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Register New Person";
            // 
            // addNewPersonuc1
            // 
            addNewPersonuc1.Address = null;
            addNewPersonuc1.BirthDate = new DateTime(0L);
            addNewPersonuc1.CountryId = 0;
            addNewPersonuc1.Email = null;
            addNewPersonuc1.FirstName = null;
            addNewPersonuc1.Gendor = 0;
            addNewPersonuc1.ID = 0;
            addNewPersonuc1.ImgPath = null;
            addNewPersonuc1.LastName = null;
            addNewPersonuc1.Location = new Point(10, 77);
            addNewPersonuc1.NaitonalID = null;
            addNewPersonuc1.Name = "addNewPersonuc1";
            addNewPersonuc1.Phone = null;
            addNewPersonuc1.SecondName = null;
            addNewPersonuc1.Size = new Size(1115, 575);
            addNewPersonuc1.TabIndex = 1;
            addNewPersonuc1.ThirdName = null;
         
            // 
            // AddUpdateNewPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 657);
            Controls.Add(addNewPersonuc1);
            Controls.Add(lbTitle);
            Name = "AddUpdateNewPerson";
            Text = "AddNewPerson";
            FormClosing += AddNewPerson_FormClosing;
            Load += AddNewPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbTitle;
        private AddNewPersonUC addNewPersonuc1;
    }
}