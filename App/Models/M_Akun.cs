using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B1.App.Models
{
    internal class M_Akun
    {
        public M_Akun(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public int Akun_id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }

        public string jabatan { get; set; }
        public string foto_profile { get; set; }
        public string jabatan_jabatan { get; set; }
        public string no_hp { get; set; }
    }
}
