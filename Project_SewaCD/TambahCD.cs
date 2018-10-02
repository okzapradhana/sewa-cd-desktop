using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project_SewaCD
{
    public partial class TambahCD : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";


        public TambahCD()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PeminjamanAdmin peminjamanAdmin = new PeminjamanAdmin();
            this.Hide();
            peminjamanAdmin.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            string query1 = "INSERT INTO cd(`cd_name`,`stock`,`harga`) VALUES ('" +
                bunifuMaterialTextboxJudul.Text + "', '" + bunifuMaterialTextboxStok.Text + "', '" + Convert.ToInt32(bunifuMaterialTextboxHarga.Text) + "')";
            
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query1, databaseConnection);
            MySqlDataReader myReader;
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Tambah CD Sukses");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
