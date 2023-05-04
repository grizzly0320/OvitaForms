namespace OvitaForms
{
    partial class ProductAddForm
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
            categotyComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            countryTextBox = new TextBox();
            regionTextBox = new TextBox();
            cityTextBox = new TextBox();
            priceTextBox = new TextBox();
            modelTextBox = new TextBox();
            makerTextBox = new TextBox();
            typeTextBox = new TextBox();
            descriptionRichTextBox = new RichTextBox();
            productPictureBox = new PictureBox();
            button1 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // categotyComboBox
            // 
            categotyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categotyComboBox.FormattingEnabled = true;
            categotyComboBox.Items.AddRange(new object[] { "Одежда, обувь и аксессуары", "Транспорт", "Работа ", "Для дома и дачи", "Недвижимость", "Электроника", "Хобби и отдых", "Животные ", "Услуги" });
            categotyComboBox.Location = new Point(503, 25);
            categotyComboBox.Name = "categotyComboBox";
            categotyComboBox.Size = new Size(251, 28);
            categotyComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Margin = new Padding(20, 10, 20, 10);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберите категорию";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 93);
            label2.Margin = new Padding(20, 10, 20, 10);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите производителя";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(204, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 330);
            panel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 293);
            label8.Margin = new Padding(20, 10, 20, 10);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 9;
            label8.Text = "Введите страну";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 253);
            label7.Margin = new Padding(20, 10, 20, 10);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 8;
            label7.Text = "Введите регион";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 173);
            label6.Margin = new Padding(20, 10, 20, 10);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 7;
            label6.Text = "Введите цену";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 213);
            label5.Margin = new Padding(20, 10, 20, 10);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 6;
            label5.Text = "Введите город";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 133);
            label4.Margin = new Padding(20, 10, 20, 10);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 5;
            label4.Text = "Введите модель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 53);
            label3.Margin = new Padding(20, 10, 20, 10);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Введите тип";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(countryTextBox);
            panel3.Controls.Add(regionTextBox);
            panel3.Controls.Add(cityTextBox);
            panel3.Controls.Add(priceTextBox);
            panel3.Controls.Add(modelTextBox);
            panel3.Controls.Add(makerTextBox);
            panel3.Controls.Add(typeTextBox);
            panel3.Location = new Point(488, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 330);
            panel3.TabIndex = 5;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(15, 293);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(251, 27);
            countryTextBox.TabIndex = 6;
            // 
            // regionTextBox
            // 
            regionTextBox.Location = new Point(15, 253);
            regionTextBox.Name = "regionTextBox";
            regionTextBox.Size = new Size(251, 27);
            regionTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(15, 213);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(251, 27);
            cityTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(15, 173);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(251, 27);
            priceTextBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(15, 133);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(251, 27);
            modelTextBox.TabIndex = 2;
            // 
            // makerTextBox
            // 
            makerTextBox.Location = new Point(15, 93);
            makerTextBox.Name = "makerTextBox";
            makerTextBox.Size = new Size(251, 27);
            makerTextBox.TabIndex = 1;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(15, 53);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(251, 27);
            typeTextBox.TabIndex = 0;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(12, 348);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(776, 121);
            descriptionRichTextBox.TabIndex = 6;
            descriptionRichTextBox.Text = "Введите описание товара";
            // 
            // productPictureBox
            // 
            productPictureBox.BackColor = Color.FromArgb(255, 192, 192);
            productPictureBox.ImageLocation = "C:\\Users\\domit\\source\\repos\\OvitaForms\\OvitaForms\\DefaultImages\\no_account_photo.jpg";
            productPictureBox.Location = new Point(12, 12);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(186, 200);
            productPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            productPictureBox.TabIndex = 7;
            productPictureBox.TabStop = false;
            productPictureBox.Click += productPictureBox_Click;
            // 
            // button1
            // 
            button1.Location = new Point(296, 475);
            button1.Name = "button1";
            button1.Size = new Size(205, 29);
            button1.TabIndex = 8;
            button1.Text = "Выставить на продажу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(button1);
            Controls.Add(productPictureBox);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(categotyComboBox);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "ProductAddForm";
            Text = "ProductAddForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox categotyComboBox;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox countryTextBox;
        private TextBox regionTextBox;
        private TextBox cityTextBox;
        private TextBox priceTextBox;
        private TextBox modelTextBox;
        private TextBox makerTextBox;
        private TextBox typeTextBox;
        private RichTextBox descriptionRichTextBox;
        private PictureBox productPictureBox;
        private Button button1;
    }
}