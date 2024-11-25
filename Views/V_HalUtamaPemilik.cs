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
    public partial class V_HalUtamaPemilik : Form
    {
        V_HalProfile v_HalProfile = new V_HalProfile();
        V_HalBarang v_HalBarang = new V_HalBarang();
        V_HalTransaksi v_HalTransaksi = new V_HalTransaksi();
        V_HalLaporan v_HalLaporan = new V_HalLaporan();
        V_HalAdmin v_HalAdmin = new V_HalAdmin();
        public V_HalUtamaPemilik()
        {
            InitializeComponent();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(v_HalProfile);
            v_HalProfile.Dock = DockStyle.Fill;
        }

        private void V_HalUtamaPemilik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            panelmain.Controls.Add(v_HalProfile);
            v_HalProfile.Dock = DockStyle.Fill;
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            panelmain.Controls.Add(v_HalBarang);
            v_HalBarang.Dock = DockStyle.Fill;
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            panelmain.Controls.Add(v_HalTransaksi);
            v_HalTransaksi.Dock = DockStyle.Fill;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            panelmain.Controls.Add(v_HalLaporan);
            v_HalLaporan.Dock = DockStyle.Fill;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            panelmain.Controls.Add(v_HalAdmin);
            v_HalAdmin.Dock = DockStyle.Fill;
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
