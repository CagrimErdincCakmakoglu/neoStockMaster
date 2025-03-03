namespace neoStockMaster.Forms
{
    partial class ProductManagementScreen
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
            menuStripLanguage = new MenuStrip();
            türkçeToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            grbActivity = new GroupBox();
            lblActivity = new Label();
            btnToExcel = new Button();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            grbOrdery = new GroupBox();
            cmbOrdery = new ComboBox();
            grbProducts = new GroupBox();
            dgwProducts = new DataGridView();
            menuStripLanguage.SuspendLayout();
            grbActivity.SuspendLayout();
            grbOrdery.SuspendLayout();
            grbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            SuspendLayout();
            // 
            // menuStripLanguage
            // 
            menuStripLanguage.Items.AddRange(new ToolStripItem[] { türkçeToolStripMenuItem, englishToolStripMenuItem });
            menuStripLanguage.Location = new Point(0, 0);
            menuStripLanguage.Name = "menuStripLanguage";
            menuStripLanguage.Size = new Size(369, 24);
            menuStripLanguage.TabIndex = 0;
            menuStripLanguage.Text = "menuStrip1";
            // 
            // türkçeToolStripMenuItem
            // 
            türkçeToolStripMenuItem.Image = Languages.English.cropped_tc_bayrak;
            türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            türkçeToolStripMenuItem.Size = new Size(70, 20);
            türkçeToolStripMenuItem.Text = "Türkçe";
            türkçeToolStripMenuItem.Click += türkçeToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Image = Languages.English.cii;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(73, 20);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // grbActivity
            // 
            grbActivity.Controls.Add(lblActivity);
            grbActivity.Controls.Add(btnToExcel);
            grbActivity.Controls.Add(btnAddProduct);
            grbActivity.Controls.Add(btnEditProduct);
            grbActivity.Location = new Point(12, 27);
            grbActivity.Name = "grbActivity";
            grbActivity.Size = new Size(346, 100);
            grbActivity.TabIndex = 1;
            grbActivity.TabStop = false;
            // 
            // lblActivity
            // 
            lblActivity.AutoSize = true;
            lblActivity.Location = new Point(153, 0);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(59, 15);
            lblActivity.TabIndex = 3;
            lblActivity.Text = "İşlemi Seç";
            // 
            // btnToExcel
            // 
            btnToExcel.Location = new Point(52, 61);
            btnToExcel.Name = "btnToExcel";
            btnToExcel.Size = new Size(266, 23);
            btnToExcel.TabIndex = 2;
            btnToExcel.Text = "Excel'e Aktar";
            btnToExcel.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(52, 22);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(120, 33);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(198, 22);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(120, 33);
            btnEditProduct.TabIndex = 1;
            btnEditProduct.Text = "Ürün Düzenle";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // grbOrdery
            // 
            grbOrdery.Controls.Add(cmbOrdery);
            grbOrdery.Location = new Point(12, 133);
            grbOrdery.Name = "grbOrdery";
            grbOrdery.Size = new Size(346, 55);
            grbOrdery.TabIndex = 4;
            grbOrdery.TabStop = false;
            grbOrdery.Text = "Sıralama";
            // 
            // cmbOrdery
            // 
            cmbOrdery.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdery.FormattingEnabled = true;
            cmbOrdery.Location = new Point(6, 22);
            cmbOrdery.Name = "cmbOrdery";
            cmbOrdery.Size = new Size(334, 23);
            cmbOrdery.TabIndex = 0;
            // 
            // grbProducts
            // 
            grbProducts.Controls.Add(dgwProducts);
            grbProducts.Location = new Point(12, 194);
            grbProducts.Name = "grbProducts";
            grbProducts.Size = new Size(346, 251);
            grbProducts.TabIndex = 5;
            grbProducts.TabStop = false;
            grbProducts.Text = "Ürünler";
            // 
            // dgwProducts
            // 
            dgwProducts.AllowUserToAddRows = false;
            dgwProducts.AllowUserToDeleteRows = false;
            dgwProducts.AllowUserToResizeColumns = false;
            dgwProducts.AllowUserToResizeRows = false;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(6, 22);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.ReadOnly = true;
            dgwProducts.Size = new Size(334, 222);
            dgwProducts.TabIndex = 0;
            // 
            // ProductManagementScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(grbProducts);
            Controls.Add(grbOrdery);
            Controls.Add(grbActivity);
            Controls.Add(menuStripLanguage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStripLanguage;
            MaximizeBox = false;
            Name = "ProductManagementScreen";
            Text = "ProductManagementScreen";
            menuStripLanguage.ResumeLayout(false);
            menuStripLanguage.PerformLayout();
            grbActivity.ResumeLayout(false);
            grbActivity.PerformLayout();
            grbOrdery.ResumeLayout(false);
            grbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripLanguage;
        private ToolStripMenuItem türkçeToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private GroupBox grbActivity;
        private Label lblActivity;
        private Button btnToExcel;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private GroupBox grbOrdery;
        private ComboBox cmbOrdery;
        private GroupBox grbProducts;
        private DataGridView dgwProducts;
    }
}