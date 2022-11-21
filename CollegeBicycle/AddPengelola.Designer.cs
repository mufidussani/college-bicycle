namespace CollegeBicycle
{
    partial class AddPengelola
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbNip = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(483, 343);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(173, 29);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // tbNip
            // 
            this.tbNip.Location = new System.Drawing.Point(366, 146);
            this.tbNip.Name = "tbNip";
            this.tbNip.Size = new System.Drawing.Size(290, 27);
            this.tbNip.TabIndex = 23;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(366, 89);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(290, 27);
            this.tbNama.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(108, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "NIP Pengelola :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama Pengelola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Station :";
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(366, 202);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(290, 28);
            this.cbStation.TabIndex = 27;
            this.cbStation.SelectedIndexChanged += new System.EventHandler(this.cbStation_SelectedIndexChanged);
            // 
            // AddPengelola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbNip);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AddPengelola";
            this.Text = "AddPengelola";
            this.Load += new System.EventHandler(this.AddPengelola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSimpan;
        private TextBox tbNip;
        private TextBox tbNama;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cbStation;
    }
}