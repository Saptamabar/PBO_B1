using PBO_B1.App.Context; // Menggunakan C_Transaksi untuk mengambil data transaksi
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_B1.Views
{
    public partial class V_HalTransaksi : UserControl
    {
        public V_HalTransaksi()
        {
            InitializeComponent();
            LoadDataTransaksi();
        }


        // Method untuk memuat data ke DataGridView
        private void LoadDataTransaksi()
        {
            try
            {
                // Ambil data dari C_Transaksi
                DataTable dataTransaksi = C_Transaksi.All();

                // Debugging: Cek apakah data ada
                if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data transaksi ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Debugging: Log jumlah data yang diterima
                Console.WriteLine($"Jumlah data transaksi: {dataTransaksi.Rows.Count}");

                // Isi DataGridView dengan data
                dataGridViewTransaksi.DataSource = dataTransaksi;

                // (Opsional) Atur properti DataGridView
                dataGridViewTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTransaksi.ReadOnly = true; // Data hanya untuk ditampilkan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler untuk klik pada label1
        private void label1_Click(object sender, EventArgs e)
        {
            // Ketika label1 diklik, refresh DataGridView dengan memuat ulang data
            // Memanggil LoadDataTransaksi untuk mengupdate data
        }

        // Event handler untuk klik pada DataGridView
        private void dataGridViewTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Anda bisa tambahkan logika di sini jika ingin aksi khusus saat user klik cell.
        }
    }
}
