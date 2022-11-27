namespace CollegeBicycle
{
    partial class AddSepeda
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
            this.tbKodeSepeda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.tbLokasiSepeda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKoordinat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLatLong = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxKetersediaan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbKodeSepeda
            // 
            this.tbKodeSepeda.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKodeSepeda.Location = new System.Drawing.Point(392, 137);
            this.tbKodeSepeda.Name = "tbKodeSepeda";
            this.tbKodeSepeda.Size = new System.Drawing.Size(290, 27);
            this.tbKodeSepeda.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kode Sepeda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Station :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(608, 363);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(173, 29);
            this.btnSimpan.TabIndex = 34;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(392, 73);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(290, 33);
            this.comboBoxStation.TabIndex = 36;
            this.comboBoxStation.SelectedIndexChanged += new System.EventHandler(this.comboBoxStation_SelectedIndexChanged);
            // 
            // tbLokasiSepeda
            // 
            this.tbLokasiSepeda.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLokasiSepeda.Location = new System.Drawing.Point(392, 202);
            this.tbLokasiSepeda.Name = "tbLokasiSepeda";
            this.tbLokasiSepeda.Size = new System.Drawing.Size(290, 27);
            this.tbLokasiSepeda.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(134, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Lokasi Sepeda :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ketersediaan Sepeda :";
            // 
            // btnKoordinat
            // 
            this.btnKoordinat.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKoordinat.Location = new System.Drawing.Point(713, 187);
            this.btnKoordinat.Name = "btnKoordinat";
            this.btnKoordinat.Size = new System.Drawing.Size(96, 61);
            this.btnKoordinat.TabIndex = 41;
            this.btnKoordinat.Text = "Tampilkan\r\nKoordinat";
            this.btnKoordinat.UseVisualStyleBackColor = true;
            this.btnKoordinat.Click += new System.EventHandler(this.btnKoordinat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(135, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Koordinat Sepeda :";
            // 
            // lblLatLong
            // 
            this.lblLatLong.AutoSize = true;
            this.lblLatLong.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLatLong.Location = new System.Drawing.Point(392, 263);
            this.lblLatLong.Name = "lblLatLong";
            this.lblLatLong.Size = new System.Drawing.Size(0, 25);
            this.lblLatLong.TabIndex = 43;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(608, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 29);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxKetersediaan
            // 
            this.comboBoxKetersediaan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKetersediaan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKetersediaan.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxKetersediaan.FormattingEnabled = true;
            this.comboBoxKetersediaan.Items.AddRange(new object[] {
            "Tersedia",
            "Tidak Tersedia"});
            this.comboBoxKetersediaan.Location = new System.Drawing.Point(392, 308);
            this.comboBoxKetersediaan.Name = "comboBoxKetersediaan";
            this.comboBoxKetersediaan.Size = new System.Drawing.Size(290, 33);
            this.comboBoxKetersediaan.TabIndex = 45;
            this.comboBoxKetersediaan.Text = "Tersedia";
            // 
            // AddSepeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.comboBoxKetersediaan);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblLatLong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKoordinat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLokasiSepeda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStation);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbKodeSepeda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSepeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSepeda";
            this.Load += new System.EventHandler(this.AddSepeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnKoordinat;
        private Label label5;
        public TextBox tbKodeSepeda;
        public ComboBox comboBoxStation;
        public TextBox tbLokasiSepeda;
        public Label lblLatLong;
        public ComboBox comboBoxKetersediaan;
        public Button btnUpdate;
        public Button btnSimpan;
    }
}