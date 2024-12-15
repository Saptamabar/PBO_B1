using Npgsql;
using PBO_B1.App.Context;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.Views
{
    public partial class V_HalTambahBarang : UserControl
    {
        M_Barang data = new M_Barang();
        public bool IsEditMode { get; set; } = false;
        string destinationPath = null;
        public V_HalTambahBarang()
        {
            InitializeComponent();

        }

        private void Fotobarang_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Cek apakah file yang dipilih ada
                    if (File.Exists(f.FileName))
                    {

                        string sourcePath = f.FileName;

                        // Tentukan nama file baru
                        string fileName = Path.GetFileName(sourcePath);

                        string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Foto_barang");
                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        // Pastikan nama file memiliki ekstensi
                        string fileExtension = Path.GetExtension(sourcePath);
                        destinationPath = Path.Combine(destinationFolder, fileName);

                        // Salin file ke folder tujuan
                        File.Copy(sourcePath, destinationPath, overwrite: true);

                        Fotobarang.Image = Image.FromFile(destinationPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buttonsimpan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(destinationPath))
            {
                data.foto_barang = destinationPath;
            }
            try
            {

                data.nama_barang = TbNamaBarang.Text;
                data.jumlah = (int)Convert.ToInt64(TBStok.Text);
                data.harga = (int)Convert.ToInt64(TBHarga.Text);
                data.tanggal_pembelian = DateOnly.FromDateTime(TanggalPembelian.Value);
                data.kategori = daftarKategori.Text;
                data.merk_merk = daftraMerk.Text;


                if (IsEditMode)
                {
                    DialogResult dialogResult = MessageBox.Show("Yakin ingin mengubah data?", "Edit Data", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        C_Barang.UpdateBarang(data);
                        MessageBox.Show("Data berhasil diperbarui!");
                        V_HalUtamaPemilik.LoadUserControl(new V_HalBarang());
                    }

                }
                else
                {
                    C_Barang.AddBarang(data);
                    MessageBox.Show("Data berhasil ditambahkan!");
                    V_HalUtamaPemilik.LoadUserControl(new V_HalBarang());

                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Data harus lengkap", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData(M_Barang dataedit)
        {
            data.barang_id = dataedit.barang_id;
            TbNamaBarang.Text = dataedit.nama_barang;
            TBHarga.Text = dataedit.harga.ToString();
            TBStok.Text = dataedit.jumlah.ToString();
            Fotobarang.Image = !string.IsNullOrEmpty(dataedit.foto_barang) && File.Exists(dataedit.foto_barang)
                    ? Image.FromFile(dataedit.foto_barang)
                    : Properties.Resources.DeafultImageBarang;
            data.foto_barang = dataedit.foto_barang;
            daftarKategori.Text = dataedit.kategori.ToString();
            daftraMerk.Text = dataedit.merk;
            DateOnly dateOnly = dataedit.tanggal_pembelian;

            DateTime dateTime = dateOnly.ToDateTime(TimeOnly.MinValue);

            TanggalPembelian.Value = dateTime;
            BtnHapus.Visible = true;
            BtnHapus.Enabled = true;
            IsEditMode = true;
            Buttonsimpan.Text = "Update";
        }

      

        private void V_HalTambahBarang_Load(object sender, EventArgs e)
        {
            daftarKategori.Items.Clear();
            M_Kategori[] daftar_barang = C_Barang.LoadKategori();
            foreach (var data in daftar_barang)
            {
                daftarKategori.Items.Add(data.nama_kategori);
            }

            daftraMerk.Items.Clear();
            M_Merk[] daftar_merk = C_Barang.LoadMerk();
            foreach (var data in daftar_merk)
            {
                daftraMerk.Items.Add(data.merk);
            }
        }

        private void TBHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Input harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; 
            }

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            V_HalUtamaPemilik.LoadUserControl(new V_HalBarang());
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus {data.nama_barang}?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                C_Barang.DeleteBarang(data.barang_id);
                V_HalUtamaPemilik.LoadUserControl(new V_HalBarang());
                MessageBox.Show("Barang berhasil dihapus.", "Hapus barang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Barang tidak dihapus", "Hapus barang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
