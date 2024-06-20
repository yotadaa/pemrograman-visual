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
    public partial class Dashboard : Form
    {
        FormMain main;
        public Dashboard(FormMain form)
        {
            InitializeComponent();
            this.main = form; 
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            ShowFormToPanel(new FormBarang());
        }

        public void ShowFormToPanel(Form form)
        {
            main.ProgressBarLoad.Value = 0;
            if (main.PanelFormFill.Controls.Find(form.Name, true).Length == 0)
            {
                form.WindowState = FormWindowState.Normal;
                form.TopLevel = false;
                form.Resize += new EventHandler(main.FormChild_Resize);
                main.PanelFormFill.Controls.Add(form);
                form.Show();
            }
            else
                form = (Form)main.PanelFormFill.Controls.Find(form.Name, true)[0];
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            main.FormActive = form.Name;
            main.BringFomMinimizeToFront();
            main.ProgressBarLoad.Value = 100;
        }
    }
}
