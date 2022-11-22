namespace CollegeBicycle
{
    partial class Maps
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.Latitude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(33, 109);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(848, 311);
            this.map.TabIndex = 0;
            this.map.Zoom = 2D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maps";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(33, 61);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(175, 27);
            this.txtLat.TabIndex = 2;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(230, 61);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(177, 27);
            this.txtLong.TabIndex = 3;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(430, 61);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(130, 29);
            this.btnMap.TabIndex = 4;
            this.btnMap.Text = "Cari Sepedanya!";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(33, 33);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(63, 20);
            this.Latitude.TabIndex = 5;
            this.Latitude.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longitude";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Name = "Maps";
            this.Text = "Maps";
            this.Load += new System.EventHandler(this.Maps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private Label label1;
        private TextBox txtLat;
        private TextBox txtLong;
        private Button btnMap;
        private Label Latitude;
        private Label label2;
    }
}