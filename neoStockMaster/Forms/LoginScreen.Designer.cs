namespace neoStockMaster.Forms
{
    partial class LoginScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            lblCoder = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtId = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnRecovery = new Button();
            btnClear = new Button();
            chkRememberID = new CheckBox();
            chkRememberPassword = new CheckBox();
            cmbLanguage = new ComboBox();
            lblVersion = new Label();
            timerMarquee = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCoder
            // 
            lblCoder.AutoSize = true;
            lblCoder.Location = new Point(136, 28);
            lblCoder.Name = "lblCoder";
            lblCoder.Size = new Size(176, 15);
            lblCoder.TabIndex = 0;
            lblCoder.Text = "Çağrım Erdinç ÇAKMAKOĞLU || ";
            lblCoder.Click += lblCoder_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(16, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Kullanıcı İsmi";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(16, 92);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Kullanıcı Şifresi";
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(210, 23);
            txtId.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(113, 144);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(210, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(113, 173);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(210, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecovery
            // 
            btnRecovery.Location = new Point(113, 202);
            btnRecovery.Name = "btnRecovery";
            btnRecovery.Size = new Size(117, 23);
            btnRecovery.TabIndex = 7;
            btnRecovery.Text = "Bilgilerimi Hatırlat";
            btnRecovery.UseVisualStyleBackColor = true;
            btnRecovery.Click += btnRecovery_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(236, 202);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chkRememberID
            // 
            chkRememberID.AutoSize = true;
            chkRememberID.Location = new Point(127, 119);
            chkRememberID.Name = "chkRememberID";
            chkRememberID.Size = new Size(75, 19);
            chkRememberID.TabIndex = 9;
            chkRememberID.Text = "ID Hatırla";
            chkRememberID.UseVisualStyleBackColor = true;
            // 
            // chkRememberPassword
            // 
            chkRememberPassword.AutoSize = true;
            chkRememberPassword.Location = new Point(216, 118);
            chkRememberPassword.Name = "chkRememberPassword";
            chkRememberPassword.Size = new Size(87, 19);
            chkRememberPassword.TabIndex = 10;
            chkRememberPassword.Text = "Şifre Hatırla";
            chkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(12, 247);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(121, 23);
            cmbLanguage.TabIndex = 11;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(281, 250);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(13, 15);
            lblVersion.TabIndex = 12;
            lblVersion.Text = "v";
            // 
            // timerMarquee
            // 
            timerMarquee.Tick += timerMarquee_Tick;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 287);
            Controls.Add(lblVersion);
            Controls.Add(cmbLanguage);
            Controls.Add(chkRememberPassword);
            Controls.Add(chkRememberID);
            Controls.Add(btnClear);
            Controls.Add(btnRecovery);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtId);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblCoder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginScreen";
            Text = "Giriş Ekranı";
            FormClosed += LoginScreen_FormClosed;
            Load += LoginScreen_Load;
            KeyDown += LoginScreen_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCoder;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtId;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnRecovery;
        private Button btnClear;
        private CheckBox chkRememberID;
        private CheckBox chkRememberPassword;
        private ComboBox cmbLanguage;
        private Label lblVersion;
        private System.Windows.Forms.Timer timerMarquee;
    }
}