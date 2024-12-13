﻿using Npgsql;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using PBO_B1.Properties;
using PBO_B1.Views;
using System.Collections.Generic;
using System.Data;
using System.Resources;

namespace PBO_B1.App.Context
{
    internal class C_Barang : DatabaseWrapper
    {
        public static M_Barang[] getAllBarang()
        {
            string query = "select * from barang where dihapus = False";

            DataTable databarang = queryExecutor(query);

            
            List<M_Barang> Daftar_barang = databarang.AsEnumerable().Select(row => new M_Barang
            {
                barang_id = row.Field<int>("barang_id"),
                nama_barang = row.Field<string>("nama_barang"),
                harga = row.Field<int>("harga"),
                jumlah = row.Field<int>("jumlah"),
                tanggal_pembelian = DateOnly.FromDateTime(row.Field<DateTime>("tanggal_pembelian")),
                foto_barang = row.Field<string>("foto_barang"),
                kategori = row.Field<string>("kategori_nama_kategori"),
                merk = row.Field<string>("merk_merk")
            }).ToList();

            return Daftar_barang.ToArray();
        }

        public static M_Barang[] Getbarangbysearch(string search)
        {
            string query = "select * from barang where dihapus = False AND nama_barang ILIKE 'keyword%' ;";

            query = query.Replace("keyword", search);

            DataTable databarang = queryExecutor(query);

            List<M_Barang> Daftar_barang = databarang.AsEnumerable().Select(row => new M_Barang
            {
                barang_id = row.Field<int>("barang_id"),
                nama_barang = row.Field<string>("nama_barang"),
                harga = row.Field<int>("harga"),
                jumlah = row.Field<int>("jumlah"),
                tanggal_pembelian = DateOnly.FromDateTime(row.Field<DateTime>("tanggal_pembelian")),
                foto_barang = row.Field<string>("foto_barang"),
                kategori = row.Field<string>("kategori_nama_kategori"),
                merk = row.Field<string>("merk_merk")
            }).ToList();

            return Daftar_barang.ToArray();
        }

        public static M_Barang[] Getbarangbykategori(string kategori)
        {
            string query = "select * from barang where dihapus = False AND kategori_nama_kategori = 'keyword' ;";

            query = query.Replace("keyword", kategori);

            DataTable databarang = queryExecutor(query);

            List<M_Barang> Daftar_barang = databarang.AsEnumerable().Select(row => new M_Barang
            {
                barang_id = row.Field<int>("barang_id"),
                nama_barang = row.Field<string>("nama_barang"),
                harga = row.Field<int>("harga"),
                jumlah = row.Field<int>("jumlah"),
                tanggal_pembelian = DateOnly.FromDateTime(row.Field<DateTime>("tanggal_pembelian")),
                foto_barang = row.Field<string>("foto_barang"),
                kategori = row.Field<string>("kategori_nama_kategori"),
                merk = row.Field<string>("merk_merk")
            }).ToList();

            return Daftar_barang.ToArray();
        }

        public static Panel CreateItem(M_Barang data)
        {

            Panel panelbasebarang = new Panel
            {
                BackgroundImage = Properties.Resources.Base_panel_barang,
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(18, 18),
                Margin = new Padding(8),
                Name = "PanelBarangBaru",
                Size = new Size(211, 322),
                TabIndex = 0,
                Visible = true,
            };

            Label NamaBarang = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(3, 13),
                Name = data.nama_barang,
                Size = new Size(205, 28),
                TabIndex = 0,
                Text = data.nama_barang,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            PictureBox FotoBarang = new PictureBox
            {
                BackColor= Color.Transparent,
                Location = new Point(32, 49),
                Name = "FotoBarang",
                Size = new Size(145, 139),
                TabIndex = 1,
                TabStop = false,
                Image = !string.IsNullOrEmpty(data.foto_barang) && File.Exists(data.foto_barang)
                    ? Image.FromFile(data.foto_barang)
                    : Properties.Resources.DeafultImageBarang,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            Label Merk = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 196),
                Margin = new Padding(3),
                Name = "Merk",
                Padding = new Padding(5, 0, 0, 0),
                Size = new Size(110, 28),
                TabIndex = 2,
                Text = "Merk",
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label NamaMerk = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(95, 196),
                Margin = new Padding(3),
                Name = "NamaMerk",
                Padding = new Padding(5, 0, 5, 0),
                Size = new Size(113, 28),
                TabIndex = 4,
                Text = data.merk,
                TextAlign = ContentAlignment.MiddleRight,
            };

            Label Stok = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 230),
                Margin = new Padding(3),
                Name = "Stok",
                Padding = new Padding(5, 0, 0, 0),
                Size = new Size(110, 28),
                TabIndex = 3,
                Text = "Stok",
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label JumlahStok = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(95, 230),
                Margin = new Padding(3),
                Name = "JumlahStok",
                Padding = new Padding(5, 0, 5, 0),
                Size = new Size(113, 28),
                TabIndex = 5,
                Text = data.jumlah.ToString(),
                TextAlign = ContentAlignment.MiddleRight,
            };

            Label Rupiah = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(5, 273),
                Margin = new Padding(3),
                Name = "Rupiah",
                Padding = new Padding(5, 0, 0, 0),
                Size = new Size(46, 28),
                TabIndex = 6,
                Text = "Rp",
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label Harga = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(38, 273),
                Margin = new Padding(3),
                Name = "Harga",
                Size = new Size(110, 28),
                TabIndex = 7,
                Text = data.harga.ToString(),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            PictureBox ButtonEditBarang = new PictureBox
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_edit_barang,
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(165, 273),
                Name = "ButtonEditBarang",
                Size = new Size(36, 28),
                TabIndex = 8,
                TabStop = false,
            };

            void ButtonEditBarang_Click(object sender, EventArgs e)
            {
                V_HalTambahBarang v_HalTambahBarang = new V_HalTambahBarang();
                v_HalTambahBarang.LoadData(data);
                V_HalUtamaPemilik.LoadUserControl(v_HalTambahBarang);
            }


            ButtonEditBarang.Click += ButtonEditBarang_Click;
            

            panelbasebarang.Controls.Add(ButtonEditBarang);
            panelbasebarang.Controls.Add(Harga);
            panelbasebarang.Controls.Add(Rupiah);
            panelbasebarang.Controls.Add(JumlahStok);
            panelbasebarang.Controls.Add(NamaMerk);
            panelbasebarang.Controls.Add(Stok);
            panelbasebarang.Controls.Add(Merk);
            panelbasebarang.Controls.Add(FotoBarang);
            panelbasebarang.Controls.Add(NamaBarang);

            if (Session.CurrentUser.jabatan == "Admin")
            {
                ButtonEditBarang.Visible = false;
            }

            return panelbasebarang;
        }

        public static void AddBarang(M_Barang addbarang)
        {
            string query = $"INSERT INTO barang (nama_barang, harga, jumlah, tanggal_pembelian, foto_barang, kategori_nama_kategori, merk_merk) " +
                $"VALUES(@nama_barang, @harga, @jumlah, @tanggal_pembelian, @foto_barang, @kategori_nama_kategori, @merk_merk)";
            
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_barang", addbarang.nama_barang),
                new NpgsqlParameter("@harga", addbarang.harga),
                new NpgsqlParameter("@jumlah", addbarang.jumlah),
                new NpgsqlParameter("@tanggal_pembelian", addbarang.tanggal_pembelian),
                new NpgsqlParameter("@foto_barang", DbType.String){ Value = !string.IsNullOrEmpty(addbarang.foto_barang) ? addbarang.foto_barang : DBNull.Value },
                new NpgsqlParameter("@kategori_nama_kategori", addbarang.kategori),
                new NpgsqlParameter("@merk_merk", DbType.String) {Value = addbarang.merk_merk}
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateBarang(M_Barang addbarang)
        {
            string query = $"update barang set nama_barang = @nama_barang, " +
                $"harga = @harga, " +
                $"jumlah = @jumlah, " +
                $"tanggal_pembelian = " +
                $"@tanggal_pembelian, " +
                $"foto_barang = " +
                $"@foto_barang, " +
                $"kategori_nama_kategori = @kategori_nama_kategori, " +
                $"merk_merk = @merk_merk " +
                $"where barang_id = @barang_id";
        
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@barang_id", addbarang.barang_id),
                new NpgsqlParameter("@nama_barang", addbarang.nama_barang),
                new NpgsqlParameter("@harga", addbarang.harga),
                new NpgsqlParameter("@jumlah", addbarang.jumlah),
                new NpgsqlParameter("@tanggal_pembelian", addbarang.tanggal_pembelian),
                new NpgsqlParameter("@foto_barang", DbType.String){ Value = !string.IsNullOrEmpty(addbarang.foto_barang) ? addbarang.foto_barang : DBNull.Value },
                new NpgsqlParameter("@kategori_nama_kategori", addbarang.kategori),
                new NpgsqlParameter("@merk_merk", DbType.String) {Value = addbarang.merk_merk}
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteBarang(int id)
        {
            string query = $"update barang set dihapus = True where barang_id = @barang_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@barang_id", id)
            };

            commandExecutor(query, parameters);
        }

        public static M_Kategori[] LoadKategori()
        {
            string query = "select * from kategori";

            DataTable datakategori = queryExecutor(query);

            
            List<M_Kategori> Daftar_kategori = datakategori.AsEnumerable().Select(row => new M_Kategori
            {
                nama_kategori = row.Field<string>("nama_kategori")
            }).ToList();

            
            return Daftar_kategori.ToArray();
        }

        public static M_Merk[] LoadMerk()
        {
            string query = "select * from merk";

            DataTable datamerk = queryExecutor(query);


            List<M_Merk> Daftar_merk = datamerk.AsEnumerable().Select(row => new M_Merk
            {
                merk_id = row.Field<int>("merk_id"),
                merk = row.Field<string>("merk"),

            }).ToList();


            return Daftar_merk.ToArray();
        }

    }


}
