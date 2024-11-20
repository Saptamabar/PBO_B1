using PBO_B1.App.Context;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.Views
{
    public partial class V_HalProfile : UserControl
    {
        V_HalProfileUbah v_HalProfileUbah = new V_HalProfileUbah();
        public V_HalProfile()
        {
            InitializeComponent();
            M_Akun data = Session.CurrentUser;
            LabelNama.Text = data.Nama;
            LabelUsername.Text = data.Username;
            LabelPassword.Text = data.Password;
            LabelNoHP.Text = data.no_hp;
            LabelEmail.Text = "Ga ada email";
            LabelJabatan.Text = data.jabatan;
            byte[] imageBytes = Convert.FromBase64String(data.foto_profile);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Fotoprofile.Image = Image.FromStream(ms);
            }
        }

        private void LabelNama_Click(object sender, EventArgs e)
        {
            
            v_HalProfileUbah.Show();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            C_Profile profile = new C_Profile();
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Membaca file gambar
                    Image image = Image.FromFile(f.FileName);
                    Fotoprofile.Image = image; // Menampilkan gambar di kontrol (misalnya PictureBox)

                    // Konversi gambar ke Base64 string
                    string base64String = profile.ConvertImageToBase64(image);

                    // Simpan Base64 string ke database
                    profile.SaveImageToDatabase(base64String);
                    MessageBox.Show("Gambar berhasil disimpan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {
            this.Hide();
            v_HalProfileUbah.Show();
        }

        private void LabelJabatan_Click(object sender, EventArgs e)
        {
            this.Hide();
            v_HalProfileUbah.Show();
        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            v_HalProfileUbah.Show();
        }

        private void LabelNoHP_Click(object sender, EventArgs e)
        {
            this.Hide();
            v_HalProfileUbah.Show();
        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            v_HalProfileUbah.Show();
        }
    }
}
