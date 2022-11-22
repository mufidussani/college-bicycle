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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbConfirm.Text == tbCreatePassword.Text)
            {
                if (tbCreateUsername.Text != string.Empty || tbCreatePassword.Text != string.Empty)
                {
                    try
                    {
                        conn.Open();
                        sql = @"select * from pengelola_signup(:_username,:_password)";
                        cmd = new NpgsqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("_username", tbCreateUsername.Text);
                        cmd.Parameters.AddWithValue("_password", tbCreatePassword.Text);

                        int result = (int)cmd.ExecuteScalar();

                        conn.Close();

                        if (result == 1)
                        {
                            MessageBox.Show("Sign Up Berhasil! Selamat datang " + tbCreateUsername.Text);
                            this.Hide();
                            new Login().Show();
                        }
                        else
                        {
                            MessageBox.Show("Sign Up Gagal!", "Silakan Ulangi Kembali", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sign Up Gagal!", "Silakan Cek Username atau Password Kembali", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
