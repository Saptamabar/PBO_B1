using PBO_B1.App.Context;
using System;
using System.Data;
using System.Windows.Forms;
using PBO_B1.App.Context;
using PBO_B1.App.Core;

namespace PBO_B1.Views
{
    public partial class V_HalAdmin : UserControl
    {
        V_HalTambahAdmin v_HalTambahAdmin = new V_HalTambahAdmin();

        public V_HalAdmin()
        {
            InitializeComponent();

        }

        private void V_HalAdmin_Load(object sender, EventArgs e)
        {
            // Bersihkan semua kolom
            dataGridAdmin.Columns.Clear();

            // Tambahkan kolom nomor
            DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "No",
                Name = "nomor",
                ReadOnly = true // Kolom hanya-baca
            };
            dataGridAdmin.Columns.Add(nomorColumn);

            // Set DataSource
            DataTable dataAkun = C_Admin.All();
            dataGridAdmin.DataSource = dataAkun;

            dataGridAdmin.ReadOnly = true;
            dataGridAdmin.AutoGenerateColumns = false;
            dataGridAdmin.Columns["Akun_id"].Visible = false;
            dataGridAdmin.Columns["dihapus"].Visible = false;


            // Tambahkan kolom Edit dan Hapus jika belum ada
            if (!dataGridAdmin.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridAdmin.Columns.Add(editColumn);
            }

            if (!dataGridAdmin.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    HeaderText = "Hapus",
                    Text = "Hapus",
                    UseColumnTextForButtonValue = true
                };
                dataGridAdmin.Columns.Add(deleteColumn);
            }

            // Pastikan event DataBindingComplete ditangani
            dataGridAdmin.DataBindingComplete += DataGridAdmin_DataBindingComplete;
        }

        private void DataGridAdmin_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Set nilai untuk kolom nomor
            for (int i = 0; i < dataGridAdmin.Rows.Count; i++)
            {
                dataGridAdmin.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridAdmin.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridAdmin.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Akun_id"].Value);
                DataTable dataAkun = C_Admin.getDataAkunById(id);
                v_HalTambahAdmin.LoadData(dataAkun);
                V_HalUtamaPemilik.LoadUserControl(v_HalTambahAdmin);
            }

            if (e.ColumnIndex == dataGridAdmin.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridAdmin.Rows[e.RowIndex].Cells["Akun_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Hapus Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    C_Admin.DeleteAkun(id);
                    MessageBox.Show("Data berhasil dihapus!");
                    dataGridAdmin.DataSource = C_Admin.All();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahAdmin_Click(object sender, EventArgs e)
        {
            V_HalUtamaPemilik.LoadUserControl(v_HalTambahAdmin);
        }
    }

}