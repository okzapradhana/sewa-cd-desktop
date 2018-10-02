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
    public partial class PeminjamanAdmin : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";

        public PeminjamanAdmin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM peminjaman";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            commandDatabase.CommandTimeout = 60;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("ID CD");
            dataTable.Columns.Add("ID Pinjam");
            dataTable.Columns.Add("Tanggal Pinjam");
            dataTable.Columns.Add("Batas Pinjam");
            dataTable.Columns.Add("Tanggal Kembali");
            dataTable.Columns.Add("Harga");
            dataTable.Columns.Add("Denda");
            dataTable.Columns.Add("Disc(%)");
            dataTable.Columns.Add("Total");

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3), reader.GetString(4), reader.GetString(5),
                            reader.GetString(6), reader.GetString(7), reader.GetString(8),
                            reader.GetString(9));
                        bunifuCustomDataGrid1.DataSource = dataTable;
                    }
                }
                else
                {
                    Console.WriteLine("No rows found!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Pengembalian pengembalian = new Pengembalian();
            pengembalian.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            TambahCD tambahCD = new TambahCD();
            tambahCD.Show();
            this.Hide();
        }

        private void bunifuFlatButtonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
