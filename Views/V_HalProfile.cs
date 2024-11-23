﻿using PBO_B1.App.Context;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B1.Views
{
    public partial class V_HalProfile : UserControl
    {
        private byte[] imageBytes;
        public V_HalProfile()
        {
            InitializeComponent();
            M_Akun data = Session.CurrentUser;
            LabelNama.Text = data.Nama;
            LabelUsername.Text = data.Username;
            LabelPassword.Text = data.Password;
            LabelNoHP.Text = data.no_hp;
            LabelEmail.Text = "Ga ada email";
            LabelJabatan.Text = data.jabatan;
            if (!string.IsNullOrEmpty(data.foto_profile))
            {
                imageBytes = Convert.FromBase64String(data.foto_profile);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Fotoprofile.Image = Image.FromStream(ms);
                }
            }
        }

        private void LabelNama_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            V_HalProfileUbah v_HalProfileUbah = new V_HalProfileUbah();
            V_HalUtamaPemilik.LoadUserControl(v_HalProfileUbah);
        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {
           
        }

        private void LabelJabatan_Click(object sender, EventArgs e)
        {
            ;
        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelNoHP_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}
