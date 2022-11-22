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
            this.tbLokasi = new System.Windows.Forms.TextBox();
            this.lblLokasiSepeda = new System.Windows.Forms.Label();
            this.lblKetersediaan = new System.Windows.Forms.Label();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnTambahSepeda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepeda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(29, 15);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(298, 37);
            this.comboBoxStation.TabIndex = 4;
            this.comboBoxStation.Text = "Pilih Station";
            this.comboBoxStation.SelectedIndexChanged += new System.EventHandler(this.comboBoxStation_SelectedIndexChanged);
            // 
            // dgvSepeda
            // 
            this.dgvSepeda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSepeda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepeda.Location = new System.Drawing.Point(29, 63);
            this.dgvSepeda.Name = "dgvSepeda";
            this.dgvSepeda.RowHeadersWidth = 51;
            this.dgvSepeda.RowTemplate.Height = 29;
            this.dgvSepeda.Size = new System.Drawing.Size(470, 358);
            this.dgvSepeda.TabIndex = 5;
            this.dgvSepeda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepeda_CellClick);
            this.dgvSepeda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepeda_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbLokasi);
            this.panel1.Controls.Add(this.lblLokasiSepeda);
            this.panel1.Controls.Add(this.lblKetersediaan);
            this.panel1.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(548, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 80);
            this.panel1.TabIndex = 6;
            // 
            // tbLokasi
            // 
            this.tbLokasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.tbLokasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLokasi.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLokasi.Location = new System.Drawing.Point(16, 45);
            this.tbLokasi.Name = "tbLokasi";
            this.tbLokasi.Size = new System.Drawing.Size(257, 24);
            this.tbLokasi.TabIndex = 8;
            // 
            // lblLokasiSepeda
            // 
            this.lblLokasiSepeda.AutoSize = true;
            this.lblLokasiSepeda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLokasiSepeda.Location = new System.Drawing.Point(10, 37);
            this.lblLokasiSepeda.Name = "lblLokasiSepeda";
            this.lblLokasiSepeda.Size = new System.Drawing.Size(0, 28);
            this.lblLokasiSepeda.TabIndex = 7;
            this.lblLokasiSepeda.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblKetersediaan
            // 
            this.lblKetersediaan.AutoSize = true;
            this.lblKetersediaan.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKetersediaan.Location = new System.Drawing.Point(10, 9);
            this.lblKetersediaan.Name = "lblKetersediaan";
            this.lblKetersediaan.Size = new System.Drawing.Size(0, 29);
            this.lblKetersediaan.TabIndex = 0;
            // 
            // btnPinjam
            // 
            this.btnPinjam.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPinjam.Location = new System.Drawing.Point(548, 386);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(137, 35);
            this.btnPinjam.TabIndex = 7;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.UseVisualStyleBackColor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnTambahSepeda
            // 
            this.btnTambahSepeda.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTambahSepeda.Location = new System.Drawing.Point(703, 386);
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
        private Label lblLokasiSepeda;
        private Label lblKetersediaan;
        private Button btnPinjam;
        private Button btnTambahSepeda;
        public DataGridView dgvSepeda;
        private TextBox tbLokasi;
    }
}