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
    public partial class CollegeBicycle : Form
    {
        private Form activeForm;
        public CollegeBicycle()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CollegeBicycle_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Homepage(), sender);
        }

        private void CollegeBicycle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bicycle(), sender);
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Homepage(), sender);
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfilPengelola(), sender);
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfilPengelola(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users(), sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employee(), sender);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
