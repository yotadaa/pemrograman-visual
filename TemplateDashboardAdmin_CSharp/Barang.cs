 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TemplateDashboardAdmin_CSharp
{
    class Barang
    {
        public string Foto { get; set; }
        public string Nama   { get; set; }
        public string Deskripsi { get; set; }
        public int Kategori { get; set; }
        public int Stok { get; set; }
        public float HargaInbound { get; set; }
        public float HargaOutbound { get; set; }
        public string Email { get; set; }
        public string Kode { get; set; }

        public Barang(string name, string foto, string deskripsi, int kategori, int stok, float hargaInbound, float hargaOutbound)
        {
            Foto = foto;
            Nama = name;
            Deskripsi = deskripsi;
            Kategori = kategori;
            Stok = stok;
            HargaInbound = hargaInbound;
            HargaOutbound = hargaOutbound;

        }
    }

    
}
