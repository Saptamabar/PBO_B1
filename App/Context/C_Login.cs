using Npgsql;
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
    internal class C_Login : DatabaseWrapper
    {
        
        public M_Akun Validate(string username, string password)
        {
            M_Akun loginAkun = null;
            string query = "SELECT * FROM akun WHERE username = @username AND password = @password AND dihapus = False";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@username", username),
            new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    loginAkun = new M_Akun()
                    {
                        Akun_id = (int)reader["akun_id"],
                        Username = (string)reader["username"],
                        Password = (string)reader["password"],
                        Nama = (string)reader["Nama"],
                        jabatan = (string)reader["jabatan"],
                        foto_profile = reader["foto_profile"] == DBNull.Value ? null : (string)reader["foto_profile"],
                        Email = (string)reader["email"],
                        no_hp = (string)reader["no_hp"]
                    };
                };
            Session.CurrentUser = loginAkun;
            return loginAkun;
        }

    }
}