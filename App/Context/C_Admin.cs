using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_B1.App.Core;
using PBO_B1.App.Models;

namespace PBO_B1.App.Context
{
    internal class C_Admin
    {
        public static DataTable Admin()
        {
            string query = @"
                SELECT * FROM akun where jabatan = 'Admin'";
            DataTable datapengguna = DatabaseWrapper.queryExecutor(query);
            return datapengguna;
        }

    }
}
