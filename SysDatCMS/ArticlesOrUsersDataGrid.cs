using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using SysDatCMS.Classes;
using SysDatCMS.Enums;
using System;
using System.Windows.Forms;

namespace SysDatCMS
{
    public partial class ArticlesOrUsersDataGrid : DevExpress.XtraEditors.XtraForm
    {
        private bool _isArticle = true;

        /// <summary>
        /// Passando true la dataGridView si riempirà di articoli. Passando false si riempirà di utenti.
        /// </summary>
        /// <param name="isArticle">Booleano true - false </param>
        public ArticlesOrUsersDataGrid(bool isArticle)
        {
            InitializeComponent();

            _isArticle = isArticle;
        }

        
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Aggiorno i dati di un articolo o di un utente senza lasciare la griglia.
            if (_isArticle)
            {
                Article selectedArticle = gridView1.GetRow(gridView1.GetSelectedRows()[0]) as Article;

                if (Article.ModifyArticleWithoutImages(selectedArticle.Id, selectedArticle.Titolo, selectedArticle.Testo, selectedArticle.Status.Id, selectedArticle.Autore.Id))
                {
                    XtraMessageBox.Show("Articolo modificato con successo!", "Modifica articolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Articolo non modificato, errore", "Modifica articolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                GridUpdate();
            }
            else
            {
                User selectedUser = gridView1.GetRow(gridView1.GetSelectedRows()[0]) as User;

                if (User.AddOrUpdateUser(selectedUser.Id, selectedUser.Nome, selectedUser.Cognome, selectedUser.Email, selectedUser.Password, selectedUser.Ruolo.Id))
                {
                    XtraMessageBox.Show("Utente modificato con successo!", "Modifica utente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Utente non modificato, errore", "Modifica utente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                GridUpdate();
            }
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GoToArticleOrUserDetails();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (_isArticle == true)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sei sicuro di voler eliminare l'articolo?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Article selectedArticle = gridView1.GetRow(gridView1.GetSelectedRows()[0]) as Article;

                    if (Article.DeleteArticleById(selectedArticle.Id))
                    {
                        XtraMessageBox.Show("Articolo eliminato con successo!", "Eliminazione articolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Articolo non eliminato, errore", "Eliminazione articolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                GridUpdate();
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sei sicuro di voler eliminare l'utente?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    User selectedUser = gridView1.GetRow(gridView1.GetSelectedRows()[0]) as User;

                    if (CMSState.CurrentUserId != selectedUser.Id)
                    {
                        if (User.DeleteUser(selectedUser.Id))
                        {
                            XtraMessageBox.Show("Utente eliminato con successo!", "Eliminazione utente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Utente non eliminato, errore", "Eliminazione utente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Non è possibile effettuare l'eliminazione del proprio profilo mentre si è loggati", "Eliminazione utente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                GridUpdate();
            }
        }
        private void GoToModifyBtn_Click(object sender, EventArgs e)
        {
            GoToArticleOrUserDetails();
        }
        private void ArticleOrUserDataGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void ArticleOrUserDataGrid_Load(object sender, EventArgs e)
        {
            GridUpdate();

            if (!_isArticle)
            {
                FormTitle.Text = "Visualizzazione utenti";
                StatusGroup.Visible = false;
            }

            if (CMSState.CurrentUserRoleId == 1)
            {
                StatusGroup.Visible = false;
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Al click su una riga nella GridView viene letto il valore presente nella colonna ruolo. Se il ruolo é Super Admin, non sará possibile modificarlo.
            if (!_isArticle)
            {
                var colRole = gridView1.Columns["Ruolo"];

                if (colRole != null)
                {
                    var selectedUserRole = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colRole) as Role;
                    if (selectedUserRole.Id == 3)
                    {
                        gridView1.Columns["Ruolo"].OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        gridView1.Columns["Ruolo"].OptionsColumn.AllowEdit = true;
                    }
                }
            }
        }
        private void StatusGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridUpdate();
        }
        private void disabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
            //Evento che avviene alla lettura delle celle (quando la GridView viene generata e quando vengono effettuate operazioni sulle celle, creato con il controllo BehaviourManager
        }


        private void GridUpdate()
        {

            if (_isArticle)
            {
                //Valorizzo la gridView con gli articoli di tutti gli utenti, creando delle colonne contenenti bottoni per delle operazioni.
                ArticlesOrUsersGrid.BeginUpdate();
                try
                {
                    gridView1.Columns.Clear();
                    ArticlesOrUsersGrid.DataSource = null;
                    if (CMSState.CurrentUserRoleId == 1)
                    {
                        ArticlesOrUsersGrid.DataSource = Article.GetArticles(StatusEnum.Published);
                    }
                    else
                    {
                        switch (StatusGroup.SelectedIndex)
                        {
                            case 1:
                                ArticlesOrUsersGrid.DataSource = Article.GetArticles(StatusEnum.Published);
                                break;
                            case 2:
                                ArticlesOrUsersGrid.DataSource = Article.GetArticles(StatusEnum.Suspended);
                                break;
                            case 3:
                                ArticlesOrUsersGrid.DataSource = Article.GetArticles(StatusEnum.Deleted);
                                break;
                            default:
                                ArticlesOrUsersGrid.DataSource = Article.GetArticles(StatusEnum.all);
                                break;
                        }
                    }
                    StatusLookUpEditBtn.DataSource = Status.GetStatuses();
                    gridView1.Columns["Status"].ColumnEdit = StatusLookUpEditBtn;
                    gridView1.OptionsBehavior.Editable = false;
                    if (CMSState.CurrentUserRoleId != 1)
                    {
                        gridView1.OptionsBehavior.Editable = true;
                        gridView1.Columns["Id"].OptionsColumn.AllowEdit = false;
                        gridView1.Columns["Autore"].OptionsColumn.AllowEdit = false;
                        GridColumn UpdateCol = new GridColumn() { Caption = "Aggiorna", Visible = true, FieldName = "UpdateCol" };
                        gridView1.Columns.Add(UpdateCol);
                        gridView1.Columns["UpdateCol"].ColumnEdit = UpdateBtn;
                        GridColumn GoToModifyCol = new GridColumn() { Caption = "Vai alle modifiche", Visible = true, FieldName = "GoToModifyCol" };
                        gridView1.Columns.Add(GoToModifyCol);
                        gridView1.Columns["GoToModifyCol"].ColumnEdit = GoToModifyBtn;
                        GridColumn deleteCol = new GridColumn() { Caption = "Elimina", Visible = true, FieldName = "DeleteCol" };
                        gridView1.Columns.Add(deleteCol);
                        gridView1.Columns["DeleteCol"].ColumnEdit = DeleteBtn;
                    }
                    
                }
                finally
                {
                    ArticlesOrUsersGrid.EndUpdate();
                }
            }
            else
            {
                //Valorizzo la gridView con tutti gli utenti, creando delle colonne contenenti bottoni per delle operazioni.
                ArticlesOrUsersGrid.BeginUpdate();
                try
                {
                    gridView1.Columns.Clear();
                    ArticlesOrUsersGrid.DataSource = null;
                    ArticlesOrUsersGrid.DataSource = User.GetUsers();
                    gridView1.Columns["Id"].OptionsColumn.AllowEdit = false;
                    gridView1.Columns["Password"].OptionsColumn.AllowEdit = false;
                    RoleLookUpEditBtn.DataSource = Role.GetRoles();
                    gridView1.Columns["Ruolo"].ColumnEdit = RoleLookUpEditBtn;
                    GridColumn UpdateCol = new GridColumn() { Caption = "Aggiorna", Visible = true, FieldName = "UpdateCol" };
                    gridView1.Columns.Add(UpdateCol);
                    gridView1.Columns["UpdateCol"].ColumnEdit = UpdateBtn;
                    GridColumn GoToModifyCol = new GridColumn() { Caption = "Vai alle modifiche", Visible = true, FieldName = "GoToModifyCol" };
                    gridView1.Columns.Add(GoToModifyCol);
                    gridView1.Columns["GoToModifyCol"].ColumnEdit = GoToModifyBtn;
                    GridColumn deleteCol = new GridColumn() { Caption = "Elimina", Visible = true, FieldName = "DeleteCol" };
                    gridView1.Columns.Add(deleteCol);
                    gridView1.Columns["DeleteCol"].ColumnEdit = DeleteBtn;
                }
                finally
                {
                    ArticlesOrUsersGrid.EndUpdate();
                }
            }
        }
        private void GoToArticleOrUserDetails()
        {
            //Vado nella pagina dettaglio di un articolo o di un utente.
            if (CMSState.CurrentUserRoleId != 1)
            {
                //Questa variabile é l'ID Dell'articolo oppure l'ID dell'utente in base ai dati presenti nella GridView
                var Id = gridView1.GetFocusedRowCellValue(colId.FieldName);

                if (_isArticle)
                {
                    var author = gridView1.GetFocusedRowCellValue(colAutore.FieldName) as User;
                    var articleDetails = new ArticleOperations((int)Id, author.Id);
                    this.Hide();

                    articleDetails.ShowDialog();

                    GridUpdate();
                    this.Show();
                }
                else
                {
                    var userDetails = new UserOperations((int)Id);
                    this.Hide();
                    userDetails.ShowDialog();

                    GridUpdate();
                    this.Show();
                }
            }
        }
    }
}