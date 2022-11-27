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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeBicycle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=database-2.c2ftykohxpnw.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=college-bicycle";
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
                    CollegeBicycle collegebicycle = new CollegeBicycle(tbUsername.Text);
                    collegebicycle.ShowDialog();
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
        }
    }
}
