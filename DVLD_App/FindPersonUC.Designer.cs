namespace DVLD_App
{
    partial class FindPersonUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            comboFind = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            boxFind = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // comboFind
            // 
            comboFind.BackColor = Color.Transparent;
            comboFind.CustomizableEdges = customizableEdges1;
            comboFind.DrawMode = DrawMode.OwnerDrawFixed;
            comboFind.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFind.FocusedColor = Color.FromArgb(94, 148, 255);
            comboFind.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboFind.Font = new Font("Segoe UI", 10F);
            comboFind.ForeColor = Color.FromArgb(68, 88, 112);
            comboFind.ItemHeight = 30;
            comboFind.Location = new Point(72, 20);
            comboFind.Name = "comboFind";
            comboFind.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboFind.Size = new Size(195, 36);
            comboFind.TabIndex = 0;
            comboFind.SelectedIndexChanged += comboFind_SelectedIndexChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(9, 28);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(53, 19);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Find By:";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // boxFind
            // 
            boxFind.CustomizableEdges = customizableEdges3;
            boxFind.DefaultText = "";
            boxFind.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            boxFind.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            boxFind.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            boxFind.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            boxFind.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            boxFind.Font = new Font("Segoe UI", 9F);
            boxFind.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            boxFind.Location = new Point(283, 20);
            boxFind.Margin = new Padding(3, 4, 3, 4);
            boxFind.Name = "boxFind";
            boxFind.PasswordChar = '\0';
            boxFind.PlaceholderText = "Type here..";
            boxFind.SelectedText = "";
            boxFind.ShadowDecoration.CustomizableEdges = customizableEdges4;
            boxFind.Size = new Size(213, 36);
            boxFind.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.CustomizableEdges = customizableEdges5;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(705, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearch.Size = new Size(105, 45);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.CustomizableEdges = customizableEdges7;
            btnAddNewPerson.DisabledState.BorderColor = Color.DarkGray;
            btnAddNewPerson.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNewPerson.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNewPerson.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNewPerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddNewPerson.ForeColor = Color.White;
            btnAddNewPerson.Location = new Point(827, 20);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddNewPerson.Size = new Size(119, 45);
            btnAddNewPerson.TabIndex = 4;
            btnAddNewPerson.Text = "Add New Person";
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // FindPersonUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddNewPerson);
            Controls.Add(btnSearch);
            Controls.Add(boxFind);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(comboFind);
            Name = "FindPersonUC";
            Size = new Size(976, 86);
            Load += FindPersonUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboFind;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox boxFind;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
    }
}
