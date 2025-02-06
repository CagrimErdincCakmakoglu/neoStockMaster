using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace neoStockMaster.Data.Entities
{
    public class User
    {
        public string ID { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; private set; }  // Hash'lenmiş şifre
        public string PasswordSalt { get; private set; }  // Salt değeri
        public string Cargo { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int UsageRemainingDays { get; set; }
        public string Language { get; set; }
        public List<string> LastLoginIps { get; set; } = new List<string>();



        public User(string name, string email, string password, string language)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            RegistrationDate = DateTime.Now;
            Language = language;

            // Şifreyi hash'leyerek sakla
            GeneratePasswordHash(password);
        }

        public void GeneratePasswordHash(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[16];
                rng.GetBytes(saltBytes);
                PasswordSalt = Convert.ToBase64String(saltBytes);
            }

            PasswordHash = ComputeHash(password, PasswordSalt);
        }

        public string ComputeHash(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public bool ValidatePassword(string password)
        {
            return ComputeHash(password, PasswordSalt) == PasswordHash;
        }
    }
}
