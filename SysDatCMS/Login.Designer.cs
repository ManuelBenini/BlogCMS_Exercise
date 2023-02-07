
namespace SysDatCMS
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new DevExpress.XtraEditors.LabelControl();
            this.loginLabel = new DevExpress.XtraEditors.LabelControl();
            this.emailLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.emailField = new DevExpress.XtraEditors.TextEdit();
            this.passwordField = new DevExpress.XtraEditors.TextEdit();
            this.loginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.registrationBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.LoginEP = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEP)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.welcomeLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Appearance.Options.UseFont = true;
            this.welcomeLabel.Appearance.Options.UseForeColor = true;
            this.welcomeLabel.Location = new System.Drawing.Point(273, 10);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(242, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "BENVENUTO AL BLOG!";
            // 
            // loginLabel
            // 
            this.loginLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.loginLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Appearance.Options.UseFont = true;
            this.loginLabel.Appearance.Options.UseForeColor = true;
            this.loginLabel.Location = new System.Drawing.Point(614, 121);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(56, 29);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // emailLabel
            // 
            this.emailLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.emailLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Appearance.Options.UseFont = true;
            this.emailLabel.Appearance.Options.UseForeColor = true;
            this.emailLabel.Location = new System.Drawing.Point(495, 202);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 23);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.passwordLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Appearance.Options.UseFont = true;
            this.passwordLabel.Appearance.Options.UseForeColor = true;
            this.passwordLabel.Location = new System.Drawing.Point(463, 253);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 23);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(557, 202);
            this.emailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailField.Name = "emailField";
            this.emailField.Properties.AutoHeight = false;
            this.emailField.Size = new System.Drawing.Size(202, 22);
            this.emailField.TabIndex = 1;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(557, 253);
            this.passwordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordField.Name = "passwordField";
            this.passwordField.Properties.AutoHeight = false;
            this.passwordField.Properties.UseSystemPasswordChar = true;
            this.passwordField.Size = new System.Drawing.Size(202, 23);
            this.passwordField.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Appearance.BackColor = System.Drawing.Color.Chartreuse;
            this.loginBtn.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.loginBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.loginBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Appearance.Options.UseBackColor = true;
            this.loginBtn.Appearance.Options.UseBorderColor = true;
            this.loginBtn.Appearance.Options.UseForeColor = true;
            this.loginBtn.Location = new System.Drawing.Point(557, 340);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(87, 34);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registrationBtn
            // 
            this.registrationBtn.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.registrationBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.registrationBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.registrationBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.registrationBtn.Appearance.Options.UseBackColor = true;
            this.registrationBtn.Appearance.Options.UseBorderColor = true;
            this.registrationBtn.Appearance.Options.UseForeColor = true;
            this.registrationBtn.Location = new System.Drawing.Point(674, 340);
            this.registrationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(86, 34);
            this.registrationBtn.TabIndex = 4;
            this.registrationBtn.Text = "Registrazione";
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::SysDatCMS.Properties.Resources.computer_user_icon;
            this.pictureEdit1.Location = new System.Drawing.Point(83, 74);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(295, 315);
            this.pictureEdit1.TabIndex = 1;
            // 
            // LoginEP
            // 
            this.LoginEP.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 405);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl welcomeLabel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl loginLabel;
        private DevExpress.XtraEditors.LabelControl emailLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.TextEdit emailField;
        private DevExpress.XtraEditors.TextEdit passwordField;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
        private DevExpress.XtraEditors.SimpleButton registrationBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider LoginEP;
    }
}