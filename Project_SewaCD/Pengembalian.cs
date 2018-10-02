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
    public partial class Pengembalian : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sewa_cd";

        public Pengembalian()
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

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
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

        string id_pinjam, batas_pinjam, tgl_pinjam, id_cd, tgl_kembali;
        int diskon = 0;

        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in bunifuCustomDataGrid1.SelectedRows)
            {
                id_cd = row.Cells[1].Value.ToString();
                id_pinjam = row.Cells[2].Value.ToString();
                tgl_pinjam = row.Cells[3].Value.ToString();
                batas_pinjam = row.Cells[4].Value.ToString();
                tgl_kembali = row.Cells[5].Value.ToString();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            cekKodePromo();
            string harga = "SELECT `harga` FROM `peminjaman` WHERE `id_pinjam`=" + id_pinjam;

            MySqlDataReader reader;
            MySqlCommand commandDatabase;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(harga, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                string temp = reader.GetString(0);
                int hargaCD = Convert.ToInt32(temp);
                databaseConnection.Close();

                DateTime now = DateTime.Now;

                DateTime batas = Convert.ToDateTime(batas_pinjam);
                DateTime pinjam = Convert.ToDateTime(tgl_pinjam);
                int telat = Convert.ToInt32(Math.Floor((now - batas).TotalDays));
                int masaPinjam = Convert.ToInt32(Math.Floor((now - pinjam).TotalDays));

                if (telat < 0)
                {
                    telat = 0;
                }
                string query = "UPDATE `peminjaman` SET `tgl_kembali` = '" + now.ToString("MM-dd-yyyy hh:mm:ss") +
                "', `denda` = '" + (telat * 1000) + "', `diskon` = '" + diskon + "', `total` = '" +
                (((masaPinjam * hargaCD) - (masaPinjam * hargaCD * ((double)diskon / 100))) + (telat * 1000)) +
                "' WHERE `id_pinjam`=" + id_pinjam;

                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (tgl_kembali.Equals("-"))
                {
                    cddikembalikan();
                    MessageBox.Show("Pengembalian Sukses!");
                }
                else
                {
                    MessageBox.Show("CD telah dikembalikan");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengembalian Gagal / Error");
            }

        }

        private void cddikembalikan()
        {
            string getStock = "SELECT `stock` FROM `cd` WHERE `cd_id`= " + id_cd;
            MySqlDataReader reader;
            MySqlCommand commandDatabase;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(getStock, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                int stock = reader.GetInt32(0);
                databaseConnection.Close();
                stock += 1;
                string updateStock = "UPDATE `cd` SET `stock` = " + stock + " WHERE `cd_id`=" + id_cd;

                commandDatabase = new MySqlCommand(updateStock, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void cekKodePromo()
        {
            string cekkode = "SELECT `kuota_promo`, `besar_diskon` FROM `diskon` WHERE `kode_diskon`='" + bunifuMaterialTextbox1.Text + "'";
            MySqlDataReader reader;
            MySqlCommand commandDatabase;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(cekkode, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                int kuota = reader.GetInt32(0);
                diskon = reader.GetInt32(1);
                databaseConnection.Close();

                if (kuota > 0)
                {
                    kuota -= 1;
                }
                string updateKuota = "UPDATE `diskon` SET `kuota_promo` = '" + kuota + "' WHERE `kode_diskon`='" + bunifuMaterialTextbox1.Text + "'";

                commandDatabase = new MySqlCommand(updateKuota, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Berhasil Mendapatkan Promo!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kode Promo Tidak Tersedia");
            }
        }
    }
}
