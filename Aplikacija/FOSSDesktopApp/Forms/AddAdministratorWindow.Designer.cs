
namespace FOSSDesktopApp.Forms
{
    partial class AddAdministratorWindow
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.MaskedTextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEnterKey = new System.Windows.Forms.Label();
            this.tbxEnterkey = new System.Windows.Forms.MaskedTextBox();
            this.btnAddNewAdministrator = new System.Windows.Forms.Button();
            this.gbxAddAdministrator = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.LblListOfAdministrators = new System.Windows.Forms.Label();
            this.dgwAdministratorList = new System.Windows.Forms.DataGridView();
            this.btnDeleteAdministrator = new System.Windows.Forms.Button();
            this.btnDeleteCompetition = new System.Windows.Forms.Button();
            this.dgwAdministratorsCompetitionLIst = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCompetitions = new System.Windows.Forms.ComboBox();
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxAddAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdministratorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdministratorsCompetitionLIst)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(348, 38);
            this.tbxName.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(415, 32);
            this.tbxName.TabIndex = 0;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(348, 78);
            this.tbxSurname.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(415, 32);
            this.tbxSurname.TabIndex = 1;
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
            // lblEnterKey
            // 
            this.lblEnterKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterKey.AutoSize = true;
            this.lblEnterKey.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterKey.Location = new System.Drawing.Point(121, 119);
            this.lblEnterKey.MaximumSize = new System.Drawing.Size(1000, 300);
            this.lblEnterKey.Name = "lblEnterKey";
            this.lblEnterKey.Size = new System.Drawing.Size(210, 24);
            this.lblEnterKey.TabIndex = 6;
            this.lblEnterKey.Text = "Unesite EnterKey:";
            // 
            // tbxEnterkey
            // 
            this.tbxEnterkey.Location = new System.Drawing.Point(348, 119);
            this.tbxEnterkey.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbxEnterkey.Name = "tbxEnterkey";
            this.tbxEnterkey.Size = new System.Drawing.Size(415, 32);
            this.tbxEnterkey.TabIndex = 5;
            // 
            // btnAddNewAdministrator
            // 
            this.btnAddNewAdministrator.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewAdministrator.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAdministrator.Location = new System.Drawing.Point(348, 156);
            this.btnAddNewAdministrator.MaximumSize = new System.Drawing.Size(1000, 300);
            this.btnAddNewAdministrator.Name = "btnAddNewAdministrator";
            this.btnAddNewAdministrator.Size = new System.Drawing.Size(415, 68);
            this.btnAddNewAdministrator.TabIndex = 7;
            this.btnAddNewAdministrator.Text = "DODAJ ADMINISTRATORA";
            this.btnAddNewAdministrator.UseVisualStyleBackColor = false;
            this.btnAddNewAdministrator.Click += new System.EventHandler(this.BtnAddNewAdministrator_Click);
            // 
            // gbxAddAdministrator
            // 
            this.gbxAddAdministrator.Controls.Add(this.lblIme);
            this.gbxAddAdministrator.Controls.Add(this.btnAddNewAdministrator);
            this.gbxAddAdministrator.Controls.Add(this.lblEnterKey);
            this.gbxAddAdministrator.Controls.Add(this.tbxName);
            this.gbxAddAdministrator.Controls.Add(this.tbxEnterkey);
            this.gbxAddAdministrator.Controls.Add(this.tbxSurname);
            this.gbxAddAdministrator.Controls.Add(this.lblPrezime);
            this.gbxAddAdministrator.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddAdministrator.Location = new System.Drawing.Point(247, 101);
            this.gbxAddAdministrator.Name = "gbxAddAdministrator";
            this.gbxAddAdministrator.Size = new System.Drawing.Size(944, 233);
            this.gbxAddAdministrator.TabIndex = 8;
            this.gbxAddAdministrator.TabStop = false;
            this.gbxAddAdministrator.Text = "Dodavanje novog administratora";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(274, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(930, 56);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "UPRAVLJANJE ADMINISTRATORIMA";
            // 
            // LblListOfAdministrators
            // 
            this.LblListOfAdministrators.AutoSize = true;
            this.LblListOfAdministrators.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListOfAdministrators.Location = new System.Drawing.Point(84, 338);
            this.LblListOfAdministrators.Name = "LblListOfAdministrators";
            this.LblListOfAdministrators.Size = new System.Drawing.Size(243, 24);
            this.LblListOfAdministrators.TabIndex = 10;
            this.LblListOfAdministrators.Text = "Lista administratora:";
            // 
            // dgwAdministratorList
            // 
            this.dgwAdministratorList.AllowUserToAddRows = false;
            this.dgwAdministratorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAdministratorList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwAdministratorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdministratorList.Location = new System.Drawing.Point(89, 366);
            this.dgwAdministratorList.MultiSelect = false;
            this.dgwAdministratorList.Name = "dgwAdministratorList";
            this.dgwAdministratorList.ReadOnly = true;
            this.dgwAdministratorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAdministratorList.Size = new System.Drawing.Size(720, 157);
            this.dgwAdministratorList.TabIndex = 11;
            this.dgwAdministratorList.TabStop = false;
            this.dgwAdministratorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwAdministratorList_CellClick);
            // 
            // btnDeleteAdministrator
            // 
            this.btnDeleteAdministrator.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteAdministrator.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdministrator.Location = new System.Drawing.Point(396, 529);
            this.btnDeleteAdministrator.Name = "btnDeleteAdministrator";
            this.btnDeleteAdministrator.Size = new System.Drawing.Size(413, 52);
            this.btnDeleteAdministrator.TabIndex = 12;
            this.btnDeleteAdministrator.Text = "Obriši selektovanog administratora";
            this.btnDeleteAdministrator.UseVisualStyleBackColor = false;
            this.btnDeleteAdministrator.Click += new System.EventHandler(this.BtnDeleteAdministrator_Click);
            // 
            // btnDeleteCompetition
            // 
            this.btnDeleteCompetition.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteCompetition.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompetition.Location = new System.Drawing.Point(1000, 776);
            this.btnDeleteCompetition.Name = "btnDeleteCompetition";
            this.btnDeleteCompetition.Size = new System.Drawing.Size(332, 52);
            this.btnDeleteCompetition.TabIndex = 15;
            this.btnDeleteCompetition.Text = "Obriši privilegiju";
            this.btnDeleteCompetition.UseVisualStyleBackColor = false;
            this.btnDeleteCompetition.Click += new System.EventHandler(this.btnDeleteCompetition_Click);
            // 
            // dgwAdministratorsCompetitionLIst
            // 
            this.dgwAdministratorsCompetitionLIst.AllowUserToAddRows = false;
            this.dgwAdministratorsCompetitionLIst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAdministratorsCompetitionLIst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwAdministratorsCompetitionLIst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdministratorsCompetitionLIst.Location = new System.Drawing.Point(89, 613);
            this.dgwAdministratorsCompetitionLIst.MultiSelect = false;
            this.dgwAdministratorsCompetitionLIst.Name = "dgwAdministratorsCompetitionLIst";
            this.dgwAdministratorsCompetitionLIst.ReadOnly = true;
            this.dgwAdministratorsCompetitionLIst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAdministratorsCompetitionLIst.Size = new System.Drawing.Size(1243, 157);
            this.dgwAdministratorsCompetitionLIst.TabIndex = 14;
            this.dgwAdministratorsCompetitionLIst.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista takmičenja za koje selektovani administrator ima privilegije:";
            // 
            // cbxCompetitions
            // 
            this.cbxCompetitions.FormattingEnabled = true;
            this.cbxCompetitions.Location = new System.Drawing.Point(70, 75);
            this.cbxCompetitions.Name = "cbxCompetitions";
            this.cbxCompetitions.Size = new System.Drawing.Size(242, 33);
            this.cbxCompetitions.TabIndex = 16;
            // 
            // btnAddCompetition
            // 
            this.btnAddCompetition.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCompetition.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddCompetition.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompetition.Location = new System.Drawing.Point(336, 27);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(167, 185);
            this.btnAddCompetition.TabIndex = 18;
            this.btnAddCompetition.Text = "DODAJ\r\nPRIVILEGIJU\r\n\r\n";
            this.btnAddCompetition.UseVisualStyleBackColor = false;
            this.btnAddCompetition.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Izaberi novu privilegiju:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddCompetition);
            this.groupBox1.Controls.Add(this.cbxCompetitions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(847, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 215);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje nove privilegije";
            // 
            // AddAdministratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1435, 839);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteCompetition);
            this.Controls.Add(this.dgwAdministratorsCompetitionLIst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAdministrator);
            this.Controls.Add(this.dgwAdministratorList);
            this.Controls.Add(this.LblListOfAdministrators);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gbxAddAdministrator);
            this.Name = "AddAdministratorWindow";
            this.Text = "AddAdministrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxAddAdministrator.ResumeLayout(false);
            this.gbxAddAdministrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdministratorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdministratorsCompetitionLIst)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.MaskedTextBox tbxSurname;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblEnterKey;
        private System.Windows.Forms.MaskedTextBox tbxEnterkey;
        private System.Windows.Forms.Button btnAddNewAdministrator;
        private System.Windows.Forms.GroupBox gbxAddAdministrator;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label LblListOfAdministrators;
        private System.Windows.Forms.DataGridView dgwAdministratorList;
        private System.Windows.Forms.Button btnDeleteAdministrator;
        private System.Windows.Forms.Button btnDeleteCompetition;
        private System.Windows.Forms.DataGridView dgwAdministratorsCompetitionLIst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCompetitions;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}