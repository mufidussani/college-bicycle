using Geocoding.Google;
using Geocoding;
using Newtonsoft.Json;
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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using CollegeBicycle.Entity;
using CollegeBicycle.Repository;

namespace CollegeBicycle
{
    public partial class AddSepeda : Form
    {
        readonly private SepedaRepository newSepeda = new SepedaRepository();
        public string latlong;
        Bicycle bicycle;
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c2ftykohxpnw.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        internal string? idsepeda;

        public AddSepeda()
        {
            InitializeComponent();
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
            if(lblLatLong.Text != string.Empty)
            {
                try
                {
                    Bicycle bicycle = new Bicycle();
                    //getLatLong();
                    conn.Open();
                    sql = @"select * from insert_sepeda(:_id_station, :_nama_station, :_kode_sepeda, :_lokasi_sepeda, :_ketersediaan_sepeda)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_station", comboBoxStation.SelectedIndex);
                    cmd.Parameters.AddWithValue("_nama_station", comboBoxStation.Text);
                    cmd.Parameters.AddWithValue("_kode_sepeda", tbKodeSepeda.Text);
                    cmd.Parameters.AddWithValue("_lokasi_sepeda", lblLatLong.Text);
                    cmd.Parameters.AddWithValue("_ketersediaan_sepeda", comboBoxKetersediaan.Text);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Sepeda Berhasil Ditambahkan!", "", MessageBoxButtons.OK);
                        conn.Close();
                        tbKodeSepeda = tbLokasiSepeda = null;
                    }
                    else
                    {
                        MessageBox.Show("Cek Kembali Lokasi Sepeda!", "Penambahan Sepeda Gagal", MessageBoxButtons.OK);
                    }
                    UpdateDgv();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Penambahan Sepeda Gagal!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Silakan Cek Koordinat Sepeda", "Penambahan Sepeda Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
        public static string getLat(string adresse)
        {
            string APIKEY = "AIzaSyASXZxJtgbVSoeUtoSULejLYt4F8OzxoTA";
            var requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(adresse), APIKEY);

            var request = WebRequest.Create(requestUri);
            var response = request.GetResponse();
            var xdoc = XDocument.Load(response.GetResponseStream());

            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var lat = locationElement.Element("lat");
            var lng = locationElement.Element("lng");
            string latitude = lat.ToString();
            string longitude = lng.ToString();
            //float floatLatitude = float.Parse(latitude);
            //float absLatitude = Math.Abs(floatLatitude);
            //float floatLongitude = float.Parse(longitude);
            //float absLongitude = Math.Abs(floatLongitude);
            //string coord = + absLatitude + ", " + absLongitude;
           
            string coord = latitude + ", " + longitude;
            string cleanString = Regex.Replace(coord, @"[^0-9-., ]", "");
            return cleanString;
        }

        private void btnKoordinat_Click(object sender, EventArgs e)
        {
            string address = tbLokasiSepeda.Text;
            getLat(address);
            lblLatLong.Text = getLat(address);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Bicycle bicycle = new Bicycle();
                int id = int.Parse(idsepeda);
                newSepeda.Update(id, comboBoxStation.SelectedIndex, comboBoxStation.Text, tbKodeSepeda.Text, lblLatLong.Text, comboBoxKetersediaan.Text);
                MessageBox.Show("Pengguna Sepeda berhasil diubah");
                //UpdateDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Ubah Data Sepeda Gagal!", MessageBoxButtons.OK);
            }
        }
        public void UpdateDgv()
        {
            Bicycle bicycle = new Bicycle();
            List<Sepeda> ListSepeda = newSepeda.GetSpesificStation(comboBoxStation.SelectedIndex);
            bicycle.dgvSepeda.DataSource = ListSepeda;
        }
    }
}
