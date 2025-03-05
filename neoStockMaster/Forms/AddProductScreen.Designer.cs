namespace neoStockMaster.Forms
{
    partial class AddProductScreen
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
            lblName = new Label();
            lblCost = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblPercent = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbProduct = new GroupBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            comboBox2 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            grbExchangeInfo = new GroupBox();
            nmrEuro = new NumericUpDown();
            nmrDollar = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            lblEuro = new Label();
            lblDolar = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            menuStripLanguage.SuspendLayout();
            grbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            grbExchangeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrEuro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrDollar).BeginInit();
            SuspendLayout();
            // 
            // menuStripLanguage
            // 
            menuStripLanguage.Items.AddRange(new ToolStripItem[] { türkçeToolStripMenuItem, englishToolStripMenuItem });
            menuStripLanguage.Location = new Point(0, 0);
            menuStripLanguage.Name = "menuStripLanguage";
            menuStripLanguage.Size = new Size(486, 24);
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
            englishToolStripMenuItem.Size = new Size(79, 20);
            englishToolStripMenuItem.Text = "English2";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(7, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(29, 15);
            lblName.TabIndex = 1;
            lblName.Text = "İsim";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(7, 54);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(46, 15);
            lblCost.TabIndex = 2;
            lblCost.Text = "Maliyet";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(6, 83);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(8, 112);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(30, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stok";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(6, 141);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(67, 15);
            lblPercent.TabIndex = 5;
            lblPercent.Text = "Kâr Yüzdesi";
            // 
            // grbProduct
            // 
            grbProduct.Controls.Add(numericUpDown4);
            grbProduct.Controls.Add(numericUpDown3);
            grbProduct.Controls.Add(comboBox2);
            grbProduct.Controls.Add(numericUpDown2);
            grbProduct.Controls.Add(comboBox1);
            grbProduct.Controls.Add(numericUpDown1);
            grbProduct.Controls.Add(textBox1);
            grbProduct.Controls.Add(lblName);
            grbProduct.Controls.Add(lblPercent);
            grbProduct.Controls.Add(lblCost);
            grbProduct.Controls.Add(lblStock);
            grbProduct.Controls.Add(lblPrice);
            grbProduct.Location = new Point(12, 27);
            grbProduct.Name = "grbProduct";
            grbProduct.Size = new Size(287, 177);
            grbProduct.TabIndex = 6;
            grbProduct.TabStop = false;
            grbProduct.Text = "Ürün Bilgileri";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(98, 139);
            numericUpDown4.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 12;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(98, 110);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(224, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(55, 23);
            comboBox2.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(98, 81);
            numericUpDown2.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(55, 23);
            comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(98, 52);
            numericUpDown1.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 6;
            // 
            // grbExchangeInfo
            // 
            grbExchangeInfo.Controls.Add(nmrEuro);
            grbExchangeInfo.Controls.Add(nmrDollar);
            grbExchangeInfo.Controls.Add(label5);
            grbExchangeInfo.Controls.Add(label4);
            grbExchangeInfo.Controls.Add(lblEuro);
            grbExchangeInfo.Controls.Add(lblDolar);
            grbExchangeInfo.Location = new Point(305, 27);
            grbExchangeInfo.Name = "grbExchangeInfo";
            grbExchangeInfo.Size = new Size(174, 177);
            grbExchangeInfo.TabIndex = 7;
            grbExchangeInfo.TabStop = false;
            grbExchangeInfo.Text = "Döviz Bilgisi";
            // 
            // nmrEuro
            // 
            nmrEuro.DecimalPlaces = 4;
            nmrEuro.Location = new Point(85, 52);
            nmrEuro.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            nmrEuro.Name = "nmrEuro";
            nmrEuro.Size = new Size(73, 23);
            nmrEuro.TabIndex = 11;
            // 
            // nmrDollar
            // 
            nmrDollar.DecimalPlaces = 4;
            nmrDollar.Location = new Point(85, 23);
            nmrDollar.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            nmrDollar.Name = "nmrDollar";
            nmrDollar.Size = new Size(73, 23);
            nmrDollar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 54);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 3;
            label5.Text = "(€)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 25);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 2;
            label4.Text = "($)";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(15, 54);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(31, 15);
            lblEuro.TabIndex = 1;
            lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(15, 25);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(35, 15);
            lblDolar.TabIndex = 0;
            lblDolar.Text = "Dolar";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(91, 210);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(197, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 242);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(grbExchangeInfo);
            Controls.Add(grbProduct);
            Controls.Add(menuStripLanguage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStripLanguage;
            MaximizeBox = false;
            Name = "AddProductScreen";
            Text = "AddProductScreen";
            menuStripLanguage.ResumeLayout(false);
            menuStripLanguage.PerformLayout();
            grbProduct.ResumeLayout(false);
            grbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            grbExchangeInfo.ResumeLayout(false);
            grbExchangeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrEuro).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrDollar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripLanguage;
        private ToolStripMenuItem türkçeToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private Label lblName;
        private Label lblCost;
        private Label lblPrice;
        private Label lblStock;
        private Label lblPercent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbProduct;
        private GroupBox grbExchangeInfo;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label lblEuro;
        private Label lblDolar;
        private Button btnClear;
        private Button btnAdd;
        private NumericUpDown nmrEuro;
        private NumericUpDown nmrDollar;
    }
}