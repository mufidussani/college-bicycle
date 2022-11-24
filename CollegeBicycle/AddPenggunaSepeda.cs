using CollegeBicycle.Repository;
using Microsoft.VisualBasic.ApplicationServices;
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
        internal object id;

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
            Users user = new Users();
            newPeminjam.Add(tbStation.Text, tbKodeSepeda.Text, tbNama.Text, tbNim.Text, tbNoHp.Text, dtpTanggalPinjam.Value, dtpTanggalKembali.Value);
            MessageBox.Show("Pengguna Sepeda berhasil ditambahkan");
            user.UpdateDgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            { 
                Users user = new Users();
                newPeminjam.Update((int)id, tbStation.Text, tbKodeSepeda.Text, tbNama.Text, tbNim.Text, tbNoHp.Text, dtpTanggalPinjam.Value, dtpTanggalKembali.Value);
                MessageBox.Show("Pengguna Sepeda berhasil diubah");
                user.UpdateDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
