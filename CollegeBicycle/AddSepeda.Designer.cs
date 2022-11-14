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
            this.SuspendLayout();
            // 
            // tbKodeSepeda
            // 
            this.tbKodeSepeda.Location = new System.Drawing.Point(412, 181);
            this.tbKodeSepeda.Name = "tbKodeSepeda";
            this.tbKodeSepeda.Size = new System.Drawing.Size(290, 27);
            this.tbKodeSepeda.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kode Sepeda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Station :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(529, 305);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(173, 29);
            this.btnSimpan.TabIndex = 34;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(412, 117);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(290, 28);
            this.comboBoxStation.TabIndex = 36;
            this.comboBoxStation.SelectedIndexChanged += new System.EventHandler(this.comboBoxStation_SelectedIndexChanged);
            // 
            // tbLokasiSepeda
            // 
            this.tbLokasiSepeda.Location = new System.Drawing.Point(412, 246);
            this.tbLokasiSepeda.Name = "tbLokasiSepeda";
            this.tbLokasiSepeda.Size = new System.Drawing.Size(290, 27);
            this.tbLokasiSepeda.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(154, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Lokasi Sepeda :";
            // 
            // AddSepeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
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

        private TextBox tbKodeSepeda;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private ComboBox comboBoxStation;
        private TextBox tbLokasiSepeda;
        private Label label3;
    }
}