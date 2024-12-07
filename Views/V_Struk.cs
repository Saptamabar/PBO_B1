using PBO_B1.App.Context;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Bitmap memoryImage;
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
                int kembali = bayar - V_DetailTransaksi.JumlahTotal;
                if (kembali < 0)
                {
                    MessageBox.Show("Pembayaran tidak mencukupi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Kembali.Text = "Rp " + kembali.ToString();

            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Kembali.Text))
            {
                C_Transaksi.InsertTransaksiandDetail();
                btnBayar.Hide();
                Batal.Hide();
                MessageBox.Show("Transaksi berhasil tersimpan", "Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
               


                // Tangkapan layar menggunakan DrawToBitmap
                memoryImage = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(memoryImage, new Rectangle(0, 0, this.Width, this.Height));

                // Pratinjau dan cetak dokumen
                printPreviewDialog1.Document = printDocument1;
                //printPreviewDialog1.PrintPreviewControl.Zoom = 0;
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
                this.Close();
                V_HalUtamaPemilik.LoadUserControl(new V_HalLaporan());
            }
            else
            {
                MessageBox.Show("Pembayaran harus terisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(memoryImage, 0, 0);

        }
    }
}
