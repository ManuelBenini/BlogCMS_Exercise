
namespace SysDatCMS
{
    partial class ArticleOperations
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
            this.FormTitle = new DevExpress.XtraEditors.LabelControl();
            this.ReturnToMenuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.titleField = new DevExpress.XtraEditors.TextEdit();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.textLabel = new DevExpress.XtraEditors.LabelControl();
            this.imageLabel = new DevExpress.XtraEditors.LabelControl();
            this.createArticleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.VisualizeArticlesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.StatusLabel = new DevExpress.XtraEditors.LabelControl();
            this.StatusGroup = new DevExpress.XtraEditors.RadioGroup();
            this.createArticleEP = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.ImageFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.openImageDialogBtn = new DevExpress.XtraEditors.SimpleButton();
            this.articleImageSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageField = new DevExpress.XtraEditors.TextEdit();
            this.textField = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.titleField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createArticleEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImageSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textField.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.FormTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.FormTitle.Appearance.Options.UseFont = true;
            this.FormTitle.Appearance.Options.UseForeColor = true;
            this.FormTitle.Location = new System.Drawing.Point(308, 28);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(134, 29);
            this.FormTitle.TabIndex = 3;
            this.FormTitle.Text = "Crea articolo";
            // 
            // ReturnToMenuBtn
            // 
            this.ReturnToMenuBtn.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.ReturnToMenuBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.ReturnToMenuBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.ReturnToMenuBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ReturnToMenuBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.ReturnToMenuBtn.Appearance.Options.UseBackColor = true;
            this.ReturnToMenuBtn.Appearance.Options.UseBorderColor = true;
            this.ReturnToMenuBtn.Appearance.Options.UseFont = true;
            this.ReturnToMenuBtn.Appearance.Options.UseForeColor = true;
            this.ReturnToMenuBtn.Location = new System.Drawing.Point(659, 28);
            this.ReturnToMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnToMenuBtn.Name = "ReturnToMenuBtn";
            this.ReturnToMenuBtn.Size = new System.Drawing.Size(119, 34);
            this.ReturnToMenuBtn.TabIndex = 6;
            this.ReturnToMenuBtn.Text = "Torna al menù";
            this.ReturnToMenuBtn.Click += new System.EventHandler(this.ReturnToMenuBtn_Click);
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(494, 115);
            this.titleField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleField.Name = "titleField";
            this.titleField.Properties.AutoHeight = false;
            this.titleField.Size = new System.Drawing.Size(285, 29);
            this.titleField.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.titleLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Appearance.Options.UseFont = true;
            this.titleLabel.Appearance.Options.UseForeColor = true;
            this.titleLabel.Location = new System.Drawing.Point(436, 117);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 23);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Titolo:";
            // 
            // textLabel
            // 
            this.textLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textLabel.Appearance.Options.UseFont = true;
            this.textLabel.Appearance.Options.UseForeColor = true;
            this.textLabel.Location = new System.Drawing.Point(438, 271);
            this.textLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(52, 23);
            this.textLabel.TabIndex = 21;
            this.textLabel.Text = "Testo:";
            // 
            // imageLabel
            // 
            this.imageLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.imageLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.imageLabel.Appearance.Options.UseFont = true;
            this.imageLabel.Appearance.Options.UseForeColor = true;
            this.imageLabel.Location = new System.Drawing.Point(399, 167);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(92, 23);
            this.imageLabel.TabIndex = 20;
            this.imageLabel.Text = "Immagine:";
            // 
            // createArticleBtn
            // 
            this.createArticleBtn.Appearance.BackColor = System.Drawing.Color.Chartreuse;
            this.createArticleBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.createArticleBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.createArticleBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.createArticleBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.createArticleBtn.Appearance.Options.UseBackColor = true;
            this.createArticleBtn.Appearance.Options.UseBorderColor = true;
            this.createArticleBtn.Appearance.Options.UseFont = true;
            this.createArticleBtn.Appearance.Options.UseForeColor = true;
            this.createArticleBtn.Location = new System.Drawing.Point(496, 405);
            this.createArticleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createArticleBtn.Name = "createArticleBtn";
            this.createArticleBtn.Size = new System.Drawing.Size(75, 34);
            this.createArticleBtn.TabIndex = 4;
            this.createArticleBtn.Text = "Crea";
            this.createArticleBtn.Click += new System.EventHandler(this.createArticleBtn_Click);
            // 
            // VisualizeArticlesBtn
            // 
            this.VisualizeArticlesBtn.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.VisualizeArticlesBtn.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.VisualizeArticlesBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.VisualizeArticlesBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.VisualizeArticlesBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.VisualizeArticlesBtn.Appearance.Options.UseBackColor = true;
            this.VisualizeArticlesBtn.Appearance.Options.UseBorderColor = true;
            this.VisualizeArticlesBtn.Appearance.Options.UseFont = true;
            this.VisualizeArticlesBtn.Appearance.Options.UseForeColor = true;
            this.VisualizeArticlesBtn.Location = new System.Drawing.Point(591, 405);
            this.VisualizeArticlesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizeArticlesBtn.Name = "VisualizeArticlesBtn";
            this.VisualizeArticlesBtn.Size = new System.Drawing.Size(187, 34);
            this.VisualizeArticlesBtn.TabIndex = 5;
            this.VisualizeArticlesBtn.Text = "Visualizzazione Articoli";
            this.VisualizeArticlesBtn.Click += new System.EventHandler(this.VisualizeArticlesBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.StatusLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Appearance.Options.UseFont = true;
            this.StatusLabel.Appearance.Options.UseForeColor = true;
            this.StatusLabel.Location = new System.Drawing.Point(439, 223);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(50, 23);
            this.StatusLabel.TabIndex = 25;
            this.StatusLabel.Text = "Stato:";
            // 
            // StatusGroup
            // 
            this.StatusGroup.Location = new System.Drawing.Point(496, 222);
            this.StatusGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatusGroup.Properties.Appearance.Options.UseBackColor = true;
            this.StatusGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.StatusGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pubblicato", true, 1),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Sospeso", true, 2),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Cancellato", true, 3)});
            this.StatusGroup.Size = new System.Drawing.Size(283, 28);
            this.StatusGroup.TabIndex = 0;
            // 
            // createArticleEP
            // 
            this.createArticleEP.ContainerControl = this;
            // 
            // openImageDialogBtn
            // 
            this.openImageDialogBtn.Location = new System.Drawing.Point(556, 168);
            this.openImageDialogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openImageDialogBtn.Name = "openImageDialogBtn";
            this.openImageDialogBtn.Size = new System.Drawing.Size(110, 29);
            this.openImageDialogBtn.TabIndex = 2;
            this.openImageDialogBtn.Text = "Carica";
            this.openImageDialogBtn.Click += new System.EventHandler(this.openImageDialogBtn_Click);
            // 
            // articleImageSlider
            // 
            this.articleImageSlider.Location = new System.Drawing.Point(10, 117);
            this.articleImageSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.articleImageSlider.Name = "articleImageSlider";
            this.articleImageSlider.Size = new System.Drawing.Size(383, 258);
            this.articleImageSlider.TabIndex = 32;
            this.articleImageSlider.Text = "imageSlider1";
            // 
            // imageField
            // 
            this.imageField.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageField.Enabled = false;
            this.imageField.Location = new System.Drawing.Point(494, 168);
            this.imageField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageField.Name = "imageField";
            this.imageField.Properties.AutoHeight = false;
            this.imageField.Size = new System.Drawing.Size(79, 29);
            this.imageField.TabIndex = 33;
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(506, 270);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(272, 96);
            this.textField.TabIndex = 3;
            // 
            // ArticleOperations
            // 
            this.AcceptButton = this.createArticleBtn;
            this.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.openImageDialogBtn);
            this.Controls.Add(this.imageField);
            this.Controls.Add(this.articleImageSlider);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.VisualizeArticlesBtn);
            this.Controls.Add(this.createArticleBtn);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.ReturnToMenuBtn);
            this.Controls.Add(this.FormTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArticleOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleOperations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArticleOperations_FormClosed);
            this.Load += new System.EventHandler(this.ArticleOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createArticleEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImageSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textField.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl FormTitle;
        private DevExpress.XtraEditors.SimpleButton ReturnToMenuBtn;
        private DevExpress.XtraEditors.TextEdit titleField;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.XtraEditors.LabelControl textLabel;
        private DevExpress.XtraEditors.LabelControl imageLabel;
        private DevExpress.XtraEditors.SimpleButton createArticleBtn;
        private DevExpress.XtraEditors.SimpleButton VisualizeArticlesBtn;
        private DevExpress.XtraEditors.LabelControl StatusLabel;
        private DevExpress.XtraEditors.RadioGroup StatusGroup;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider createArticleEP;
        private DevExpress.XtraEditors.XtraOpenFileDialog ImageFileDialog;
        private DevExpress.XtraEditors.SimpleButton openImageDialogBtn;
        private DevExpress.XtraEditors.Controls.ImageSlider articleImageSlider;
        private DevExpress.XtraEditors.TextEdit imageField;
        private DevExpress.XtraEditors.MemoEdit textField;
    }
}