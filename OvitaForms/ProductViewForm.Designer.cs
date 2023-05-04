namespace OvitaForms
{
    partial class ProductViewForm
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
            productImagePictureBox = new PictureBox();
            productCategoryLinkLabel = new LinkLabel();
            productStaticCategoryLabel = new Label();
            productNameLabel = new Label();
            productStaticSalerLabel = new Label();
            productStaticLocationLabel = new Label();
            productStaticPanel = new Panel();
            productLinkedPanel = new Panel();
            productLocationLinkLabel = new LinkLabel();
            productSalerLinkLabel = new LinkLabel();
            productDescriptionRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).BeginInit();
            productStaticPanel.SuspendLayout();
            productLinkedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // productImagePictureBox
            // 
            productImagePictureBox.BackColor = Color.FromArgb(255, 192, 192);
            productImagePictureBox.Location = new Point(12, 12);
            productImagePictureBox.Name = "productImagePictureBox";
            productImagePictureBox.Size = new Size(300, 281);
            productImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            productImagePictureBox.TabIndex = 0;
            productImagePictureBox.TabStop = false;
            // 
            // productCategoryLinkLabel
            // 
            productCategoryLinkLabel.AutoSize = true;
            productCategoryLinkLabel.Location = new Point(14, 11);
            productCategoryLinkLabel.Name = "productCategoryLinkLabel";
            productCategoryLinkLabel.Size = new Size(76, 20);
            productCategoryLinkLabel.TabIndex = 2;
            productCategoryLinkLabel.TabStop = true;
            productCategoryLinkLabel.Text = "linkLabel1";
            productCategoryLinkLabel.LinkClicked += productCategoryLinkLabel_LinkClicked;
            // 
            // productStaticCategoryLabel
            // 
            productStaticCategoryLabel.AutoSize = true;
            productStaticCategoryLabel.Location = new Point(4, 11);
            productStaticCategoryLabel.Name = "productStaticCategoryLabel";
            productStaticCategoryLabel.Size = new Size(93, 20);
            productStaticCategoryLabel.TabIndex = 3;
            productStaticCategoryLabel.Text = "В категории";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productNameLabel.Location = new Point(334, 12);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(97, 41);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "label2";
            // 
            // productStaticSalerLabel
            // 
            productStaticSalerLabel.AutoSize = true;
            productStaticSalerLabel.Location = new Point(4, 40);
            productStaticSalerLabel.Name = "productStaticSalerLabel";
            productStaticSalerLabel.Size = new Size(79, 20);
            productStaticSalerLabel.TabIndex = 5;
            productStaticSalerLabel.Text = "Продавец";
            // 
            // productStaticLocationLabel
            // 
            productStaticLocationLabel.AutoSize = true;
            productStaticLocationLabel.Location = new Point(3, 70);
            productStaticLocationLabel.Name = "productStaticLocationLabel";
            productStaticLocationLabel.Size = new Size(51, 20);
            productStaticLocationLabel.TabIndex = 6;
            productStaticLocationLabel.Text = "Адрес";
            // 
            // productStaticPanel
            // 
            productStaticPanel.BackColor = Color.FromArgb(255, 255, 192);
            productStaticPanel.Controls.Add(productStaticLocationLabel);
            productStaticPanel.Controls.Add(productStaticCategoryLabel);
            productStaticPanel.Controls.Add(productStaticSalerLabel);
            productStaticPanel.Location = new Point(334, 56);
            productStaticPanel.Name = "productStaticPanel";
            productStaticPanel.Size = new Size(154, 237);
            productStaticPanel.TabIndex = 7;
            // 
            // productLinkedPanel
            // 
            productLinkedPanel.BackColor = Color.FromArgb(192, 255, 192);
            productLinkedPanel.Controls.Add(productLocationLinkLabel);
            productLinkedPanel.Controls.Add(productSalerLinkLabel);
            productLinkedPanel.Controls.Add(productCategoryLinkLabel);
            productLinkedPanel.Location = new Point(504, 56);
            productLinkedPanel.Name = "productLinkedPanel";
            productLinkedPanel.Size = new Size(284, 237);
            productLinkedPanel.TabIndex = 8;
            // 
            // productLocationLinkLabel
            // 
            productLocationLinkLabel.AutoSize = true;
            productLocationLinkLabel.Location = new Point(14, 70);
            productLocationLinkLabel.MaximumSize = new Size(256, 0);
            productLocationLinkLabel.Name = "productLocationLinkLabel";
            productLocationLinkLabel.Size = new Size(76, 20);
            productLocationLinkLabel.TabIndex = 4;
            productLocationLinkLabel.TabStop = true;
            productLocationLinkLabel.Text = "linkLabel3";
            // 
            // productSalerLinkLabel
            // 
            productSalerLinkLabel.AutoSize = true;
            productSalerLinkLabel.Location = new Point(14, 40);
            productSalerLinkLabel.Name = "productSalerLinkLabel";
            productSalerLinkLabel.Size = new Size(76, 20);
            productSalerLinkLabel.TabIndex = 3;
            productSalerLinkLabel.TabStop = true;
            productSalerLinkLabel.Text = "linkLabel2";
            productSalerLinkLabel.LinkClicked += productSalerLinkLabel_LinkClicked;
            // 
            // productDescriptionRichTextBox
            // 
            productDescriptionRichTextBox.Location = new Point(12, 299);
            productDescriptionRichTextBox.Name = "productDescriptionRichTextBox";
            productDescriptionRichTextBox.ReadOnly = true;
            productDescriptionRichTextBox.Size = new Size(776, 139);
            productDescriptionRichTextBox.TabIndex = 9;
            productDescriptionRichTextBox.Text = "";
            // 
            // ProductViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productDescriptionRichTextBox);
            Controls.Add(productNameLabel);
            Controls.Add(productImagePictureBox);
            Controls.Add(productStaticPanel);
            Controls.Add(productLinkedPanel);
            Name = "ProductViewForm";
            Text = "ProductViewForm";
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).EndInit();
            productStaticPanel.ResumeLayout(false);
            productStaticPanel.PerformLayout();
            productLinkedPanel.ResumeLayout(false);
            productLinkedPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImagePictureBox;
        private LinkLabel productCategoryLinkLabel;
        private Label productStaticCategoryLabel;
        private Label productNameLabel;
        private Label productStaticSalerLabel;
        private Label productStaticLocationLabel;
        private Panel productStaticPanel;
        private Panel productLinkedPanel;
        private LinkLabel productLocationLinkLabel;
        private LinkLabel productSalerLinkLabel;
        private RichTextBox productDescriptionRichTextBox;
    }
}