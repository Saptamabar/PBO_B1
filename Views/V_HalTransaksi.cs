using PBO_B1.App.Context;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PBO_B1.Views
{
    public partial class V_HalTransaksi : UserControl
    {
        public V_HalTransaksi()
        {
            InitializeComponent();
            ShowItems();
            ShowKategori();
        }
        private void ShowItems()
        {
            M_Barang[] barangArray = C_Transaksi.getAllBarang();

            foreach (var data in barangArray)
            {

                Panel reviewPanel = C_Transaksi.CreateItem(data);
                reviewPanel.BringToFront();
                panelbasebarang.Controls.Add(reviewPanel);
            }

        }

        private void ShowKategori()
        {
            CBKategori.Items.Clear();
            M_Kategori[] daftar_barang = C_Barang.LoadKategori();
            foreach (var data in daftar_barang)
            {
                CBKategori.Items.Add(data.nama_kategori);
            }
        }

        public static void ShowKeranjang()
        {
            M_Barang[] barangArray = C_Transaksi.getkeranjang();
            flowpanelkeranjang.Controls.Clear();
            foreach (var data in barangArray)
            {
                Panel reviewPanel = C_Transaksi.CreateKeranjang(data);
                reviewPanel.BringToFront();
                flowpanelkeranjang.Controls.Add(reviewPanel);

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            List<M_Barang> keranjang = C_Transaksi.getkeranjang().ToList();
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Isi Keranjang tidak boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            V_DetailTransaksi v_DetailTransaksi = new V_DetailTransaksi();
            V_HalUtamaPemilik.LoadUserControl(v_DetailTransaksi);
        }

        private void TBSearchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                panelbasebarang.Controls.Clear();
                M_Barang[] barangArray = C_Barang.Getbarangbysearch(TBSearchbar.Text);

                foreach (var data in barangArray)
                {

                    Panel reviewPanel = C_Transaksi.CreateItem(data);
                    reviewPanel.BringToFront();
                    panelbasebarang.Controls.Add(reviewPanel);
                }

            }
        }

        private void CBKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelbasebarang.Controls.Clear();
            M_Barang[] barangArray = C_Barang.Getbarangbykategori(CBKategori.Text);

            foreach (var data in barangArray)
            {

                Panel reviewPanel = C_Transaksi.CreateItem(data);
                reviewPanel.BringToFront();
                panelbasebarang.Controls.Add(reviewPanel);
            }
        }

       

        private void TBSearchbar_Click(object sender, EventArgs e)
        {
            TBSearchbar.Text = string.Empty;
        }
    }
}
