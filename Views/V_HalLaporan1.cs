using PBO_B1.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBO_B1.Views;

namespace PBO_B1.Views
{
    public partial class V_HalLaporan1 : UserControl
    {
        private int halsaatini = 0;
        private int batasawalhalaman = 0;
        private int batasakhirhalaman = 1;

        public V_HalLaporan1()
        {
            InitializeComponent();
        }
        private void LoadChartLaporanTransaksi()
        {
            try
            {

                DataTable dataTransaksi = C_Laporan.getcharttransaksi();

                if (dataTransaksi != null && dataTransaksi.Rows.Count > 0)
                {
                    // Pastikan chart direset sebelum diisi ulang
                    chart1.Series.Clear();
                    chart1.Titles.Clear();

                    chart1.Titles.Add("Total transaksi");


                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Format label tanggal


                    // Tambahkan seri ke chart
                    Series series = new Series("Total Transaksi")
                    {
                        ChartType = SeriesChartType.Line,    // Jenis chart
                        XValueType = ChartValueType.DateTime,
                        YValueType = ChartValueType.Double,
                        IsValueShownAsLabel = true,           // Tampilkan label di setiap titik


                    };

                    // Isi data ke dalam seri
                    foreach (DataRow row in dataTransaksi.Rows)
                    {
                        DateTime tanggal = Convert.ToDateTime(row["tanggal_transaksi"]);
                        double totalTransaksi = Convert.ToDouble(row["total_transaksi_harian"]);

                        series.Points.AddXY(tanggal, totalTransaksi);
                    }

                    // Tambahkan seri ke chart
                    chart1.Series.Add(series);
                }
                else
                {
                    MessageBox.Show("Tidak ada data untuk ditampilkan dalam chart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadtop3barang()
        {
            try
            {
                DataTable databarang = C_Laporan.gettop3barang(); // Ambil data barang terlaris

                if (databarang != null && databarang.Rows.Count > 0)
                {
                    // Reset chart sebelum diisi ulang
                    chart1.Series.Clear();
                    chart1.Titles.Clear();
                    chart1.ChartAreas.Clear();

                    // Tambahkan area chart
                    ChartArea chartArea = new ChartArea("PieChartArea");
                    chart1.ChartAreas.Add(chartArea);

                    // Tambahkan judul chart
                    chart1.Titles.Add("Top 3 Barang Terlaris dan Barang Lainnya");

                    // Tambahkan seri ke chart
                    Series series = new Series("Barang Terlaris")
                    {
                        ChartType = SeriesChartType.Pie,       // Ubah menjadi Pie Chart
                        IsValueShownAsLabel = true,            // Menampilkan label nilai
                        LabelFormat = "#,##0"                  // Format label angka
                    };

                    // Isi data ke dalam seri (nama_barang sebagai label, total_jumlah sebagai nilai)
                    foreach (DataRow row in databarang.Rows)
                    {
                        string namaBarang = row["nama_barang"].ToString();   // Nama barang
                        double totalJumlah = Convert.ToDouble(row["total_jumlah"]); // Total jumlah barang terjual

                        series.Points.AddXY(namaBarang, totalJumlah);
                    }

                    // Tambahkan seri ke chart
                    chart1.Series.Add(series);
                }
                else
                {
                    MessageBox.Show("Tidak ada data untuk ditampilkan dalam chart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data barang terlaris: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void V_Cobabaru_Load(object sender, EventArgs e)
        {
            LoadChartLaporanTransaksi();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            halsaatini += 1;
            if (halsaatini > batasakhirhalaman)
            {
                halsaatini = batasawalhalaman;
                checkhalaman();
            }
            else
            {
                checkhalaman();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            halsaatini -= 1;
            if (halsaatini < batasawalhalaman)
            {
                halsaatini = batasakhirhalaman;
                checkhalaman();
            }
            else
            {
                checkhalaman();
            }
        }

        private void checkhalaman()
        {
            if (halsaatini == 0)
            {
                LoadChartLaporanTransaksi();
            }
            else if (halsaatini == 1)
            {
                loadtop3barang();
            }

        }

        private void btnTabelLaporan_Click(object sender, EventArgs e)
        {
            V_HalLaporan2 v_HalTransaksi = new V_HalLaporan2();
            V_HalUtamaPemilik.LoadUserControl(v_HalTransaksi);
        }
    }
}
