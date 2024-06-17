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

        public static string GetCurrentUnixTime11Length()
        {
            // Get the current Unix time in seconds since the epoch
            long unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            // Convert it to a string
            string unixTimeString = unixTime.ToString();

            // Ensure the length is exactly 11 characters
            if (unixTimeString.Length > 11)
            {
                unixTimeString = unixTimeString.Substring(0, 11); // Trim if longer than 11 characters
            }
            else if (unixTimeString.Length < 11)
            {
                unixTimeString = unixTimeString.PadLeft(11, '0'); // Pad with leading zeros if shorter than 11 characters
            }

            return unixTimeString;
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

                // Step 1: Retrieve the last Kode from the ITEMS table
                string getLastKodeSql = "SELECT Kode FROM items ORDER BY id DESC LIMIT 1";
                MySqlCommand getLastKodeCmd = new MySqlCommand(getLastKodeSql, con);
                object result = getLastKodeCmd.ExecuteScalar();
                string lastKode = result != null ? result.ToString() : "0";

                // Assuming Kode is an integer, generate the new Kode
                int newKode = int.Parse(lastKode) + 1;
                std.Kode = newKode.ToString();

                // Step 2: Insert the new record with the generated Kode
                string sql = "INSERT INTO items (nama, kategori, desk, stok, harga_awal, harga_jual, kode, email) VALUES (@BarangNama, @BarangKategori, @BarangDeskripsi,   @BarangStok, @BarangHargaInbound, @BarangHargaOutbound, @BarangKode, 'email@gmail.com')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@BarangNama", MySqlDbType.VarChar).Value = std.Nama;
                cmd.Parameters.Add("@BarangKategori", MySqlDbType.VarChar).Value = std.Kategori;
                cmd.Parameters.Add("@BarangDeskripsi", MySqlDbType.VarChar).Value = std.Deskripsi;
                cmd.Parameters.Add("@BarangStok", MySqlDbType.Int32).Value = std.Stok;
                cmd.Parameters.Add("@BarangHargaInbound", MySqlDbType.Decimal).Value = std.HargaInbound;
                cmd.Parameters.Add("@BarangHargaOutbound", MySqlDbType.Decimal).Value = std.HargaOutbound;
                cmd.Parameters.Add("@BarangKode", MySqlDbType.Int32).Value = GetCurrentUnixTime11Length();
                cmd.Parameters.Add("@BarangEmail", MySqlDbType.VarChar).Value = "email@gmail.com";
                MessageBox.Show("Nama: "+std.Nama+"Kategori: "+std.Kategori+"DESKRIPSI : "+std.Deskripsi+"STOK : "+std.Stok+"INBOUND: "+std.HargaInbound+"OUTBOUND: "+std.HargaOutbound+"KODE : "+newKode.ToString()+"email"+std.Email);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
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
        public static void DeleteBarang(int kode)
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
