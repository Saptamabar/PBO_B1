using Npgsql;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B1.App.Context
{
    internal class C_Barang : DatabaseWrapper
    {
        private static string table = "barang";

        // Method untuk mendapatkan semua data barang
        public static DataTable GetAllBarang()
        {
            string query = @"
                SELECT 
                    b.id,
                    b.nama_barang,
                    b.harga,
                    b.jumlah,
                    b.kategori,
                    b.tanggal_pembelian
                FROM 
                    barang b";

            DataTable dataBarang = queryExecutor(query);
            return dataBarang;
        }

        // Method untuk mendapatkan data barang berdasarkan ID
        public static DataTable GetBarangById(int id)
        {
            string query = @"
                SELECT 
                    b.id,
                    b.nama_barang,
                    b.harga,
                    b.jumlah,
                    b.kategori,
                    b.tanggal_pembelian
                FROM 
                    barang b
                WHERE 
                    b.id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataBarang = queryExecutor(query, parameters);
            return dataBarang;
        }

        // Method untuk menambahkan barang baru
        public static void AddBarang(M_Barang barangBaru)
        {
            string query = $"INSERT INTO {table} (nama_barang, harga, jumlah, kategori, tanggal_pembelian) VALUES(@nama_barang, @harga, @jumlah, @kategori, @tanggal_pembelian)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_barang", barangBaru.nama_barang),
                new NpgsqlParameter("@harga", barangBaru.harga),
                new NpgsqlParameter("@jumlah", barangBaru.jumlah),
                new NpgsqlParameter("@kategori", barangBaru.kategori),
                new NpgsqlParameter("@tanggal_pembelian", barangBaru.tanggal_pembelian)
            };

            commandExecutor(query, parameters);
        }

        // Method untuk mengupdate data barang
        public static void UpdateBarang(M_Barang barang)
        {
            string query = $"UPDATE {table} SET nama_barang = @nama_barang, harga = @harga, jumlah = @jumlah, kategori = @kategori, tanggal_pembelian = @tanggal_pembelian WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_barang", barang.nama_barang),
                new NpgsqlParameter("@harga", barang.harga),
                new NpgsqlParameter("@jumlah", barang.jumlah),
                new NpgsqlParameter("@kategori", barang.kategori),
                new NpgsqlParameter("@tanggal_pembelian", barang.tanggal_pembelian),
                new NpgsqlParameter("@id", barang.barang_id)
            };

            commandExecutor(query, parameters);
        }

        // Method untuk menghapus data barang berdasarkan ID
        public static void DeleteBarang(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
