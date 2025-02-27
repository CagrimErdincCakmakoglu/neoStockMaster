namespace neoStockMaster.Forms
{
    partial class RegisterScreen
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
            grbUserInfo = new GroupBox();
            cmbLanguage = new ComboBox();
            txtMail = new TextBox();
            lblMail = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLanguage = new Label();
            lblName = new Label();
            btnClear = new Button();
            btnRegister = new Button();
            grbVerification = new GroupBox();
            btnVerificationConfirm = new Button();
            btnVerificationClear = new Button();
            txtVerificationCode = new TextBox();
            txtVerificationName = new TextBox();
            lblVerificationCode = new Label();
            lblVerificationName = new Label();
            grbUserInfo.SuspendLayout();
            grbVerification.SuspendLayout();
            SuspendLayout();
            // 
            // grbUserInfo
            // 
            grbUserInfo.Controls.Add(cmbLanguage);
            grbUserInfo.Controls.Add(txtMail);
            grbUserInfo.Controls.Add(lblMail);
            grbUserInfo.Controls.Add(lblPassword);
            grbUserInfo.Controls.Add(txtPassword);
            grbUserInfo.Controls.Add(txtUsername);
            grbUserInfo.Controls.Add(lblLanguage);
            grbUserInfo.Controls.Add(lblName);
            grbUserInfo.Location = new Point(12, 12);
            grbUserInfo.Name = "grbUserInfo";
            grbUserInfo.Size = new Size(338, 142);
            grbUserInfo.TabIndex = 0;
            grbUserInfo.TabStop = false;
            grbUserInfo.Text = "Kullanıcı Bilgileri";
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(76, 109);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(248, 23);
            cmbLanguage.TabIndex = 7;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(76, 80);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(248, 23);
            txtMail.TabIndex = 6;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(7, 83);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(7, 54);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(30, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifre";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(76, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(248, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(76, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(248, 23);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(6, 115);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(21, 15);
            lblLanguage.TabIndex = 3;
            lblLanguage.Text = "Dil";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(7, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(29, 15);
            lblName.TabIndex = 0;
            lblName.Text = "İsim";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(129, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(238, 160);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // grbVerification
            // 
            grbVerification.Controls.Add(btnVerificationConfirm);
            grbVerification.Controls.Add(btnVerificationClear);
            grbVerification.Controls.Add(txtVerificationCode);
            grbVerification.Controls.Add(txtVerificationName);
            grbVerification.Controls.Add(lblVerificationCode);
            grbVerification.Controls.Add(lblVerificationName);
            grbVerification.Location = new Point(12, 189);
            grbVerification.Name = "grbVerification";
            grbVerification.Size = new Size(338, 114);
            grbVerification.TabIndex = 10;
            grbVerification.TabStop = false;
            grbVerification.Text = "Kullanıcı Onaylama";
            // 
            // btnVerificationConfirm
            // 
            btnVerificationConfirm.Location = new Point(226, 80);
            btnVerificationConfirm.Name = "btnVerificationConfirm";
            btnVerificationConfirm.Size = new Size(75, 23);
            btnVerificationConfirm.TabIndex = 5;
            btnVerificationConfirm.Text = "Onayla";
            btnVerificationConfirm.UseVisualStyleBackColor = true;
            btnVerificationConfirm.Click += btnVerificationConfirm_Click;
            // 
            // btnVerificationClear
            // 
            btnVerificationClear.Location = new Point(117, 80);
            btnVerificationClear.Name = "btnVerificationClear";
            btnVerificationClear.Size = new Size(75, 23);
            btnVerificationClear.TabIndex = 4;
            btnVerificationClear.Text = "Temizle";
            btnVerificationClear.UseVisualStyleBackColor = true;
            btnVerificationClear.Click += btnVerificationClear_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.Location = new Point(76, 51);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.Size = new Size(248, 23);
            txtVerificationCode.TabIndex = 3;
            // 
            // txtVerificationName
            // 
            txtVerificationName.Location = new Point(76, 22);
            txtVerificationName.Name = "txtVerificationName";
            txtVerificationName.Size = new Size(248, 23);
            txtVerificationName.TabIndex = 2;
            // 
            // lblVerificationCode
            // 
            lblVerificationCode.AutoSize = true;
            lblVerificationCode.Location = new Point(16, 54);
            lblVerificationCode.Name = "lblVerificationCode";
            lblVerificationCode.Size = new Size(28, 15);
            lblVerificationCode.TabIndex = 1;
            lblVerificationCode.Text = "Kod";
            // 
            // lblVerificationName
            // 
            lblVerificationName.AutoSize = true;
            lblVerificationName.Location = new Point(16, 25);
            lblVerificationName.Name = "lblVerificationName";
            lblVerificationName.Size = new Size(29, 15);
            lblVerificationName.TabIndex = 0;
            lblVerificationName.Text = "İsim";
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 312);
            Controls.Add(grbVerification);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(grbUserInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterScreen";
            Text = "Kayıt Ekranı";
            Load += RegisterScreen_Load;
            grbUserInfo.ResumeLayout(false);
            grbUserInfo.PerformLayout();
            grbVerification.ResumeLayout(false);
            grbVerification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbUserInfo;
        private ComboBox cmbLanguage;
        private TextBox txtMail;
        private Label lblMail;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblLanguage;
        private Label lblName;
        private Button btnClear;
        private Button btnRegister;
        private GroupBox grbVerification;
        private Button btnVerificationConfirm;
        private Button btnVerificationClear;
        private TextBox txtVerificationCode;
        private TextBox txtVerificationName;
        private Label lblVerificationCode;
        private Label lblVerificationName;
    }
}