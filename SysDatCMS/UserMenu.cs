using DevExpress.XtraEditors;
using SysDatCMS.Classes;
using System;
using System.Windows.Forms;

namespace SysDatCMS
{
    public partial class UserMenu : DevExpress.XtraEditors.XtraForm
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Article selectedArticle = ArticlesTable.GetRow(ArticlesTable.GetSelectedRows()[0]) as Article;

            if (Article.CreateOrModifyArticle(selectedArticle.Id, selectedArticle.Titolo, selectedArticle.Testo, selectedArticle.Status.Id, selectedArticle.Autore.Id) > 0)
            {
                XtraMessageBox.Show("Articolo modificato con successo!", "Modifica articolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Articolo non modificato, errore", "Modifica articolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GoToModifyBtn_Click(object sender, EventArgs e)
        {
            int Id = (int)ArticlesTable.GetFocusedRowCellValue(colId.FieldName);

            var ArticleDetails = new ArticleOperations(Id, CMSState.CurrentUserId);
            this.Hide();
            ArticleDetails.ShowDialog();

            ArticleGrid.DataSource = Article.GetCurrentUserArticles();
            PublishedUserArticleNumber.Text = Article.GetNumberOfArticlesOfTheCurrentUser().ToString();
            this.Show();
        }
        private void RequestPublishBtn_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Richiesta di pubblicazione inviata!", "Pubblicazione", MessageBoxButtons.OK);
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            CMSState.CurrentUserId = 0;
            this.DialogResult = DialogResult.OK;
        }
        private void CreateArticleBtn_Click(object sender, EventArgs e)
        {
            var createArticle = new ArticleOperations();
            this.Hide();
            createArticle.ShowDialog();
            // quando il form appena aperto viene chiuso, si torna qui
            ArticleGrid.DataSource = Article.GetCurrentUserArticles();
            PublishedUserArticleNumber.Text = Article.GetNumberOfArticlesOfTheCurrentUser().ToString();
            this.Show();
        }
        private void VisualizeArticlesBtn_Click(object sender, EventArgs e)
        {
            var visualizeArticles = new ArticlesOrUsersDataGrid(true);
            this.Hide();
            visualizeArticles.ShowDialog();
            // quando il form appena aperto viene chiuso, si torna qui
            ArticleGrid.DataSource = Article.GetCurrentUserArticles();
            PublishedUserArticleNumber.Text = Article.GetNumberOfArticlesOfTheCurrentUser().ToString();
            this.Show();
        }
        private void VisualizeUsersBtn_Click(object sender, EventArgs e)
        {
            var visualizeUsers = new ArticlesOrUsersDataGrid(false);
            this.Hide();
            visualizeUsers.ShowDialog();
            // quando il form appena aperto viene chiuso, si torna qui
            ArticleGrid.DataSource = Article.GetCurrentUserArticles();
            PublishedUserArticleNumber.Text = Article.GetNumberOfArticlesOfTheCurrentUser().ToString();
            this.Show();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int Id = (int)ArticlesTable.GetFocusedRowCellValue(colId.FieldName);

            if (Article.DeleteArticleById(Id))
            {
                XtraMessageBox.Show("Articolo eliminato con successo!", "Eliminazione articolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Articolo non eliminato, errore", "Eliminazione articolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ArticleGrid.DataSource = Article.GetCurrentUserArticles();
            PublishedUserArticleNumber.Text = Article.GetNumberOfArticlesOfTheCurrentUser().ToString();
        }


        private void UserMenu_Load(object sender, EventArgs e)
        {
            // 1 --> Contributor, 2 --> Manager, 3 --> Super admin //
            switch (CMSState.CurrentUserRoleId)
            {
                case 1:
                    VisualizeUsersBtn.Visible = false;
                    break;

                case 2:
                    VisualizeUsersBtn.Visible = false;
                    break;

                default:
                    break;
            }

            PublishedUserArticleNumber.Text = Article.GetNumberOfArticlesOfTheCurrentUser().ToString();

            ArticleGrid.DataSource = Article.GetCurrentUserArticles();
            statusLookUpEditBtn.DataSource = Status.GetStatuses();
        }
        private void UserMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CMSState.CurrentUserId = 0;
            this.DialogResult = DialogResult.OK;
        }

        private void disabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
            if (CMSState.CurrentUserRoleId == 1)
            {
                e.Disabled = e.FieldName == "Status" ? true : false;
                //if (e.FieldName == "Status")
                //{
                //    e.Disabled = true;
                //}
            }
        }
    }

}