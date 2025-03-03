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
    public partial class ProductManagementScreen : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static User LoggedInUser { get; set; }

        public ProductManagementScreen(string selectedLanguage)
        {
            InitializeComponent();

            LanguageService.LanguageChanged += LanguageService_LanguageChanged;
            LanguageService.SetLanguage(LanguageService.CurrentLanguage);
            PopulateOrderComboBox();
        }

        private void LanguageService_LanguageChanged()
        {
            UpdateFormTexts();
            PopulateOrderComboBox();
        }

        private void UpdateFormTexts()
        {
            türkçeToolStripMenuItem.Text = LanguageService.GetString("Türkçe");
            englishToolStripMenuItem.Text = LanguageService.GetString("English2");

            lblActivity.Text = LanguageService.GetString("İşlemi Seç");
            btnAddProduct.Text = LanguageService.GetString("Ürün Ekle");
            btnEditProduct.Text = LanguageService.GetString("Ürün Düzenle");
            btnToExcel.Text = LanguageService.GetString("Excel'e Aktar");
            grbOrdery.Text = LanguageService.GetString("Sıralama");
            grbProducts.Text = LanguageService.GetString("Ürünler");


            this.Text = LanguageService.GetString("Ürün İşlemleri");
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
        private void PopulateOrderComboBox()
        {
            cmbOrdery.Items.Clear();
            if (LanguageService.CurrentLanguage == "Türkçe")
            {
                cmbOrdery.Items.AddRange(new string[]
                {
                    "A'dan Z'ye", "Z'den A'ya", "Ucuzdan Pahalıya", "Pahalıdan Ucuza", "Eskiden Yeniye", "Yeniden Eskiye", "Azdan Çoğa", "Çoktan Aza"
                });
            }
            else
            {
                cmbOrdery.Items.AddRange(new string[]
                {
                    "A to Z", "Z to A", "Cheapest to Expensive", "Expensive to Cheapest", "Oldest to Newest", "Newest to Oldest", "Least to Most", "Most to Least"
                });
            }
            cmbOrdery.SelectedIndex = 0;
        }

    }
}
