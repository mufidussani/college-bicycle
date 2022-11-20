namespace CollegeBicycle
{
    partial class Users
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
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.dgvPeminjam = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informasi Peminjaman Sepeda";
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(328, 58);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(218, 28);
            this.comboBoxStation.TabIndex = 5;
            this.comboBoxStation.Text = "Pilih Station...";
            // 
            // dgvPeminjam
            // 
            this.dgvPeminjam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeminjam.ColumnHeadersHeight = 29;
            this.dgvPeminjam.Location = new System.Drawing.Point(46, 105);
            this.dgvPeminjam.Name = "dgvPeminjam";
            this.dgvPeminjam.RowHeadersWidth = 51;
            this.dgvPeminjam.RowTemplate.Height = 29;
            this.dgvPeminjam.Size = new System.Drawing.Size(819, 279);
            this.dgvPeminjam.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(716, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "Perbarui Form";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvPeminjam);
            this.Controls.Add(this.comboBoxStation);
            this.Controls.Add(this.label1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ComboBox comboBoxStation;
        private DataGridView dgvPeminjam;
        private Button button5;
    }
}