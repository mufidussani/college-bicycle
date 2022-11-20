namespace CollegeBicycle
{
    partial class Bicycle
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
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.dgvSepeda = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnTambahSepeda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepeda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(29, 15);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(298, 36);
            this.comboBoxStation.TabIndex = 4;
            this.comboBoxStation.Text = "Pilih Station";
            // 
            // dgvSepeda
            // 
            this.dgvSepeda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepeda.Location = new System.Drawing.Point(29, 63);
            this.dgvSepeda.Name = "dgvSepeda";
            this.dgvSepeda.RowHeadersWidth = 51;
            this.dgvSepeda.RowTemplate.Height = 29;
            this.dgvSepeda.Size = new System.Drawing.Size(424, 358);
            this.dgvSepeda.TabIndex = 5;
            this.dgvSepeda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepeda_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(523, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 80);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lokasi: -7.77070, 110.37655";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tersedia : Tidak";
            // 
            // btnPinjam
            // 
            this.btnPinjam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPinjam.Location = new System.Drawing.Point(523, 386);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(137, 35);
            this.btnPinjam.TabIndex = 7;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.UseVisualStyleBackColor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnTambahSepeda
            // 
            this.btnTambahSepeda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTambahSepeda.Location = new System.Drawing.Point(678, 386);
            this.btnTambahSepeda.Name = "btnTambahSepeda";
            this.btnTambahSepeda.Size = new System.Drawing.Size(159, 35);
            this.btnTambahSepeda.TabIndex = 8;
            this.btnTambahSepeda.Text = "Tambah Sepeda";
            this.btnTambahSepeda.UseVisualStyleBackColor = true;
            this.btnTambahSepeda.Click += new System.EventHandler(this.btnTambahSepeda_Click);
            // 
            // Bicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.btnTambahSepeda);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSepeda);
            this.Controls.Add(this.comboBoxStation);
            this.Name = "Bicycle";
            this.Text = "Bicycle";
            this.Load += new System.EventHandler(this.Bicycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepeda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox comboBoxStation;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnPinjam;
        private Button btnTambahSepeda;
        public DataGridView dgvSepeda;
    }
}