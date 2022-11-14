using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeBicycle
{
    public partial class Bicycle : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=mufidussani;Password=mufidussani;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public Bicycle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahSepeda_Click(object sender, EventArgs e)
        {
            AddSepeda addsepeda = new AddSepeda(this);
            addsepeda.Show();
        }

        private void Bicycle_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            //combo box station
            sql = "select * from station";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Station");
            comboBoxStation.DisplayMember = "nama_station";
            comboBoxStation.ValueMember = "id_station";
            comboBoxStation.DataSource = ds.Tables["Station"];

            //dgvsepeda
            dgvSepeda.DataSource = null;
            sql = "select * from select_sepeda()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvSepeda.DataSource = dt;
            conn.Close();
            
        }
    }
}
