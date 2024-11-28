using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B1.App.Models
{
    internal class M_Barang
    {
        public int barang_id { get; set; }
        public string nama_barang { get; set; }
        public int harga { get; set; }
        public int jumlah { get; set; }
        public DateOnly tanggal_pembelian { get; set; }
        public string foto_barang { get; set; }
        public string kategori { get; set; }
        public string merk {  get; set; }
    }
}
