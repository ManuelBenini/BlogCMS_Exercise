using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using SysDatCMS.Classes;
using SysDatCMS.Enums;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SysDatCMS
{
    public partial class UserOperations : DevExpress.XtraEditors.XtraForm
    {
        private int _userId = 0;

        public UserOperations()
        {
            InitializeComponent();

            _userId = 0;
        }

        public UserOperations(int userId)
        {
            InitializeComponent();

            _userId = userId;
        }
        private void ReturnToLoginBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                string captionOperationMsg = $"{(CMSState.CurrentUserId <= 0 ? "Registrazione" : "Aggiornamento")}";
                string textOperationMsg = $"{(CMSState.CurrentUserId <= 0 ? "registrato" : "aggiornato")}";

                var userRole = RoleLookUpEdit.EditValue as Role;

                if (userRole == null)
                {
                    // in caso di nuova registrazione, viene assegnato il ruolo Contributor
                    userRole = Role.GetRoleById(RolesEnum.Contributor);
                }

                bool IsDbOperationValid = User.AddOrUpdateUser(_userId, nameField.Text, surnameField.Text, emailField.Text, passwordField.Text, userRole.Id);

                string finalMsg = IsDbOperationValid ?
                    $"L'utente è stato {textOperationMsg} correttamente." :
                    $"L'utente non è stato {textOperationMsg} correttamente, riprovare.";

                XtraMessageBox.Show(finalMsg, $"{captionOperationMsg} utente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (IsDbOperationValid)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    passwordField.Text = "";
                }

            }
        }
        private void deleteUserBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = XtraMessageBox.Show("Sei sicuro di voler eliminare l'utente?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (User.DeleteUser(_userId))
                {
                    XtraMessageBox.Show("Utente eliminato con successo!", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("Utente non eliminato", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void VisualizeUsersBtn_Click(object sender, EventArgs e)
        {
            var visualizeUsers = new ArticlesOrUsersDataGrid(false);
            this.Hide();
            visualizeUsers.ShowDialog();
            // quando il form appena aperto viene chiuso, si torna qui
            this.Show();
        }
        private void UserOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private bool IsFormValid()
        {
            if (nameField.Text.Length == 0)
            {
                UserOperationsEP.SetError(nameField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else
            {
                UserOperationsEP.SetError(nameField, "");
            }

            if (surnameField.Text.Length == 0)
            {
                UserOperationsEP.SetError(surnameField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else
            {
                UserOperationsEP.SetError(surnameField, "");
            }

            if (emailField.Text.Length == 0)
            {
                UserOperationsEP.SetError(emailField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else if (Regex.IsMatch(emailField.Text, CMSHelper.EmailPattern) == false)
            {
                UserOperationsEP.SetError(emailField, "Inserire una mail valida", ErrorType.Warning);
            }
            else
            {
                UserOperationsEP.SetError(emailField, "");
            }

            if (passwordField.Text.Length == 0)
            {
                UserOperationsEP.SetError(passwordField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else if (Regex.IsMatch(passwordField.Text, CMSHelper.PwdPattern) == false)
            {
                UserOperationsEP.SetError(passwordField, "Inserire una password valida", ErrorType.Warning);
            }
            else
            {
                UserOperationsEP.SetError(passwordField, "");
            }

            return !UserOperationsEP.HasErrors;
        }

        private void UserOperations_Load(object sender, EventArgs e)
        {
            if (_userId != 0)
            {
                FormTitle.Text = "Modifica";
                RegistrationBtn.Text = "Aggiorna";
                ReturnToLoginBtn.Text = "Torna alla lista";
                deleteUserBtn.Visible = true;

                var user = User.GetUserById(_userId);

                nameField.Text = user.Nome;
                surnameField.Text = user.Cognome;
                emailField.Text = user.Email;
                passwordField.Text = user.Password;
                passwordField.Enabled = false;
                RoleLookUpEdit.Properties.DataSource = Role.GetRoles();
                RoleLookUpEdit.EditValue = user.Ruolo;

                if (user.Ruolo.Id == 3)
                {
                    RoleLookUpEdit.Enabled = false;
                }
            }
            else
            {
                RegistrationBtn.Location = new Point(540, 431);
                VisualizeUsersBtn.Visible = false;
                roleLabel.Visible = false;
                RoleLookUpEdit.Visible = false;
            }

        }
    }
}