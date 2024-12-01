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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            data.Username = tbUsername.Text;
            data.Password = tbPassword.Text;
            data.Nama = tbNama.Text;
            data.jabatan = "Admin";
            data.no_hp = tbNohp.Text;
            data.Email = tbEmail.Text;
            

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
