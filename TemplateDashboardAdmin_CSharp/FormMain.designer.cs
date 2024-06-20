

namespace TemplateDashboardAdmin_CSharp
{
    partial class FormMain
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ProgressBarLoad = new System.Windows.Forms.ProgressBar();
            this.PanelFormFill = new System.Windows.Forms.Panel();
            this.PanelSparator = new System.Windows.Forms.Panel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PanelTool = new System.Windows.Forms.Panel();
            this.btnNotif = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.PanelSideBar = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.MenuApp = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelRefresh = new System.Windows.Forms.Label();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.PanelMain.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.PanelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.PanelSideBar.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.MenuApp.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.LightGray;
            this.PanelMain.Controls.Add(this.ProgressBarLoad);
            this.PanelMain.Controls.Add(this.PanelFormFill);
            this.PanelMain.Controls.Add(this.PanelSparator);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(219, 42);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(19, 43, 19, 19);
            this.PanelMain.Size = new System.Drawing.Size(1065, 619);
            this.PanelMain.TabIndex = 7;
            // 
            // ProgressBarLoad
            // 
            this.ProgressBarLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarLoad.Location = new System.Drawing.Point(-1, 0);
            this.ProgressBarLoad.Name = "ProgressBarLoad";
            this.ProgressBarLoad.Size = new System.Drawing.Size(1067, 3);
            this.ProgressBarLoad.TabIndex = 7;
            this.ProgressBarLoad.Value = 100;
            // 
            // PanelFormFill
            // 
            this.PanelFormFill.BackColor = System.Drawing.Color.White;
            this.PanelFormFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelFormFill.Location = new System.Drawing.Point(19, 52);
            this.PanelFormFill.Margin = new System.Windows.Forms.Padding(17);
            this.PanelFormFill.Name = "PanelFormFill";
            this.PanelFormFill.Size = new System.Drawing.Size(1027, 548);
            this.PanelFormFill.TabIndex = 4;
            this.PanelFormFill.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormFill_Paint);
            // 
            // PanelSparator
            // 
            this.PanelSparator.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelSparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSparator.Location = new System.Drawing.Point(19, 43);
            this.PanelSparator.Name = "PanelSparator";
            this.PanelSparator.Size = new System.Drawing.Size(1027, 9);
            this.PanelSparator.TabIndex = 0;
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(219, 661);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(1065, 40);
            this.PanelFooter.TabIndex = 5;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.Controls.Add(this.PanelTool);
            this.PanelHeader.Controls.Add(this.btnMenu);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(219, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1065, 42);
            this.PanelHeader.TabIndex = 6;
            // 
            // PanelTool
            // 
            this.PanelTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTool.BackColor = System.Drawing.Color.Transparent;
            this.PanelTool.Controls.Add(this.btnNotif);
            this.PanelTool.Controls.Add(this.btnLogout);
            this.PanelTool.Location = new System.Drawing.Point(882, -3);
            this.PanelTool.Name = "PanelTool";
            this.PanelTool.Size = new System.Drawing.Size(183, 42);
            this.PanelTool.TabIndex = 0;
            // 
            // btnNotif
            // 
            this.btnNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotif.BackColor = System.Drawing.Color.Transparent;
            this.btnNotif.FlatAppearance.BorderSize = 0;
            this.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotif.Image = global::TemplateDashboardAdmin_CSharp.Properties.Resources.notif;
            this.btnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotif.Location = new System.Drawing.Point(0, 4);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Padding = new System.Windows.Forms.Padding(3);
            this.btnNotif.Size = new System.Drawing.Size(86, 42);
            this.btnNotif.TabIndex = 5;
            this.btnNotif.Text = "0";
            this.btnNotif.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = global::TemplateDashboardAdmin_CSharp.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(86, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(3);
            this.btnLogout.Size = new System.Drawing.Size(97, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = global::TemplateDashboardAdmin_CSharp.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(-1, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(11);
            this.btnMenu.Size = new System.Drawing.Size(38, 42);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // PanelSideBar
            // 
            this.PanelSideBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.PanelSideBar.Controls.Add(this.PanelMenu);
            this.PanelSideBar.Controls.Add(this.PanelTitle);
            this.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelSideBar.Name = "PanelSideBar";
            this.PanelSideBar.Size = new System.Drawing.Size(219, 701);
            this.PanelSideBar.TabIndex = 4;
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.PanelInfo);
            this.PanelMenu.Controls.Add(this.MenuApp);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelMenu.Location = new System.Drawing.Point(0, 42);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PanelMenu.Size = new System.Drawing.Size(219, 659);
            this.PanelMenu.TabIndex = 5;
            // 
            // PanelInfo
            // 
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfo.Location = new System.Drawing.Point(3, 619);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(213, 40);
            this.PanelInfo.TabIndex = 1;
            // 
            // MenuApp
            // 
            this.MenuApp.BackColor = System.Drawing.Color.Transparent;
            this.MenuApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuApp.GripMargin = new System.Windows.Forms.Padding(19);
            this.MenuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.MenuApp.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MenuApp.Location = new System.Drawing.Point(3, 0);
            this.MenuApp.Name = "MenuApp";
            this.MenuApp.Padding = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.MenuApp.Size = new System.Drawing.Size(213, 107);
            this.MenuApp.TabIndex = 0;
            this.MenuApp.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItem1.Text = "Dashboard";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masterDataToolStripMenuItem.Image")));
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.masterDataToolStripMenuItem.Text = "Daftar Barang";
            this.masterDataToolStripMenuItem.Click += new System.EventHandler(this.masterDataToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transaksiToolStripMenuItem.Image")));
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.transaksiToolStripMenuItem.Text = "Barang Masuk";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("laporanToolStripMenuItem.Image")));
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.laporanToolStripMenuItem.Text = "Barang Keluar";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.PanelTitle.Controls.Add(this.LabelRefresh);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(219, 42);
            this.PanelTitle.TabIndex = 1;
            // 
            // LabelRefresh
            // 
            this.LabelRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRefresh.AutoSize = true;
            this.LabelRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelRefresh.Location = new System.Drawing.Point(48, 7);
            this.LabelRefresh.Name = "LabelRefresh";
            this.LabelRefresh.Size = new System.Drawing.Size(108, 25);
            this.LabelRefresh.TabIndex = 0;
            this.LabelRefresh.Text = "SIMPELO";
            this.LabelRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimerMain
            // 
            this.TimerMain.Enabled = true;
            this.TimerMain.Interval = 1000;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelSideBar);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.PanelSideBar.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.MenuApp.ResumeLayout(false);
            this.MenuApp.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelMain;
        internal System.Windows.Forms.ProgressBar ProgressBarLoad;
        internal System.Windows.Forms.Panel PanelSparator;
        internal System.Windows.Forms.Panel PanelFooter;
        internal System.Windows.Forms.Panel PanelHeader;
        internal System.Windows.Forms.Panel PanelTool;
        internal System.Windows.Forms.Button btnNotif;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.PictureBox btnMenu;
        internal System.Windows.Forms.Panel PanelSideBar;
        internal System.Windows.Forms.Panel PanelMenu;
        internal System.Windows.Forms.Panel PanelInfo;
        internal System.Windows.Forms.MenuStrip MenuApp;
        internal System.Windows.Forms.Panel PanelTitle;
        internal System.Windows.Forms.Label LabelRefresh;
        internal System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        internal System.Windows.Forms.Panel PanelFormFill;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

