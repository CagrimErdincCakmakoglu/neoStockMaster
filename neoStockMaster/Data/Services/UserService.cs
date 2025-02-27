using neoStockMaster.Data.Entities;
using neoStockMaster.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace neoStockMaster.Data.Services
{
    public class UserService
    {
        private readonly string _filePath = "users.json";
        public static User LoggedInUser { get; set; }
        private List<User> users;
        private User _currentUser;

        public UserService()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
            users = GetAllUsers();
        }

        public string RegisterUser(User newUser)
        {
            users = GetAllUsers();

            if (users.Any(u => u.Name.Equals(newUser.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return "Bu kullanıcı adı zaten kullanılıyor!";
            }

            if (users.Any(u => u.Email.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase)))
            {
                return "Bu e-posta adresi zaten kayıtlı!";
            }

            try
            {
                EmailService emailService = new EmailService("stockmasterapp@gmail.com", "bfbi cpom gikz azjx");
                emailService.SendWelcomeEmail(newUser.Email, newUser.Name);

                users.Add(newUser);
                SaveAllUsers(users);
            }
            catch (Exception ex)
            {
                return $"Kayıt başarısız! Hoş geldiniz e-postası gönderilemedi: {ex.Message}";
            }

            return "Kayıt başarılı!";
        }

        public string Login(string username, string password, bool rememberUsername, bool rememberPassword)
        {
            users = GetAllUsers();

            var user = users.FirstOrDefault(u => u.Name.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                return "Geçersiz kullanıcı adı veya şifre!";
            }

            _currentUser = user;
            string currentIp = GetIpAddress();
            user.LastLoginIps.Add(currentIp);
            SaveAllUsers(users);

            if (rememberUsername)
                Settings.Default.Username = username;
            else
                Settings.Default.Username = string.Empty;

            if (rememberPassword)
                Settings.Default.Password = password;
            else
                Settings.Default.Password = string.Empty;

            Settings.Default.Save();

            return $"Giriş başarılı! Hoş geldiniz, {user.Name}.";
        }

        public string ChangePassword(string username, string currentPassword, string newPassword)
        {
            users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Name.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                return "Geçersiz mevcut şifre!";
            }

            if (newPassword.Length < 6)
            {
                return "Yeni şifre en az 6 karakter olmalıdır!";
            }

            user.Password = newPassword;
            SaveAllUsers(users);

            return "Şifreniz başarıyla değiştirildi!";
        }

        public string UpdateCargo(string cargo)
        {
            if (LoggedInUser != null)
            {
                LoggedInUser.Cargo = cargo;
                var user = users.FirstOrDefault(u => u.Name.Equals(LoggedInUser.Name, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                {
                    user.Cargo = cargo;
                }
                SaveAllUsers(users);
            }
            return cargo;
        }

        public string LogOut()
        {
            if (_currentUser == null)
                return "Zaten giriş yapılmamış!";

            _currentUser = null;
            Settings.Default.Save();
            return "Başarıyla çıkış yaptınız!";
        }

        public string GetIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            var ipAddress = host.AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return ipAddress?.ToString() ?? "IP adresi alınamadı";
        }

        public List<User> GetAllUsers()
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        private void SaveAllUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public User FindUserByEmail(string email)
        {
            users = GetAllUsers();
            return users?.FirstOrDefault(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }




        public User GetCurrentUser()
        {
            return _currentUser;
        }
    }
}

