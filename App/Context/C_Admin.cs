using Npgsql;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PBO_B1.App.Core;
using PBO_B1.App.Models;

namespace PBO_B1.App.Context
{
    internal class C_Admin : DatabaseWrapper
    {
        private static string table = "akun";
        public static DataTable All()
        {
            string query = @"
                SELECT 
                    a.Akun_id,
                    a.Username,
                    a.Password,
                    a.Nama,
                    a.jabatan,
                    a.foto_profile,
                    a.jabatan_jabatan
                FROM 
                    akun a
                JOIN 
                    jabatan j ON a.Akun_id = j.jabatan_id";
            DataTable DataAkun = queryExecutor(query);
            return DataAkun;
        }

        public static DataTable getDataAkunById(int id)
        {
            string query = @"
                SELECT 
                    a.Akun_id,
                    a.Username,
                    a.Password,
                    a.Nama,
                    a.jabatan,
                    a.foto_profile,
                    a.jabatan_jabatan
                FROM 
                    akun a
                JOIN 
                    jabatan j ON a.Akun_id = j.jabatan_id
                WHERE 
                    a.Akun_id = @Akun_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Akun_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable DataAkun = queryExecutor(query, parameters);
            return DataAkun;
        }

        public static void AddAkun(M_Akun addAkun)
        {
            string query = $"INSERT INTO {table} (Akun_id, Username, Password, Nama, jabatan, foto_profile, jabatan_jabatan) VALUES(@Akun_id, @Username, @Password, @Nama, @jabatan, @foto_profile, @jabatan_jabatan)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Username", addAkun.Username),
                new NpgsqlParameter("@Password", addAkun.Password),
                new NpgsqlParameter("@Nama", addAkun.Nama),
                new NpgsqlParameter("@jabatan", addAkun.jabatan),
                new NpgsqlParameter("@foto_profile", addAkun.foto_profile),
                new NpgsqlParameter("@jabatan_jabatan", addAkun.jabatan_jabatan),
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateAkun(M_Akun editAkun)
        {
            string query = $"UPDATE INTO {table} (Akun_id, Username, Password, Nama, jabatan, foto_profile, jabatan_jabatan) VALUES(@Akun_id, @Username, @Password, @Nama, @jabatan, @foto_profile, @jabatan_jabatan)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Username", editAkun.Username),
                new NpgsqlParameter("@Password", editAkun.Password),
                new NpgsqlParameter("@Nama", editAkun.Nama),
                new NpgsqlParameter("@jabatan", editAkun.jabatan),
                new NpgsqlParameter("@foto_profile", editAkun.foto_profile),
                new NpgsqlParameter("@jabatan_jabatan", editAkun.jabatan_jabatan),
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteAkun(int id)
        {
            string query = $"DELETE FROM {table} WHERE Akun_id = @Akun_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Akun_id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
