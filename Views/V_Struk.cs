using PBO_B1.App.Context;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PBO_B1.Views
{
    public partial class V_Struk : Form
    {
        public V_Struk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void V_Struk_Load(object sender, EventArgs e)
        {
            C_Transaksi.getkeranjang();
            Tanggal.Text = "Jember, " + DateTime.Today.ToString("yyyy-MM-dd");
            Admin.Text = "Admin : " + Session.CurrentUser.Nama;
            LoadDataStruk();
        }

        private void LoadDataStruk()
        {
            Total.Text = "Rp " + V_DetailTransaksi.JumlahTotal.ToString();

            try
            {

                M_Barang[] dataTransaksi = C_Transaksi.getkeranjang();
                List<M_Barang> dataTransaksi2 = dataTransaksi.ToList();

                Datastruk.DataSource = dataTransaksi2;
                Datastruk.Columns.Add("Total", "Total");
                Datastruk.Columns["barang_id"].Visible = false;
                Datastruk.Columns["nama_barang"].HeaderText = "Nama Barang";
                Datastruk.Columns["harga"].HeaderText = "Harga";
                Datastruk.Columns["harga"].DefaultCellStyle.Format = "Rp #,##0.00";
                Datastruk.Columns["jumlah"].HeaderText = "Jumlah";
                Datastruk.Columns["tanggal_pembelian"].Visible = false;
                Datastruk.Columns["foto_barang"].Visible = false;
                Datastruk.Columns["kategori"].Visible = false;
                Datastruk.Columns["merk"].Visible = false;
                Datastruk.Columns["merk_merk"].Visible = false;

                for (int i = 0; i < dataTransaksi.Length; i++)
                {
                    Datastruk.Rows[i].Cells["Total"].Value = "Rp" + (dataTransaksi2[i].harga * dataTransaksi2[i].jumlah).ToString("n2", CultureInfo.GetCultureInfo("id-ID"));


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Input harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
            {

                int bayar = (int)Convert.ToInt64(Bayar.Text);
                int kembali =  bayar - V_DetailTransaksi.JumlahTotal;
                if (kembali  < 0)
                {
                    MessageBox.Show("Uang anda kurang","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Kembali.Text = "Rp " + kembali.ToString();

            }
        }
    }
}
