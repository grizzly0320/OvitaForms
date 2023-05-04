namespace OvitaForms
{
    partial class PersonalProducts
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
            addProductButton = new Button();
            SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(579, 409);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(209, 29);
            addProductButton.TabIndex = 0;
            addProductButton.Text = "Создать новое объявление";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // PersonalProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addProductButton);
            Name = "PersonalProducts";
            Text = "PersonalProducts";
            ResumeLayout(false);
        }

        #endregion

        private Button addProductButton;
    }
}