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
            ShowKategori();
        }
        private void ShowItems()
        {
            M_Barang[] barangArray = C_Barang.getAllBarang();

            foreach (var data in barangArray)
            {

                Panel reviewPanel = C_Barang.CreateItem(data);
                reviewPanel.BringToFront();
                PanelBarang.Controls.Add(reviewPanel);
            }

        }

        private void ShowKategori()
        {
            ComboBoxKategori.Items.Clear();
            M_Kategori[] daftar_barang = C_Barang.LoadKategori();
            foreach( var data in daftar_barang)
            {
                ComboBoxKategori.Items.Add(data.nama_kategori);
            }
        }

        private void TBSearchbar_Click(object sender, EventArgs e)
        {
            TBSearchbar.Text = string.Empty;
        }

        private void BtnTambahBarang_Click(object sender, EventArgs e)
        {
            V_HalTambahBarang v_HalTambahBarang = new V_HalTambahBarang();

            V_HalUtamaPemilik.LoadUserControl(v_HalTambahBarang);

        }

        private void ComboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelBarang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
