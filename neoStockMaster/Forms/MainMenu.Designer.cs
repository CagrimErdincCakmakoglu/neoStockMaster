namespace neoStockMaster.Forms
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            menuStripLanguage = new MenuStrip();
            türkçeToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            grbMenu = new GroupBox();
            btnZReport = new Button();
            btnViewOrdersEditOrders = new Button();
            btnCalculatePriceAddOrder = new Button();
            btnProductManagement = new Button();
            grbUserPanel = new GroupBox();
            chbTop = new CheckBox();
            btnLogOut = new Button();
            btnAboutUser = new Button();
            menuStripLanguage.SuspendLayout();
            grbMenu.SuspendLayout();
            grbUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripLanguage
            // 
            menuStripLanguage.Items.AddRange(new ToolStripItem[] { türkçeToolStripMenuItem, englishToolStripMenuItem });
            menuStripLanguage.Location = new Point(0, 0);
            menuStripLanguage.Name = "menuStripLanguage";
            menuStripLanguage.Size = new Size(303, 24);
            menuStripLanguage.TabIndex = 0;
            menuStripLanguage.Text = "menuStrip1";
            // 
            // türkçeToolStripMenuItem
            // 
            türkçeToolStripMenuItem.Image = (Image)resources.GetObject("türkçeToolStripMenuItem.Image");
            türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            türkçeToolStripMenuItem.Size = new Size(70, 20);
            türkçeToolStripMenuItem.Text = "Türkçe";
            türkçeToolStripMenuItem.Click += türkçeToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Image = (Image)resources.GetObject("englishToolStripMenuItem.Image");
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(79, 20);
            englishToolStripMenuItem.Text = "English2";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(btnZReport);
            grbMenu.Controls.Add(btnViewOrdersEditOrders);
            grbMenu.Controls.Add(btnCalculatePriceAddOrder);
            grbMenu.Controls.Add(btnProductManagement);
            grbMenu.Location = new Point(12, 27);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(281, 179);
            grbMenu.TabIndex = 1;
            grbMenu.TabStop = false;
            grbMenu.Text = "İşlem Menüsü";
            // 
            // btnZReport
            // 
            btnZReport.Location = new Point(6, 136);
            btnZReport.Name = "btnZReport";
            btnZReport.Size = new Size(269, 32);
            btnZReport.TabIndex = 3;
            btnZReport.Text = "Z Raporu";
            btnZReport.UseVisualStyleBackColor = true;
            // 
            // btnViewOrdersEditOrders
            // 
            btnViewOrdersEditOrders.Location = new Point(6, 98);
            btnViewOrdersEditOrders.Name = "btnViewOrdersEditOrders";
            btnViewOrdersEditOrders.Size = new Size(269, 32);
            btnViewOrdersEditOrders.TabIndex = 2;
            btnViewOrdersEditOrders.Text = "Siparişleri Görüntüle - Düzenle";
            btnViewOrdersEditOrders.UseVisualStyleBackColor = true;
            // 
            // btnCalculatePriceAddOrder
            // 
            btnCalculatePriceAddOrder.Location = new Point(6, 60);
            btnCalculatePriceAddOrder.Name = "btnCalculatePriceAddOrder";
            btnCalculatePriceAddOrder.Size = new Size(269, 32);
            btnCalculatePriceAddOrder.TabIndex = 1;
            btnCalculatePriceAddOrder.Text = "Fiyat Hesapla - Sipariş Ekle";
            btnCalculatePriceAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new Point(6, 22);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(269, 32);
            btnProductManagement.TabIndex = 0;
            btnProductManagement.Text = "Ürün İşlemleri";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // grbUserPanel
            // 
            grbUserPanel.Controls.Add(chbTop);
            grbUserPanel.Controls.Add(btnLogOut);
            grbUserPanel.Controls.Add(btnAboutUser);
            grbUserPanel.Location = new Point(12, 212);
            grbUserPanel.Name = "grbUserPanel";
            grbUserPanel.Size = new Size(281, 87);
            grbUserPanel.TabIndex = 2;
            grbUserPanel.TabStop = false;
            grbUserPanel.Text = "Kullanıcı Paneli";
            // 
            // chbTop
            // 
            chbTop.AutoSize = true;
            chbTop.Location = new Point(78, 60);
            chbTop.Name = "chbTop";
            chbTop.Size = new Size(139, 19);
            chbTop.TabIndex = 6;
            chbTop.Text = "Uygulamayı Üstte Tut";
            chbTop.UseVisualStyleBackColor = true;
            chbTop.CheckedChanged += chbTop_CheckedChanged;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(144, 22);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(132, 32);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnAboutUser
            // 
            btnAboutUser.Location = new Point(6, 22);
            btnAboutUser.Name = "btnAboutUser";
            btnAboutUser.Size = new Size(132, 32);
            btnAboutUser.TabIndex = 4;
            btnAboutUser.Text = "Kullanıcı Bilgileri";
            btnAboutUser.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 304);
            Controls.Add(grbUserPanel);
            Controls.Add(grbMenu);
            Controls.Add(menuStripLanguage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStripLanguage;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "Ana Menü";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            menuStripLanguage.ResumeLayout(false);
            menuStripLanguage.PerformLayout();
            grbMenu.ResumeLayout(false);
            grbUserPanel.ResumeLayout(false);
            grbUserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripLanguage;
        private ToolStripMenuItem türkçeToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private GroupBox grbMenu;
        private Button btnZReport;
        private Button btnViewOrdersEditOrders;
        private Button btnCalculatePriceAddOrder;
        private Button btnProductManagement;
        private GroupBox grbUserPanel;
        private Button btnLogOut;
        private Button btnAboutUser;
        private CheckBox chbTop;
    }
}