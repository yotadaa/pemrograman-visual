namespace TemplateDashboardAdmin_CSharp.Sistem_Admin
{
    partial class FormMasuk
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idbrg_text = new System.Windows.Forms.TextBox();
            this.idbrg = new System.Windows.Forms.Label();
            this.cekbrg = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(313, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 34);
            this.button6.TabIndex = 31;
            this.button6.Text = "Kembali";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(205, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 34);
            this.button5.TabIndex = 30;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(98, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 34);
            this.button7.TabIndex = 29;
            this.button7.Text = "Submit";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tanggal
            // 
            this.tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tanggal.Location = new System.Drawing.Point(99, 286);
            this.tanggal.Margin = new System.Windows.Forms.Padding(2);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(253, 26);
            this.tanggal.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tanggal";
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(99, 217);
            this.jumlah.Margin = new System.Windows.Forms.Padding(2);
            this.jumlah.Multiline = true;
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(171, 29);
            this.jumlah.TabIndex = 26;
            this.jumlah.TextChanged += new System.EventHandler(this.jumlah_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Jumlah Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nama Barang";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(99, 151);
            this.nama.Margin = new System.Windows.Forms.Padding(2);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(488, 29);
            this.nama.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Barang Masuk";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // idbrg_text
            // 
            this.idbrg_text.Location = new System.Drawing.Point(99, 96);
            this.idbrg_text.Margin = new System.Windows.Forms.Padding(2);
            this.idbrg_text.Multiline = true;
            this.idbrg_text.Name = "idbrg_text";
            this.idbrg_text.Size = new System.Drawing.Size(407, 29);
            this.idbrg_text.TabIndex = 32;
            // 
            // idbrg
            // 
            this.idbrg.AutoSize = true;
            this.idbrg.Location = new System.Drawing.Point(101, 71);
            this.idbrg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idbrg.Name = "idbrg";
            this.idbrg.Size = new System.Drawing.Size(53, 13);
            this.idbrg.TabIndex = 33;
            this.idbrg.Text = "Id Barang";
            // 
            // cekbrg
            // 
            this.cekbrg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cekbrg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekbrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cekbrg.Location = new System.Drawing.Point(511, 91);
            this.cekbrg.Name = "cekbrg";
            this.cekbrg.Size = new System.Drawing.Size(76, 34);
            this.cekbrg.TabIndex = 34;
            this.cekbrg.Text = "Cari";
            this.cekbrg.UseVisualStyleBackColor = false;
            this.cekbrg.Click += new System.EventHandler(this.cekbrg_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(177, 190);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(33, 13);
            this.totalLabel.TabIndex = 35;
            this.totalLabel.Text = "[total]";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(303, 227);
            this.harga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(36, 13);
            this.harga.TabIndex = 36;
            this.harga.Text = "Harga";
            this.harga.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 467);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.cekbrg);
            this.Controls.Add(this.idbrg);
            this.Controls.Add(this.idbrg_text);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMasuk";
            this.Text = "FormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idbrg_text;
        private System.Windows.Forms.Label idbrg;
        private System.Windows.Forms.Button cekbrg;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label harga;
    }
}

