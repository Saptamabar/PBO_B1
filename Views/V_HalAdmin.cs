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
        public V_HalAdmin()
        {
            InitializeComponent();

        }

        private void V_HalAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable dataAkun = C_Admin.All();
            dataGridView1.DataSource = dataAkun;
            dataGridView1.AutoGenerateColumns = true;


            if (!dataGridView1.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editColumn);
            }
            if (!dataGridView1.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    HeaderText = "Hapus",
                    Text = "Hapus",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteColumn);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Akun_id"].Value);
                DataTable dataAkun = C_Admin.getDataAkunById(id);
                v_HalTambahAdmin.LoadData(dataAkun);
                V_HalUtamaPemilik.LoadUserControl(v_HalTambahAdmin);
            }

            if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Akun_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Hapus Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    C_Admin.DeleteAkun(id);
                    MessageBox.Show("Data berhasil dihapus!");
                    dataGridView1.DataSource = C_Admin.All();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        V_HalTambahAdmin v_HalTambahAdmin = new V_HalTambahAdmin();
        private void btnTambahAdmin_Click(object sender, EventArgs e)
        {
            V_HalUtamaPemilik.LoadUserControl(v_HalTambahAdmin);
        }
    }

}