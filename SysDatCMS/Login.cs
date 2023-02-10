using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using SysDatCMS.Classes;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.DXErrorProvider;

namespace SysDatCMS
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                var userId = User.Login(emailField.Text, passwordField.Text);

                if (userId != 0)
                {
                    XtraMessageBox.Show("Login riuscito!", "Autenticazione", MessageBoxButtons.OK);

                    CMSState.CurrentUserId = userId;

                    CMSState.CurrentUserRoleId = User.GetCurrentUserRole();


                    var userMenu = new UserMenu();
                    this.Hide();
                    userMenu.ShowDialog();
                    // quando il form appena aperto viene chiuso, si torna qui

                    passwordField.Text = "";
                    this.Show();
                }
                else
                {
                    XtraMessageBox.Show("Utente non trovato, riprovare", "Autenticazione", MessageBoxButtons.OK);

                    passwordField.Text = "";
                }
            }
            
        }
        private void registrationBtn_Click(object sender, EventArgs e)
        {
            var registration = new UserOperations();
            this.Hide();
            registration.ShowDialog();
            // quando il form appena aperto viene chiuso, si torna qui
            this.Show();
        }


        private bool IsFormValid()
        {
            if(emailField.Text.Length == 0)
            {
                LoginEP.SetError(emailField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else if (Regex.IsMatch(emailField.Text, CMSHelper.EmailPattern) == false)
            {
                LoginEP.SetError(emailField, "Inserire una mail valida", ErrorType.Warning);
            }
            else
            {
                LoginEP.SetError(emailField, "");
            }

            if (passwordField.Text.Length == 0)
            {
                LoginEP.SetError(passwordField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else if (Regex.IsMatch(passwordField.Text, CMSHelper.PwdPattern) == false)
            {
                LoginEP.SetError(passwordField, "Inserire una password valida", ErrorType.Warning);
            }
            else
            {
                LoginEP.SetError(passwordField, "");
            }

            return !LoginEP.HasErrors;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            emailField.Text = "manuelbenini1905@gmail.com";
            passwordField.Text = "123Stella";
        }
    }
}