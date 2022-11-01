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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Pengelola pengelola = new Pengelola(tbUsername.Text, tbPassword.Text);
            if(pengelola.Login())
            {
                MessageBox.Show("Login Berhasil! Selamat datang " + pengelola.PengelolaName.ToString());
                var homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal! Silakan Ulangi Kembali");
            }
        }
    }
}
