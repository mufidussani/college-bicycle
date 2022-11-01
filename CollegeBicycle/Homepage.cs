using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CollegeBicycle
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            var login = new Login();
            login.Close();
            login.Dispose();
        }
    }
}
