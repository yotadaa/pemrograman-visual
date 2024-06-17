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
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            DbBarang.DisplayAndSearch("select  nama, desk, kategori,stok,harga_awal, harga_jual FROM items", dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBarang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new FormInpBrg();
            form.Show();
        }
    }
}
