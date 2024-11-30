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

                Panel reviewPanel = C_Barang.CreateItem(data);
                reviewPanel.BringToFront();
                PanelBarang.Controls.Add(reviewPanel);

            }

        }

        private void TBSearchbar_Click(object sender, EventArgs e)
        {
            TBSearchbar.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEditBarang_Click(object sender, EventArgs e)
        {

        }

        private void BtnTambahBarang_Click(object sender, EventArgs e)
        {
            V_HalTambahBarang v_HalTambahBarang = new V_HalTambahBarang();
            V_HalUtamaPemilik.LoadUserControl(v_HalTambahBarang);
            
        }
    }
}
