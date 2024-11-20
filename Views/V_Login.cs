using Microsoft.VisualBasic.ApplicationServices;
using PBO_B1.App.Context;
using PBO_B1.App.Models;
using PBO_B1.Views;

namespace PBO_B1
{
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            C_Login login = new C_Login();
            M_Akun login_Akun = login.Validate(tbUsername.Text, tbPassword.Text);

            if (login_Akun != null)
            {
                if (login_Akun.jabatan == "Owner")
                {
                    Hide();
                    V_HalUtamaPemilik Halutama = new V_HalUtamaPemilik();
                    Halutama.ShowDialog();
                }
                else
                {
                    Hide() ;
                    V_HalUtamaKaryawan halUtamaKaryawan = new V_HalUtamaKaryawan();
                    halUtamaKaryawan.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "ERROR", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void V_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
