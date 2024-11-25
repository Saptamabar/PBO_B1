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
            DataTable dataAkun = C_Admin.All();
            dataGridView1.DataSource = dataAkun;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //V_HalTambahAdmin v_HalTambahAdmin = new V_HalTambahAdmin();
            //v_HalTambahAdmin.Show();
            //V_HalProfile v_HalProfile = new V_HalProfile();
            //v_HalProfile.Show();
        }
    }
}
