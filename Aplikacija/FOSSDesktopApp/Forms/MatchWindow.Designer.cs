
namespace FOSSDesktopApp.Forms
{
    partial class MatchWindow
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
            this.lblTeam1Result = new System.Windows.Forms.Label();
            this.lblTeam2Result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIsLive = new System.Windows.Forms.Label();
            this.lblTeam1Name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTeam2Name = new System.Windows.Forms.Label();
            this.dgwPlayerListTeam1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwPlayerListTeam2 = new System.Windows.Forms.DataGridView();
            this.btnFinishMatch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxRefereeList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDateOfMatch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLevelOfMatch = new System.Windows.Forms.Label();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayerListTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayerListTeam2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeam1Result
            // 
            this.lblTeam1Result.AutoSize = true;
            this.lblTeam1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1Result.Location = new System.Drawing.Point(6, 16);
            this.lblTeam1Result.Name = "lblTeam1Result";
            this.lblTeam1Result.Size = new System.Drawing.Size(99, 108);
            this.lblTeam1Result.TabIndex = 0;
            this.lblTeam1Result.Text = "0";
            // 
            // lblTeam2Result
            // 
            this.lblTeam2Result.AutoSize = true;
            this.lblTeam2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2Result.Location = new System.Drawing.Point(181, 16);
            this.lblTeam2Result.Name = "lblTeam2Result";
            this.lblTeam2Result.Size = new System.Drawing.Size(99, 108);
            this.lblTeam2Result.TabIndex = 1;
            this.lblTeam2Result.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOMAĆI:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.lblIsLive);
            this.groupBox1.Controls.Add(this.lblTeam1Result);
            this.groupBox1.Controls.Add(this.lblTeam2Result);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(714, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblIsLive
            // 
            this.lblIsLive.AutoSize = true;
            this.lblIsLive.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsLive.Location = new System.Drawing.Point(64, 124);
            this.lblIsLive.Name = "lblIsLive";
            this.lblIsLive.Size = new System.Drawing.Size(189, 22);
            this.lblIsLive.TabIndex = 3;
            this.lblIsLive.Text = "Nije pokrenut mec";
            // 
            // lblTeam1Name
            // 
            this.lblTeam1Name.AutoSize = true;
            this.lblTeam1Name.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1Name.Location = new System.Drawing.Point(20, 80);
            this.lblTeam1Name.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblTeam1Name.Name = "lblTeam1Name";
            this.lblTeam1Name.Size = new System.Drawing.Size(294, 44);
            this.lblTeam1Name.TabIndex = 6;
            this.lblTeam1Name.Text = "IME 1. KLUBA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTeam1Name);
            this.groupBox2.Location = new System.Drawing.Point(38, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 273);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblTeam2Name);
            this.groupBox3.Location = new System.Drawing.Point(1008, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 273);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 56);
            this.label6.TabIndex = 3;
            this.label6.Text = "GOSTI:";
            // 
            // lblTeam2Name
            // 
            this.lblTeam2Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTeam2Name.AutoSize = true;
            this.lblTeam2Name.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2Name.Location = new System.Drawing.Point(24, 80);
            this.lblTeam2Name.MaximumSize = new System.Drawing.Size(640, 0);
            this.lblTeam2Name.Name = "lblTeam2Name";
            this.lblTeam2Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTeam2Name.Size = new System.Drawing.Size(294, 44);
            this.lblTeam2Name.TabIndex = 6;
            this.lblTeam2Name.Text = "IME 2. KLUBA";
            // 
            // dgwPlayerListTeam1
            // 
            this.dgwPlayerListTeam1.AllowUserToAddRows = false;
            this.dgwPlayerListTeam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlayerListTeam1.Location = new System.Drawing.Point(22, 367);
            this.dgwPlayerListTeam1.MultiSelect = false;
            this.dgwPlayerListTeam1.Name = "dgwPlayerListTeam1";
            this.dgwPlayerListTeam1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPlayerListTeam1.Size = new System.Drawing.Size(829, 433);
            this.dgwPlayerListTeam1.TabIndex = 10;
            this.dgwPlayerListTeam1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPlayerListTeam1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "IGRAČI DOMAĆIH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1255, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "IGRAČI GOSTIJU:";
            // 
            // dgwPlayerListTeam2
            // 
            this.dgwPlayerListTeam2.AllowUserToAddRows = false;
            this.dgwPlayerListTeam2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlayerListTeam2.Location = new System.Drawing.Point(857, 367);
            this.dgwPlayerListTeam2.MultiSelect = false;
            this.dgwPlayerListTeam2.Name = "dgwPlayerListTeam2";
            this.dgwPlayerListTeam2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPlayerListTeam2.Size = new System.Drawing.Size(820, 433);
            this.dgwPlayerListTeam2.TabIndex = 12;
            this.dgwPlayerListTeam2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPlayerListTeam2_CellClick);
            // 
            // btnFinishMatch
            // 
            this.btnFinishMatch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinishMatch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFinishMatch.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishMatch.Location = new System.Drawing.Point(0, 920);
            this.btnFinishMatch.Name = "btnFinishMatch";
            this.btnFinishMatch.Size = new System.Drawing.Size(1705, 64);
            this.btnFinishMatch.TabIndex = 14;
            this.btnFinishMatch.Text = "ZAVRŠI MEČ";
            this.btnFinishMatch.UseVisualStyleBackColor = false;
            this.btnFinishMatch.Click += new System.EventHandler(this.btnFinishMatch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(575, 815);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(544, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "IZABERITE SUDIJU ZA OVAJ MEČ:";
            // 
            // cbxRefereeList
            // 
            this.cbxRefereeList.BackColor = System.Drawing.Color.DarkOrange;
            this.cbxRefereeList.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRefereeList.FormattingEnabled = true;
            this.cbxRefereeList.Location = new System.Drawing.Point(699, 853);
            this.cbxRefereeList.Name = "cbxRefereeList";
            this.cbxRefereeList.Size = new System.Drawing.Size(301, 27);
            this.cbxRefereeList.TabIndex = 16;
            this.cbxRefereeList.SelectedIndexChanged += new System.EventHandler(this.cbxRefereeList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(794, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Datum meča:";
            // 
            // lblDateOfMatch
            // 
            this.lblDateOfMatch.AutoSize = true;
            this.lblDateOfMatch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfMatch.Location = new System.Drawing.Point(778, 34);
            this.lblDateOfMatch.Name = "lblDateOfMatch";
            this.lblDateOfMatch.Size = new System.Drawing.Size(60, 20);
            this.lblDateOfMatch.TabIndex = 18;
            this.lblDateOfMatch.Text = "datum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(778, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nivo takmičenja:";
            // 
            // lblLevelOfMatch
            // 
            this.lblLevelOfMatch.AutoSize = true;
            this.lblLevelOfMatch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelOfMatch.Location = new System.Drawing.Point(810, 94);
            this.lblLevelOfMatch.Name = "lblLevelOfMatch";
            this.lblLevelOfMatch.Size = new System.Drawing.Size(41, 20);
            this.lblLevelOfMatch.TabIndex = 20;
            this.lblLevelOfMatch.Text = "nivo";
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStartMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMatch.Location = new System.Drawing.Point(714, 313);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(286, 33);
            this.btnStartMatch.TabIndex = 21;
            this.btnStartMatch.Text = "Pokreni meč";
            this.btnStartMatch.UseVisualStyleBackColor = false;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // MatchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1705, 984);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.lblLevelOfMatch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDateOfMatch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxRefereeList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFinishMatch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwPlayerListTeam2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgwPlayerListTeam1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MatchWindow";
            this.Text = "MatchWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayerListTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayerListTeam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeam1Result;
        private System.Windows.Forms.Label lblTeam2Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTeam1Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTeam2Name;
        private System.Windows.Forms.DataGridView dgwPlayerListTeam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwPlayerListTeam2;
        private System.Windows.Forms.Button btnFinishMatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxRefereeList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDateOfMatch;
        private System.Windows.Forms.Label lblIsLive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLevelOfMatch;
        private System.Windows.Forms.Button btnStartMatch;
    }
}