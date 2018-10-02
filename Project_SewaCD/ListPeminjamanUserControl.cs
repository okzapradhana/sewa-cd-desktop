using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_SewaCD
{
    public partial class ListPeminjamanUserControl : UserControl
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";
        String username;

        public ListPeminjamanUserControl()
        {
            InitializeComponent();
        }

        public void callListUser(String user)
        {
            username = user;
        }

        private void bunifuThinButtonTampilkan_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM peminjaman WHERE username='" + username+"'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
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
                        dataTable.Rows.Add(reader[0], reader[1], reader[2],
                            reader[3], reader[4], reader[5],
                            reader[6], reader[7], reader[8],
                            reader[9]);
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
    }
}
