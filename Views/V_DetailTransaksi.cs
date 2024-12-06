using PBO_B1.App.Context;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.Views
{

    public partial class V_DetailTransaksi : UserControl
    {
        public static int JumlahTotal { get; set; }
        public V_DetailTransaksi()
        {
            InitializeComponent();
            Showdetailtransaksi();
            updatetotalHarga();
        }

        private void Showdetailtransaksi()
        {
            M_Barang[] barangArray = C_Transaksi.getkeranjang();
            Flowlayoutbarang.Controls.Clear();
            foreach (var data in barangArray)
            {
                JumlahTotal += (data.harga * data.jumlah);
                Panel reviewPanel = C_Detailtransaksi.CreateItem(data);
                reviewPanel.BringToFront();
                Flowlayoutbarang.Controls.Add(reviewPanel);

            }
        }

        private void Bayar_Click(object sender, EventArgs e)
        {
            V_Struk v_Struk = new V_Struk();
            v_Struk.ShowDialog();
        }

        public static void updatetotalHarga()
        {
            int hasil = 0;
            foreach(M_Barang data in C_Transaksi.getkeranjang())
            {
                hasil += data.harga * data.jumlah;
            }
            JumlahTotal = hasil;
            Totalharga.Text = "Total : Rp "+ hasil.ToString();
        }
    }
}
