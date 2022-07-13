
namespace FOSSDesktopApp.Forms
{
    partial class AddCompetitionWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCompetitionName = new System.Windows.Forms.Label();
            this.lblLocationOfCompetition = new System.Windows.Forms.Label();
            this.lblDateOfCompetition = new System.Windows.Forms.Label();
            this.gbxCompetitionInfo = new System.Windows.Forms.GroupBox();
            this.dtpCompetitionDate = new System.Windows.Forms.DateTimePicker();
            this.tbxCompetitionLocation = new System.Windows.Forms.TextBox();
            this.tbxCompetitionName = new System.Windows.Forms.TextBox();
            this.btnAddNewClub = new System.Windows.Forms.Button();
            this.dgwTeams = new System.Windows.Forms.DataGridView();
            this.lblListOfClubs = new System.Windows.Forms.Label();
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwAllTeams = new System.Windows.Forms.DataGridView();
            this.btnRemoveSelectedClub = new System.Windows.Forms.Button();
            this.gbxCompetitionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(467, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(878, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DODAVANJE NOVOG TAKMIČENJA";
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.AutoSize = true;
            this.lblCompetitionName.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitionName.Location = new System.Drawing.Point(14, 44);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(317, 28);
            this.lblCompetitionName.TabIndex = 1;
            this.lblCompetitionName.Text = "Unesite ime takmičenja:";
            // 
            // lblLocationOfCompetition
            // 
            this.lblLocationOfCompetition.AutoSize = true;
            this.lblLocationOfCompetition.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationOfCompetition.Location = new System.Drawing.Point(14, 79);
            this.lblLocationOfCompetition.Name = "lblLocationOfCompetition";
            this.lblLocationOfCompetition.Size = new System.Drawing.Size(370, 28);
            this.lblLocationOfCompetition.TabIndex = 2;
            this.lblLocationOfCompetition.Text = "Unesite lokaciju takmičenja:";
            // 
            // lblDateOfCompetition
            // 
            this.lblDateOfCompetition.AutoSize = true;
            this.lblDateOfCompetition.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfCompetition.Location = new System.Drawing.Point(14, 115);
            this.lblDateOfCompetition.Name = "lblDateOfCompetition";
            this.lblDateOfCompetition.Size = new System.Drawing.Size(350, 28);
            this.lblDateOfCompetition.TabIndex = 3;
            this.lblDateOfCompetition.Text = "Unesite datum takmičenja:";
            // 
            // gbxCompetitionInfo
            // 
            this.gbxCompetitionInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxCompetitionInfo.Controls.Add(this.dtpCompetitionDate);
            this.gbxCompetitionInfo.Controls.Add(this.tbxCompetitionLocation);
            this.gbxCompetitionInfo.Controls.Add(this.tbxCompetitionName);
            this.gbxCompetitionInfo.Controls.Add(this.lblLocationOfCompetition);
            this.gbxCompetitionInfo.Controls.Add(this.lblCompetitionName);
            this.gbxCompetitionInfo.Controls.Add(this.lblDateOfCompetition);
            this.gbxCompetitionInfo.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCompetitionInfo.Location = new System.Drawing.Point(555, 88);
            this.gbxCompetitionInfo.Name = "gbxCompetitionInfo";
            this.gbxCompetitionInfo.Size = new System.Drawing.Size(710, 166);
            this.gbxCompetitionInfo.TabIndex = 5;
            this.gbxCompetitionInfo.TabStop = false;
            this.gbxCompetitionInfo.Text = "Podaci o takmičenju";
            // 
            // dtpCompetitionDate
            // 
            this.dtpCompetitionDate.CalendarFont = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCompetitionDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpCompetitionDate.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCompetitionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCompetitionDate.Location = new System.Drawing.Point(402, 120);
            this.dtpCompetitionDate.Name = "dtpCompetitionDate";
            this.dtpCompetitionDate.Size = new System.Drawing.Size(268, 23);
            this.dtpCompetitionDate.TabIndex = 7;
            // 
            // tbxCompetitionLocation
            // 
            this.tbxCompetitionLocation.Location = new System.Drawing.Point(402, 79);
            this.tbxCompetitionLocation.Name = "tbxCompetitionLocation";
            this.tbxCompetitionLocation.Size = new System.Drawing.Size(268, 30);
            this.tbxCompetitionLocation.TabIndex = 6;
            // 
            // tbxCompetitionName
            // 
            this.tbxCompetitionName.Location = new System.Drawing.Point(402, 44);
            this.tbxCompetitionName.Name = "tbxCompetitionName";
            this.tbxCompetitionName.Size = new System.Drawing.Size(268, 30);
            this.tbxCompetitionName.TabIndex = 5;
            // 
            // btnAddNewClub
            // 
            this.btnAddNewClub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewClub.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewClub.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClub.Location = new System.Drawing.Point(1180, 586);
            this.btnAddNewClub.Name = "btnAddNewClub";
            this.btnAddNewClub.Size = new System.Drawing.Size(439, 95);
            this.btnAddNewClub.TabIndex = 6;
            this.btnAddNewClub.Text = "DODAJ SELEKTOVANI KLUB";
            this.btnAddNewClub.UseVisualStyleBackColor = false;
            this.btnAddNewClub.Click += new System.EventHandler(this.BtnAddNewClub_Click);
            // 
            // dgwTeams
            // 
            this.dgwTeams.AllowUserToAddRows = false;
            this.dgwTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeams.Location = new System.Drawing.Point(181, 332);
            this.dgwTeams.MultiSelect = false;
            this.dgwTeams.Name = "dgwTeams";
            this.dgwTeams.ReadOnly = true;
            this.dgwTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTeams.Size = new System.Drawing.Size(710, 235);
            this.dgwTeams.TabIndex = 7;
            this.dgwTeams.TabStop = false;
            // 
            // lblListOfClubs
            // 
            this.lblListOfClubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListOfClubs.AutoSize = true;
            this.lblListOfClubs.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfClubs.Location = new System.Drawing.Point(181, 291);
            this.lblListOfClubs.Name = "lblListOfClubs";
            this.lblListOfClubs.Size = new System.Drawing.Size(289, 28);
            this.lblListOfClubs.TabIndex = 8;
            this.lblListOfClubs.Text = "Lista dodatih klubova:";
            // 
            // btnAddCompetition
            // 
            this.btnAddCompetition.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCompetition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCompetition.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompetition.Location = new System.Drawing.Point(0, 768);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(1781, 53);
            this.btnAddCompetition.TabIndex = 9;
            this.btnAddCompetition.Text = "DODAJ TAKMIČENJE";
            this.btnAddCompetition.UseVisualStyleBackColor = false;
            this.btnAddCompetition.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista postojećih klubova:";
            // 
            // dgwAllTeams
            // 
            this.dgwAllTeams.AllowUserToAddRows = false;
            this.dgwAllTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwAllTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAllTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwAllTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAllTeams.Location = new System.Drawing.Point(909, 332);
            this.dgwAllTeams.MultiSelect = false;
            this.dgwAllTeams.Name = "dgwAllTeams";
            this.dgwAllTeams.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAllTeams.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAllTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAllTeams.Size = new System.Drawing.Size(710, 235);
            this.dgwAllTeams.TabIndex = 10;
            // 
            // btnRemoveSelectedClub
            // 
            this.btnRemoveSelectedClub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveSelectedClub.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoveSelectedClub.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedClub.Location = new System.Drawing.Point(181, 586);
            this.btnRemoveSelectedClub.Name = "btnRemoveSelectedClub";
            this.btnRemoveSelectedClub.Size = new System.Drawing.Size(439, 95);
            this.btnRemoveSelectedClub.TabIndex = 12;
            this.btnRemoveSelectedClub.Text = "IZBACI SELEKTOVANI KLUB";
            this.btnRemoveSelectedClub.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedClub.Click += new System.EventHandler(this.btnRemoveSelectedClub_Click);
            // 
            // AddCompetitionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1781, 821);
            this.Controls.Add(this.btnRemoveSelectedClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAllTeams);
            this.Controls.Add(this.btnAddCompetition);
            this.Controls.Add(this.lblListOfClubs);
            this.Controls.Add(this.dgwTeams);
            this.Controls.Add(this.btnAddNewClub);
            this.Controls.Add(this.gbxCompetitionInfo);
            this.Controls.Add(this.lblHeader);
            this.Name = "AddCompetitionWindow";
            this.Text = "AddCompetitionWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxCompetitionInfo.ResumeLayout(false);
            this.gbxCompetitionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCompetitionName;
        private System.Windows.Forms.Label lblLocationOfCompetition;
        private System.Windows.Forms.Label lblDateOfCompetition;
        private System.Windows.Forms.GroupBox gbxCompetitionInfo;
        private System.Windows.Forms.DateTimePicker dtpCompetitionDate;
        private System.Windows.Forms.TextBox tbxCompetitionLocation;
        private System.Windows.Forms.TextBox tbxCompetitionName;
        private System.Windows.Forms.Button btnAddNewClub;
        private System.Windows.Forms.DataGridView dgwTeams;
        private System.Windows.Forms.Label lblListOfClubs;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwAllTeams;
        private System.Windows.Forms.Button btnRemoveSelectedClub;
    }
}