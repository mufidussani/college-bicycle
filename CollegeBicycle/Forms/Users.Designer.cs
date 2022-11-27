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
            this.btnUpdateForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informasi Peminjaman Sepeda";
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(357, 51);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(218, 37);
            this.comboBoxStation.TabIndex = 5;
            this.comboBoxStation.Text = "Pilih Station...";
            this.comboBoxStation.SelectedIndexChanged += new System.EventHandler(this.comboBoxStation_SelectedIndexChanged);
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
            this.dgvPeminjam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjam_CellClick);
            this.dgvPeminjam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjam_CellDoubleClick);
            // 
            // btnUpdateForm
            // 
            this.btnUpdateForm.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateForm.Location = new System.Drawing.Point(716, 401);
            this.btnUpdateForm.Name = "btnUpdateForm";
            this.btnUpdateForm.Size = new System.Drawing.Size(149, 29);
            this.btnUpdateForm.TabIndex = 7;
            this.btnUpdateForm.Text = "Perbarui Form";
            this.btnUpdateForm.UseVisualStyleBackColor = true;
            this.btnUpdateForm.Click += new System.EventHandler(this.btnUpdateForm_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.btnUpdateForm);
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
        private Button btnUpdateForm;
        public DataGridView dgvPeminjam;
    }
}