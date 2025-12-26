using Npgsql;
using System;
using System.Security.Cryptography;
using System.Text;

namespace tr
{
    public class Globals
    {
        public static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=qwert;Database=BD1";
        public static NpgsqlConnection connection = null;

        /*public static string HashPasswordWithSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }*/

        public enum CallType
        {
            ADD,
            CHANGE,
            OTHER
        }
    }
}
