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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_B1.Views
{
    public partial class V_HalTambahAdmin : UserControl
    {
        public V_HalTambahAdmin()
        {
            InitializeComponent();
           
        }
        public bool IsEditMode { get; set; } = false;
        public void LoadData(DataTable data)
        {
            if (data.Rows.Count > 0)
            {
                label8.Text = "Update Data";
                tbUsername.Text = data.Rows[0]["Username"].ToString();
                tbPassword.Text = data.Rows[0]["Password"].ToString();
                tbNama.Text = data.Rows[0]["Nama"].ToString();
                cbJabatan.Text = data.Rows[0]["jabatan"].ToString();
                tbNohp.Text = data.Rows[0]["no_hp"].ToString();
                tbEmail.Text = data.Rows[0]["email"].ToString();
                cbJabatan.SelectedItem = data.Rows[0]["jabatan"].ToString();
                IsEditMode = true;
               
                UpdateButtonText();
            }
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
            var akun = new M_Akun(tbUsername.Text,tbPassword.Text)
            {
                Nama = tbNama.Text,
                jabatan = cbJabatan.Text,
                no_hp = tbNohp.Text,
                Email = tbEmail.Text,
                foto_profile = null
            };

            if (IsEditMode)
            {
                DialogResult dialogResult = MessageBox.Show("Yakin ingin mengubah data?", "Edit Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    C_Admin.UpdateAkun(akun);
                    MessageBox.Show("Data berhasil diperbarui!");
                    V_HalUtamaPemilik.LoadUserControl(new V_HalAdmin());
                }
               
            }
            else
            {
                bool isAdded = C_Admin.CheckUsernameAdd(akun);
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

    }
}
