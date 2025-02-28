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
using System.Diagnostics;

namespace neoStockMaster.Forms
{
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();

            cmbLanguage.Items.Add("Türkçe");
            cmbLanguage.Items.Add("English");
            cmbLanguage.SelectedIndex = 0;

            LanguageService.LanguageChanged += UpdateLanguage;
            UpdateLanguage();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtId.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;

            chkRememberID.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.Username);
            chkRememberPassword.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.Password);

            cmbLanguage.SelectedItem = LanguageService.CurrentLanguage;

            string version = Application.ProductVersion;
            lblVersion.Text = $"v{version}";

            timerMarquee.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtPassword.Clear();

            chkRememberID.Checked = false;
            chkRememberPassword.Checked = false;
        }

        private void timerMarquee_Tick(object sender, EventArgs e)
        {
            lblCoder.Text = lblCoder.Text.Substring(1) + lblCoder.Text.Substring(0, 1);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string selectedLanguage = cmbLanguage.SelectedItem.ToString(); // Seçili dili al
            
            RegisterScreen registerScreen = new RegisterScreen(selectedLanguage); // Parametre olarak gönder
            registerScreen.ShowDialog();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            string selectedLanguage = cmbLanguage.SelectedItem.ToString(); // Seçili dili al

            RecoveryScreen recoveryScreen = new RecoveryScreen(selectedLanguage);
            recoveryScreen.LanguageChanged += UpdateLanguageComboBox; // Dil değişikliği event'ini dinle
            recoveryScreen.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre giriş alanlarının kontrolü
            string username = txtId.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ya da şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserService userService = new UserService();
            bool rememberUsername = chkRememberID.Checked;
            bool rememberPassword = chkRememberPassword.Checked;

            // Giriş işlemi
            string loginResult = userService.Login(username, password, rememberUsername, rememberPassword);

            if (loginResult.StartsWith("Giriş başarılı!"))
            {
                // Başarılı giriş
                MessageBox.Show(loginResult, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                User loggedInUser = userService.GetCurrentUser();
                MainMenu.LoggedInUser = loggedInUser;
                //ProductManagementScreen.LoggedInUser = loggedInUser;
                //AddProductScreen.LoggedInUser = loggedInUser;
                //ProductEditingScreen.LoggedInUser = loggedInUser;
                //ProductService.LoggedInUser = loggedInUser;
                //CalculatePriceAddOrderScreen.LoggedInUser = loggedInUser;
                //UserInformationScreen.LoggedInUser = loggedInUser;
                //UserService.LoggedInUser = loggedInUser;
                //ViewOrdersEditingScreen.LoggedInUser = loggedInUser;
                OrderService.LoggedInUser = loggedInUser;
                //ZReportForm.LoggedInUser = loggedInUser;

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide(); // Login ekranını gizle
            }
            else
            {
                // Başarısız giriş
                MessageBox.Show(loginResult, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLanguage()
        {
            lblUsername.Text = LanguageService.GetString("Kullanıcı İsmi");
            lblPassword.Text = LanguageService.GetString("Kullanıcı Şifresi");
            chkRememberID.Text = LanguageService.GetString("ID Hatırla");
            chkRememberPassword.Text = LanguageService.GetString("Şifre Hatırla");
            btnLogin.Text = LanguageService.GetString("Giriş Yap");
            btnRegister.Text = LanguageService.GetString("Kayıt Ol");
            btnRecovery.Text = LanguageService.GetString("Bilgilerimi Hatırlat");
            btnClear.Text = LanguageService.GetString("Temizle");

            this.Text = LanguageService.GetString("Giriş Ekranı");

            // Checkbox konumlarını ve görünürlüğünü güncelle
            if (LanguageService.CurrentLanguage == "English")
            {
                chkRememberID.Location = new Point(100, 121);
                chkRememberPassword.Location = new Point(200, 121);
            }
            else
            {
                chkRememberID.Location = new Point(130, 121);
                chkRememberPassword.Location = new Point(220, 121);
            }
        }

        private void lblCoder_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/CagrimErdincCakmakoglu");
            OpenUrl("https://linkedin.com/in/cagrimerdinccakmakoglu");
            OpenUrl("https://cagrimcakmakoglu.com/");
        }

        private void OpenUrl(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = cmbLanguage.SelectedItem.ToString();
            LanguageService.SetLanguage(selectedLanguage);
        }

        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateLanguageComboBox(string language)
        {
            cmbLanguage.SelectedItem = language;


        }
    }
}

