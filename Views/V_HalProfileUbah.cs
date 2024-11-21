using PBO_B1.App.Core;
using PBO_B1.App.Models;
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
    public partial class V_HalProfileUbah : UserControl
    {
        private byte[] imageBytes;

        public V_HalProfileUbah()
        {
            InitializeComponent();
            M_Akun data = Session.CurrentUser;
            tbNama.Text = data.Nama;
            tbUsername.Text = data.Username;
            tbPassword.Text = data.Password;
            tbNohp.Text = data.no_hp;
            tbEmail.Text = "kocak di db ga ada email";
            tbJabatan.Text = data.jabatan;
            if (!string.IsNullOrEmpty(data.foto_profile))
            {
                imageBytes = Convert.FromBase64String(data.foto_profile);
            }
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                fotoprofile.Image = Image.FromStream(ms);
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
