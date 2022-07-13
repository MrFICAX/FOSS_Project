
namespace FOSSDesktopApp.Forms
{
    partial class AddOrganizerWindow
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbxAddAdministrator = new System.Windows.Forms.GroupBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnAddNewOrganizer = new System.Windows.Forms.Button();
            this.lblEnterKey = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxInputPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbxSurname = new System.Windows.Forms.MaskedTextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInputConfirmPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInputUsername = new System.Windows.Forms.TextBox();
            this.gbxAddAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(131, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(949, 56);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "DODAVANJE NOVOG ORGANIZATORA";
            // 
            // gbxAddAdministrator
            // 
            this.gbxAddAdministrator.Controls.Add(this.label2);
            this.gbxAddAdministrator.Controls.Add(this.tbxInputUsername);
            this.gbxAddAdministrator.Controls.Add(this.label1);
            this.gbxAddAdministrator.Controls.Add(this.tbxInputConfirmPassword);
            this.gbxAddAdministrator.Controls.Add(this.lblIme);
            this.gbxAddAdministrator.Controls.Add(this.btnAddNewOrganizer);
            this.gbxAddAdministrator.Controls.Add(this.lblEnterKey);
            this.gbxAddAdministrator.Controls.Add(this.tbxName);
            this.gbxAddAdministrator.Controls.Add(this.tbxInputPassword);
            this.gbxAddAdministrator.Controls.Add(this.tbxSurname);
            this.gbxAddAdministrator.Controls.Add(this.lblPrezime);
            this.gbxAddAdministrator.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddAdministrator.Location = new System.Drawing.Point(141, 127);
            this.gbxAddAdministrator.Name = "gbxAddAdministrator";
            this.gbxAddAdministrator.Size = new System.Drawing.Size(944, 520);
            this.gbxAddAdministrator.TabIndex = 10;
            this.gbxAddAdministrator.TabStop = false;
            this.gbxAddAdministrator.Text = "Dodajte novog organizatora";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(180, 38);
            this.lblIme.MaximumSize = new System.Drawing.Size(1000, 300);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(148, 24);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Unesite ime:";
            // 
            // btnAddNewOrganizer
            // 
            this.btnAddNewOrganizer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewOrganizer.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewOrganizer.Location = new System.Drawing.Point(359, 408);
            this.btnAddNewOrganizer.MaximumSize = new System.Drawing.Size(1000, 300);
            this.btnAddNewOrganizer.Name = "btnAddNewOrganizer";
            this.btnAddNewOrganizer.Size = new System.Drawing.Size(415, 68);
            this.btnAddNewOrganizer.TabIndex = 7;
            this.btnAddNewOrganizer.Text = "DODAJ ORGANIZATORA";
            this.btnAddNewOrganizer.UseVisualStyleBackColor = false;
            this.btnAddNewOrganizer.Click += new System.EventHandler(this.btnAddNewOrganizer_Click);
            // 
            // lblEnterKey
            // 
            this.lblEnterKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterKey.AutoSize = true;
            this.lblEnterKey.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterKey.Location = new System.Drawing.Point(122, 261);
            this.lblEnterKey.MaximumSize = new System.Drawing.Size(1000, 300);
            this.lblEnterKey.Name = "lblEnterKey";
            this.lblEnterKey.Size = new System.Drawing.Size(206, 24);
            this.lblEnterKey.TabIndex = 6;
            this.lblEnterKey.Text = "Unesite password:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(348, 38);
            this.tbxName.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(415, 32);
            this.tbxName.TabIndex = 0;
            // 
            // tbxInputPassword
            // 
            this.tbxInputPassword.Location = new System.Drawing.Point(348, 258);
            this.tbxInputPassword.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxInputPassword.Name = "tbxInputPassword";
            this.tbxInputPassword.Size = new System.Drawing.Size(415, 32);
            this.tbxInputPassword.TabIndex = 5;
            this.tbxInputPassword.UseSystemPasswordChar = true;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(348, 78);
            this.tbxSurname.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(415, 32);
            this.tbxSurname.TabIndex = 1;
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(134, 78);
            this.lblPrezime.MaximumSize = new System.Drawing.Size(1000, 300);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(195, 24);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Unesite prezime:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 319);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Potvrdite password:";
            // 
            // tbxInputConfirmPassword
            // 
            this.tbxInputConfirmPassword.Location = new System.Drawing.Point(348, 316);
            this.tbxInputConfirmPassword.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxInputConfirmPassword.Name = "tbxInputConfirmPassword";
            this.tbxInputConfirmPassword.Size = new System.Drawing.Size(415, 32);
            this.tbxInputConfirmPassword.TabIndex = 8;
            this.tbxInputConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 204);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unesite username:";
            // 
            // tbxInputUsername
            // 
            this.tbxInputUsername.Location = new System.Drawing.Point(348, 204);
            this.tbxInputUsername.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxInputUsername.Name = "tbxInputUsername";
            this.tbxInputUsername.Size = new System.Drawing.Size(415, 32);
            this.tbxInputUsername.TabIndex = 10;
            // 
            // AddOrganizerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1222, 730);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gbxAddAdministrator);
            this.Name = "AddOrganizerWindow";
            this.Text = "AddOrganizerWindow";
            this.gbxAddAdministrator.ResumeLayout(false);
            this.gbxAddAdministrator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbxAddAdministrator;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnAddNewOrganizer;
        private System.Windows.Forms.Label lblEnterKey;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.MaskedTextBox tbxInputPassword;
        private System.Windows.Forms.MaskedTextBox tbxSurname;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInputUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxInputConfirmPassword;
    }
}