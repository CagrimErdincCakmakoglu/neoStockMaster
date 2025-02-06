using neoStockMaster.Data.Entities;
using neoStockMaster.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neoStockMaster.Forms
{
    public partial class RegisterScreen : Form
    {
        private string selectedLanguage;
        private UserService _userService;

        public RegisterScreen(string selectedLanguage)
        {
            InitializeComponent();

            this.selectedLanguage = selectedLanguage;

            cmbLanguage.Items.Add("Türkçe");
            cmbLanguage.Items.Add("English");

            if (selectedLanguage == "Türkçe")
            {
                cmbLanguage.SelectedIndex = 0;
            }
            else if (selectedLanguage == "English")
            {
                cmbLanguage.SelectedIndex = 1;
            }

            LanguageService.LanguageChanged += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            lblName.Text = LanguageService.GetString("İsim");
            lblPassword.Text = LanguageService.GetString("Şifre");
            lblMail.Text = LanguageService.GetString("Mail");
            lblLanguage.Text = LanguageService.GetString("Dil");
            btnClear.Text = LanguageService.GetString("Temizle");
            btnRegister.Text = LanguageService.GetString("Kayıt Ol");
            grbUserInfo.Text = LanguageService.GetString("Kullanıcı Bilgileri");

            this.Text = LanguageService.GetString("Kayıt Ekranı");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtMail.Clear();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = cmbLanguage.SelectedItem.ToString();
            LanguageService.SetLanguage(selectedLanguage);

            // Dil değiştiğinde, LoginScreen formundaki cmbLanguage'ı da güncelleyeceğiz.
            var loginScreen = Application.OpenForms["LoginScreen"] as LoginScreen;
            if (loginScreen != null)
            {
                loginScreen.UpdateLanguageComboBox(selectedLanguage);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgiler
            string name = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtMail.Text.Trim();
            string language = cmbLanguage.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("İsim boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Mail adresi boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Hata mesajı verildikten sonra işlem durdurulacak
            }

            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);

                User newUser = new User(name, email, password, language);

                string resultMessage = _userService.RegisterUser(newUser);

                MessageBox.Show(resultMessage);


                if (resultMessage == "Kayıt başarılı!")
                {
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geçersiz mail adresi formatı. Lütfen doğru bir mail adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

