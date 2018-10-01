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
        public LamanUser()
        {
            InitializeComponent();
            listCDUserControl1.BringToFront();
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
        }
    }
}
