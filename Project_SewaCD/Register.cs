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
    public partial class Register : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";
        int i;

        public Register()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
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
                if (!String.IsNullOrEmpty(bunifuMaterialTextbox1.Text) && !String.IsNullOrEmpty(bunifuMaterialTextbox2.Text))
                {
                    string query = "INSERT INTO user(`username`,`password`) VALUES ('" +
                    bunifuMaterialTextbox1.Text + "', '" + bunifuMaterialTextbox2.Text + "')";

                    MySqlCommand commandDatabase = new MySqlCommand(query, con);
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("User succesfully registered");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password Null");
                }
            }
            else
            {
                MessageBox.Show("Username already registered!"); 

            }

            con.Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void panel123_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
