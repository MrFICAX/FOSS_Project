
namespace FOSSDesktopApp.Forms
{
    partial class AdministratorWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTeamOverview = new System.Windows.Forms.Button();
            this.btnManageMatches = new System.Windows.Forms.Button();
            this.btnCompetitionOverview = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDateOfLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxSelectCompetition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.lblDateOfSelectedCompetition = new System.Windows.Forms.Label();
            this.lblLocationOfSelectedCompetition = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNameOfSelectedCompetition = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblnameCompetition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinnerOfCompetition = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnTeamOverview);
            this.panel1.Controls.Add(this.btnManageMatches);
            this.panel1.Controls.Add(this.btnCompetitionOverview);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 1061);
            this.panel1.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 962);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(347, 99);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "IZLOGUJ SE";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTeamOverview
            // 
            this.btnTeamOverview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTeamOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeamOverview.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamOverview.Location = new System.Drawing.Point(0, 508);
            this.btnTeamOverview.Name = "btnTeamOverview";
            this.btnTeamOverview.Size = new System.Drawing.Size(347, 99);
            this.btnTeamOverview.TabIndex = 13;
            this.btnTeamOverview.Text = "PREGLED TIMOVA";
            this.btnTeamOverview.UseVisualStyleBackColor = false;
            this.btnTeamOverview.Click += new System.EventHandler(this.btnTeamOverview_Click);
            // 
            // btnManageMatches
            // 
            this.btnManageMatches.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnManageMatches.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMatches.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMatches.Location = new System.Drawing.Point(0, 409);
            this.btnManageMatches.Name = "btnManageMatches";
            this.btnManageMatches.Size = new System.Drawing.Size(347, 99);
            this.btnManageMatches.TabIndex = 12;
            this.btnManageMatches.Text = "UPRAVLJANJE MEČEVIMA";
            this.btnManageMatches.UseVisualStyleBackColor = false;
            this.btnManageMatches.Click += new System.EventHandler(this.btnManageMatches_Click);
            // 
            // btnCompetitionOverview
            // 
            this.btnCompetitionOverview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompetitionOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetitionOverview.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitionOverview.Location = new System.Drawing.Point(0, 310);
            this.btnCompetitionOverview.Name = "btnCompetitionOverview";
            this.btnCompetitionOverview.Size = new System.Drawing.Size(347, 99);
            this.btnCompetitionOverview.TabIndex = 11;
            this.btnCompetitionOverview.Text = "PREGLED TAKMIČENJA";
            this.btnCompetitionOverview.UseVisualStyleBackColor = false;
            this.btnCompetitionOverview.Click += new System.EventHandler(this.btnCompetitionOverview_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblDateOfLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 160);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum logovanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vaš username:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(25, 46);
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
            this.lblDateOfLogin.Location = new System.Drawing.Point(26, 111);
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
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 150);
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
            this.cbxSelectCompetition.Location = new System.Drawing.Point(414, 55);
            this.cbxSelectCompetition.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.cbxSelectCompetition.Name = "cbxSelectCompetition";
            this.cbxSelectCompetition.Size = new System.Drawing.Size(302, 30);
            this.cbxSelectCompetition.Sorted = true;
            this.cbxSelectCompetition.TabIndex = 3;
            this.cbxSelectCompetition.SelectedIndexChanged += new System.EventHandler(this.cbxSelectCompetition_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "IZABERITE TAKMIČENJE:";
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdministrator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAdministrator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlAdministrator.Location = new System.Drawing.Point(346, 150);
            this.pnlAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(1365, 911);
            this.pnlAdministrator.TabIndex = 3;
            // 
            // lblDateOfSelectedCompetition
            // 
            this.lblDateOfSelectedCompetition.AutoSize = true;
            this.lblDateOfSelectedCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfSelectedCompetition.Location = new System.Drawing.Point(1095, 86);
            this.lblDateOfSelectedCompetition.Name = "lblDateOfSelectedCompetition";
            this.lblDateOfSelectedCompetition.Size = new System.Drawing.Size(253, 32);
            this.lblDateOfSelectedCompetition.TabIndex = 15;
            this.lblDateOfSelectedCompetition.Text = "_________________";
            // 
            // lblLocationOfSelectedCompetition
            // 
            this.lblLocationOfSelectedCompetition.AutoSize = true;
            this.lblLocationOfSelectedCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationOfSelectedCompetition.Location = new System.Drawing.Point(1095, 55);
            this.lblLocationOfSelectedCompetition.Name = "lblLocationOfSelectedCompetition";
            this.lblLocationOfSelectedCompetition.Size = new System.Drawing.Size(253, 32);
            this.lblLocationOfSelectedCompetition.TabIndex = 14;
            this.lblLocationOfSelectedCompetition.Text = "_________________";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(942, 86);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(118, 32);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum:";
            // 
            // lblNameOfSelectedCompetition
            // 
            this.lblNameOfSelectedCompetition.AutoSize = true;
            this.lblNameOfSelectedCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfSelectedCompetition.Location = new System.Drawing.Point(1095, 19);
            this.lblNameOfSelectedCompetition.Name = "lblNameOfSelectedCompetition";
            this.lblNameOfSelectedCompetition.Size = new System.Drawing.Size(253, 32);
            this.lblNameOfSelectedCompetition.TabIndex = 12;
            this.lblNameOfSelectedCompetition.Text = "_________________";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(917, 55);
            this.lblLokacija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(143, 32);
            this.lblLokacija.TabIndex = 11;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // lblnameCompetition
            // 
            this.lblnameCompetition.AutoSize = true;
            this.lblnameCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameCompetition.Location = new System.Drawing.Point(815, 17);
            this.lblnameCompetition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnameCompetition.Name = "lblnameCompetition";
            this.lblnameCompetition.Size = new System.Drawing.Size(245, 32);
            this.lblnameCompetition.TabIndex = 10;
            this.lblnameCompetition.Text = "Ime takmičenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1451, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pobednik takmičenja:";
            // 
            // lblWinnerOfCompetition
            // 
            this.lblWinnerOfCompetition.AutoSize = true;
            this.lblWinnerOfCompetition.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerOfCompetition.Location = new System.Drawing.Point(1449, 55);
            this.lblWinnerOfCompetition.Name = "lblWinnerOfCompetition";
            this.lblWinnerOfCompetition.Size = new System.Drawing.Size(323, 32);
            this.lblWinnerOfCompetition.TabIndex = 17;
            this.lblWinnerOfCompetition.Text = "______________________";
            // 
            // AdministratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1710, 1061);
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
            this.Controls.Add(this.pnlAdministrator);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorWindow";
            this.Text = "AdministratorWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxSelectCompetition;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDateOfLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAdministrator;
        private System.Windows.Forms.Label lblDateOfSelectedCompetition;
        private System.Windows.Forms.Label lblLocationOfSelectedCompetition;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblNameOfSelectedCompetition;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblnameCompetition;
        private System.Windows.Forms.Button btnCompetitionOverview;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTeamOverview;
        private System.Windows.Forms.Button btnManageMatches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinnerOfCompetition;
    }
}