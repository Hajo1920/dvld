namespace DVLD_App
{
    partial class CurrentUserInformationUC
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
            personInfouc1 = new PersonInfoUC();
            currentUserInfouc1 = new ShortUserInfoUC();
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
            personInfouc1.Location = new Point(39, 27);
            personInfouc1.NaitonalID = null;
            personInfouc1.Name = "personInfouc1";
            personInfouc1.Phone = null;
            personInfouc1.SecondName = null;
            personInfouc1.Size = new Size(1049, 377);
            personInfouc1.TabIndex = 0;
            personInfouc1.ThirdName = null;
            // 
            // currentUserInfouc1
            // 
            currentUserInfouc1.BorderStyle = BorderStyle.FixedSingle;
            currentUserInfouc1.Location = new Point(39, 434);
            currentUserInfouc1.Name = "currentUserInfouc1";
            currentUserInfouc1.Size = new Size(1049, 89);
            currentUserInfouc1.TabIndex = 1;
            // 
            // CurrentUserInformationUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(currentUserInfouc1);
            Controls.Add(personInfouc1);
            Name = "CurrentUserInformationUC";
            Size = new Size(1124, 575);
            Load += CurrentUserInformationUC_Load;
            ResumeLayout(false);
        }

        #endregion

        private PersonInfoUC personInfouc1;
        private ShortUserInfoUC currentUserInfouc1;
    }
}
