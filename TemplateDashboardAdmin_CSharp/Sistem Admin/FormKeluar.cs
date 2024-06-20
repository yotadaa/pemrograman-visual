using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateDashboardAdmin_CSharp.Sistem_Admin
{
    public partial class FormKeluar : Form
    {
        Barang std = new Barang();
        public FormKeluar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "123";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nama.Clear();
            jumlah.Clear();
            tanggal.Value = DateTime.Now; // Set to the current date and time
        }

        private void cekbrg_Click(object sender, EventArgs e)
        {
            DbBarang.GetBarang(idbrg_text.Text, this.std);
            nama.Text = std.Nama;
            totalLabel.Text = std.Stok.ToString();
            harga.Text = std.HargaOutbound.ToString();
        }

        private void jumlah_TextChanged(object sender, EventArgs e)
        {
            if (this.std.HargaOutbound != null)
            {
                int jumlahValue;
                if (!int.TryParse(jumlah.Text, out jumlahValue))
                {
                    jumlahValue = 0; // Default value if parsing fails
                }
                else jumlahValue = int.Parse(jumlah.Text);
                harga.Text = (jumlahValue * (float)this.std.HargaOutbound).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.std.Stok == null)
            {
                int jumlahValue;
                if (!int.TryParse(jumlah.Text, out jumlahValue))
                {
                } else
                {

                    MessageBox.Show("Barang tidak cukup!");
                }

            }
            else
            {
                int jumlahValue;
                if (!int.TryParse(jumlah.Text, out jumlahValue))
                {
                    jumlahValue = 0;
                }
                else jumlahValue = int.Parse(jumlah.Text);
                if (jumlahValue > this.std.Stok) MessageBox.Show("Barang Tidak Cukup");
                float total = jumlahValue * this.std.HargaOutbound;
                DateTime selectedTime = tanggal.Value;
                DbBarang.AddTransaksi(std,jumlahValue, total, selectedTime);
                DbBarang.UpdateBarang(std, -jumlahValue);
                MessageBox.Show("Success");
            }
        }
    }
}
