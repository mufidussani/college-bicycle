using CollegeBicycle.Repository;
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
    public partial class AddPenggunaSepeda : Form
    {
        readonly private PeminjamRepository newPeminjam = new PeminjamRepository();
        public AddPenggunaSepeda()
        {
            InitializeComponent();
        }

        private void tanggalKembali_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddPenggunaSepeda_Load(object sender, EventArgs e)
        {
            dtpTanggalKembali.Value = dtpTanggalPinjam.Value.AddDays(1);
        }

        private void dtpTanggalPinjam_ValueChanged(object sender, EventArgs e)
        {
            dtpTanggalKembali.Value = dtpTanggalPinjam.Value.AddDays(1);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            newPeminjam.Add(tbStation.Text, tbKodeSepeda.Text, tbNama.Text, tbNim.Text, tbNoHp.Text, dtpTanggalPinjam.Value.ToString(), dtpTanggalKembali.Value.ToString());
            MessageBox.Show("Pengguna Sepeda berhasil ditambahkan");
        }
    }
}
