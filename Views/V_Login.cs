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
            tbUsername.KeyDown += new KeyEventHandler(tb_KeyDown);
            tbPassword.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnLogin_Click(sender, e);
            }
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
                
                Hide();
                V_Loadingscreen loadingscreen = new V_Loadingscreen();
                //loadingscreen.ShowDialog();
                V_HalUtamaPemilik Halutama = new V_HalUtamaPemilik();
                Halutama.ShowDialog();
                
                
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
