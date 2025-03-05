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
using System.Xml;

namespace neoStockMaster.Forms
{
    public partial class AddProductScreen : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static User LoggedInUser { get; set; }
        private System.Windows.Forms.Timer timerExchangeRates;

        public AddProductScreen()
        {
            InitializeComponent();

            LanguageService.LanguageChanged += LanguageService_LanguageChanged;
            LanguageService.SetLanguage(LanguageService.CurrentLanguage);

            // Timer ve döviz kurlarını başlatmak için metodu çağırıyoruz
            StartTimerAndLoadExchangeRates();

            nmrDollar.Controls.RemoveAt(0);
        }

        private void LanguageService_LanguageChanged()
        {
            UpdateFormTexts();
        }

        private void UpdateFormTexts()
        {
            türkçeToolStripMenuItem.Text = LanguageService.GetString("Türkçe");
            englishToolStripMenuItem.Text = LanguageService.GetString("English2");

            grbProduct.Text = LanguageService.GetString("Ürün Bilgileri");
            lblName.Text = LanguageService.GetString("İsim");
            lblCost.Text = LanguageService.GetString("Maliyet");
            lblPrice.Text = LanguageService.GetString("Fiyat");
            lblStock.Text = LanguageService.GetString("Stok");
            lblPercent.Text = LanguageService.GetString("Kâr Yüzdesi");
            grbExchangeInfo.Text = LanguageService.GetString("Döviz Bilgisi");
            lblDolar.Text = LanguageService.GetString("Dolar");
            lblEuro.Text = LanguageService.GetString("Euro");
            btnClear.Text = LanguageService.GetString("Temizle");
            btnAdd.Text = LanguageService.GetString("Ekle");

            this.Text = LanguageService.GetString("Ürün Ekle");

            UpdateSelectedLanguage();
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

        // DÖVİZ YANSITMA BAŞLANGIÇ
        // Timer'ı başlatan ve döviz kurlarını yükleyen metot
        private void StartTimerAndLoadExchangeRates()
        {
            // Timer oluşturuluyor, her 30 saniyede bir güncelleme yapacak
            timerExchangeRates = new System.Windows.Forms.Timer();
            timerExchangeRates.Interval = 10000; // 10 saniyede bir güncelleme
            timerExchangeRates.Tick += TimerExchangeRates_Tick;

            // Timer başlatılıyor
            timerExchangeRates.Start();

            // Form açıldığında hemen döviz kurlarını güncelle
            LoadExchangeRates();
        }

        // Döviz kurlarını TCMB'den çekme
        private async void LoadExchangeRates()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string xmlData = await client.GetStringAsync(url);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(xmlData);

                    // USD ve EUR kuru alınıyor: BanknoteSelling kısmından alınacak
                    string usd = xmlDoc.SelectSingleNode("//Currency[@Kod='USD']/ForexSelling")?.InnerText;
                    string eur = xmlDoc.SelectSingleNode("//Currency[@Kod='EUR']/ForexSelling")?.InnerText;

                    // NumericUpDown kontrollerini güncelle
                    if (usd != null)
                    {
                        nmrDollar.Value = Convert.ToDecimal(usd.Replace('.', ','));
                    }
                    if (eur != null)
                    {
                        nmrEuro.Value = Convert.ToDecimal(eur.Replace('.', ','));
                    }

                    // nmrDollar ve nmrEuro'yu sadece okunabilir yapıyoruz
                    nmrDollar.ReadOnly = true;
                    nmrEuro.ReadOnly = true;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Döviz kuru alınırken hata oluştu: {ex.Message}");
                }
            }
        }

        // Timer tetiklendiğinde döviz kurlarını güncelle
        private void TimerExchangeRates_Tick(object sender, EventArgs e)
        {
            LoadExchangeRates();
        }

        // Form kapanırken Timer'ı durdur
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timerExchangeRates.Stop();
        }


        //DÖVİZ YANSITMA BİTİŞ
    }
}
