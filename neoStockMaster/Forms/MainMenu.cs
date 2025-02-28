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
            string userLanguage = LoggedInUser.Language; // Kullanıcının dil bilgisi
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageService.SetLanguage("Türkçe");
            türkçeToolStripMenuItem.BackColor = Color.LightBlue;
            englishToolStripMenuItem.BackColor = SystemColors.Control;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageService.SetLanguage("English");
            englishToolStripMenuItem.BackColor = Color.LightBlue;
            türkçeToolStripMenuItem.BackColor = SystemColors.Control;
        }
    }
}
