using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateDashboardAdmin_CSharp
{
    internal class DbBarang
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=plinplan";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            } catch (MySqlException e)
            {
                MessageBox.Show("MySQL Connection! \n"+e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void DisplayAndSearch(string query, DataGridView  dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void AddBarang(Barang std)
        {
            MySqlConnection con = GetConnection();

            try
            {
                con.Open();

                // Step 1: Retrieve the last Kode from the ITEMS table
                string getLastKodeSql = "SELECT Kode FROM items ORDER BY id DESC LIMIT 1";
                MySqlCommand getLastKodeCmd = new MySqlCommand(getLastKodeSql, con);
                object result = getLastKodeCmd.ExecuteScalar();
                string lastKode = result != null ? result.ToString() : "0";

                // Assuming Kode is an integer, generate the new Kode
                int newKode = int.Parse(lastKode) + 1;
                std.Kode = newKode.ToString();

                // Step 2: Insert the new record with the generated Kode
                string sql = "INSERT INTO items (Nama, Kategori, Deskripsi, Stok, HargaInbound, HargaOutbound, Kode, Email) VALUES (@BarangNama, @BarangKategori, @BarangDeskripsi, @BarangStok, @BarangHargaInbound, @BarangHargaOutbound, @BarangKode, @BarangEmail)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@BarangNama", MySqlDbType.VarChar).Value = std.Nama;
                cmd.Parameters.Add("@BarangKategori", MySqlDbType.VarChar).Value = std.Kategori;
                cmd.Parameters.Add("@BarangDeskripsi", MySqlDbType.VarChar).Value = std.Deskripsi;
                cmd.Parameters.Add("@BarangStok", MySqlDbType.Int32).Value = std.Stok;
                cmd.Parameters.Add("@BarangHargaInbound", MySqlDbType.Decimal).Value = std.HargaInbound;
                cmd.Parameters.Add("@BarangHargaOutbound", MySqlDbType.Decimal).Value = std.HargaOutbound;
                cmd.Parameters.Add("@BarangKode", MySqlDbType.VarChar).Value = std.Kode;
                cmd.Parameters.Add("@BarangEmail", MySqlDbType.VarChar).Value = std.Email;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void UpdateBarang(Barang std)
        {
            string sql = "UPDATE items SET Nama = @BarangNama, Kategori = @BarangKategori, Deskripsi = @BarangDeskripsi, Stok = @BarangStok, HargaInbound = @BarangHargaInbound, HargaOutbound = @BarangHargaOutbound, Email = @BarangEmail WHERE Kode = @BarangKode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@BarangNama", MySqlDbType.VarChar).Value = std.Nama;
            cmd.Parameters.Add("@BarangKategori", MySqlDbType.VarChar).Value = std.Kategori;
            cmd.Parameters.Add("@BarangDeskripsi", MySqlDbType.VarChar).Value = std.Deskripsi;
            cmd.Parameters.Add("@BarangStok", MySqlDbType.Int32).Value = std.Stok;
            cmd.Parameters.Add("@BarangHargaInbound", MySqlDbType.Decimal).Value = std.HargaInbound;
            cmd.Parameters.Add("@BarangHargaOutbound", MySqlDbType.Decimal).Value = std.HargaOutbound;
            cmd.Parameters.Add("@BarangEmail", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@BarangKode", MySqlDbType.VarChar).Value = std.Kode;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void DeleteBarang(string kode)
        {
            string sql = "DELETE FROM items WHERE Kode = @BarangKode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@BarangKode", MySqlDbType.VarChar).Value = kode;

            try
            {   
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
