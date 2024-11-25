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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Loaddatagridview()
        {
            dataGridAdmin.ReadOnly = true;
            dataGridAdmin.AllowUserToAddRows = false;
            DataTable data_admin = C_Admin.Admin();
            if (data_admin == null)
            {
                MessageBox.Show("Error gagal memuat data");
                return;
            }

            dataGridAdmin.Columns.Clear();

            DataGridViewTextBoxColumn NomorKolom = new DataGridViewTextBoxColumn();
            NomorKolom.HeaderText = "No";
            NomorKolom.Name = "Nomor";
            dataGridAdmin.Columns.Add(NomorKolom);


            dataGridAdmin.DataSource = data_admin;

            if (dataGridAdmin.Columns["akun_id"] != null)
                dataGridAdmin.Columns["akun_id"].HeaderText = "ID";


            for (int i = 0; i < dataGridAdmin.Rows.Count; i++)
            {
                dataGridAdmin.Rows[i].Cells["Nomor"].Value = (i + 1).ToString();
            }

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Update",
                HeaderText = "Update",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
            };

            dataGridAdmin.Columns.Add(updateButtonColumn);
            dataGridAdmin.Columns.Add(deleteButtonColumn);


        }

        
    }

}