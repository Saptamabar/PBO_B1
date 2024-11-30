using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBO_B1.App.Models
{
    internal class M_Barang
    {
        [Key]
        public int barang_id { get; set; }
        [Required]
        public string nama_barang { get; set; }
        [Required]
        public string merk_merk { get; set; }
        [Required]
        public int harga { get; set; }
        [Required]
        
        public int jumlah { get; set; }
        public DateOnly tanggal_pembelian { get; set; }
        public string foto_barang { get; set; }
        public string kategori { get; set; }
        public string merk {  get; set; }
    }
}
