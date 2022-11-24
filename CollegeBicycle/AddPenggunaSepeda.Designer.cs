namespace CollegeBicycle
{
    partial class AddPenggunaSepeda
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTanggalPinjam = new System.Windows.Forms.DateTimePicker();
            this.tbKodeSepeda = new System.Windows.Forms.TextBox();
            this.tbStation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoHp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTanggalKembali = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(591, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 29);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(591, 382);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(173, 29);
            this.btnSimpan.TabIndex = 32;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbNim
            // 
            this.tbNim.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNim.Location = new System.Drawing.Point(355, 178);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(290, 28);
            this.tbNim.TabIndex = 30;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNama.Location = new System.Drawing.Point(355, 127);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(290, 28);
            this.tbNama.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "NIM Peminjam :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nama Peminjam :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tanggal Peminjaman :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(96, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tanggal Pengembalian :";
            // 
            // dtpTanggalPinjam
            // 
            this.dtpTanggalPinjam.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalPinjam.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTanggalPinjam.Location = new System.Drawing.Point(354, 276);
            this.dtpTanggalPinjam.Name = "dtpTanggalPinjam";
            this.dtpTanggalPinjam.Size = new System.Drawing.Size(290, 28);
            this.dtpTanggalPinjam.TabIndex = 34;
            this.dtpTanggalPinjam.ValueChanged += new System.EventHandler(this.dtpTanggalPinjam_ValueChanged);
            // 
            // tbKodeSepeda
            // 
            this.tbKodeSepeda.Enabled = false;
            this.tbKodeSepeda.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKodeSepeda.Location = new System.Drawing.Point(355, 78);
            this.tbKodeSepeda.Name = "tbKodeSepeda";
            this.tbKodeSepeda.Size = new System.Drawing.Size(290, 28);
            this.tbKodeSepeda.TabIndex = 28;
            // 
            // tbStation
            // 
            this.tbStation.Enabled = false;
            this.tbStation.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStation.Location = new System.Drawing.Point(354, 30);
            this.tbStation.Name = "tbStation";
            this.tbStation.Size = new System.Drawing.Size(290, 28);
            this.tbStation.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kode Sepeda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Station :";
            // 
            // tbNoHp
            // 
            this.tbNoHp.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNoHp.Location = new System.Drawing.Point(354, 230);
            this.tbNoHp.Name = "tbNoHp";
            this.tbNoHp.Size = new System.Drawing.Size(290, 28);
            this.tbNoHp.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(96, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "No. Handphone :";
            // 
            // dtpTanggalKembali
            // 
            this.dtpTanggalKembali.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalKembali.Enabled = false;
            this.dtpTanggalKembali.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTanggalKembali.Location = new System.Drawing.Point(354, 320);
            this.dtpTanggalKembali.Name = "dtpTanggalKembali";
            this.dtpTanggalKembali.Size = new System.Drawing.Size(290, 28);
            this.dtpTanggalKembali.TabIndex = 37;
            this.dtpTanggalKembali.ValueChanged += new System.EventHandler(this.tanggalKembali_ValueChanged);
            // 
            // AddPenggunaSepeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.dtpTanggalKembali);
            this.Controls.Add(this.tbNoHp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTanggalPinjam);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbKodeSepeda);
            this.Controls.Add(this.tbStation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPenggunaSepeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPenggunaSepeda";
            this.Load += new System.EventHandler(this.AddPenggunaSepeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        public TextBox tbStation;
        public TextBox tbKodeSepeda;
        private Label label7;
        public TextBox tbNama;
        public TextBox tbNim;
        public DateTimePicker dtpTanggalPinjam;
        public TextBox tbNoHp;
        public DateTimePicker dtpTanggalKembali;
        public Button btnSimpan;
        public Button btnUpdate;
    }
}