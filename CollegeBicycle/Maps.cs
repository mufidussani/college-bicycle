using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeBicycle
{
    public partial class Maps : Form
    {
        public Maps()
        {
            
            InitializeComponent();
        }

        private void Maps_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Zoom = 18;
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.DragButton = MouseButtons.Left;
            double latUGM = Convert.ToDouble(-7.771282459713296);
            double longUGM = Convert.ToDouble(110.3775106671571);
            map.Position = new PointLatLng(latUGM, longUGM);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.Zoom = 18;
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.DragButton = MouseButtons.Left;
            double lat = Convert.ToDouble(txtLat.Text);
            double longitude = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longitude);
        }
    }
}
