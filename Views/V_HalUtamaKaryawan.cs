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
    public partial class V_HalUtamaKaryawan : Form
    {
        public V_HalUtamaKaryawan()
        {
            InitializeComponent();
        }

        private void V_HalUtamaKaryawan_Load(object sender, EventArgs e)
        {

        }

        public static void LoadUserControl(Control control)
        {
            panelmain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panelmain.Controls.Add(control);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            V_HalProfile v_HalProfile = new V_HalProfile();

            LoadUserControl(v_HalProfile);
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            V_HalBarang v_HalBarang = new V_HalBarang();
            LoadUserControl(v_HalBarang);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            V_HalLaporan v_HalLaporan = new V_HalLaporan();
            LoadUserControl(v_HalLaporan);
        }
    }
}
