using CollegeBicycle.Entity;
using CollegeBicycle.Repository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CollegeBicycle
{
    public partial class Bicycle : Form
    {
        AddPenggunaSepeda addpenggunasepeda = new AddPenggunaSepeda();
        AddSepeda addsepeda = new AddSepeda();
        Homepage homepage = new Homepage();
        readonly private SepedaRepository listSepeda = new SepedaRepository();
        readonly private StationRepository listStation = new StationRepository();
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        public Bicycle()
        {
            InitializeComponent();
            tbLokasi.Text = "";
            tbLokasi.ReadOnly = true;
            tbLokasi.BorderStyle = 0;
            tbLokasi.BackColor = this.BackColor;
            tbLokasi.TabStop = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahSepeda_Click(object sender, EventArgs e)
        {
            addsepeda.ShowDialog();
        }

        private void Bicycle_Load(object sender, EventArgs e)
        {
            
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            //combo box station
            //sql = "select * from station";
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Station");
            //comboBoxStation.DisplayMember = "nama_station";
            //comboBoxStation.ValueMember = "id_station";
            //comboBoxStation.DataSource = ds.Tables["Station"];
            List<Station> ListStation = listStation.GetAll();
            comboBoxStation.DataSource = ListStation;
            comboBoxStation.DisplayMember = "nama_station";

            //dgvsepeda
            //dgvSepeda.DataSource = null;
            //sql = "select * from select_sepeda()";
            //cmd = new NpgsqlCommand(sql, conn);
            //dt = new DataTable();
            //NpgsqlDataReader rd = cmd.ExecuteReader();
            //dt.Load(rd);
            //dgvSepeda.DataSource = dt;
            //conn.Close();

            //List<Sepeda> ListSepeda = listSepeda.GetAll();
            List<Sepeda> ListSepeda = listSepeda.GetSpesificStation(comboBoxStation.SelectedIndex);
            dgvSepeda.DataSource = ListSepeda;
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            addpenggunasepeda.btnUpdate.Visible = false;
            addpenggunasepeda.btnUpdate.Enabled = false;
            addpenggunasepeda.ShowDialog();
        }

        private void dgvSepeda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvSepeda.Rows[e.RowIndex];
                addpenggunasepeda.tbStation.Text = r.Cells["nama_station"].Value.ToString();
                addpenggunasepeda.tbKodeSepeda.Text = r.Cells["kode_sepeda"].Value.ToString();
                addsepeda.comboBoxStation.Text = r.Cells["nama_station"].Value.ToString();
                addsepeda.tbKodeSepeda.Text = r.Cells["kode_sepeda"].Value.ToString();
                addsepeda.tbLokasiSepeda.Text = r.Cells["lokasi_sepeda"].Value.ToString();
                addsepeda.comboBoxKetersediaan.Text = r.Cells["ketersediaan_sepeda"].Value.ToString();
                tbLokasi.Text = "Lokasi: " + r.Cells["lokasi_sepeda"].Value.ToString();
                lblKetersediaan.Text = "Tersedia: " + r.Cells["ketersediaan_sepeda"].Value.ToString();
            }
        }
        public void UpdateDgv()
        {
            List<Sepeda> ListSepeda = listSepeda.GetAll();
            dgvSepeda.DataSource = ListSepeda;
        }

        private void dgvSepeda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Apakah benar ingin menghapus data sepeda " + r.Cells["kode_sepeda"].Value.ToString() + "?", "Konfirmasi hapus data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var ids = dgvSepeda.Rows[e.RowIndex].Cells[0].Value;
                listSepeda.Delete((int)ids);
                MessageBox.Show("Hapus data berhasil!");

                UpdateDgv();
            }
        }

        private void comboBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sepeda> ListSepeda = listSepeda.GetSpesificStation(comboBoxStation.SelectedIndex);
            dgvSepeda.DataSource = ListSepeda;
        }
    }
}
