using CollegeBicycle.Entity;
using CollegeBicycle.Repository;
using Npgsql;
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
    public partial class Users : Form
    {
        readonly private StationRepository listStation = new StationRepository();
        readonly private PeminjamRepository listPeminjam = new PeminjamRepository();
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        public Users()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            List<Station> ListStation = listStation.GetAll();
            comboBoxStation.DataSource = ListStation;
            comboBoxStation.DisplayMember = "nama_station";

            List<Peminjam> ListPeminjam = listPeminjam.GetAll();
            dgvPeminjam.DataSource = ListPeminjam;
        }
    }
}
