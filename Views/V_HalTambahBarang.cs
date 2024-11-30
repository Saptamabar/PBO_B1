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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_B1.Views
{
    public partial class V_HalTambahBarang : UserControl
    {
        M_Barang data = new M_Barang();
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
                        string destinationPath = Path.Combine(destinationFolder, fileName);

                        // Salin file ke folder tujuan
                        File.Copy(sourcePath, destinationPath, overwrite: true);

                        // Simpan path ke dalam data
                        data.foto_barang = destinationPath;
                        Fotobarang.Image = Image.FromFile(data.foto_barang);
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

        }
    }
}
