namespace neoStockMaster.Forms
{
    partial class RecoveryScreen
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
            grbMail = new GroupBox();
            txtMail = new TextBox();
            menuStripLanguage = new MenuStrip();
            türkçeToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            grbActivity = new GroupBox();
            btnForgetPassword = new Button();
            btnForgetUsername = new Button();
            grbMail.SuspendLayout();
            menuStripLanguage.SuspendLayout();
            grbActivity.SuspendLayout();
            SuspendLayout();
            // 
            // grbMail
            // 
            grbMail.Controls.Add(txtMail);
            grbMail.Location = new Point(12, 27);
            grbMail.Name = "grbMail";
            grbMail.Size = new Size(364, 56);
            grbMail.TabIndex = 0;
            grbMail.TabStop = false;
            grbMail.Text = "E-Mail Adresinizi Yazınız";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(6, 22);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(349, 23);
            txtMail.TabIndex = 0;
            // 
            // menuStripLanguage
            // 
            menuStripLanguage.Items.AddRange(new ToolStripItem[] { türkçeToolStripMenuItem, englishToolStripMenuItem });
            menuStripLanguage.Location = new Point(0, 0);
            menuStripLanguage.Name = "menuStripLanguage";
            menuStripLanguage.Size = new Size(386, 24);
            menuStripLanguage.TabIndex = 1;
            menuStripLanguage.Text = "menuStrip1";
            // 
            // türkçeToolStripMenuItem
            // 
            türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            türkçeToolStripMenuItem.Size = new Size(54, 20);
            türkçeToolStripMenuItem.Text = "Türkçe";
            türkçeToolStripMenuItem.Click += türkçeToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(57, 20);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // grbActivity
            // 
            grbActivity.Controls.Add(btnForgetPassword);
            grbActivity.Controls.Add(btnForgetUsername);
            grbActivity.Location = new Point(12, 89);
            grbActivity.Name = "grbActivity";
            grbActivity.Size = new Size(364, 71);
            grbActivity.TabIndex = 2;
            grbActivity.TabStop = false;
            grbActivity.Text = "İşlemi Seç";
            // 
            // btnForgetPassword
            // 
            btnForgetPassword.Location = new Point(187, 26);
            btnForgetPassword.Name = "btnForgetPassword";
            btnForgetPassword.Size = new Size(168, 31);
            btnForgetPassword.TabIndex = 1;
            btnForgetPassword.Text = "Şifremi Unuttum";
            btnForgetPassword.UseVisualStyleBackColor = true;
            btnForgetPassword.Click += btnForgetPassword_Click;
            // 
            // btnForgetUsername
            // 
            btnForgetUsername.Location = new Point(6, 26);
            btnForgetUsername.Name = "btnForgetUsername";
            btnForgetUsername.Size = new Size(168, 31);
            btnForgetUsername.TabIndex = 0;
            btnForgetUsername.Text = "Kullanıcı İsmini Unuttum";
            btnForgetUsername.UseVisualStyleBackColor = true;
            btnForgetUsername.Click += btnForgetUsername_Click;
            // 
            // RecoveryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 178);
            Controls.Add(grbActivity);
            Controls.Add(grbMail);
            Controls.Add(menuStripLanguage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RecoveryScreen";
            Text = "Bilgilerimi Hatırlat";
            grbMail.ResumeLayout(false);
            grbMail.PerformLayout();
            menuStripLanguage.ResumeLayout(false);
            menuStripLanguage.PerformLayout();
            grbActivity.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbMail;
        private TextBox txtMail;
        private MenuStrip menuStripLanguage;
        private ToolStripMenuItem türkçeToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private GroupBox grbActivity;
        private Button btnForgetPassword;
        private Button btnForgetUsername;
    }
}