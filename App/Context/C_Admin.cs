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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_B1.App.Context
{
    internal class C_Admin : DatabaseWrapper
    {
        private static string table = "akun";
        public static DataTable All()
        {
            string query = "select * from akun where jabatan = 'Admin' and dihapus = false";
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
                    a.no_hp,
                    a.email
                FROM 
                    akun a
                WHERE 
                    a.Akun_id = @Akun_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Akun_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable DataAkun = queryExecutor(query, parameters);
            return DataAkun;
        }

        public static bool CheckUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM akun WHERE Username = @Username";
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@Username", username)
    };

            DataTable result = queryExecutor(query, parameters);

            return Convert.ToInt32(result.Rows[0][0]) > 0;
        }


        public static bool CheckUsernameAdd(M_Akun addAkun)
        {
            if (!CheckUsernameExists(addAkun.Username))
            {
                AddAkun(addAkun);
                return true;
                
            }
            else
            {
                MessageBox.Show("Username sudah ada, mohon masukkan username lain.");
                return false;
            }
        }


        public static void AddAkun(M_Akun addAkun)
        {
            string query = $"INSERT INTO {table} (Username, Password, Nama, jabatan, foto_profile, no_hp, email) VALUES(@Username, @Password, @Nama, @jabatan, @foto_profile, @no_hp, @email)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Username", addAkun.Username),
                new NpgsqlParameter("@Password", addAkun.Password),
                new NpgsqlParameter("@Nama", addAkun.Nama),
                new NpgsqlParameter("@jabatan", addAkun.jabatan),
                new NpgsqlParameter("@foto_profile", DbType.String){ Value = !string.IsNullOrEmpty(addAkun.foto_profile) ? addAkun.foto_profile : DBNull.Value },
                new NpgsqlParameter("@no_hp", addAkun.no_hp),
                new NpgsqlParameter("@email", addAkun.Email)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateAkun(M_Akun editAkun)
        {

            string query = @$"UPDATE {table}
                 SET 
                     Password = @Password,
                     Nama = @Nama,
                     jabatan = @jabatan,
                     foto_profile = @foto_profile,
                     no_hp = @no_hp,
                     email = @Email
                 WHERE 
                     Username = @Username";


            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Username", editAkun.Username),
                new NpgsqlParameter("@Password", editAkun.Password),
                new NpgsqlParameter("@Nama", editAkun.Nama),
                new NpgsqlParameter("@jabatan", editAkun.jabatan),
                new NpgsqlParameter("@foto_profile", editAkun.foto_profile),
                new NpgsqlParameter("@no_hp", editAkun.no_hp),
                new NpgsqlParameter("@email", editAkun.Email)
            };

            commandExecutor(query, parameters);

        }

        public static void DeleteAkun(int id)
        {
            string query = $"UPDATE {table} SET dihapus = true WHERE Akun_id = @Akun_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@Akun_id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
