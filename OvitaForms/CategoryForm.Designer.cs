namespace OvitaForms
{
    partial class CategoryForm
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
            panel1 = new Panel();
            categoryLabel = new Label();
            inCategoryStaticLabel = new Label();
            panel2 = new Panel();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(inCategoryStaticLabel);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 0;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(224, 8);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(109, 46);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "label2";
            // 
            // inCategoryStaticLabel
            // 
            inCategoryStaticLabel.AutoSize = true;
            inCategoryStaticLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            inCategoryStaticLabel.Location = new Point(11, 8);
            inCategoryStaticLabel.Name = "inCategoryStaticLabel";
            inCategoryStaticLabel.Size = new Size(207, 46);
            inCategoryStaticLabel.TabIndex = 0;
            inCategoryStaticLabel.Text = "В категории";
            // 
            // panel2
            // 
            panel2.Location = new Point(624, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 370);
            panel2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(606, 370);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label categoryLabel;
        private Label inCategoryStaticLabel;
        private Panel panel2;
        private ListView listView1;
    }
}