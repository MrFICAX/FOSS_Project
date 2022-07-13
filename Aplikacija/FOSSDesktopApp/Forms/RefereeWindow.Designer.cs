
namespace FOSSDesktopApp.Forms
{
    partial class RefereeWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwRefereeList = new System.Windows.Forms.DataGridView();
            this.gbxAddNewReferee = new System.Windows.Forms.GroupBox();
            this.nudRefereeQuality = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewReferee = new System.Windows.Forms.Button();
            this.tbxRefereeSurname = new System.Windows.Forms.TextBox();
            this.tbxRefereeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRefereeList)).BeginInit();
            this.gbxAddNewReferee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefereeQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPRAVLJANJE SUDIJAMA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA POSTOJEĆIH SUDIJA: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unesite ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unesite prezime:";
            // 
            // dgwRefereeList
            // 
            this.dgwRefereeList.AllowUserToAddRows = false;
            this.dgwRefereeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwRefereeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRefereeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwRefereeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRefereeList.Enabled = false;
            this.dgwRefereeList.Location = new System.Drawing.Point(234, 126);
            this.dgwRefereeList.MultiSelect = false;
            this.dgwRefereeList.Name = "dgwRefereeList";
            this.dgwRefereeList.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgwRefereeList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwRefereeList.Size = new System.Drawing.Size(753, 280);
            this.dgwRefereeList.TabIndex = 4;
            // 
            // gbxAddNewReferee
            // 
            this.gbxAddNewReferee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxAddNewReferee.Controls.Add(this.nudRefereeQuality);
            this.gbxAddNewReferee.Controls.Add(this.label5);
            this.gbxAddNewReferee.Controls.Add(this.btnAddNewReferee);
            this.gbxAddNewReferee.Controls.Add(this.tbxRefereeSurname);
            this.gbxAddNewReferee.Controls.Add(this.tbxRefereeName);
            this.gbxAddNewReferee.Controls.Add(this.label3);
            this.gbxAddNewReferee.Controls.Add(this.label4);
            this.gbxAddNewReferee.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddNewReferee.Location = new System.Drawing.Point(257, 440);
            this.gbxAddNewReferee.Name = "gbxAddNewReferee";
            this.gbxAddNewReferee.Size = new System.Drawing.Size(706, 376);
            this.gbxAddNewReferee.TabIndex = 5;
            this.gbxAddNewReferee.TabStop = false;
            this.gbxAddNewReferee.Text = "DODAVANJE NOVOG SUDIJE";
            // 
            // nudRefereeQuality
            // 
            this.nudRefereeQuality.Location = new System.Drawing.Point(355, 192);
            this.nudRefereeQuality.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudRefereeQuality.Name = "nudRefereeQuality";
            this.nudRefereeQuality.Size = new System.Drawing.Size(215, 32);
            this.nudRefereeQuality.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unesite registarski broj:";
            // 
            // btnAddNewReferee
            // 
            this.btnAddNewReferee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNewReferee.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewReferee.Location = new System.Drawing.Point(107, 259);
            this.btnAddNewReferee.Name = "btnAddNewReferee";
            this.btnAddNewReferee.Size = new System.Drawing.Size(462, 64);
            this.btnAddNewReferee.TabIndex = 7;
            this.btnAddNewReferee.Text = "DODAJ NOVOG SUDIJU";
            this.btnAddNewReferee.UseVisualStyleBackColor = false;
            this.btnAddNewReferee.Click += new System.EventHandler(this.btnAddNewReferee_Click);
            // 
            // tbxRefereeSurname
            // 
            this.tbxRefereeSurname.Location = new System.Drawing.Point(355, 125);
            this.tbxRefereeSurname.Name = "tbxRefereeSurname";
            this.tbxRefereeSurname.Size = new System.Drawing.Size(215, 32);
            this.tbxRefereeSurname.TabIndex = 6;
            // 
            // tbxRefereeName
            // 
            this.tbxRefereeName.Location = new System.Drawing.Point(355, 50);
            this.tbxRefereeName.Name = "tbxRefereeName";
            this.tbxRefereeName.Size = new System.Drawing.Size(215, 32);
            this.tbxRefereeName.TabIndex = 5;
            // 
            // RefereeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 872);
            this.Controls.Add(this.gbxAddNewReferee);
            this.Controls.Add(this.dgwRefereeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RefereeWindow";
            this.Text = "RefereeWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwRefereeList)).EndInit();
            this.gbxAddNewReferee.ResumeLayout(false);
            this.gbxAddNewReferee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefereeQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwRefereeList;
        private System.Windows.Forms.GroupBox gbxAddNewReferee;
        private System.Windows.Forms.Button btnAddNewReferee;
        private System.Windows.Forms.TextBox tbxRefereeSurname;
        private System.Windows.Forms.TextBox tbxRefereeName;
        private System.Windows.Forms.NumericUpDown nudRefereeQuality;
        private System.Windows.Forms.Label label5;
    }
}