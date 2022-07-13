
namespace FOSSDesktopApp.Forms
{
    partial class OrganizerWindow
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddReferee = new System.Windows.Forms.Button();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddAdministrator = new System.Windows.Forms.Button();
            this.btnAddNewCompetition = new System.Windows.Forms.Button();
            this.btnControlDraw = new System.Windows.Forms.Button();
            this.btnOverviewCompetition = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDateOfLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxSelectCompetition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnameCompetition = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblNameOfSelectedCompetition = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblLocationOfSelectedCompetition = new System.Windows.Forms.Label();
            this.lblDateOfSelectedCompetition = new System.Windows.Forms.Label();
            this.lblWinnerOfCompetition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddReferee);
            this.panel3.Controls.Add(this.btnAddClub);
            this.panel3.Controls.Add(this.btnLogOut);
            this.panel3.Controls.Add(this.btnAddAdministrator);
            this.panel3.Controls.Add(this.btnAddNewCompetition);
            this.panel3.Controls.Add(this.btnControlDraw);
            this.panel3.Controls.Add(this.btnOverviewCompetition);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 1030);
            this.panel3.TabIndex = 1;
            // 
            // btnAddReferee
            // 
            this.btnAddReferee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddReferee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddReferee.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReferee.Location = new System.Drawing.Point(0, 803);
            this.btnAddReferee.Name = "btnAddReferee";
            this.btnAddReferee.Size = new System.Drawing.Size(346, 99);
            this.btnAddReferee.TabIndex = 14;
            this.btnAddReferee.Text = "Dodaj sudiju";
            this.btnAddReferee.UseVisualStyleBackColor = false;
            this.btnAddReferee.Click += new System.EventHandler(this.btnAddReferee_Click);
            // 
            // btnAddClub
            // 
            this.btnAddClub.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddClub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClub.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClub.Location = new System.Drawing.Point(0, 704);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(346, 99);
            this.btnAddClub.TabIndex = 13;
            this.btnAddClub.Text = "Dodaj klub";
            this.btnAddClub.UseVisualStyleBackColor = false;
            this.btnAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 951);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(346, 79);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "IZLOGUJ SE";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddAdministrator
            // 
            this.btnAddAdministrator.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddAdministrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAdministrator.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdministrator.Location = new System.Drawing.Point(0, 605);
            this.btnAddAdministrator.Name = "btnAddAdministrator";
            this.btnAddAdministrator.Size = new System.Drawing.Size(346, 99);
            this.btnAddAdministrator.TabIndex = 11;
            this.btnAddAdministrator.Text = "Dodaj administratora";
            this.btnAddAdministrator.UseVisualStyleBackColor = false;
            this.btnAddAdministrator.Click += new System.EventHandler(this.btnAddAdministrator_Click);
            // 
            // btnAddNewCompetition
            // 
            this.btnAddNewCompetition.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNewCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewCompetition.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCompetition.Location = new System.Drawing.Point(0, 506);
            this.btnAddNewCompetition.Name = "btnAddNewCompetition";
            this.btnAddNewCompetition.Size = new System.Drawing.Size(346, 99);
            this.btnAddNewCompetition.TabIndex = 10;
            this.btnAddNewCompetition.Text = "Dodaj takmicenje";
            this.btnAddNewCompetition.UseVisualStyleBackColor = false;
            this.btnAddNewCompetition.Click += new System.EventHandler(this.btnAddNewCompetition_Click);
            // 
            // btnControlDraw
            // 
            this.btnControlDraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnControlDraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlDraw.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlDraw.Location = new System.Drawing.Point(0, 407);
            this.btnControlDraw.Name = "btnControlDraw";
            this.btnControlDraw.Size = new System.Drawing.Size(346, 99);
            this.btnControlDraw.TabIndex = 15;
            this.btnControlDraw.Text = "Upravljanje žrebom";
            this.btnControlDraw.UseVisualStyleBackColor = false;
            this.btnControlDraw.Click += new System.EventHandler(this.btnControlDraw_Click);
            // 
            // btnOverviewCompetition
            // 
            this.btnOverviewCompetition.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOverviewCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverviewCompetition.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverviewCompetition.ForeColor = System.Drawing.Color.Black;
            this.btnOverviewCompetition.Location = new System.Drawing.Point(0, 308);
            this.btnOverviewCompetition.Name = "btnOverviewCompetition";
            this.btnOverviewCompetition.Size = new System.Drawing.Size(346, 99);
            this.btnOverviewCompetition.TabIndex = 5;
            this.btnOverviewCompetition.Text = "Pregled takmičenja";
            this.btnOverviewCompetition.UseVisualStyleBackColor = false;
            this.btnOverviewCompetition.Click += new System.EventHandler(this.btnOverviewCompetition_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblDateOfLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 161);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum logovanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vaš username:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(20, 49);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(238, 24);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "CUSTOM USERNAME";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateOfLogin
            // 
            this.lblDateOfLogin.AutoSize = true;
            this.lblDateOfLogin.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfLogin.Location = new System.Drawing.Point(20, 113);
            this.lblDateOfLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfLogin.Name = "lblDateOfLogin";
            this.lblDateOfLogin.Size = new System.Drawing.Size(184, 24);
            this.lblDateOfLogin.TabIndex = 2;
            this.lblDateOfLogin.Text = "DATE OF LOGIN";
            this.lblDateOfLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FOSSDesktopApp.Properties.Resources.FossLogoPrimer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbxSelectCompetition
            // 
            this.cbxSelectCompetition.BackColor = System.Drawing.Color.Orange;
            this.cbxSelectCompetition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSelectCompetition.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectCompetition.FormattingEnabled = true;
            this.cbxSelectCompetition.Location = new System.Drawing.Point(408, 59);
            this.cbxSelectCompetition.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.cbxSelectCompetition.Name = "cbxSelectCompetition";
            this.cbxSelectCompetition.Size = new System.Drawing.Size(302, 30);
            this.cbxSelectCompetition.Sorted = true;
            this.cbxSelectCompetition.TabIndex = 3;
            this.cbxSelectCompetition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "IZABERITE TAKMIČENJE:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(345, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 883);
            this.panel1.TabIndex = 2;
            // 
            // lblnameCompetition
            // 
            this.lblnameCompetition.AutoSize = true;
            this.lblnameCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameCompetition.Location = new System.Drawing.Point(862, 14);
            this.lblnameCompetition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnameCompetition.Name = "lblnameCompetition";
            this.lblnameCompetition.Size = new System.Drawing.Size(245, 32);
            this.lblnameCompetition.TabIndex = 4;
            this.lblnameCompetition.Text = "Ime takmičenja:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(964, 50);
            this.lblLokacija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(143, 32);
            this.lblLokacija.TabIndex = 5;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // lblNameOfSelectedCompetition
            // 
            this.lblNameOfSelectedCompetition.AutoSize = true;
            this.lblNameOfSelectedCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfSelectedCompetition.Location = new System.Drawing.Point(1142, 14);
            this.lblNameOfSelectedCompetition.Name = "lblNameOfSelectedCompetition";
            this.lblNameOfSelectedCompetition.Size = new System.Drawing.Size(253, 32);
            this.lblNameOfSelectedCompetition.TabIndex = 6;
            this.lblNameOfSelectedCompetition.Text = "_________________";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(989, 81);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(118, 32);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum:";
            // 
            // lblLocationOfSelectedCompetition
            // 
            this.lblLocationOfSelectedCompetition.AutoSize = true;
            this.lblLocationOfSelectedCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationOfSelectedCompetition.Location = new System.Drawing.Point(1142, 50);
            this.lblLocationOfSelectedCompetition.Name = "lblLocationOfSelectedCompetition";
            this.lblLocationOfSelectedCompetition.Size = new System.Drawing.Size(253, 32);
            this.lblLocationOfSelectedCompetition.TabIndex = 8;
            this.lblLocationOfSelectedCompetition.Text = "_________________";
            // 
            // lblDateOfSelectedCompetition
            // 
            this.lblDateOfSelectedCompetition.AutoSize = true;
            this.lblDateOfSelectedCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfSelectedCompetition.Location = new System.Drawing.Point(1142, 81);
            this.lblDateOfSelectedCompetition.Name = "lblDateOfSelectedCompetition";
            this.lblDateOfSelectedCompetition.Size = new System.Drawing.Size(253, 32);
            this.lblDateOfSelectedCompetition.TabIndex = 9;
            this.lblDateOfSelectedCompetition.Text = "_________________";
            // 
            // lblWinnerOfCompetition
            // 
            this.lblWinnerOfCompetition.AutoSize = true;
            this.lblWinnerOfCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerOfCompetition.Location = new System.Drawing.Point(1529, 50);
            this.lblWinnerOfCompetition.Name = "lblWinnerOfCompetition";
            this.lblWinnerOfCompetition.Size = new System.Drawing.Size(323, 32);
            this.lblWinnerOfCompetition.TabIndex = 19;
            this.lblWinnerOfCompetition.Text = "______________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1531, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pobednik takmičenja:";
            // 
            // OrganizerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1893, 1030);
            this.Controls.Add(this.lblWinnerOfCompetition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDateOfSelectedCompetition);
            this.Controls.Add(this.lblLocationOfSelectedCompetition);
            this.Controls.Add(this.cbxSelectCompetition);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNameOfSelectedCompetition);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnameCompetition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(617, 410);
            this.Name = "OrganizerWindow";
            this.Text = "OrganizerWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDateOfLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxSelectCompetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblnameCompetition;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Button btnAddNewCompetition;
        private System.Windows.Forms.Button btnAddAdministrator;
        private System.Windows.Forms.Label lblNameOfSelectedCompetition;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblLocationOfSelectedCompetition;
        private System.Windows.Forms.Label lblDateOfSelectedCompetition;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOverviewCompetition;
        private System.Windows.Forms.Button btnAddReferee;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnControlDraw;
        private System.Windows.Forms.Label lblWinnerOfCompetition;
        private System.Windows.Forms.Label label4;
    }
}