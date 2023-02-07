
namespace SysDatCMS
{
    partial class UserOperations
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.VisualizeUsersBtn = new DevExpress.XtraEditors.SimpleButton();
            this.RegistrationBtn = new DevExpress.XtraEditors.SimpleButton();
            this.surnameField = new DevExpress.XtraEditors.TextEdit();
            this.nameField = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ReturnToLoginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.FormTitle = new DevExpress.XtraEditors.LabelControl();
            this.emailField = new DevExpress.XtraEditors.TextEdit();
            this.passwordField = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.UserOperationsEP = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.roleLabel = new DevExpress.XtraEditors.LabelControl();
            this.RoleLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.surnameField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserOperationsEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(498, 244);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 23);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Email:";
            // 
            // VisualizeUsersBtn
            // 
            this.VisualizeUsersBtn.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.VisualizeUsersBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.VisualizeUsersBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.VisualizeUsersBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.VisualizeUsersBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.VisualizeUsersBtn.Appearance.Options.UseBackColor = true;
            this.VisualizeUsersBtn.Appearance.Options.UseBorderColor = true;
            this.VisualizeUsersBtn.Appearance.Options.UseFont = true;
            this.VisualizeUsersBtn.Appearance.Options.UseForeColor = true;
            this.VisualizeUsersBtn.Location = new System.Drawing.Point(649, 431);
            this.VisualizeUsersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizeUsersBtn.Name = "VisualizeUsersBtn";
            this.VisualizeUsersBtn.Size = new System.Drawing.Size(187, 34);
            this.VisualizeUsersBtn.TabIndex = 8;
            this.VisualizeUsersBtn.Text = "Visualizzazione utenti";
            this.VisualizeUsersBtn.Click += new System.EventHandler(this.VisualizeUsersBtn_Click);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Appearance.BackColor = System.Drawing.Color.Chartreuse;
            this.RegistrationBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.RegistrationBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.RegistrationBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.RegistrationBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.RegistrationBtn.Appearance.Options.UseBackColor = true;
            this.RegistrationBtn.Appearance.Options.UseBorderColor = true;
            this.RegistrationBtn.Appearance.Options.UseFont = true;
            this.RegistrationBtn.Appearance.Options.UseForeColor = true;
            this.RegistrationBtn.Location = new System.Drawing.Point(475, 431);
            this.RegistrationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(95, 34);
            this.RegistrationBtn.TabIndex = 6;
            this.RegistrationBtn.Text = "Registrati";
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(554, 180);
            this.surnameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameField.Name = "surnameField";
            this.surnameField.Properties.AutoHeight = false;
            this.surnameField.Size = new System.Drawing.Size(282, 29);
            this.surnameField.TabIndex = 2;
            this.surnameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameField_KeyPress);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(554, 129);
            this.nameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameField.Name = "nameField";
            this.nameField.Properties.AutoHeight = false;
            this.nameField.Size = new System.Drawing.Size(285, 29);
            this.nameField.TabIndex = 1;
            this.nameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameField_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(494, 129);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 23);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Nome:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(465, 297);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 23);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Password:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(463, 181);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 23);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Cognome:";
            // 
            // ReturnToLoginBtn
            // 
            this.ReturnToLoginBtn.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.ReturnToLoginBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.ReturnToLoginBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.ReturnToLoginBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ReturnToLoginBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.ReturnToLoginBtn.Appearance.Options.UseBackColor = true;
            this.ReturnToLoginBtn.Appearance.Options.UseBorderColor = true;
            this.ReturnToLoginBtn.Appearance.Options.UseFont = true;
            this.ReturnToLoginBtn.Appearance.Options.UseForeColor = true;
            this.ReturnToLoginBtn.Location = new System.Drawing.Point(717, 40);
            this.ReturnToLoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnToLoginBtn.Name = "ReturnToLoginBtn";
            this.ReturnToLoginBtn.Size = new System.Drawing.Size(119, 34);
            this.ReturnToLoginBtn.TabIndex = 9;
            this.ReturnToLoginBtn.Text = "Torna al login";
            this.ReturnToLoginBtn.Click += new System.EventHandler(this.ReturnToLoginBtn_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.FormTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.FormTitle.Appearance.Options.UseFont = true;
            this.FormTitle.Appearance.Options.UseForeColor = true;
            this.FormTitle.Location = new System.Drawing.Point(374, 40);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(142, 29);
            this.FormTitle.TabIndex = 33;
            this.FormTitle.Text = "Registrazione";
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(555, 240);
            this.emailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailField.Name = "emailField";
            this.emailField.Properties.AutoHeight = false;
            this.emailField.Size = new System.Drawing.Size(282, 29);
            this.emailField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(556, 295);
            this.passwordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordField.Name = "passwordField";
            this.passwordField.Properties.AutoHeight = false;
            this.passwordField.Properties.UseSystemPasswordChar = true;
            this.passwordField.Size = new System.Drawing.Size(282, 29);
            this.passwordField.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysDatCMS.Properties.Resources.clipart2600984;
            this.pictureBox1.Location = new System.Drawing.Point(23, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.deleteUserBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.deleteUserBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.deleteUserBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deleteUserBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteUserBtn.Appearance.Options.UseBackColor = true;
            this.deleteUserBtn.Appearance.Options.UseBorderColor = true;
            this.deleteUserBtn.Appearance.Options.UseFont = true;
            this.deleteUserBtn.Appearance.Options.UseForeColor = true;
            this.deleteUserBtn.Location = new System.Drawing.Point(575, 431);
            this.deleteUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(69, 34);
            this.deleteUserBtn.TabIndex = 7;
            this.deleteUserBtn.Text = "Elimina";
            this.deleteUserBtn.Visible = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // UserOperationsEP
            // 
            this.UserOperationsEP.ContainerControl = this;
            // 
            // roleLabel
            // 
            this.roleLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.roleLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.roleLabel.Appearance.Options.UseFont = true;
            this.roleLabel.Appearance.Options.UseForeColor = true;
            this.roleLabel.Location = new System.Drawing.Point(494, 347);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(54, 23);
            this.roleLabel.TabIndex = 43;
            this.roleLabel.Text = "Ruolo:";
            // 
            // RoleLookUpEdit
            // 
            this.RoleLookUpEdit.Location = new System.Drawing.Point(556, 344);
            this.RoleLookUpEdit.Name = "RoleLookUpEdit";
            this.RoleLookUpEdit.Properties.AutoHeight = false;
            this.RoleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RoleLookUpEdit.Properties.DataSource = this.roleBindingSource;
            this.RoleLookUpEdit.Properties.DisplayMember = "Name";
            this.RoleLookUpEdit.Properties.KeyMember = "Id";
            this.RoleLookUpEdit.Properties.NullText = "[Value is null]";
            this.RoleLookUpEdit.Size = new System.Drawing.Size(281, 32);
            this.RoleLookUpEdit.TabIndex = 5;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(SysDatCMS.Classes.Role);
            // 
            // UserOperations
            // 
            this.AcceptButton = this.RegistrationBtn;
            this.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 489);
            this.Controls.Add(this.RoleLookUpEdit);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.deleteUserBtn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.VisualizeUsersBtn);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ReturnToLoginBtn);
            this.Controls.Add(this.FormTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOperations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserOperations_FormClosed);
            this.Load += new System.EventHandler(this.UserOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.surnameField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserOperationsEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton VisualizeUsersBtn;
        private DevExpress.XtraEditors.SimpleButton RegistrationBtn;
        private DevExpress.XtraEditors.TextEdit surnameField;
        private DevExpress.XtraEditors.TextEdit nameField;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton ReturnToLoginBtn;
        private DevExpress.XtraEditors.LabelControl FormTitle;
        private DevExpress.XtraEditors.TextEdit emailField;
        private DevExpress.XtraEditors.TextEdit passwordField;
        private DevExpress.XtraEditors.SimpleButton deleteUserBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider UserOperationsEP;
        private DevExpress.XtraEditors.LabelControl roleLabel;
        private DevExpress.XtraEditors.LookUpEdit RoleLookUpEdit;
        private System.Windows.Forms.BindingSource roleBindingSource;
    }
}