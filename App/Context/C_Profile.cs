using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using PBO_B1.App.Core;
using PBO_B1.App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B1.App.Context
{
    internal class C_Profile : DatabaseWrapper
    {

        public void Updateprofile()
        {
            // Query untuk menyimpan data
            string query = "UPDATE akun SET username = @username, " +
                            "password = @password, " +
                            "nama = @nama," +
                            "jabatan = @jabatan, " +
                            "foto_profile = @foto_profile, " +
                            "no_hp= @no_hp, " +
                            "email= @email " +
                            "where akun_id = @id";

            // Parameter untuk query
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", Session.CurrentUser.Akun_id),
                new NpgsqlParameter("@username", Session.CurrentUser.Username),
                new NpgsqlParameter("@password", Session.CurrentUser.Password),
                new NpgsqlParameter("@nama", Session.CurrentUser.Nama),
                new NpgsqlParameter("@jabatan", Session.CurrentUser.jabatan),
                new NpgsqlParameter("@foto_profile", DbType.String) {Value = Session.CurrentUser.foto_profile},
                new NpgsqlParameter("@no_hp", Session.CurrentUser.no_hp),
                new NpgsqlParameter("@email", Session.CurrentUser.Email),

            };

            // Gunakan DatabaseWrapper untuk eksekusi
            try
            {
                commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Kesalahan saat menyimpan ke database: " + ex.Message);
            }
        }
    }

}

