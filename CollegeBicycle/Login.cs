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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=sanisani19;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from pengelola_login(:_username,:_password)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_username", tbUsername.Text);
                cmd.Parameters.AddWithValue("_password", tbPassword.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if(result == 1)
                {
                    MessageBox.Show("Login Berhasil! Selamat datang " + tbUsername.Text);
                    this.Hide();
                    new CollegeBicycle().Show();
                }
                else
                {
                    MessageBox.Show("Login Gagal!", "Silakan Ulangi Kembali", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
