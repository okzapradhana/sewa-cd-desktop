using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";
        int i;

        public Login()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bunifuFormDock2_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user where username='" + bunifuMaterialTextbox1.Text + "' and password='" + bunifuMaterialTextbox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dataset = new MySqlDataAdapter(cmd);
            dataset.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
               MessageBox.Show("Username dan Password invalid!");
            }
            else
            {
                if (bunifuMaterialTextbox1.Text.Equals("admin"))
                {
                    this.Hide();
                    PeminjamanAdmin peminjamanAdmin = new PeminjamanAdmin();
                    peminjamanAdmin.Show();
                }
                else
                {
                    this.Hide();
                    LamanUser frm2 = new LamanUser(bunifuMaterialTextbox1.Text);
                    frm2.Show();
                }

            }

            con.Close();
        }
    }
}
