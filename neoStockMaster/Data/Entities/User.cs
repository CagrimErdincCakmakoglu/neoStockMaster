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
        public string Password { get; set; }
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
        }
    }
}

