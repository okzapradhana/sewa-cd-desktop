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
    public partial class ListCDUserControl : UserControl
    {
        public string username;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";
        String cdID, nama, stockCD, harga;

        public ListCDUserControl(String user)
        {
            InitializeComponent();
            username = user;
        }

        public void callListUser(String user)
        {
            username = user;
            bunifuCustomLabel2.Text = user;
        }

        public ListCDUserControl()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.SelectedRows)
            {
                cdID = row.Cells[0].Value.ToString();
                nama = row.Cells[1].Value.ToString();
                stockCD = row.Cells[2].Value.ToString();
                harga = row.Cells[3].Value.ToString();
            }
        }

        private void bunifuThinButtonTampilkan_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cd";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID CD");
            dataTable.Columns.Add("Judul");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Harga");

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
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

        private void bunifuThinButtonPinjam_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO peminjaman(`username`,`cd_id`,`id_pinjam`,`tgl_pinjam`,`batas_pinjam`,`tgl_kembali`,`harga`,`denda`,`diskon`,`total`) VALUES ('" +
            username + "', '" + cdID + "', NULL, '" + DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss") + "', '" + DateTime.Now.AddDays(+7).ToString("MM-dd-yyyy hh:mm:ss") + "','-','" + harga + "','0','0','0')";
            string query2 = "UPDATE `cd` SET `stock` = '" + (Convert.ToInt32(stockCD) - 1) + "' WHERE `cd_id`=" + cdID;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query1, databaseConnection);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            MySqlDataReader myReader;
            commandDatabase.CommandTimeout = 60;
            commandDatabase2.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();

                databaseConnection.Open();
                myReader = commandDatabase2.ExecuteReader();
                MessageBox.Show("Peminjaman Sukses!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bunifuThinButtonTampilkan_Click(sender, e);
            }
        }
    }
}
