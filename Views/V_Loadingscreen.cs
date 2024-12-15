using System;
using System.Windows.Forms;

namespace PBO_B1.Views
{
    public partial class V_Loadingscreen : Form
    {
        private int timeElapsed = 0; // Counter untuk melacak waktu

        public V_Loadingscreen()
        {
            InitializeComponent();

            // Atur properti awal ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 3;
            progressBar1.Step = 1;

            // Aktifkan timer
            timer1.Interval = 500; // 1 detik
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;

            // Tambah nilai progress bar
            progressBar1.PerformStep();

            // Tutup form setelah 3 detik
            if (timeElapsed >= 5)
            {
                timer1.Stop(); // Hentikan timer
                this.Close(); // Tutup form
                

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Tidak ada aksi untuk klik pada ProgressBar
        }
    }
}
