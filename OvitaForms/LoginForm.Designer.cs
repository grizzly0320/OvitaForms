namespace OvitaForms
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            enterButton = new Button();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.Location = new Point(104, 162);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(94, 29);
            enterButton.TabIndex = 0;
            enterButton.Text = "Вход";
            enterButton.TextImageRelation = TextImageRelation.TextAboveImage;
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(49, 116);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(216, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.Text = "Пароль";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(49, 67);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(216, 27);
            emailTextBox.TabIndex = 2;
            emailTextBox.Text = "E-mail";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(86, 194);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забыли пароль?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(273, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите логин и пароль, чтобы войти";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(38, 214);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(245, 20);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Нет аккаунта? Зарегестрируйтесь!";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 243);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(emailTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(enterButton);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterButton;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}