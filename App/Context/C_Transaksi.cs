using Npgsql;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using PBO_B1.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_B1.App.Context
{
    class C_Transaksi : DatabaseWrapper
    {
        public static List<M_Barang> ListKeranjang = new List<M_Barang>();

        public static void InsertTransaksiandDetail()
        {
            AddTransaksi();
            int transaksi_id = Getidtransaksi();
            AddDetailtransaksi(transaksi_id);
            SetAllBarang();
            List<M_Barang> list = new List<M_Barang>();
            M_Barang[] arraykosong = list.ToArray();
            setkeranjang(arraykosong);
        }

        public static void AddTransaksi()
        {
            string query = "INSERT INTO transaksi (tanggal, total, akun_username) " +
                "VALUES (@tanggal, @total, @akun_username)";
            NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@tanggal",DbType.Date) {Value = DateTime.Today.Date},
                new NpgsqlParameter("@total",V_DetailTransaksi.JumlahTotal),
                new NpgsqlParameter("@akun_username",Session.CurrentUser.Username)
            };

            commandExecutor(query, parameters);
        }

        public static int Getidtransaksi()
        {
            int id_transaksi = 0;

            string query = "SELECT * FROM transaksi ORDER BY transaksi_id DESC LIMIT 1;";

            NpgsqlParameter[] parameters =
            { };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    id_transaksi = (int)reader["transaksi_id"];
                };
            
            return id_transaksi;
        }

        public static void AddDetailtransaksi(int transaksi_id)
        {
            M_Barang[] data = getkeranjang();
            foreach (M_Barang bar in data)
            {
                string query = "INSERT INTO detail_transaksi (harga, jumlah, barang_barang_id, transaksi_transaksi_id) " +
                "VALUES (@harga, @jumlah, @barang_id, @transaksi_id)";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@harga",bar.harga),
                    new NpgsqlParameter("@jumlah",bar.jumlah),
                    new NpgsqlParameter("@barang_id",bar.barang_id),
                    new NpgsqlParameter("@transaksi_id",transaksi_id)
                };

                commandExecutor(query, parameters);
            }
            
        }

        public static M_Barang[] getAllBarang()
        {
            string query = "select * from barang where dihapus = False  and jumlah > 0";

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

        public static void SetAllBarang()
        {
            M_Barang[] barang = getkeranjang();

            foreach (M_Barang bar in barang)
            {
                int jumlah = 0;
                int sisa = 0;

                string query = "select * from barang where dihapus = False and barang_id = @barang_id";
                NpgsqlParameter[] parameters =
                {
            new NpgsqlParameter("@barang_id", bar.barang_id)
        };

                using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))
                {
                    if (reader.Read())
                    {
                        jumlah = (int)reader["jumlah"];
                        sisa = jumlah - bar.jumlah;
                    }
                    else
                    {
                        throw new Exception($"Barang dengan ID {bar.barang_id} tidak ditemukan.");
                    }
                }

                string query2 = "update barang set " +
                                "jumlah = @jumlah " +
                                "where barang_id = @barang_id";

                NpgsqlParameter[] parameters2 =
                {
            new NpgsqlParameter("@jumlah", sisa),
            new NpgsqlParameter("@barang_id", bar.barang_id)
        };

                commandExecutor(query2, parameters2);
            }
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
                BackColor = Color.Transparent,
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

            PictureBox ButtonTambahKeranjang = new PictureBox
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_tambah__barang,
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(165, 273),
                Name = "ButtonTambahKerangjang",
                Size = new Size(36, 28),
                TabIndex = 8,
                TabStop = false,
            };

            void ButtonTambahKeranjang_Click(object sender, EventArgs e)
            {

                var existingItem = ListKeranjang.FirstOrDefault(item => item.barang_id == data.barang_id);
                if (existingItem != null)
                {
                    
                }
                else
                {
                    M_Barang databarangkeranjang = new M_Barang
                    {
                        barang_id = data.barang_id,
                        nama_barang = data.nama_barang,
                        merk_merk = data.merk_merk,
                        harga = data.harga,
                        jumlah = data.jumlah,
                        tanggal_pembelian = data.tanggal_pembelian,
                        foto_barang = data.foto_barang,
                        kategori = data.kategori,
                        merk = data.merk
                    };
                    ListKeranjang.Add(databarangkeranjang);
                }

                V_HalLaporan.ShowKeranjang();
            }

            ButtonTambahKeranjang.Click += ButtonTambahKeranjang_Click;

            panelbasebarang.Controls.Add(ButtonTambahKeranjang);
            panelbasebarang.Controls.Add(Harga);
            panelbasebarang.Controls.Add(Rupiah);
            panelbasebarang.Controls.Add(NamaMerk);
            panelbasebarang.Controls.Add(Merk);
            panelbasebarang.Controls.Add(FotoBarang);
            panelbasebarang.Controls.Add(NamaBarang);

            return panelbasebarang;
        }

        public static Panel CreateKeranjang(M_Barang data)
        {
            Panel panelkeranjang = new Panel
            {
                BackColor = Color.White,
                Location = new Point(3, 3),
                Name = "PanelKeranjang",
                Size = new Size(208, 101),
                TabIndex = 0,
            };

            Label lblNamaBarang = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(3, 11),
                Name = "lblNamaBarang",
                Size = new Size(202, 24),
                TabIndex = 0,
                Text = data.nama_barang,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label Merk = new Label
            {
                Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(17, 57),
                Name = "Merk",
                Size = new Size(84, 24),
                TabIndex = 5,
                Text = data.merk,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label lblHarga = new Label
            {
                Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(126, 57),
                Name = "lblHarga",
                Size = new Size(69, 24),
                TabIndex = 4,
                Text = data.harga.ToString(),
                TextAlign = ContentAlignment.MiddleRight,
            };

            PictureBox buttonhapus = new PictureBox
            {
                Image = Properties.Resources.Button_hapus, // Pastikan resource ini ada
                Location = new Point(17, 11), // Pastikan lokasi ini berada dalam batas panel
                Name = "btnHapus",
                Size = new Size(29, 24),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 0,
                TabStop = false,
                Visible = true // Pastikan kontrol ini terlihat
            };

            buttonhapus.Click += buttonhapus_Click;
            // Pastikan ini dipanggil setelah semua kontrol ditambahkan ke panel
            buttonhapus.BringToFront();

            void buttonhapus_Click(object sender, EventArgs e)
            {
                // Find the parent panel of the clicked button
                var button = sender as PictureBox;
                var panel = button?.Parent as Panel;

                if (panel != null)
                {
                    // Find the label that contains the item name
                    var lblNamaBarang = panel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "lblNamaBarang");

                    if (lblNamaBarang != null)
                    {
                        // Find the item in the shopping cart list
                        var itemToRemove = ListKeranjang.FirstOrDefault(item => item.nama_barang == lblNamaBarang.Text);

                        if (itemToRemove != null)
                        {
                            // Remove the item from the shopping cart list
                            ListKeranjang.Remove(itemToRemove);

                            // Optionally, update the UI to reflect the removal
                            V_HalLaporan.ShowKeranjang();
                            
                        }
                    }
                }
            }

            panelkeranjang.Controls.Add(buttonhapus);
            panelkeranjang.Controls.Add(Merk);
            panelkeranjang.Controls.Add(lblHarga);
            panelkeranjang.Controls.Add(lblNamaBarang);

            return panelkeranjang;
        }


        public static M_Barang[] getkeranjang()
        {
            return ListKeranjang.ToArray();
        }
        public static void setkeranjang(M_Barang[] barangArray)
        {
            
            ListKeranjang = barangArray.ToList();
            
        }
    }
}
