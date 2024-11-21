using PBO_B1.App.Context;
using PBO_B1.App.Models;
using PBO_B1.Views;
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
    public partial class V_HalBarang : Form
    {

        public V_HalBarang()
        {
            InitializeComponent();
            this.Load += V_HalBarang_Load;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_UpdateBarang updateBarangForm = new V_UpdateBarang();

            if (updateBarangForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataBarang();
            }

            this.Show();
        }

        private void V_HalBarang_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
        }

        private void LoadDataBarang()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable barangData = C_Barang.GetAllBarang();
                if (barangData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data barang");
                    return;
                }
                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = barangData;

                if (dataGridView1.Columns["barang_id"] != null) dataGridView1.Columns["barang_id"].Visible = false;
                if (dataGridView1.Columns["nama_barang"] != null)
                    dataGridView1.Columns["nama_barang"].HeaderText = "Nama barang";
                if (dataGridView1.Columns["merk"] != null)
                    dataGridView1.Columns["merk"].HeaderText = "Merk";
                if (dataGridView1.Columns["kategori"] != null)
                    dataGridView1.Columns["kategori"].HeaderText = "Kategori";
                if (dataGridView1.Columns["jumlah"] != null)
                    dataGridView1.Columns["jumlah   "].HeaderText = "Jumlah";
                if (dataGridView1.Columns["tanggal_pembelian"] != null)
                    dataGridView1.Columns["tanggal_pembelian"].HeaderText = "Tanggal_pembelian";
                if (dataGridView1.Columns["harga"] != null)
                    dataGridView1.Columns["harga"].HeaderText = "Harga";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }

                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataBarang: {ex.Message}\n{ex.StackTrace}");
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    int barangID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["barang_id"].Value);

                    DataTable mahasiswaData = C_Barang.GetBarangById(barangID);

                    if (mahasiswaData.Rows.Count > 0)
                    {
                        DataRow row = mahasiswaData.Rows[0];
                        C_Barang barang = new C_Barang
                        {
                            barang_id = (int)row["barang_id"],
                            nama_barang = row["nama_barang"].ToString(),
                            merk_merk = row["merk_merk"].ToString(),
                            kategori = row["kategori"].ToString(),
                            jumlah = (int)row["jumlah"],
                            harga = (int)row["harga"]
                        };

                        this.Hide();
                        V_UpdateBarang updateBarangForm = new V_UpdateBarang();
                        if (updateBarangForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDataBarang();
                        }
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int barangId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                C_Barang.DeleteBarang(barangId);
                LoadDataBarang();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
