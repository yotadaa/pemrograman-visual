using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateDashboardAdmin_CSharp.Sistem_Admin;

namespace TemplateDashboardAdmin_CSharp
{
    public partial class FormMain : Form
    {


        #region "Jangan Merubah Bagian Ini"
        public String FormActive = "FormMain";

        public FormMain()
        {
            InitializeComponent();
            MenuApp.Renderer = new MyRender();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
/*            PanelSideBar.Visible = !PanelSideBar.Visible;*/
        }
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = PanelTitle.BackColor;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = PanelHeader.BackColor;
        }
        public void ShowFormToPanel(Form form)
        {
            ProgressBarLoad.Value = 0;
            if (PanelFormFill.Controls.Find(form.Name, true).Length == 0)
            {
                form.WindowState = FormWindowState.Normal;
                form.TopLevel = false;
                form.Resize += new EventHandler(FormChild_Resize);
                PanelFormFill.Controls.Add(form);
                form.Show();
            }
            else
                form = (Form)PanelFormFill.Controls.Find(form.Name, true)[0];
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            LabelTitle.Text = form.Text;
            form.BringToFront();
            FormActive = form.Name;
            BringFomMinimizeToFront();
            ProgressBarLoad.Value = 100;
        }
        private void FormChild_Resize(object sender, EventArgs e)
        {
            LabelTitle.Text = ((Form)sender).Text;
            FormActive = ((Form)sender).Name;
            BringFomMinimizeToFront();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Visible && ((Form)control).WindowState != FormWindowState.Minimized)
                {
                    ((Form)control).Close();
                    break;
                }
            }
            GetTopFormChild();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Visible && ((Form)control).WindowState != FormWindowState.Minimized)
                {
                    ((Form)control).WindowState = FormWindowState.Minimized;
                    ((Form)control).BringToFront();
                    break;
                }
            }
            GetTopFormChild();
        }
        private void GetTopFormChild()
        {
            /*foreach (Control control in PanelFormFill.Controls)
            {
                if (control.Visible && ((Form)control).WindowState != FormWindowState.Minimized)
                {
                    LabelTitle.Text = ((Form)control).Text;
                    FormActive = ((Form)control).Name;
                    break;
                }
            }*/
        }
        private void BringFomMinimizeToFront()
        {
           /* foreach (Control control in PanelFormFill.Controls)
            {
                if (((Form)control).WindowState == FormWindowState.Minimized)
                {
                    ((Form)control).BringToFront();
                }
            }*/
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 32, 33);
            btnNotif.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 32, 33);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Us: Zainu.developer@gmail.com");
        }
        #endregion



        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormToPanel(new FormUser());
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormToPanel(new FormGroup());
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormToPanel(new FormBarang());  
        }

        private void authToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormToPanel(new FormUser());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }

    #region "Fungsi Membuat Custom Desain Menu Strip"
    public class MyRender : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {

            e.Item.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            e.Item.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            e.Item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            e.Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            e.Item.ForeColor = Color.White;
            var rc = new Rectangle(Point.Empty, e.Item.Size);
            var genap = (e.ToolStrip.Items.IndexOf(e.Item) % 2 == 0);
            var color = (e.Item.Selected) ? System.Drawing.Color.FromArgb(29, 56, 84) : (genap) ? Color.SteelBlue : Color.FromArgb(51, 133, 166);
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, rc);
            }

        }
    }
    #endregion
}
