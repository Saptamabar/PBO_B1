using PBO_B1.App.Models;
using PBO_B1.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.App.Context
{
    class C_Detailtransaksi
    {
        public static Panel CreateItem(M_Barang data)
        {
            int jumlah_awal = data.jumlah;
            int Jumlah_pembelian = 1;
            int jumlah = jumlah_awal - Jumlah_pembelian;  
            data.jumlah = Jumlah_pembelian;

            Panel panelbarang = new Panel()
            {
                BackColor = Color.White,
                Location = new Point(5, 5),
                Margin = new Padding(5),
                Name = "panelbarang",
                Padding = new Padding(3),
                Size = new Size(1106, 191),
                TabIndex = 0,
            };

            Label Stokbarang = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(183, 84),
                Name = "Stokbarang",
                Size = new Size(281, 23),
                TabIndex = 10,
                Text = jumlah.ToString(),
            };

            Label Total = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(963, 143),
                Name = "Total",
                Size = new Size(125, 25),
                TabIndex = 8,
                Text = $"Rp {Jumlah_pembelian * data.harga}",
                TextAlign = ContentAlignment.MiddleRight,
            };

            Label label3 = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(939, 106),
                Name = "label3",
                Size = new Size(118, 25),
                TabIndex = 7,
                Text = "Sub Total :",
            };

            TextBox Jumlahpembelian = new TextBox()
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(229, 148),
                Name = "Jumlah",
                Size = new Size(30, 24),
                TabIndex = 11,
                Text = Jumlah_pembelian.ToString(),
                TextAlign = HorizontalAlignment.Center,
            };

            Label Harga = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(183, 114),
                Name = "Harga",
                Size = new Size(281, 23),
                TabIndex = 3,
                Text = $"Rp. {data.harga}",
            };

            Label namamerk = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(183, 54),
                Name = "namamerk",
                Size = new Size(281, 23),
                TabIndex = 2,
                Text = data.merk,
            };

            Label lblNamaBarang = new Label()
            {
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(183, 24),
                Name = "lblNamaBarang",
                Size = new Size(281, 23),
                TabIndex = 1,
                Text = data.nama_barang
            };

            PictureBox Fotobarang = new PictureBox()
            {
                Image = !string.IsNullOrEmpty(data.foto_barang) && File.Exists(data.foto_barang)
                    ? Image.FromFile(data.foto_barang)
                    : Properties.Resources.DeafultImageBarang,
                Location = new Point(30, 23),
                Name = "Fotobarang",
                Size = new Size(130, 130),
                TabIndex = 0,
                TabStop = false,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            PictureBox ButtonHapus = new PictureBox()
            {
                Image = Properties.Resources.Button_hapus,
                Location = new Point(1055, 6),
                Name = "ButtonHapus",
                Size = new Size(31, 42),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 9,
                TabStop = false,
            };

            PictureBox Buttonkurang = new PictureBox()
            {
                Image = Properties.Resources.Tombol_Kurang_Keranjang,
                Location = new Point(183, 143),
                Name = "Buttonkurang",
                Size = new Size(39, 36),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 4,
                TabStop = false,
            };

            PictureBox Buttontambah = new PictureBox()
            {
                Image = Properties.Resources.Tombol_Tambah_Keranjang,
                Location = new Point(268, 143),
                Name = "Buttontambah",
                Size = new Size(39, 36),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 5,
                TabStop = false,
            };

            Jumlahpembelian.KeyPress += Jumlahpembelian_KeyPress;
            ButtonHapus.Click += ButtonHapus_Click;
            Buttonkurang.Click += Buttonkurang_Click;
            Buttontambah.Click += Buttontambah_Click;

         

            void Jumlahpembelian_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    try
                    {
                        Jumlah_pembelian = Convert.ToInt32(Jumlahpembelian.Text);
                        if (Convert.ToInt32(Jumlahpembelian.Text) > jumlah_awal)
                        {
                            MessageBox.Show("Jumlah pembelian melebihi stok barang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else if (Convert.ToInt32(Jumlahpembelian.Text) < 1)
                        {
                            MessageBox.Show("Jumlah pembelian tidak boleh kurang dari 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Jumlah_pembelian = 1;
                            Jumlahpembelian.Text = Jumlah_pembelian.ToString();
                        }
                        else
                        {
                            jumlah = jumlah_awal - Jumlah_pembelian;
                            Jumlahpembelian.Text = Jumlah_pembelian.ToString();
                            Stokbarang.Text = jumlah.ToString();
                            Total.Text = $"Rp {Jumlah_pembelian * data.harga}";
                            data.jumlah = Jumlah_pembelian;
                            V_DetailTransaksi.updatetotalHarga();
                        }

                    }

                    catch (Exception ex) 
                    { 
                        MessageBox.Show("Inputan harus angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            void Buttontambah_Click(object sender, EventArgs e)
            {
                Jumlah_pembelian += 1;
                if (Convert.ToInt32(Jumlahpembelian.Text) > jumlah_awal - 1)
                {
                    MessageBox.Show("Jumlah pembelian melebihi stok barang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Jumlah_pembelian = 1;
                    jumlah = jumlah_awal - Jumlah_pembelian;
                    Jumlahpembelian.Text = Jumlah_pembelian.ToString();
                    Stokbarang.Text = jumlah.ToString();
                    Total.Text = $"Rp {Jumlah_pembelian * data.harga}";
                    V_DetailTransaksi.updatetotalHarga();
                }

                else
                {
                    jumlah = jumlah_awal - Jumlah_pembelian;
                    Jumlahpembelian.Text = Jumlah_pembelian.ToString();
                    Stokbarang.Text = jumlah.ToString();
                    Total.Text = $"Rp {Jumlah_pembelian * data.harga}";
                    data.jumlah = Jumlah_pembelian;
                    V_DetailTransaksi.updatetotalHarga();
                }
            }

            void Buttonkurang_Click(object sender, EventArgs e)
            {
                Jumlah_pembelian -= 1;
                if (Convert.ToInt32(Jumlahpembelian.Text) < 2)
                {
                    MessageBox.Show("Jumlah pembelian tidak boleh kurang dari 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Jumlah_pembelian = 1;
                    Jumlahpembelian.Text = Jumlah_pembelian.ToString();
                    return;
                }
                jumlah = jumlah_awal - Jumlah_pembelian;
                Jumlahpembelian.Text = Jumlah_pembelian.ToString();
                Stokbarang.Text = jumlah.ToString();
                Total.Text = $"Rp {Jumlah_pembelian * data.harga}";
                data.jumlah = Jumlah_pembelian;
                V_DetailTransaksi.updatetotalHarga();

            }

            void ButtonHapus_Click(object sender, EventArgs e)
            {
                List<M_Barang> keranjang = C_Transaksi.getkeranjang().ToList();
                keranjang.Remove(data);
                if (keranjang.Count == 0)
                {
                    MessageBox.Show("Isi Keranjang tidak boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                C_Transaksi.setkeranjang(keranjang.ToArray());
                V_DetailTransaksi.updatetotalHarga();

                // Hapus panel dari parent (FlowLayoutPanel)
                if (panelbarang.Parent != null)
                {
                    panelbarang.Parent.Controls.Remove(panelbarang);
                }

                // Bersihkan resource panel
                panelbarang.Dispose();
            }


            panelbarang.Controls.Add(Stokbarang);
            panelbarang.Controls.Add(ButtonHapus);
            panelbarang.Controls.Add(Total);
            panelbarang.Controls.Add(label3);
            panelbarang.Controls.Add(Jumlahpembelian);
            panelbarang.Controls.Add(Buttontambah);
            panelbarang.Controls.Add(Buttonkurang);
            panelbarang.Controls.Add(Harga);
            panelbarang.Controls.Add(namamerk);
            panelbarang.Controls.Add(lblNamaBarang);
            panelbarang.Controls.Add(Fotobarang);
            return panelbarang;
        }
    }
}
