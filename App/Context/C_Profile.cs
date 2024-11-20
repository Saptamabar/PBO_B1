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
        
        public string ConvertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); // Simpan dalam format PNG (atau format lainnya sesuai kebutuhan)
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes); // Konversi ke string Base64
            }
        }

        public void SaveImageToDatabase(string base64String)
        {
            // Query untuk menyimpan data
            string query = "UPDATE akun SET foto_profile = @Image where akun_id = @id";

            // Parameter untuk query
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Image", DbType.String) { Value = base64String },
                new NpgsqlParameter("@id", Session.CurrentUser.Akun_id)
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
