
namespace FOSSDesktopApp.Forms
{
    partial class AddTeamWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblListOfPlayers = new System.Windows.Forms.Label();
            this.tbxClubName = new System.Windows.Forms.TextBox();
            this.DgwPlayers = new System.Windows.Forms.DataGridView();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.tbxPlayerSurname = new System.Windows.Forms.TextBox();
            this.lblPlayerSurname = new System.Windows.Forms.Label();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.tbxPlayerPosition = new System.Windows.Forms.TextBox();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.lblAddPlayer = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.nudPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.tbxTrainerName = new System.Windows.Forms.TextBox();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.tbxTrainerSurname = new System.Windows.Forms.TextBox();
            this.lblTrainerSurname = new System.Windows.Forms.Label();
            this.btnDeleteClub = new System.Windows.Forms.Button();
            this.dgwTeams = new System.Windows.Forms.DataGridView();
            this.lblLoadedClubs = new System.Windows.Forms.Label();
            this.lblClubList = new System.Windows.Forms.Label();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCapitain = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgwPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(33, 37);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(717, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DODAVANJE NOVOG KLUBA";
            // 
            // lblClubName
            // 
            this.lblClubName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.Location = new System.Drawing.Point(89, 122);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(214, 24);
            this.lblClubName.TabIndex = 1;
            this.lblClubName.Text = "Unesite ime kluba:";
            // 
            // lblListOfPlayers
            // 
            this.lblListOfPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListOfPlayers.AutoSize = true;
            this.lblListOfPlayers.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfPlayers.Location = new System.Drawing.Point(38, 290);
            this.lblListOfPlayers.Name = "lblListOfPlayers";
            this.lblListOfPlayers.Size = new System.Drawing.Size(277, 24);
            this.lblListOfPlayers.TabIndex = 2;
            this.lblListOfPlayers.Text = "Lista prijavljenih igrača:";
            // 
            // tbxClubName
            // 
            this.tbxClubName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxClubName.Location = new System.Drawing.Point(302, 122);
            this.tbxClubName.Name = "tbxClubName";
            this.tbxClubName.Size = new System.Drawing.Size(253, 20);
            this.tbxClubName.TabIndex = 1;
            // 
            // DgwPlayers
            // 
            this.DgwPlayers.AllowUserToAddRows = false;
            this.DgwPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgwPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgwPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwPlayers.Location = new System.Drawing.Point(12, 328);
            this.DgwPlayers.Name = "DgwPlayers";
            this.DgwPlayers.ReadOnly = true;
            this.DgwPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwPlayers.Size = new System.Drawing.Size(763, 138);
            this.DgwPlayers.TabIndex = 5;
            this.DgwPlayers.TabStop = false;
            this.DgwPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwPlayers_CellClick);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPlayer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddPlayer.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.Location = new System.Drawing.Point(67, 664);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(308, 49);
            this.btnAddPlayer.TabIndex = 9;
            this.btnAddPlayer.Text = "Dodaj novog igrača";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdatePlayer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdatePlayer.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlayer.Location = new System.Drawing.Point(381, 664);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(217, 49);
            this.btnUpdatePlayer.TabIndex = 10;
            this.btnUpdatePlayer.Text = "Izmeni igrača";
            this.btnUpdatePlayer.UseVisualStyleBackColor = false;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletePlayer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.Location = new System.Drawing.Point(457, 472);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(272, 49);
            this.btnDeletePlayer.TabIndex = 8;
            this.btnDeletePlayer.Text = "Obriši igrača";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(39, 555);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(107, 21);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = "Ime igrača";
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPlayerName.Location = new System.Drawing.Point(43, 594);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayerName.TabIndex = 4;
            // 
            // tbxPlayerSurname
            // 
            this.tbxPlayerSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPlayerSurname.Location = new System.Drawing.Point(189, 594);
            this.tbxPlayerSurname.Name = "tbxPlayerSurname";
            this.tbxPlayerSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayerSurname.TabIndex = 5;
            // 
            // lblPlayerSurname
            // 
            this.lblPlayerSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerSurname.AutoSize = true;
            this.lblPlayerSurname.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerSurname.Location = new System.Drawing.Point(185, 555);
            this.lblPlayerSurname.Name = "lblPlayerSurname";
            this.lblPlayerSurname.Size = new System.Drawing.Size(145, 21);
            this.lblPlayerSurname.TabIndex = 11;
            this.lblPlayerSurname.Text = "Prezime igrača";
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNumber.Location = new System.Drawing.Point(362, 555);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(111, 21);
            this.lblPlayerNumber.TabIndex = 13;
            this.lblPlayerNumber.Text = "Broj igrača";
            // 
            // tbxPlayerPosition
            // 
            this.tbxPlayerPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPlayerPosition.Location = new System.Drawing.Point(515, 594);
            this.tbxPlayerPosition.Name = "tbxPlayerPosition";
            this.tbxPlayerPosition.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayerPosition.TabIndex = 7;
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPosition.Location = new System.Drawing.Point(511, 555);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(143, 21);
            this.lblPlayerPosition.TabIndex = 15;
            this.lblPlayerPosition.Text = "Pozicija igrača";
            // 
            // lblAddPlayer
            // 
            this.lblAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddPlayer.AutoSize = true;
            this.lblAddPlayer.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPlayer.Location = new System.Drawing.Point(37, 509);
            this.lblAddPlayer.Name = "lblAddPlayer";
            this.lblAddPlayer.Size = new System.Drawing.Size(241, 32);
            this.lblAddPlayer.TabIndex = 17;
            this.lblAddPlayer.Text = "Podaci o igraču:";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTeam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddTeam.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(12, 740);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(363, 56);
            this.btnAddTeam.TabIndex = 11;
            this.btnAddTeam.Text = "DODAJ KLUB";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // nudPlayerNumber
            // 
            this.nudPlayerNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudPlayerNumber.Location = new System.Drawing.Point(353, 594);
            this.nudPlayerNumber.Name = "nudPlayerNumber";
            this.nudPlayerNumber.Size = new System.Drawing.Size(120, 20);
            this.nudPlayerNumber.TabIndex = 6;
            // 
            // tbxTrainerName
            // 
            this.tbxTrainerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTrainerName.Location = new System.Drawing.Point(302, 170);
            this.tbxTrainerName.Name = "tbxTrainerName";
            this.tbxTrainerName.Size = new System.Drawing.Size(253, 20);
            this.tbxTrainerName.TabIndex = 2;
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerName.Location = new System.Drawing.Point(73, 170);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(235, 24);
            this.lblTrainerName.TabIndex = 20;
            this.lblTrainerName.Text = "Unesite ime trenera:";
            // 
            // tbxTrainerSurname
            // 
            this.tbxTrainerSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTrainerSurname.Location = new System.Drawing.Point(302, 215);
            this.tbxTrainerSurname.Name = "tbxTrainerSurname";
            this.tbxTrainerSurname.Size = new System.Drawing.Size(253, 20);
            this.tbxTrainerSurname.TabIndex = 3;
            // 
            // lblTrainerSurname
            // 
            this.lblTrainerSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainerSurname.AutoSize = true;
            this.lblTrainerSurname.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerSurname.Location = new System.Drawing.Point(25, 215);
            this.lblTrainerSurname.Name = "lblTrainerSurname";
            this.lblTrainerSurname.Size = new System.Drawing.Size(282, 24);
            this.lblTrainerSurname.TabIndex = 22;
            this.lblTrainerSurname.Text = "Unesite prezime trenera:";
            // 
            // btnDeleteClub
            // 
            this.btnDeleteClub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteClub.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteClub.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClub.Location = new System.Drawing.Point(1153, 664);
            this.btnDeleteClub.Name = "btnDeleteClub";
            this.btnDeleteClub.Size = new System.Drawing.Size(289, 49);
            this.btnDeleteClub.TabIndex = 25;
            this.btnDeleteClub.Text = "Obriši klub";
            this.btnDeleteClub.UseVisualStyleBackColor = false;
            this.btnDeleteClub.Click += new System.EventHandler(this.btnDeleteClub_Click);
            // 
            // dgwTeams
            // 
            this.dgwTeams.AllowUserToAddRows = false;
            this.dgwTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeams.Location = new System.Drawing.Point(791, 216);
            this.dgwTeams.Name = "dgwTeams";
            this.dgwTeams.ReadOnly = true;
            this.dgwTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTeams.Size = new System.Drawing.Size(654, 442);
            this.dgwTeams.TabIndex = 24;
            this.dgwTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTeams_CellClick);
            // 
            // lblLoadedClubs
            // 
            this.lblLoadedClubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadedClubs.AutoSize = true;
            this.lblLoadedClubs.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadedClubs.Location = new System.Drawing.Point(787, 189);
            this.lblLoadedClubs.Name = "lblLoadedClubs";
            this.lblLoadedClubs.Size = new System.Drawing.Size(284, 24);
            this.lblLoadedClubs.TabIndex = 23;
            this.lblLoadedClubs.Text = "Lista postojećih klubova:";
            // 
            // lblClubList
            // 
            this.lblClubList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClubList.AutoSize = true;
            this.lblClubList.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubList.Location = new System.Drawing.Point(854, 37);
            this.lblClubList.Name = "lblClubList";
            this.lblClubList.Size = new System.Drawing.Size(522, 56);
            this.lblClubList.TabIndex = 26;
            this.lblClubList.Text = "PREGLED KLUBOVA";
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateTeam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateTeam.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeam.Location = new System.Drawing.Point(412, 740);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(363, 56);
            this.btnUpdateTeam.TabIndex = 27;
            this.btnUpdateTeam.Text = "AŽURIRAJ KLUB";
            this.btnUpdateTeam.UseVisualStyleBackColor = false;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kapiten";
            // 
            // cbxCapitain
            // 
            this.cbxCapitain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCapitain.AutoSize = true;
            this.cbxCapitain.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCapitain.Location = new System.Drawing.Point(676, 594);
            this.cbxCapitain.Name = "cbxCapitain";
            this.cbxCapitain.Size = new System.Drawing.Size(85, 24);
            this.cbxCapitain.TabIndex = 29;
            this.cbxCapitain.Text = "DA/NE";
            this.cbxCapitain.UseVisualStyleBackColor = true;
            // 
            // AddTeamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1454, 811);
            this.Controls.Add(this.cbxCapitain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateTeam);
            this.Controls.Add(this.lblClubList);
            this.Controls.Add(this.btnDeleteClub);
            this.Controls.Add(this.dgwTeams);
            this.Controls.Add(this.lblLoadedClubs);
            this.Controls.Add(this.tbxTrainerSurname);
            this.Controls.Add(this.lblTrainerSurname);
            this.Controls.Add(this.tbxTrainerName);
            this.Controls.Add(this.lblTrainerName);
            this.Controls.Add(this.nudPlayerNumber);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lblAddPlayer);
            this.Controls.Add(this.tbxPlayerPosition);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.tbxPlayerSurname);
            this.Controls.Add(this.lblPlayerSurname);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.DgwPlayers);
            this.Controls.Add(this.tbxClubName);
            this.Controls.Add(this.lblListOfPlayers);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.lblHeader);
            this.Name = "AddTeamWindow";
            this.Text = "AddClubWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgwPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblListOfPlayers;
        private System.Windows.Forms.TextBox tbxClubName;
        private System.Windows.Forms.DataGridView DgwPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.TextBox tbxPlayerSurname;
        private System.Windows.Forms.Label lblPlayerSurname;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.TextBox tbxPlayerPosition;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lblAddPlayer;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.NumericUpDown nudPlayerNumber;
        private System.Windows.Forms.TextBox tbxTrainerName;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.TextBox tbxTrainerSurname;
        private System.Windows.Forms.Label lblTrainerSurname;
        private System.Windows.Forms.Button btnDeleteClub;
        private System.Windows.Forms.DataGridView dgwTeams;
        private System.Windows.Forms.Label lblLoadedClubs;
        private System.Windows.Forms.Label lblClubList;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxCapitain;
    }
}