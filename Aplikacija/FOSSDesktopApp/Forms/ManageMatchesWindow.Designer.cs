
namespace FOSSDesktopApp.Forms
{
    partial class ManageMatchesWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgwUnplayedMatches = new System.Windows.Forms.DataGridView();
            this.dgwPlayedMatches = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUnplayedMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayedMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPRAVLJANJE MEČEVIMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neodigrani mečevi:";
            // 
            // dgwUnplayedMatches
            // 
            this.dgwUnplayedMatches.AllowUserToAddRows = false;
            this.dgwUnplayedMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUnplayedMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwUnplayedMatches.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwUnplayedMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUnplayedMatches.Location = new System.Drawing.Point(80, 119);
            this.dgwUnplayedMatches.MultiSelect = false;
            this.dgwUnplayedMatches.Name = "dgwUnplayedMatches";
            this.dgwUnplayedMatches.ReadOnly = true;
            this.dgwUnplayedMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUnplayedMatches.Size = new System.Drawing.Size(1385, 308);
            this.dgwUnplayedMatches.TabIndex = 2;
            this.dgwUnplayedMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUnplayedMatches_CellClick);
            // 
            // dgwPlayedMatches
            // 
            this.dgwPlayedMatches.AllowUserToAddRows = false;
            this.dgwPlayedMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPlayedMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwPlayedMatches.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwPlayedMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlayedMatches.Location = new System.Drawing.Point(80, 478);
            this.dgwPlayedMatches.Name = "dgwPlayedMatches";
            this.dgwPlayedMatches.Size = new System.Drawing.Size(1385, 324);
            this.dgwPlayedMatches.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Odigrani mečevi:";
            // 
            // ManageMatchesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1501, 814);
            this.Controls.Add(this.dgwPlayedMatches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwUnplayedMatches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageMatchesWindow";
            this.Text = "ManageMatchesWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgwUnplayedMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayedMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwUnplayedMatches;
        private System.Windows.Forms.DataGridView dgwPlayedMatches;
        private System.Windows.Forms.Label label3;
    }
}