using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_B1.App.Context;


namespace PBO_B1.Views
{
    public partial class V_HalUtamaPemilik : Form
    {
        V_HalProfile v_HalProfile = new V_HalProfile();
        V_HalBarang v_HalBarang = new V_HalBarang();
        V_HalTransaksi v_HalTransaksi = new V_HalTransaksi();
        V_HalLaporan v_HalLaporan = new V_HalLaporan();
        V_HalAdmin v_HalAdmin = new V_HalAdmin();
        V_HalProfileUbah v_HalProfileUbah = new V_HalProfileUbah();
        public V_HalUtamaPemilik()
        {
            InitializeComponent();
            LoadUserControl(v_HalProfile);
        }

        public static void LoadUserControl(Control control)
        {
            panelmain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panelmain.Controls.Add(control);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin keluar?", "Keluar", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                
            }
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadUserControl(v_HalProfile);
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            LoadUserControl(v_HalBarang);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            LoadUserControl(v_HalTransaksi);

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            LoadUserControl(v_HalLaporan);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoadUserControl(v_HalAdmin);

        }
    }
}
