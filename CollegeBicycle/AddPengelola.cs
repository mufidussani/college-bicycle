using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeBicycle.Entity;
using Npgsql;

namespace CollegeBicycle
{
    public partial class AddPengelola : Form
    {
        Employee f1;
        //Employee employee;
        public AddPengelola(Employee employee)
        {
            InitializeComponent();
            this.f1 = employee;
        }
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void AddPengelola_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from station";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Station");
            cbStation.DisplayMember = "nama_station";
            cbStation.ValueMember = "id_station";
            cbStation.DataSource = ds.Tables["Station"];
            conn.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            

        }

        private void cbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbStation.SelectedItem != null)
                {
                    DataRowView drv = cbStation.SelectedItem as DataRowView;

                    Debug.WriteLine("Item: " + drv.Row["nama_station"].ToString());
                    Debug.WriteLine("Value: " + drv.Row["id_station"].ToString());
                    Debug.WriteLine("Value: " + cbStation.SelectedValue.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK);
            }
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            //Employee employee = new Employee();
            //employee.Show();
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_nama,:_nip,:_station)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_nip", tbNip.Text);
                cmd.Parameters.AddWithValue("_station", cbStation.Text);

                conn.Close();

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Sepeda Berhasil Ditambahkan!", "", MessageBoxButtons.OK);
                    this.Hide();
                    Employee employee = new Employee();
                    employee.Show();
                }
                else
                {
                    MessageBox.Show("Login Gagal!", "Silakan Ulangi Kembali", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Penambahan Sepeda Gagal!", MessageBoxButtons.OK);
                conn.Close();
            }
        }
    }
}
