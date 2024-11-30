using PBO_B1.App.Context;
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
    public partial class V_HalAdmin : UserControl
    {
        public V_HalAdmin()
        {
            InitializeComponent();
            Loaddatagridview();
        }

        public void Loaddatagridview()
        {
            dataGridAdmin.AllowUserToAddRows = false;
            dataGridAdmin.AllowUserToDeleteRows = false;

            dataGridAdmin.Columns.Clear();

            DataTable data_admin = C_Admin.Admin();
            if (data_admin == null)
            {
                MessageBox.Show("Error gagal memuat data");
                return;
            }
            dataGridAdmin.DataSource = data_admin;

            dataGridAdmin.Columns["akun_id"].Visible = false;


            DataGridViewTextBoxColumn nomorKolom = new DataGridViewTextBoxColumn
            {
                HeaderText = "No",
                Name = "Nomor",
                ReadOnly = true
            };
            dataGridAdmin.Columns.Insert(0, nomorKolom);

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Update",
                HeaderText = "Update",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
            };
            dataGridAdmin.Columns.Add(updateButtonColumn);
            dataGridAdmin.Columns.Add(deleteButtonColumn);

            dataGridAdmin.DataBindingComplete += (s, e) =>
            {
                for (int i = 0; i < dataGridAdmin.Rows.Count; i++)
                {
                    dataGridAdmin.Rows[i].Cells["Nomor"].Value = (i + 1).ToString();
                }
            };

            dataGridAdmin.ReadOnly = true;

        }

        private void dataGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataGridAdmin.DataSource = C_Admin.Admin();
                }
            }


        }

    }
}