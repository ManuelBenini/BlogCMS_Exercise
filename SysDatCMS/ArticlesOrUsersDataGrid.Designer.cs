
namespace SysDatCMS
{
    partial class ArticlesOrUsersDataGrid
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
            this.ArticlesOrUsersGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UpdateBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.DeleteBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GoToModifyBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RoleLookUpEditBtn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusLookUpEditBtn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FormTitle = new DevExpress.XtraEditors.LabelControl();
            this.LogoutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.disabledCellEvents1 = new DevExpress.Utils.Behaviors.Common.DisabledCellEvents(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesOrUsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToModifyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleLookUpEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusLookUpEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticlesOrUsersGrid
            // 
            this.ArticlesOrUsersGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArticlesOrUsersGrid.Location = new System.Drawing.Point(22, 127);
            this.ArticlesOrUsersGrid.MainView = this.gridView1;
            this.ArticlesOrUsersGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArticlesOrUsersGrid.Name = "ArticlesOrUsersGrid";
            this.ArticlesOrUsersGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UpdateBtn,
            this.DeleteBtn,
            this.GoToModifyBtn,
            this.RoleLookUpEditBtn,
            this.StatusLookUpEditBtn});
            this.ArticlesOrUsersGrid.Size = new System.Drawing.Size(930, 345);
            this.ArticlesOrUsersGrid.TabIndex = 1;
            this.ArticlesOrUsersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.behaviorManager1.SetBehaviors(this.gridView1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.DisabledCellBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.GridViewDisabledCellSource), "[SysDatCMS.Classes.Role.Id] = 3", appearanceObject1, this.disabledCellEvents1)))});
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitolo,
            this.colAutore,
            this.colStatus,
            this.colTesto,
            this.updateCol});
            this.gridView1.GridControl = this.ArticlesOrUsersGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colTitolo
            // 
            this.colTitolo.FieldName = "Titolo";
            this.colTitolo.MinWidth = 24;
            this.colTitolo.Name = "colTitolo";
            this.colTitolo.Visible = true;
            this.colTitolo.VisibleIndex = 1;
            this.colTitolo.Width = 94;
            // 
            // colAutore
            // 
            this.colAutore.Caption = "Autore";
            this.colAutore.FieldName = "Autore";
            this.colAutore.MinWidth = 24;
            this.colAutore.Name = "colAutore";
            this.colAutore.Visible = true;
            this.colAutore.VisibleIndex = 2;
            this.colAutore.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colStatus.MinWidth = 24;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 94;
            // 
            // colTesto
            // 
            this.colTesto.FieldName = "Testo";
            this.colTesto.MinWidth = 24;
            this.colTesto.Name = "colTesto";
            this.colTesto.Visible = true;
            this.colTesto.VisibleIndex = 4;
            this.colTesto.Width = 94;
            // 
            // updateCol
            // 
            this.updateCol.Caption = "Aggiorna";
            this.updateCol.ColumnEdit = this.UpdateBtn;
            this.updateCol.MinWidth = 24;
            this.updateCol.Name = "updateCol";
            this.updateCol.Visible = true;
            this.updateCol.VisibleIndex = 5;
            this.updateCol.Width = 94;
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
            // DeleteBtn
            // 
            this.DeleteBtn.AutoHeight = false;
            this.DeleteBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            // RoleLookUpEditBtn
            // 
            this.RoleLookUpEditBtn.AutoHeight = false;
            this.RoleLookUpEditBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RoleLookUpEditBtn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.RoleLookUpEditBtn.DataSource = this.roleBindingSource;
            this.RoleLookUpEditBtn.DisplayMember = "Name";
            this.RoleLookUpEditBtn.KeyMember = "Id";
            this.RoleLookUpEditBtn.Name = "RoleLookUpEditBtn";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(SysDatCMS.Classes.Role);
            // 
            // StatusLookUpEditBtn
            // 
            this.StatusLookUpEditBtn.AutoHeight = false;
            this.StatusLookUpEditBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusLookUpEditBtn.DataSource = this.statusBindingSource;
            this.StatusLookUpEditBtn.DisplayMember = "Name";
            this.StatusLookUpEditBtn.KeyMember = "Id";
            this.StatusLookUpEditBtn.Name = "StatusLookUpEditBtn";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(SysDatCMS.Classes.Status);
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(SysDatCMS.Classes.Article);
            // 
            // FormTitle
            // 
            this.FormTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.FormTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.FormTitle.Appearance.Options.UseFont = true;
            this.FormTitle.Appearance.Options.UseForeColor = true;
            this.FormTitle.Location = new System.Drawing.Point(351, 31);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(293, 36);
            this.FormTitle.TabIndex = 34;
            this.FormTitle.Text = "Visualizzazione articoli";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.LogoutBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.LogoutBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.LogoutBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LogoutBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Appearance.Options.UseBackColor = true;
            this.LogoutBtn.Appearance.Options.UseBorderColor = true;
            this.LogoutBtn.Appearance.Options.UseFont = true;
            this.LogoutBtn.Appearance.Options.UseForeColor = true;
            this.LogoutBtn.Location = new System.Drawing.Point(813, 25);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(139, 42);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Torna al menù";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(22, 87);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Non pubblicati";
            this.checkEdit1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.checkEdit1.Size = new System.Drawing.Size(113, 24);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SysDatCMS.Classes.User);
            // 
            // disabledCellEvents1
            // 
            this.disabledCellEvents1.ProcessingCell += new System.EventHandler<DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs>(this.disabledCellEvents1_ProcessingCell);
            // 
            // ArticlesOrUsersDataGrid
            // 
            this.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 598);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.ArticlesOrUsersGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArticlesOrUsersDataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleOrUserDataGrid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArticleOrUserDataGrid_FormClosed);
            this.Load += new System.EventHandler(this.ArticleOrUserDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesOrUsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToModifyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleLookUpEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusLookUpEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ArticlesOrUsersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl FormTitle;
        private DevExpress.XtraEditors.SimpleButton LogoutBtn;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit UpdateBtn;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitolo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutore;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTesto;
        private DevExpress.XtraGrid.Columns.GridColumn updateCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit GoToModifyBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RoleLookUpEditBtn;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit StatusLookUpEditBtn;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.Behaviors.Common.DisabledCellEvents disabledCellEvents1;
    }
}