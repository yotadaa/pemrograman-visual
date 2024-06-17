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
    public partial class FormInpBrg : Form
    {
        int kategori = 0;
        public FormInpBrg()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormInpBrg_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length < 1 ||
                textBox2.Text.Trim().Length < 1 ||
                textBox3.Text.Trim().Length < 1 ||
                textBox4.Text.Trim().Length < 1 ||
                textBox5.Text.Trim().Length < 1
                )
            {
                MessageBox.Show("Isi seluruh Field!");
                return;
            } 
            Barang std = new Barang(textBox1.Text.Trim(),"",  textBox5.Text.Trim(), kategori, int.Parse (textBox2.Text.Trim()), int.Parse(textBox3.Text.Trim()), int.Parse(textBox4.Text.Trim()));
            DbBarang.AddBarang(std);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
