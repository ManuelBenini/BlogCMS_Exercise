using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using SysDatCMS.Classes;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SysDatCMS
{
    public partial class ArticleOperations : DevExpress.XtraEditors.XtraForm
    {
        private int _idArticle = 0;
        private int _articleAuthorId = 0;
        public ArticleOperations()
        {
            InitializeComponent();

            _articleAuthorId = CMSState.CurrentUserId;
        }
        public ArticleOperations(int idArticle, int userId)
        {
            InitializeComponent();

            _idArticle = idArticle;
            _articleAuthorId = userId;

            FormTitle.Text = "Modifica articolo";
            createArticleBtn.Text = "Modifica";

            FillForm();
        }


        private void ReturnToMenuBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void VisualizeArticlesBtn_Click(object sender, EventArgs e)
        {
            var visualizeForm = new ArticlesOrUsersDataGrid(true);
            this.Hide();
            visualizeForm.ShowDialog();
            // quando il form appena aperto viene chiuso, si torna qui
            this.Show();
        }
        private void ArticleOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void createArticleBtn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                #region Procedimento con transazioni nel codice
                var status = 2;

                if (CMSState.CurrentUserRoleId != 1)
                {
                    status = Convert.ToInt32(StatusGroup.Properties.Items[StatusGroup.SelectedIndex].Value);
                }

                string captionOperationMsg = $"{(_idArticle <= 0 ? "Creazione" : "modifica")}";
                string textOperationMsg = $"{(_idArticle <= 0 ? "creato" : "modificato")}";

                var isDbOperationValid = Article.CreateOrModifyArticleWithImages(_idArticle, titleField.Text, textField.Text, status, _articleAuthorId, ImageFileDialog.FileNames);

                string finalMsg = isDbOperationValid ?
                    $"L'articolo è stato {textOperationMsg} correttamente." :
                    $"L'articolo non è stato {textOperationMsg} correttamente, riprovare.";

                XtraMessageBox.Show(finalMsg, $"{captionOperationMsg} articolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (isDbOperationValid)
                {
                    this.DialogResult = DialogResult.OK;
                }
                #endregion

                #region Procedimento classico senza transazioni nel codice
                //var status = 2;

                //if(CMSState.CurrentUserRoleId != 1)
                //{
                //    status = Convert.ToInt32(StatusGroup.Properties.Items[StatusGroup.SelectedIndex].Value);
                //}

                //string captionOperationMsg = $"{(_idArticle <= 0 ? "Creazione" : "modifica")}";
                //string textOperationMsg = $"{(_idArticle <= 0 ? "creato" : "modificato")}";

                //_idArticle = Article.CreateOrModifyArticle(_idArticle, titleField.Text, textField.Text, status, _articleAuthorId);

                //string finalMsg = _idArticle > 0 ?
                //    $"L'articolo è stato {textOperationMsg} correttamente." :
                //    $"L'articolo non è stato {textOperationMsg} correttamente, riprovare.";

                //XtraMessageBox.Show(finalMsg, $"{captionOperationMsg} articolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //if (_idArticle > 0)
                //{
                //    string imagesDirectory = "c:\\Users\\mbenini.LOGICONE\\source\\repos\\SysDatCMS\\images";
                //    Directory.CreateDirectory(imagesDirectory);

                //    foreach (var image in ImageFileDialog.FileNames)
                //    {
                //        string imageName = getRandomFileName();
                //        File.Copy(image, imagesDirectory + "\\" + imageName);
                //        if (!ArticleImage.CreateImageAndPushInPivotTable(imageName, _idArticle))
                //        {
                //            XtraMessageBox.Show("Errore inserimento immagini", $"inserimento immagini", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            break;
                //        }
                //    }

                //    this.DialogResult = DialogResult.OK;
                //}
                #endregion
            }
        }
        private void openImageDialogBtn_Click(object sender, EventArgs e)
        {
            ImageFileDialog.InitialDirectory = "c:\\";
            ImageFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            ImageFileDialog.Multiselect = true;

            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in ImageFileDialog.FileNames)
                {
                    articleImageSlider.Images.Add(Image.FromFile(file));
                }
            }
        }


        private void FillForm()
        {
            var article = Article.GetArticleById(_idArticle);

            if (article is null)
            {
                // fornisco messaggio d'errore la''utente e blocco l'esecuzione del restante codice

                return;
            }

            titleField.Text = article.Titolo;
            StatusGroup.SelectedIndex = article.Status.Id - 1;
            textField.Text = article.Testo;

            articleImageSlider.Images.Clear();

            for (int i = 0; i < article.Images.Count; i++)
            {
                var imagePath = Directory.GetCurrentDirectory() + @"\" + ConfigurationManager.AppSettings["ImagesPath"];

                using (FileStream stream = new FileStream(imagePath + @"\" + article.Images[i].Name, FileMode.Open))
                {
                    articleImageSlider.Images.Add(Image.FromStream(stream));
                }
            }
        }
        private bool IsFormValid()
        {
            if (titleField.Text.Length == 0)
            {
                createArticleEP.SetError(titleField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else
            {
                createArticleEP.SetError(titleField, "");
            }

            if (textField.Text.Length == 0)
            {
                createArticleEP.SetError(textField, "Non lasciare il campo vuoto", ErrorType.Warning);
            }
            else
            {
                createArticleEP.SetError(textField, "");
            }

            if(articleImageSlider.Images.Count <= 0)
            {
                createArticleEP.SetError(imageField, "Caricare almeno un'immagine", ErrorType.Warning);
            }
            else
            {
                createArticleEP.SetError(imageField, "");
            }

            if (_idArticle != 0)
            {
                if (StatusGroup.SelectedIndex == -1)
                {
                    createArticleEP.SetError(StatusGroup, "Selezionare almeno uno status", ErrorType.Warning);
                }
                else
                {
                    createArticleEP.SetError(StatusGroup, "");
                }
            }

            return !createArticleEP.HasErrors;
        }
        private void ArticleOperations_Load(object sender, EventArgs e)
        {
            //1-- > Contributor, 2-- > Manager, 3-- > Super admin
            if (CMSState.CurrentUserRoleId == 1)
            {
                StatusGroup.Visible = false;
                StatusLabel.Visible = false;
                VisualizeArticlesBtn.Visible = false;
            }
            else
            {
                StatusGroup.Visible = true;
            }
        }
    }
}