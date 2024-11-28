using PBO_B1.App.Context;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.Views
{
    public partial class V_HalBarang : UserControl
    {
        public V_HalBarang()
        {
            InitializeComponent();
            ShowItems();
        }
        private void ShowItems()
        {
            M_Barang[] barangArray = C_Barang.getAllBarang();

            foreach (var data in barangArray)
            {
                int barang_id = data.barang_id;
                string nama_barang = data.nama_barang;
                int harga = data.harga;
                DateOnly tanggal_pembelian = data.tanggal_pembelian;
                string foto_barang = data.foto_barang;
                string kategori = data.kategori;
                string merk = data.merk;

                ShowBarang showBarang = new ShowBarang(nama_barang, harga, tanggal_pembelian, foto_barang, kategori, merk);
                Panel reviewPanel = showBarang.CreateItem();
                reviewPanel.BringToFront();
                reviewPanel.BackColor = Color.FromArgb(255, 128, 0);
                reviewPanel.BorderStyle = BorderStyle.FixedSingle;
                PanelBarang.Controls.Add(reviewPanel);

            }

        }

        

        
    }
}
