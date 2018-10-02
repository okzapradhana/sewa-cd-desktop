using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SewaCD
{
    public partial class LamanUser : Form
    {
        String username;

        public LamanUser(String user)
        {
            InitializeComponent();
            listCDUserControl1.BringToFront();
            listCDUserControl1.callListUser(user);
            username = user;
        }

        public LamanUser()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButtonListCD_Click(object sender, EventArgs e)
        {
            listCDUserControl1.BringToFront();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButtonPeminjaman_Click(object sender, EventArgs e)
        {
            listPeminjamanUserControl1.BringToFront();
            listPeminjamanUserControl1.callListUser(username);
        }

        private void bunifuFlatButtonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
