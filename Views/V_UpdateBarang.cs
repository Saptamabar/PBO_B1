using PBO_B1.App.Context;
using PBO_B1.App.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PBO_B1.Views
{
    public partial class V_UpdateBarang : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int BarangId { get; set; }
        public V_UpdateBarang()
        {
            InitializeComponent();
            UpdateButtonText();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Barang barang = new M_Barang
            {
                nama_barang = textBox1.Text,
                merk_merk = textBox2.Text,
                kategori = textBox3.Text,
                jumlah = int.Parse(textBox4.Text),
                harga = int.Parse(textBox5.Text),

            };

            if (IsEditMode)
            {
                barang.id = BarangId;
                C_Barang.UpdateBarang(barang);
                MessageBox.Show("Barang berhasil diupdate");
            }
            else
            {
                C_Barang.AddBarang(barang);
                MessageBox.Show("Barang baru berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();

        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                !int.TryParse(textBox4.Text, out _) ||
                !int.TryParse(textBox5.Text, out _))

            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }


        private void UpdateButtonText()
        {
            button1.Text = IsEditMode ? "Update" : "Add";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }


        private void UpdateBarang_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
