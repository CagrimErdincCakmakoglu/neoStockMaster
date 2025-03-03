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
    public partial class MainMenu : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static User LoggedInUser { get; set; }

        public MainMenu()
        {
            InitializeComponent();

            LanguageService.LanguageChanged += LanguageService_LanguageChanged;
            LanguageService.SetLanguage(LanguageService.CurrentLanguage);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LanguageService_LanguageChanged()
        {
            UpdateFormTexts();
            UpdateSelectedLanguage(); // Seçili dili güncelle
        }

        private void UpdateFormTexts()
        {
            türkçeToolStripMenuItem.Text = LanguageService.GetString("Türkçe");
            englishToolStripMenuItem.Text = LanguageService.GetString("English2");

            grbMenu.Text = LanguageService.GetString("İşlem Menüsü");
            btnProductManagement.Text = LanguageService.GetString("Ürün İşlemleri");
            btnCalculatePriceAddOrder.Text = LanguageService.GetString("Fiyat Hesapla - Sipariş Ekle");
            btnViewOrdersEditOrders.Text = LanguageService.GetString("Siparişleri Görüntüle - Düzenle");
            btnZReport.Text = LanguageService.GetString("Z Raporu");
            grbUserPanel.Text = LanguageService.GetString("Kullanıcı Paneli");
            btnAboutUser.Text = LanguageService.GetString("Kullanıcı Bilgileri");
            btnLogOut.Text = LanguageService.GetString("Çıkış Yap");
            chbTop.Text = LanguageService.GetString("Uygulamayı Üstte Tut");

            this.Text = LanguageService.GetString("Ana Menü");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SetSelectedLanguageUI();
            UpdateSelectedLanguage(); // İlk açılışta seçili dili uygula
        }

        private void SetSelectedLanguageUI()
        {
            string userLanguage = LoggedInUser.Language; // Kullanıcının dil bilgisi

            // Seçili dili arayüze uygula
            LanguageService.SetLanguage(userLanguage);

            // Buton arka planlarını güncelle
            if (userLanguage == "Türkçe")
            {
                türkçeToolStripMenuItem.BackColor = Color.LightBlue;
                englishToolStripMenuItem.BackColor = SystemColors.Control;
            }
            else if (userLanguage == "English")
            {
                englishToolStripMenuItem.BackColor = Color.LightBlue;
                türkçeToolStripMenuItem.BackColor = SystemColors.Control;
            }

            // Form üzerindeki yazıları güncelle
            UpdateFormTexts();
        }

        private void UpdateSelectedLanguage()
        {
            string currentLanguage = LanguageService.CurrentLanguage;

            türkçeToolStripMenuItem.Checked = currentLanguage == "Türkçe";
            englishToolStripMenuItem.Checked = currentLanguage == "English";

            türkçeToolStripMenuItem.BackColor = türkçeToolStripMenuItem.Checked ? Color.LightBlue : SystemColors.Control;
            englishToolStripMenuItem.BackColor = englishToolStripMenuItem.Checked ? Color.LightBlue : SystemColors.Control;
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageService.SetLanguage("Türkçe");
            UpdateSelectedLanguage();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageService.SetLanguage("English");
            UpdateSelectedLanguage();
        }


        // UYGULAMAYI ÜSTTE TUTMAYA BAŞLANGICI
        private void ToggleAlwaysOnTop()
        {
            bool alwaysOnTop = chbTop.Checked;

            this.TopMost = alwaysOnTop; // MainMenu her zaman önde kalsın

            // Açık olan tüm formları kontrol et ve TopMost ayarlarını yap
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm != this) // MainMenu harici formlar
                {
                    openForm.TopMost = alwaysOnTop;
                }
            }
        }

        private void chbTop_CheckedChanged(object sender, EventArgs e)
        {
            ToggleAlwaysOnTop();
        }
        // UYGULAMAYI ÜSTTE TUTMAYA BİTİŞİ

        private void OpenProductManagementScreen()
        {
            string currentLanguage = LanguageService.CurrentLanguage; // Mevcut dili al

            ProductManagementScreen productManagementScreen = new ProductManagementScreen(currentLanguage);
            productManagementScreen.Owner = this; // MainMenu'yu sahip olarak ayarla (diğer formlar MainMenu'nun önüne geçebilir)

            productManagementScreen.TopMost = chbTop.Checked; // Yeni form da her zaman en önde olsun

            productManagementScreen.FormClosed += (s, e) =>
            {
                // Eğer chbTop seçiliyse, tüm formlar en önde kalmaya devam etsin
                ToggleAlwaysOnTop();
            };

            productManagementScreen.ShowDialog();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            OpenProductManagementScreen();
        }
    }
}
