
namespace SysDatCMS
{
    partial class UserMenu
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
            DevExpress.Utils.AppearanceObject appearanceObject1 = new DevExpress.Utils.AppearanceObject();
            this.FormTitle = new DevExpress.XtraEditors.LabelControl();
            this.LogoutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.ArticleGrid = new DevExpress.XtraGrid.GridControl();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArticlesTable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusLookUpEditBtn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UpdateBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GoToModifyCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoToModifyBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RequestPublishCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestPublishBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.DeleteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.imagesPopupGalleryBtn = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.VisualizeUsersBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CreateArticleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.VisualizeArticlesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PublishedUserArticleNumber = new DevExpress.XtraEditors.LabelControl();
            this.articleImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.disabledCellEvents1 = new DevExpress.Utils.Behaviors.Common.DisabledCellEvents(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToModifyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestPublishBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesPopupGalleryBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.FormTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.FormTitle.Appearance.Options.UseFont = true;
            this.FormTitle.Appearance.Options.UseForeColor = true;
            this.FormTitle.Location = new System.Drawing.Point(327, 25);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(169, 29);
            this.FormTitle.TabIndex = 2;
            this.FormTitle.Text = "Menù personale";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Appearance.BackColor = System.Drawing.Color.Brown;
            this.LogoutBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.LogoutBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.LogoutBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LogoutBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Appearance.Options.UseBackColor = true;
            this.LogoutBtn.Appearance.Options.UseBorderColor = true;
            this.LogoutBtn.Appearance.Options.UseFont = true;
            this.LogoutBtn.Appearance.Options.UseForeColor = true;
            this.LogoutBtn.Location = new System.Drawing.Point(688, 25);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(119, 34);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::SysDatCMS.Properties.Resources.login;
            this.pictureEdit1.Location = new System.Drawing.Point(10, 10);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(111, 84);
            this.pictureEdit1.TabIndex = 8;
            // 
            // ArticleGrid
            // 
            this.ArticleGrid.DataSource = this.articleBindingSource;
            this.ArticleGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArticleGrid.Location = new System.Drawing.Point(10, 110);
            this.ArticleGrid.MainView = this.ArticlesTable;
            this.ArticleGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArticleGrid.Name = "ArticleGrid";
            this.ArticleGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GoToModifyBtn,
            this.RequestPublishBtn,
            this.UpdateBtn,
            this.DeleteBtn,
            this.imagesPopupGalleryBtn,
            this.statusLookUpEditBtn});
            this.ArticleGrid.Size = new System.Drawing.Size(797, 280);
            this.ArticleGrid.TabIndex = 1;
            this.ArticleGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ArticlesTable});
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(SysDatCMS.Classes.Article);
            // 
            // ArticlesTable
            // 
            this.behaviorManager1.SetBehaviors(this.ArticlesTable, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.DisabledCellBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.GridViewDisabledCellSource), "", appearanceObject1, this.disabledCellEvents1)))});
            this.ArticlesTable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitolo,
            this.colTesto,
            this.colStatus,
            this.UpdateCol,
            this.GoToModifyCol,
            this.RequestPublishCol,
            this.DeleteCol});
            this.ArticlesTable.DetailHeight = 284;
            this.ArticlesTable.GridControl = this.ArticleGrid;
            this.ArticlesTable.Name = "ArticlesTable";
            this.ArticlesTable.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTesto, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 21;
            this.colId.Name = "colId";
            this.colId.Width = 81;
            // 
            // colTitolo
            // 
            this.colTitolo.FieldName = "Titolo";
            this.colTitolo.MinWidth = 21;
            this.colTitolo.Name = "colTitolo";
            this.colTitolo.Visible = true;
            this.colTitolo.VisibleIndex = 0;
            this.colTitolo.Width = 81;
            // 
            // colTesto
            // 
            this.colTesto.FieldName = "Testo";
            this.colTesto.MinWidth = 21;
            this.colTesto.Name = "colTesto";
            this.colTesto.Visible = true;
            this.colTesto.VisibleIndex = 1;
            this.colTesto.Width = 81;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.ColumnEdit = this.statusLookUpEditBtn;
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 21;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 81;
            // 
            // statusLookUpEditBtn
            // 
            this.statusLookUpEditBtn.AutoHeight = false;
            this.statusLookUpEditBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusLookUpEditBtn.DataSource = this.statusBindingSource;
            this.statusLookUpEditBtn.DisplayMember = "Name";
            this.statusLookUpEditBtn.KeyMember = "Id";
            this.statusLookUpEditBtn.Name = "statusLookUpEditBtn";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(SysDatCMS.Classes.Status);
            // 
            // UpdateCol
            // 
            this.UpdateCol.Caption = "Aggiorna";
            this.UpdateCol.ColumnEdit = this.UpdateBtn;
            this.UpdateCol.MinWidth = 21;
            this.UpdateCol.Name = "UpdateCol";
            this.UpdateCol.Visible = true;
            this.UpdateCol.VisibleIndex = 3;
            this.UpdateCol.Width = 81;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AutoHeight = false;
            this.UpdateBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // GoToModifyCol
            // 
            this.GoToModifyCol.Caption = "Modifica nei dettagli";
            this.GoToModifyCol.ColumnEdit = this.GoToModifyBtn;
            this.GoToModifyCol.MinWidth = 21;
            this.GoToModifyCol.Name = "GoToModifyCol";
            this.GoToModifyCol.Visible = true;
            this.GoToModifyCol.VisibleIndex = 4;
            this.GoToModifyCol.Width = 81;
            // 
            // GoToModifyBtn
            // 
            this.GoToModifyBtn.AutoHeight = false;
            this.GoToModifyBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.GoToModifyBtn.Name = "GoToModifyBtn";
            this.GoToModifyBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.GoToModifyBtn.Click += new System.EventHandler(this.GoToModifyBtn_Click);
            // 
            // RequestPublishCol
            // 
            this.RequestPublishCol.Caption = "Richiedi pubblicazione";
            this.RequestPublishCol.ColumnEdit = this.RequestPublishBtn;
            this.RequestPublishCol.MinWidth = 21;
            this.RequestPublishCol.Name = "RequestPublishCol";
            this.RequestPublishCol.Visible = true;
            this.RequestPublishCol.VisibleIndex = 5;
            this.RequestPublishCol.Width = 81;
            // 
            // RequestPublishBtn
            // 
            this.RequestPublishBtn.AutoHeight = false;
            this.RequestPublishBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.RequestPublishBtn.Name = "RequestPublishBtn";
            this.RequestPublishBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RequestPublishBtn.Click += new System.EventHandler(this.RequestPublishBtn_Click);
            // 
            // DeleteCol
            // 
            this.DeleteCol.Caption = "Elimina";
            this.DeleteCol.ColumnEdit = this.DeleteBtn;
            this.DeleteCol.Name = "DeleteCol";
            this.DeleteCol.Visible = true;
            this.DeleteCol.VisibleIndex = 6;
            this.DeleteCol.Width = 64;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoHeight = false;
            this.DeleteBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // imagesPopupGalleryBtn
            // 
            this.imagesPopupGalleryBtn.AutoHeight = false;
            this.imagesPopupGalleryBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imagesPopupGalleryBtn.Name = "imagesPopupGalleryBtn";
            // 
            // VisualizeUsersBtn
            // 
            this.VisualizeUsersBtn.Location = new System.Drawing.Point(696, 419);
            this.VisualizeUsersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizeUsersBtn.Name = "VisualizeUsersBtn";
            this.VisualizeUsersBtn.Size = new System.Drawing.Size(110, 24);
            this.VisualizeUsersBtn.TabIndex = 4;
            this.VisualizeUsersBtn.Text = "Visualizza gli utenti";
            this.VisualizeUsersBtn.Click += new System.EventHandler(this.VisualizeUsersBtn_Click);
            // 
            // CreateArticleBtn
            // 
            this.CreateArticleBtn.Location = new System.Drawing.Point(373, 419);
            this.CreateArticleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateArticleBtn.Name = "CreateArticleBtn";
            this.CreateArticleBtn.Size = new System.Drawing.Size(99, 24);
            this.CreateArticleBtn.TabIndex = 3;
            this.CreateArticleBtn.Text = "Crea articolo";
            this.CreateArticleBtn.Click += new System.EventHandler(this.CreateArticleBtn_Click);
            // 
            // VisualizeArticlesBtn
            // 
            this.VisualizeArticlesBtn.Location = new System.Drawing.Point(10, 419);
            this.VisualizeArticlesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizeArticlesBtn.Name = "VisualizeArticlesBtn";
            this.VisualizeArticlesBtn.Size = new System.Drawing.Size(135, 24);
            this.VisualizeArticlesBtn.TabIndex = 2;
            this.VisualizeArticlesBtn.Text = "Visualizza tutti gli articoli";
            this.VisualizeArticlesBtn.Click += new System.EventHandler(this.VisualizeArticlesBtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(334, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(129, 19);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Articoli pubblicati:";
            // 
            // PublishedUserArticleNumber
            // 
            this.PublishedUserArticleNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PublishedUserArticleNumber.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PublishedUserArticleNumber.Appearance.Options.UseFont = true;
            this.PublishedUserArticleNumber.Appearance.Options.UseForeColor = true;
            this.PublishedUserArticleNumber.Location = new System.Drawing.Point(473, 85);
            this.PublishedUserArticleNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublishedUserArticleNumber.Name = "PublishedUserArticleNumber";
            this.PublishedUserArticleNumber.Size = new System.Drawing.Size(8, 19);
            this.PublishedUserArticleNumber.TabIndex = 18;
            this.PublishedUserArticleNumber.Text = "x";
            // 
            // articleImageBindingSource
            // 
            this.articleImageBindingSource.DataSource = typeof(SysDatCMS.Classes.ArticleImage);
            // 
            // articleBindingSource1
            // 
            this.articleBindingSource1.DataSource = typeof(SysDatCMS.Classes.Article);
            // 
            // disabledCellEvents1
            // 
            this.disabledCellEvents1.ProcessingCell += new System.EventHandler<DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs>(this.disabledCellEvents1_ProcessingCell);
            // 
            // UserMenu
            // 
            this.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 453);
            this.Controls.Add(this.PublishedUserArticleNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.VisualizeArticlesBtn);
            this.Controls.Add(this.CreateArticleBtn);
            this.Controls.Add(this.VisualizeUsersBtn);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.ArticleGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMenu_FormClosed);
            this.Load += new System.EventHandler(this.UserMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToModifyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestPublishBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesPopupGalleryBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl FormTitle;
        private DevExpress.XtraEditors.SimpleButton LogoutBtn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl ArticleGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ArticlesTable;
        private DevExpress.XtraEditors.SimpleButton VisualizeUsersBtn;
        private DevExpress.XtraEditors.SimpleButton CreateArticleBtn;
        private DevExpress.XtraEditors.SimpleButton VisualizeArticlesBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl PublishedUserArticleNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit GoToModifyBtn;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitolo;
        private DevExpress.XtraGrid.Columns.GridColumn colTesto;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn UpdateCol;
        private DevExpress.XtraGrid.Columns.GridColumn RequestPublishCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RequestPublishBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit UpdateBtn;
        private DevExpress.XtraGrid.Columns.GridColumn GoToModifyCol;
        private DevExpress.XtraGrid.Columns.GridColumn DeleteCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit imagesPopupGalleryBtn;
        private System.Windows.Forms.BindingSource articleImageBindingSource;
        private System.Windows.Forms.BindingSource articleBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit statusLookUpEditBtn;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.Behaviors.Common.DisabledCellEvents disabledCellEvents1;
    }
}