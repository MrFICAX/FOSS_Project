
namespace FOSSDesktopApp.Forms
{
    partial class CompetitionWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPrijavljeniKlubovi = new System.Windows.Forms.Label();
            this.dgwTeams = new System.Windows.Forms.DataGridView();
            this.lblPrijavljeneSudije = new System.Windows.Forms.Label();
            this.dgwPlayers = new System.Windows.Forms.DataGridView();
            this.lblListaMeceva = new System.Windows.Forms.Label();
            this.dgwMatches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrijavljeniKlubovi
            // 
            this.lblPrijavljeniKlubovi.AutoSize = true;
            this.lblPrijavljeniKlubovi.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljeniKlubovi.Location = new System.Drawing.Point(27, 13);
            this.lblPrijavljeniKlubovi.Name = "lblPrijavljeniKlubovi";
            this.lblPrijavljeniKlubovi.Size = new System.Drawing.Size(334, 38);
            this.lblPrijavljeniKlubovi.TabIndex = 0;
            this.lblPrijavljeniKlubovi.Text = "Prijavljeni klubovi:";
            // 
            // dgwTeams
            // 
            this.dgwTeams.AllowUserToAddRows = false;
            this.dgwTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeams.Location = new System.Drawing.Point(30, 53);
            this.dgwTeams.MultiSelect = false;
            this.dgwTeams.Name = "dgwTeams";
            this.dgwTeams.ReadOnly = true;
            this.dgwTeams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTeams.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTeams.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwTeams.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTeams.Size = new System.Drawing.Size(715, 346);
            this.dgwTeams.TabIndex = 1;
            this.dgwTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTeams_CellClick);
            // 
            // lblPrijavljeneSudije
            // 
            this.lblPrijavljeneSudije.AutoSize = true;
            this.lblPrijavljeneSudije.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljeneSudije.Location = new System.Drawing.Point(358, 402);
            this.lblPrijavljeneSudije.Name = "lblPrijavljeneSudije";
            this.lblPrijavljeneSudije.Size = new System.Drawing.Size(711, 38);
            this.lblPrijavljeneSudije.TabIndex = 2;
            this.lblPrijavljeneSudije.Text = "Prijavljeni takmičari za selektovani klub:";
            // 
            // dgwPlayers
            // 
            this.dgwPlayers.AllowUserToAddRows = false;
            this.dgwPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlayers.Location = new System.Drawing.Point(30, 443);
            this.dgwPlayers.Name = "dgwPlayers";
            this.dgwPlayers.ReadOnly = true;
            this.dgwPlayers.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwPlayers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPlayers.Size = new System.Drawing.Size(1458, 364);
            this.dgwPlayers.TabIndex = 3;
            // 
            // lblListaMeceva
            // 
            this.lblListaMeceva.AutoSize = true;
            this.lblListaMeceva.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaMeceva.Location = new System.Drawing.Point(1241, 13);
            this.lblListaMeceva.Name = "lblListaMeceva";
            this.lblListaMeceva.Size = new System.Drawing.Size(249, 38);
            this.lblListaMeceva.TabIndex = 4;
            this.lblListaMeceva.Text = "Lista mečeva:";
            // 
            // dgwMatches
            // 
            this.dgwMatches.AllowUserToAddRows = false;
            this.dgwMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatches.Location = new System.Drawing.Point(751, 53);
            this.dgwMatches.Name = "dgwMatches";
            this.dgwMatches.ReadOnly = true;
            this.dgwMatches.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwMatches.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMatches.Size = new System.Drawing.Size(739, 346);
            this.dgwMatches.TabIndex = 5;
            // 
            // CompetitionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1502, 815);
            this.Controls.Add(this.dgwMatches);
            this.Controls.Add(this.lblListaMeceva);
            this.Controls.Add(this.dgwPlayers);
            this.Controls.Add(this.lblPrijavljeneSudije);
            this.Controls.Add(this.dgwTeams);
            this.Controls.Add(this.lblPrijavljeniKlubovi);
            this.Name = "CompetitionWindow";
            this.Text = "CompetitionWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrijavljeniKlubovi;
        private System.Windows.Forms.DataGridView dgwTeams;
        private System.Windows.Forms.Label lblPrijavljeneSudije;
        private System.Windows.Forms.DataGridView dgwPlayers;
        private System.Windows.Forms.Label lblListaMeceva;
        private System.Windows.Forms.DataGridView dgwMatches;
    }
}