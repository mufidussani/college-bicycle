using CollegeBicycle.Entity;
using CollegeBicycle.Repository;
using GMap.NET;
using GMap.NET.MapProviders;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CollegeBicycle
{
    public partial class Homepage : Form
    {
        readonly private PeminjamRepository listPeminjam = new PeminjamRepository();
        private NpgsqlConnection conn;
        string connstring = "Host=database-2.c2ftykohxpnw.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=college-bicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public Homepage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            //map.MapProvider = GMapProviders.GoogleMap;
            //map.Position = new PointLatLng(lat, long);
            //map.Zoom = 18;
            //map.MinZoom = 10;
            //map.DragButton = MouseButtons.Left;
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            List<Peminjams> ListPeminjam = listPeminjam.GetPengguna();
            dgvPenggunaHome.DataSource = ListPeminjam;
            conn.Close();
        }
        private void closeButton_Click(object sender, System.EventArgs e)
        {

        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPenggunaHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
