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
        AddPenggunaSepeda addpenggunasepeda = new AddPenggunaSepeda();
        readonly private StationRepository listStation = new StationRepository();
        readonly private PeminjamRepository listPeminjam = new PeminjamRepository();
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public DataGridViewRow r;
        private object ids;

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

            List<Peminjam> ListPeminjam = listPeminjam.GetSpesificStation(comboBoxStation.Text);
            dgvPeminjam.DataSource = ListPeminjam;
        }
        private void dgvPeminjam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addpenggunasepeda.id = dgvPeminjam.Rows[e.RowIndex].Cells[0].Value;
            if (e.RowIndex >= 0)
            {
                r = dgvPeminjam.Rows[e.RowIndex];
                addpenggunasepeda.tbStation.Text = r.Cells["nama_station"].Value.ToString();
                addpenggunasepeda.tbKodeSepeda.Text = r.Cells["kode_sepeda"].Value.ToString();
                addpenggunasepeda.tbNama.Text = r.Cells["nama_peminjam"].Value.ToString();
                addpenggunasepeda.tbNim.Text = r.Cells["nim_peminjam"].Value.ToString();
                addpenggunasepeda.tbNoHp.Text = r.Cells["no_hp"].Value.ToString();
                addpenggunasepeda.dtpTanggalPinjam.Text = r.Cells["tanggal_pinjam"].Value.ToString();
                addpenggunasepeda.dtpTanggalKembali.Text = r.Cells["tanggal_kembali"].Value.ToString();
            }
        }

        private void btnUpdateForm_Click(object sender, EventArgs e)
        {
            addpenggunasepeda.ShowDialog();
            UpdateDgv();
        }
        public void UpdateDgv()
        {
            List<Peminjam> ListPeminjam = listPeminjam.GetSpesificStation(comboBoxStation.Text);
            dgvPeminjam.DataSource = ListPeminjam;
        }

        private void dgvPeminjam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Apakah benar ingin menghapus data peminjam " + r.Cells["nama_peminjam"].Value.ToString() + "dengan kode sepeda " + r.Cells["kode_sepeda"] + "?", "Konfirmasi hapus data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var ids = dgvPeminjam.Rows[e.RowIndex].Cells[0].Value;
                listPeminjam.Delete((int)ids);
                MessageBox.Show("Hapus data berhasil!");

                UpdateDgv();
            }
        }

        private void comboBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Peminjam> ListPeminjam = listPeminjam.GetSpesificStation(comboBoxStation.Text);
            dgvPeminjam.DataSource = ListPeminjam;
        }
    }
}
