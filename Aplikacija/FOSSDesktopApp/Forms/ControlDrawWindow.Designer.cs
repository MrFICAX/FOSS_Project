
namespace FOSSDesktopApp.Forms
{
    partial class ControlDrawWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidateFormat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNumOfWinnerPerGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTeamsPerGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGroupNumber = new System.Windows.Forms.ComboBox();
            this.rdbCombinedPhase = new System.Windows.Forms.RadioButton();
            this.rdbDrawPhase = new System.Windows.Forms.RadioButton();
            this.rdbGroupPhase = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMAT TAKMIČENJA:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(378, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(623, 56);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "UPRAVLJANJE ŽREBOM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValidateFormat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxNumOfWinnerPerGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxTeamsPerGroup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxGroupNumber);
            this.groupBox1.Controls.Add(this.rdbCombinedPhase);
            this.groupBox1.Controls.Add(this.rdbDrawPhase);
            this.groupBox1.Controls.Add(this.rdbGroupPhase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(190, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 494);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IZABERITE FORMAT TAKMIČENJA";
            // 
            // btnValidateFormat
            // 
            this.btnValidateFormat.Location = new System.Drawing.Point(608, 416);
            this.btnValidateFormat.Name = "btnValidateFormat";
            this.btnValidateFormat.Size = new System.Drawing.Size(387, 55);
            this.btnValidateFormat.TabIndex = 10;
            this.btnValidateFormat.Text = "PROVERI UNETE VREDNOSTI";
            this.btnValidateFormat.UseVisualStyleBackColor = true;
            this.btnValidateFormat.Click += new System.EventHandler(this.btnValidateFormat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "BROJ EKIPA PO GRUPI KOJI PROLAZI DALJE:";
            // 
            // cbxNumOfWinnerPerGroup
            // 
            this.cbxNumOfWinnerPerGroup.FormattingEnabled = true;
            this.cbxNumOfWinnerPerGroup.Location = new System.Drawing.Point(667, 363);
            this.cbxNumOfWinnerPerGroup.Name = "cbxNumOfWinnerPerGroup";
            this.cbxNumOfWinnerPerGroup.Size = new System.Drawing.Size(328, 32);
            this.cbxNumOfWinnerPerGroup.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "MINIMALNI BROJ EKIPA PO GRUPI:";
            // 
            // cbxTeamsPerGroup
            // 
            this.cbxTeamsPerGroup.FormattingEnabled = true;
            this.cbxTeamsPerGroup.Location = new System.Drawing.Point(667, 281);
            this.cbxTeamsPerGroup.Name = "cbxTeamsPerGroup";
            this.cbxTeamsPerGroup.Size = new System.Drawing.Size(328, 32);
            this.cbxTeamsPerGroup.TabIndex = 6;
            this.cbxTeamsPerGroup.SelectedIndexChanged += new System.EventHandler(this.cbxTeamsPerGroup_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "BROJ GRUPA:";
            // 
            // cbxGroupNumber
            // 
            this.cbxGroupNumber.FormattingEnabled = true;
            this.cbxGroupNumber.Location = new System.Drawing.Point(667, 198);
            this.cbxGroupNumber.Name = "cbxGroupNumber";
            this.cbxGroupNumber.Size = new System.Drawing.Size(328, 32);
            this.cbxGroupNumber.TabIndex = 4;
            // 
            // rdbCombinedPhase
            // 
            this.rdbCombinedPhase.AutoSize = true;
            this.rdbCombinedPhase.Location = new System.Drawing.Point(714, 109);
            this.rdbCombinedPhase.Name = "rdbCombinedPhase";
            this.rdbCombinedPhase.Size = new System.Drawing.Size(281, 28);
            this.rdbCombinedPhase.TabIndex = 3;
            this.rdbCombinedPhase.TabStop = true;
            this.rdbCombinedPhase.Text = "KOMBINOVANI SISTEM";
            this.rdbCombinedPhase.UseVisualStyleBackColor = true;
            this.rdbCombinedPhase.CheckedChanged += new System.EventHandler(this.rdbCombinedPhase_CheckedChanged);
            // 
            // rdbDrawPhase
            // 
            this.rdbDrawPhase.AutoSize = true;
            this.rdbDrawPhase.Location = new System.Drawing.Point(46, 109);
            this.rdbDrawPhase.Name = "rdbDrawPhase";
            this.rdbDrawPhase.Size = new System.Drawing.Size(166, 28);
            this.rdbDrawPhase.TabIndex = 2;
            this.rdbDrawPhase.TabStop = true;
            this.rdbDrawPhase.Text = "KUP SISTEM";
            this.rdbDrawPhase.UseVisualStyleBackColor = true;
            this.rdbDrawPhase.CheckedChanged += new System.EventHandler(this.rdbTreePhase_CheckedChanged);
            // 
            // rdbGroupPhase
            // 
            this.rdbGroupPhase.AutoSize = true;
            this.rdbGroupPhase.Location = new System.Drawing.Point(334, 109);
            this.rdbGroupPhase.Name = "rdbGroupPhase";
            this.rdbGroupPhase.Size = new System.Drawing.Size(283, 28);
            this.rdbGroupPhase.TabIndex = 1;
            this.rdbGroupPhase.TabStop = true;
            this.rdbGroupPhase.Text = "JEDNOKRUŽNI SISTEM";
            this.rdbGroupPhase.UseVisualStyleBackColor = true;
            this.rdbGroupPhase.CheckedChanged += new System.EventHandler(this.rdbGroupPhase_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTeamNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PODACI O IZABRANOM TAKMIČENJU";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNumber.Location = new System.Drawing.Point(422, 45);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(208, 24);
            this.lblTeamNumber.TabIndex = 1;
            this.lblTeamNumber.Text = "__________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "BROJ PRIJAVLJENIH KLUBOVA:";
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartDraw.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDraw.Location = new System.Drawing.Point(0, 784);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(1377, 55);
            this.btnStartDraw.TabIndex = 5;
            this.btnStartDraw.Text = "POKRENI ŽREB";
            this.btnStartDraw.UseVisualStyleBackColor = true;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // ControlDrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 839);
            this.Controls.Add(this.btnStartDraw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHeader);
            this.Name = "ControlDrawWindow";
            this.Text = "ControlDrawWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValidateFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNumOfWinnerPerGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTeamsPerGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGroupNumber;
        private System.Windows.Forms.RadioButton rdbCombinedPhase;
        private System.Windows.Forms.RadioButton rdbDrawPhase;
        private System.Windows.Forms.RadioButton rdbGroupPhase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartDraw;
    }
}