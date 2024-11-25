using Npgsql;
using NpgsqlTypes;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B1.App.Context
{
    internal class C_Jabatan : DatabaseWrapper
    {
        private static string table = "akun";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable DataJabatan = queryExecutor(query);
            return DataJabatan;
        }
        public static void AddJabatan(M_Jabatan addJabatan)
        {
            string query = $"INSERT INTO {table} (jabatan) values (@jabatan)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@jabatan", NpgsqlDbType.Varchar){Value = addJabatan.jabatan},
            };
            commandExecutor(query, parameters);
        }

    }
}
