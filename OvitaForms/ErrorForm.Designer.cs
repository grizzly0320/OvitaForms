namespace OvitaForms
{
    partial class ErrorForm
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
            closeButton = new Button();
            errorMessageLabel = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Dock = DockStyle.Bottom;
            closeButton.Location = new Point(0, 117);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(507, 29);
            closeButton.TabIndex = 0;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.Location = new Point(20, 20);
            errorMessageLabel.Margin = new Padding(10);
            errorMessageLabel.MaximumSize = new Size(485, 0);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(50, 20);
            errorMessageLabel.TabIndex = 1;
            errorMessageLabel.Text = "label1";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 146);
            Controls.Add(errorMessageLabel);
            Controls.Add(closeButton);
            Name = "ErrorForm";
            Text = "ErrorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label errorMessageLabel;
    }
}