﻿using neoStockMaster.Data.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace neoStockMaster.Forms
{
    public partial class RecoveryScreen : Form
    {
        public event Action<string> LanguageChanged;
        string selectedLanguage;
        string email = "";
        // private const string senderEmail = "stockmasterapp@gmail.com"; // Kendi e-posta adresinizi kullanın
        // private const string senderPassword = "bfbi cpom gikz azjx"; // Kendi şifrenizi kullanın

        public RecoveryScreen(string language)
        {
            InitializeComponent();

            selectedLanguage = language;
            LanguageService.SetLanguage(selectedLanguage);

            if (selectedLanguage == "Türkçe")
            {
                menuStripLanguage.Items[0].PerformClick(); // 1. öğeyi seçili yap
            }
            else if (selectedLanguage == "English")
            {
                menuStripLanguage.Items[1].PerformClick(); // 2. öğeyi seçili yap
            }

            //LanguageService.LanguageChanged += LanguageService_LanguageChanged;
            //LanguageService.SetLanguage(LanguageService.CurrentLanguage);

            LanguageService.LanguageChanged += UpdateLanguage;
            UpdateLanguage();
        }

        private void SelectMenuStripLanguage(string userLanguage)
        {
            foreach (ToolStripMenuItem item in menuStripLanguage.Items)
            {
                //if (item.Text.Equals(userLanguage, StringComparison.OrdinalIgnoreCase))
                //{
                //    item.PerformClick(); // Öğeyi tıklanmış gibi yap
                //    break; // İlgili dili bulduktan sonra döngüyü sonlandır
                //}
                break;
            }

            //foreach (ToolStripMenuItem item in menuStripLanguage.Items)
            //{
            //    item.BackColor = item.Text.Equals(userLanguage, StringComparison.OrdinalIgnoreCase) ? Color.LightBlue : SystemColors.Control;
            //}
        }

        private void UpdateLanguage()
        {
            grbMail.Text = LanguageService.GetString("E-Mail Adresinizi Yazınız");
            grbActivity.Text = LanguageService.GetString("İşlemi Seç");
            btnForgetUsername.Text = LanguageService.GetString("Kullanıcı İsmini Hatırlat");
            btnForgetPassword.Text = LanguageService.GetString("Şifremi Hatırlat");

            this.Text = LanguageService.GetString("Bilgilerimi Hatırlat");
            SelectMenuStripLanguage(selectedLanguage);
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageService.SetLanguage("Türkçe");
            türkçeToolStripMenuItem.BackColor = Color.LightBlue;
            englishToolStripMenuItem.BackColor = SystemColors.Control;

            LanguageChanged?.Invoke("Türkçe"); // Dil değiştiğinde event'i tetikle
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageService.SetLanguage("English");
            englishToolStripMenuItem.BackColor = Color.LightBlue;
            türkçeToolStripMenuItem.BackColor = SystemColors.Control;

            LanguageChanged?.Invoke("English"); // Dil değiştiğinde event'i tetikle
        }

        private void btnForgetUsername_Click(object sender, EventArgs e)
        {
            email = txtMail.Text;

            if (CheckMailField())
            {
                try
                {
                    var mailAddress = new System.Net.Mail.MailAddress(email);

                    string recipientEmail = txtMail.Text;
                    UserService userService = new UserService();

                    User user = userService.FindUserByEmail(recipientEmail);

                    if (user != null)
                    {
                        EmailService emailService = new EmailService("stockmasterapp@gmail.com", "bfbi cpom gikz azjx");
                        emailService.SendForgotUsernameEmail(recipientEmail, user.Name);
                        MessageBox.Show("Kullanıcı adınız hatırlatıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Bu e-posta adresine ait kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Geçersiz mail adresi formatı. Lütfen doğru bir mail adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }


        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            email = txtMail.Text;

            if (CheckMailField())
            {
                try
                {
                    var mailAddress = new System.Net.Mail.MailAddress(email);

                    string recipientEmail = txtMail.Text;
                    UserService userService = new UserService();

                    User user = userService.FindUserByEmail(recipientEmail);

                    if (user != null)
                    {
                        EmailService emailService = new EmailService("stockmasterapp@gmail.com", "bfbi cpom gikz azjx");
                        emailService.SendForgotPasswordEmail(recipientEmail, user.Password);
                        MessageBox.Show("Şifreniz hatırlatıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Bu e-posta adresine ait kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Geçersiz mail adresi formatı. Lütfen doğru bir mail adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool CheckMailField()
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Mail alanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return false;
            }
            return true;
        }
    }
}
