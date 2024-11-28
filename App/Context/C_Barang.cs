using Microsoft.VisualBasic.ApplicationServices;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using PBO_B1.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.App.Context
{
    internal class C_Barang
    {
        public static M_Barang[] getAllBarang()
        {
            string query = "select * from barang";

            // Panggil queryExecutor untuk mengambil data
            DataTable databarang = DatabaseWrapper.queryExecutor(query);

            // Mapping data dari DataTable ke List<M_Barang>
            List<M_Barang> Daftar_barang = databarang.AsEnumerable().Select(row => new M_Barang
            {
                barang_id = row.Field<int>("barang_id"),
                nama_barang = row.Field<string>("nama_barang"),
                harga = row.Field<int>("harga"),
                tanggal_pembelian = DateOnly.FromDateTime(row.Field<DateTime>("tanggal_pembelian")),
                foto_barang = row.Field<string>("foto_barang"),
                kategori = row.Field<string>("kategori_nama_kategori"),
                merk = row.Field<string>("merk_merk")
            }).ToList();

            // Konversi List<M_Barang> ke array dan kembalikan
            return Daftar_barang.ToArray();
        }

    }
    public class ShowBarang
    {
        private string NamaBarang;
        private int Harga;
        private DateOnly TanggalPembelian;
        private string FotoBarang;
        private string Kategori;
        private string Merk;

        public ShowBarang(string namaBarang, int harga, DateOnly tanggalPembelian, string fotoBarang, string kategori, string merk)
        {
            NamaBarang = namaBarang;
            Harga = harga;
            TanggalPembelian = tanggalPembelian;
            FotoBarang = fotoBarang;
            Kategori = kategori;
            Merk = merk;
        }

        public Panel CreateItem()
        {
            // Buat panel utama
            Panel panelbasebarang = new Panel
            {
                Location = new Point(20, 20),
                Margin = new Padding(10),
                Name = "panelbasebarang",
                Padding = new Padding(2),
                Size = new Size(179, 318),
                TabIndex = 0,
                Visible = true,
            };

            // Buat PictureBox untuk menampilkan gambar
            PictureBox Fotobarang = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(27, 52),
                Name = "Fotobarang",
                Size = new Size(125, 125),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 1,
                TabStop = false,
                Image = !string.IsNullOrEmpty(FotoBarang) && File.Exists(FotoBarang)
                    ? Image.FromFile(FotoBarang)
                    : Image.FromFile("..\\..\\..\\Resources\\DefaultImageBarang.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                
            };

            // Buat label untuk setiap informasi
            Label JudulBarang = new Label
            {
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 11),
                Name = "JudulBarang",
                Size = new Size(169, 25),
                TabIndex = 0,
                Text = NamaBarang,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label HargaBarang = new Label
            {               
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 196),
                Name = "Harga",
                Size = new Size(169, 25),
                TabIndex = 2,
                Text = Harga.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label Stok = new Label
            {
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 221),
                Name = "Stok",
                Size = new Size(169, 25),
                TabIndex = 3,
                Text = "Stok",
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label TanggalPembelianBarang = new Label
            {
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 246),
                Name = "TanggalPembelian",
                Size = new Size(169, 25),
                TabIndex = 4,
                Text = TanggalPembelian.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Button btnUbah = new Button
            {
                BackColor = Color.FromArgb(255, 128, 0),
                ForeColor = Color.White,
                Location = new Point(40, 274),
                Name = "btnUbah",
                Size = new Size(94, 29),
                TabIndex = 5,
                Text = "Edit",
                UseVisualStyleBackColor = false,
            };
            btnUbah.Click += btnUbah_Click;

            static void btnUbah_Click(object sender, EventArgs e)
            {

            }
            panelbasebarang.Controls.Add(btnUbah);
            panelbasebarang.Controls.Add(TanggalPembelianBarang);
            panelbasebarang.Controls.Add(Stok);
            panelbasebarang.Controls.Add(HargaBarang);
            panelbasebarang.Controls.Add(Fotobarang);
            panelbasebarang.Controls.Add(JudulBarang);

            return panelbasebarang;
        }

    }
    

}
