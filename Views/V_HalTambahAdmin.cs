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
    public partial class V_HalTambahAdmin : UserControl
    {
        public M_Akun data = new M_Akun();
        public string sourcePath;
        public string destinationPath;
        public bool IsEditMode {get; set; } = false;
        public V_HalTambahAdmin()
        {
            InitializeComponent();
        }
        public void LoadData(DataTable data)
        {
            tbUsername.Text = data.Rows[0]["Username"].ToString();
            tbPassword.Text = data.Rows[0]["Password"].ToString();
            tbNama.Text = data.Rows[0]["Nama"].ToString();
            tbNohp.Text = data.Rows[0]["no_hp"].ToString();
            tbEmail.Text = data.Rows[0]["email"].ToString();
            FotoProfile.Image = !string.IsNullOrEmpty(data.Rows[0]["foto_profile"].ToString()) ? Image.FromFile(data.Rows[0]["foto_profile"].ToString()) : null ;

            IsEditMode = true;

            UpdateButtonText();
            
        }


        private void V_HalTambahAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            // Regular expression untuk memeriksa format email
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            // Cek apakah email sesuai dengan pola
            return emailRegex.IsMatch(email);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression untuk memastikan nomor HP dimulai dengan 0 dan panjangnya antara 10-15 digit
            var phoneRegex = new System.Text.RegularExpressions.Regex(@"^0\d{9,14}$");

            // Cek apakah nomor HP sesuai dengan pola
            return phoneRegex.IsMatch(phoneNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            data.Username = tbUsername.Text;
            data.Password = tbPassword.Text;
            data.Nama = tbNama.Text;
            data.jabatan = "Admin";
            data.no_hp = tbNohp.Text;
            data.Email = tbEmail.Text;

            //Pengecekan data tidak boleh kosong
            if (string.IsNullOrWhiteSpace(data.Username) ||
                string.IsNullOrWhiteSpace(data.Password) ||
                string.IsNullOrWhiteSpace(data.Nama) ||
                string.IsNullOrWhiteSpace(data.no_hp) ||
                string.IsNullOrWhiteSpace(data.Email))
            {
                MessageBox.Show("Data kosong, tidak dapat menambahkan data.");
                return;
            }

            //Pengecekan panjang maksimal username

            if (data.Username.Length > 20)
            {
                MessageBox.Show("Username tidak boleh lebih dari 20 karakter.");
                return;
            }

            // Pengecekan panjang maksimal password
            if (data.Password.Length > 20)
            {
                MessageBox.Show("Password tidak boleh lebih dari 20 karakter.");
                return;
            }

            // Pengecekan panjang maksimal nama
            if (data.Nama.Length > 100)
            {
                MessageBox.Show("Nama tidak boleh lebih dari 100 karakter.");
                return;
            }


            // Pengecekan panjang maksimal nomor HP (misalnya 15 digit)
            if (data.no_hp.Length < 10 || data.no_hp.Length > 15)
            {
                MessageBox.Show("Nomor HP harus terdiri dari 10 hingga 15 digit.");
                return;
            }


            // Pengecekan apakah no_hp hanya berisi angka
            if (!IsValidPhoneNumber(data.no_hp))
            {
                MessageBox.Show("Nomor HP harus dimulai dengan 0 dan berisi antara 10 hingga 15 digit angka.");
                return;
            }

            // Pengecekan panjang maksimal email
            if (data.Email.Length > 50)
            {
                MessageBox.Show("Email tidak boleh lebih dari 50 karakter.");
                return;
            }

            // Pengecekan format email
            if (!IsValidEmail(data.Email))
            {
                MessageBox.Show("Email tidak valid. Pastikan email mengandung '@' dan '.' setelahnya.");
                return;
            }


            if (IsEditMode)
            {
                DialogResult dialogResult = MessageBox.Show("Yakin ingin mengubah data?", "Edit Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    C_Admin.UpdateAkun(data);
                    MessageBox.Show("Data berhasil diperbarui!");
                    V_HalUtamaPemilik.LoadUserControl(new V_HalAdmin());
                }

            }
            else
            {
                bool isAdded = C_Admin.CheckUsernameAdd(data);
                if (isAdded)
                {
                    MessageBox.Show("Data berhasil ditambahkan!");
                    V_HalUtamaPemilik.LoadUserControl(new V_HalAdmin());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_HalUtamaPemilik.LoadUserControl(new V_HalAdmin());
        }

        private void UpdateButtonText()
        {
            btnSimpan.Text = IsEditMode ? "Update" : "Add";
        }

        private void FotoProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(f.FileName))
                    {

                        sourcePath = f.FileName;

                        string fileName = Path.GetFileName(sourcePath);

                        string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Foto_profile");
                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        
                        string fileExtension = Path.GetExtension(sourcePath);
                        destinationPath = Path.Combine(destinationFolder, fileName);

                        File.Copy(sourcePath, destinationPath, overwrite: true);

                        data.foto_profile = destinationPath;
                        FotoProfile.Image = Image.FromFile(data.foto_profile);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
