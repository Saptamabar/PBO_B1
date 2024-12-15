using PBO_B1.App.Context; // Menggunakan C_Transaksi untuk mengambil data transaksi
using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_B1.Views
{
    public partial class V_HalLaporan2 : UserControl
    {
        public V_HalLaporan2()
        {
            InitializeComponent();
            Loaddata();
            LoadDataTransaksi();
        }


        private void Loaddata()
        {
            BarangTerlaris.Text = ": " + C_Laporan.getbarangterlaris();
            JumlahTransaksi.Text = ": " + C_Laporan.getjumlahtransaksi();
            TotalPenjualan.Text = ": Rp " + C_Laporan.gettotalpenjualan();
        }
        // Method untuk memuat data ke DataGridView
        private void LoadDataTransaksi()
        {
            try
            {

                DataTable dataTransaksi = C_Laporan.All();

                if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data transaksi ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridTransaksi.DataSource = dataTransaksi;


                dataGridTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridTransaksi.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataTransaksi(DateOnly tanggalawal, DateOnly tanggalakhir)
        {
            try
            {

                DataTable dataTransaksi = C_Laporan.getbytanggal(tanggalawal, tanggalakhir);

                if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data transaksi ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridTransaksi.DataSource = dataTransaksi;


                dataGridTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridTransaksi.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TanggalAwal_ValueChanged(object sender, EventArgs e)
        {
            DateOnly tanggalawal = DateOnly.FromDateTime(TanggalAwal.Value);
            DateOnly tanggalakhir = DateOnly.FromDateTime(TanggalAkhir.Value);
            LoadDataTransaksi(tanggalawal, tanggalakhir);
        }

        private void TanggalAkhir_ValueChanged(object sender, EventArgs e)
        {
            DateOnly tanggalawal = DateOnly.FromDateTime(TanggalAwal.Value);
            DateOnly tanggalakhir = DateOnly.FromDateTime(TanggalAkhir.Value);
            LoadDataTransaksi(tanggalawal, tanggalakhir);
        }
    }
}
