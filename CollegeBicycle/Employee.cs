using CollegeBicycle.Entity;
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
    
    public partial class Employee : Form
    {
        //AddPengelola addpengelola = new AddPengelola();

        public Employee()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Employee_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            //conn.Open();
            //try
            //{
            //    dgvEmployee.DataSource = null;
            //    sql = "select * from st_select()";
            //    cmd = new NpgsqlCommand(sql, conn);
            //    dt = new DataTable();
            //    NpgsqlDataReader rd = cmd.ExecuteReader();
            //    dt.Load(rd);
            //    dgvEmployee.DataSource = dt;

            //    conn.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error:" + ex.Message, "Gagal memuat data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            AddPengelola f2 = new AddPengelola(this);   
            f2.ShowDialog();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvEmployee.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvEmployee.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Gagal memuat data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
