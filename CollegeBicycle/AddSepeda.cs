using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeBicycle
{
    public partial class AddSepeda : Form
    {
        Bicycle bicycle;
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=mufidussani;Password=mufidussani;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public AddSepeda(Bicycle bicycle)
        {
            InitializeComponent();
            this.bicycle = bicycle;
        }

        private void comboBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStation.SelectedItem != null)
                {
                    DataRowView drv = comboBoxStation.SelectedItem as DataRowView;

                    Debug.WriteLine("Item: " + drv.Row["nama_station"].ToString());
                    Debug.WriteLine("Value: " + drv.Row["id_station"].ToString());
                    Debug.WriteLine("Value: " + comboBoxStation.SelectedValue.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK);
            }
        }

        private void AddSepeda_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from station";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Station");
            comboBoxStation.DisplayMember = "nama_station";
            comboBoxStation.ValueMember = "id_station";
            comboBoxStation.DataSource = ds.Tables["Station"];
            conn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from insert_sepeda(:_id_station, :_kode_sepeda, :_lokasi_sepeda)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_station", comboBoxStation.SelectedValue);
                cmd.Parameters.AddWithValue("_kode_sepeda", tbKodeSepeda.Text);
                cmd.Parameters.AddWithValue("_lokasi_sepeda", tbLokasiSepeda.Text);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Sepeda Berhasil Ditambahkan!", "", MessageBoxButtons.OK);
                    conn.Close();
                    tbKodeSepeda = tbLokasiSepeda = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Penambahan Sepeda Gagal!", MessageBoxButtons.OK);
            }
        }
    }
}
