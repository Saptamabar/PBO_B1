using PBO_B1.App.Context;
using PBO_B1.App.Core;
using PBO_B1.App.Models;

namespace PBO_B1.Views
{
    public partial class V_HalProfileUbah : UserControl
    {

        C_Profile profile = new C_Profile();
        M_Akun data = Session.CurrentUser;
        Image image;
        string destinationPath = null;

        public V_HalProfileUbah()
        {
            InitializeComponent();
            tbNama.Text = data.Nama;
            tbUsername.Text = data.Username;
            tbPassword.Text = data.Password;
            tbNohp.Text = data.no_hp;
            tbEmail.Text = data.Email;
            labeljabatan.Text = data.jabatan;
            lblnama.Text = data.Nama;
            if (!string.IsNullOrEmpty(data.foto_profile))
            {
                image = Image.FromFile(data.foto_profile);
                fotoprofile.Image = image;
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
            fotoprofile.Image = Image.FromFile(data.foto_profile);
            V_HalProfile v_HalProfile = new V_HalProfile();

            V_HalUtamaPemilik.LoadUserControl(v_HalProfile);
        }

        private void fotoprofile_Click(object sender, EventArgs e)
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

                        string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Foto_profile");
                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        // Pastikan nama file memiliki ekstensi
                        string fileExtension = Path.GetExtension(sourcePath);
                        destinationPath = Path.Combine(destinationFolder, fileName);

                        // Salin file ke folder tujuan
                        File.Copy(sourcePath, destinationPath, overwrite: true);

                        // Simpan path ke dalam data
                        image = Image.FromFile(destinationPath);
                        fotoprofile.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(destinationPath))
            {
                data.foto_profile = destinationPath;
            }
            data.Nama = tbNama.Text;
            data.Username = tbUsername.Text;
            data.Password = tbPassword.Text;
            if (double.TryParse(tbNohp.Text, out _) == true)
            {
                data.no_hp = tbNohp.Text;
                data.Email = tbEmail.Text;
                profile.Updateprofile();
                MessageBox.Show("Profile berhasil di update!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                V_HalProfile v_HalProfile = new V_HalProfile();
                V_HalUtamaPemilik.LoadUserControl(v_HalProfile);
            }
            else
            {
                MessageBox.Show("No HP harus berupa angka!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void labeljabatan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jabatan tidak dapat diubah", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
