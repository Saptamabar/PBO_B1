using PBO_B1.App.Context;
using PBO_B1.App.Core;
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
    public partial class V_HalProfileUbah : UserControl
    {
        private byte[] imageBytes;
        string foto_profile;
        C_Profile profile = new C_Profile();
        M_Akun data = Session.CurrentUser;

        public V_HalProfileUbah()
        {
            InitializeComponent();
            tbNama.Text = data.Nama;
            tbUsername.Text = data.Username;
            tbPassword.Text = data.Password;
            tbNohp.Text = data.no_hp;
            tbEmail.Text = data.Email;
            tbJabatan.Text = data.jabatan;
            if (!string.IsNullOrEmpty(data.foto_profile))
            {
                imageBytes = Convert.FromBase64String(data.foto_profile);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    fotoprofile.Image = Image.FromStream(ms);
                }
            }

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void V_HalProfileUbah_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            V_HalProfile v_HalProfile = new V_HalProfile();
            V_HalUtamaPemilik.LoadUserControl(v_HalProfile);
        }

        private void fotoprofile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Membaca file gambar
                    Image image = Image.FromFile(f.FileName);
                    fotoprofile.Image = image; // Menampilkan gambar di kontrol (misalnya PictureBox)

                    // Konversi gambar ke Base64 string
                    foto_profile = profile.ConvertImageToBase64(image);
                    data.foto_profile = foto_profile;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            data.Nama = tbNama.Text;
            data.Username = tbUsername.Text;
            data.Password = tbPassword.Text;
            data.no_hp = tbNohp.Text;
            data.Email = tbEmail.Text;
            data.jabatan = tbJabatan.Text;
            profile.Updateprofile();
            MessageBox.Show("Profile berhasil di update!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
