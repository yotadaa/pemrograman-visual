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
            DbBarang.DisplayAndSearch("select  kode, nama, desk, kategori,stok,harga_awal, harga_jual FROM items", dataGridView1);
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
            Form form = new FormInpBrg(this.dataGridView1);
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Display();
        }

        private void FormBarang_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Form form = new deskbrg(
                    int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    int.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()),
                    int.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString())
                    );
                form.Show();
            } else if (e.ColumnIndex == 1)
            {

                int kode = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                MessageBox.Show("Data deleted! " + kode);
                DbBarang.DeleteBarang(kode);
                Display();
            }
        }
    }
}
