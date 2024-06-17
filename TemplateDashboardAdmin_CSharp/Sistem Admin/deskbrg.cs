using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateDashboardAdmin_CSharp
{
    public partial class deskbrg : Form
    {

        int kode;
        string nama;
        string deskripsi;
        int stok;
        float inbound;
        float outbound;
        int kategori = 0;
        string[] categories = {"Makanan", "Minuman","Rokok","Lainnya" };

        private void resetKategori()
        {
            makanan.BackColor = System.Drawing.Color.White;
            minuman.BackColor = System.Drawing.Color.White;
            rokok.BackColor = System.Drawing.Color.White;
            lainnya.BackColor = System.Drawing.Color.White;
        }
        public deskbrg(int kode, string nama, string deskripsi, int kategori, int stok, float inbound, float outbound)
        {
            InitializeComponent();
            this.kode = kode;
            this.nama = nama_brg.Text = nama;
            this.deskripsi = deskripsi_brg.Text = deskripsi;
            this.stok = stok;
            this.inbound = inbound;
            this.outbound = outbound;
            this.kategori = kategori;
            stok_brg.Text = stok.ToString();
            inbound_brg.Text = inbound.ToString();
            outbound_brg.Text = outbound.ToString();

            if (kategori == 0)
            {
                makanan.BackColor = System.Drawing.Color.Salmon;
            } else if (kategori == 1)
            {
                minuman.BackColor = System.Drawing.Color.Salmon;

            } else if (kategori == 2)
            {
                rokok.BackColor = System.Drawing.Color.Salmon;
            } else
            {
                lainnya.BackColor = System.Drawing.Color.Salmon;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deskbrg_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deskripsi_brg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
