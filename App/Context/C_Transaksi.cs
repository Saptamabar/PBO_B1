using Npgsql;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_B1.App.Context
{
    internal class C_Transaksi : DatabaseWrapper
    {
        // Mengambil semua transaksi dengan detailnya
        public static DataTable All()
        {
            string query = @"
                SELECT 
                    t.transaksi_id,
                    t.tanggal AS tanggal_transaksi,
                    t.total AS total_transaksi,
                    a.username AS username_akun,
                    a.nama AS nama_akun,
                    b.nama_barang,
                    dt.harga AS harga_barang,
                    dt.jumlah AS jumlah_barang
                FROM 
                    transaksi t
                INNER JOIN 
                    akun a ON t.akun_username = a.username
                INNER JOIN 
                    detail_transasksi dt ON t.transaksi_id = dt.transaksi_transaksi_id
                INNER JOIN 
                    barang b ON dt.barang_barang_id = b.barang_id;
            ";

            DataTable dataTransaksi = queryExecutor(query); // Pastikan queryExecutor mengembalikan DataTable

            // Debugging: Pastikan dataTransaksi tidak null atau kosong
            if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
            {
                Console.WriteLine("No transactions found.");
                MessageBox.Show("Tidak ada data transaksi ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine($"Data transaksi ditemukan: {dataTransaksi.Rows.Count} rows.");
            }

            return dataTransaksi;
        }

        // Mengambil transaksi berdasarkan ID
        public static DataTable GetById(int transaksiId)
        {
            string query = @"
                SELECT 
                    t.transaksi_id,
                    t.tanggal AS tanggal_transaksi,
                    t.total AS total_transaksi,
                    a.username AS username_akun,
                    a.nama AS nama_akun,
                    b.nama_barang,
                    b.kategori,
                    dt.harga AS harga_barang,
                    dt.jumlah AS jumlah_barang
                FROM 
                    transaksi t
                INNER JOIN 
                    akun a ON t.akun_username = a.username
                INNER JOIN 
                    detail_transasksi dt ON t.transaksi_id = dt.transaksi_transaksi_id
                INNER JOIN 
                    barang b ON dt.barang_barang_id = b.barang_id
                WHERE t.transaksi_id = @transaksi_id;
            ";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@transaksi_id", transaksiId)
            };

            DataTable dataTransaksi = queryExecutor(query, parameters); // Pastikan queryExecutor mengembalikan DataTable

            // Debugging: Cek apakah data ditemukan untuk transaksiId
            if (dataTransaksi == null || dataTransaksi.Rows.Count == 0)
            {
                Console.WriteLine($"No transaction found with ID: {transaksiId}");
                MessageBox.Show($"Tidak ada data transaksi dengan ID {transaksiId}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine($"Data transaksi ditemukan untuk ID {transaksiId}: {dataTransaksi.Rows.Count} rows.");
            }

            return dataTransaksi;
        }

        // Validasi apakah transaksi dengan ID tertentu ada
        public static M_Transaksi Validate(int transaksiId)
        {
            M_Transaksi transaksi = null;

            string query = "SELECT * FROM transaksi WHERE transaksi_id = @transaksi_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@transaksi_id", transaksiId)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters)) // Pastikan ExecuteReaderCommand ada dan benar
            {
                if (reader.Read())
                {
                    transaksi = new M_Transaksi
                    {
                        TransaksiId = (int)reader["transaksi_id"],
                        TanggalTransaksi = (DateTime)reader["tanggal"],
                        TotalTransaksi = (int)reader["total"],
                        UsernameAkun = (string)reader["akun_username"]
                    };
                    Console.WriteLine($"Transaksi ditemukan: ID = {transaksi.TransaksiId}, Tanggal = {transaksi.TanggalTransaksi}");
                }
                else
                {
                    Console.WriteLine($"Transaksi dengan ID {transaksiId} tidak ditemukan.");
                }
            }

            return transaksi;
        }
    }
}
