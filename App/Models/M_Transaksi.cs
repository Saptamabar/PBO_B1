using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B1.App.Models
{
    internal class M_Transaksi
    {
        public int TransaksiId { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int TotalTransaksi { get; set; }
        public string UsernameAkun { get; set; }
        public string NamaAkun { get; set; }
        public string NamaBarang { get; set; }
        public string KategoriBarang { get; set; }
        public int HargaBarang { get; set; }
        public int JumlahBarang { get; set; }
    }
}
