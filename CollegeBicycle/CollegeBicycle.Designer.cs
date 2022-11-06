namespace CollegeBicycle
{
    partial class CollegeBicycle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeBicycle));
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBicycle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.lblTitleApp = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.Location = new System.Drawing.Point(4, 288);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(62, 62);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.Location = new System.Drawing.Point(4, 219);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(62, 62);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnBicycle
            // 
            this.btnBicycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.btnBicycle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBicycle.FlatAppearance.BorderSize = 0;
            this.btnBicycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBicycle.Image = ((System.Drawing.Image)(resources.GetObject("btnBicycle.Image")));
            this.btnBicycle.Location = new System.Drawing.Point(4, 156);
            this.btnBicycle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(62, 56);
            this.btnBicycle.TabIndex = 7;
            this.btnBicycle.UseVisualStyleBackColor = false;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.btnHomepage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHomepage.FlatAppearance.BorderSize = 0;
            this.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomepage.Image = global::CollegeBicycle.Properties.Resources.logo_home2;
            this.btnHomepage.Location = new System.Drawing.Point(4, 85);
            this.btnHomepage.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(62, 65);
            this.btnHomepage.TabIndex = 6;
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.panelSide.Controls.Add(this.btnEmployee);
            this.panelSide.Controls.Add(this.btnUsers);
            this.panelSide.Controls.Add(this.btnBicycle);
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Controls.Add(this.btnHomepage);
            this.panelSide.Location = new System.Drawing.Point(0, -1);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(70, 564);
            this.panelSide.TabIndex = 3;
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::CollegeBicycle.Properties.Resources.frame_profile;
            this.pbProfile.Location = new System.Drawing.Point(696, 12);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(56, 56);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 2;
            this.pbProfile.TabStop = false;
            // 
            // lblTitleApp
            // 
            this.lblTitleApp.AutoSize = true;
            this.lblTitleApp.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleApp.Location = new System.Drawing.Point(58, 15);
            this.lblTitleApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleApp.Name = "lblTitleApp";
            this.lblTitleApp.Size = new System.Drawing.Size(232, 42);
            this.lblTitleApp.TabIndex = 2;
            this.lblTitleApp.Text = "College Bicycle";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panelTop.Controls.Add(this.lblProfile);
            this.panelTop.Controls.Add(this.pbProfile);
            this.panelTop.Controls.Add(this.lblTitleApp);
            this.panelTop.Location = new System.Drawing.Point(70, -1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(930, 76);
            this.panelTop.TabIndex = 2;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.Location = new System.Drawing.Point(764, 26);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(127, 28);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "Dinda Sabela";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(70, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(930, 489);
            this.panelDesktop.TabIndex = 4;
            // 
            // CollegeBicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelDesktop);
            this.Name = "CollegeBicycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CollegeBicycle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CollegeBicycle_FormClosed);
            this.Load += new System.EventHandler(this.CollegeBicycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEmployee;
        private Button btnUsers;
        private Button btnBicycle;
        private PictureBox pictureBox1;
        private Button btnHomepage;
        private Panel panelSide;
        private PictureBox pbProfile;
        private Label lblTitleApp;
        private Panel panelTop;
        private Label lblProfile;
        private Panel panelDesktop;
    }
}