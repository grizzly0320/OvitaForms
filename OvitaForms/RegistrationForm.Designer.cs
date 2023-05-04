namespace OvitaForms
{
    partial class RegistrationForm
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
            lastNameTextBox = new TextBox();
            label1 = new Label();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            firstNameTextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(37, 55);
            lastNameTextBox.Margin = new Padding(6);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(234, 27);
            lastNameTextBox.TabIndex = 0;
            lastNameTextBox.Text = "Фамилия";
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(37, 166);
            emailTextBox.Margin = new Padding(6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 27);
            emailTextBox.TabIndex = 2;
            emailTextBox.Text = "E-mail";
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(37, 127);
            phoneTextBox.Margin = new Padding(6);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(234, 27);
            phoneTextBox.TabIndex = 3;
            phoneTextBox.Text = "Телефон";
            phoneTextBox.TextChanged += phoneTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(37, 205);
            passwordTextBox.Margin = new Padding(6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.Text = "Пароль";
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(70, 241);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(159, 29);
            registerButton.TabIndex = 5;
            registerButton.Text = "Зарегестрироваться";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(37, 91);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(234, 27);
            firstNameTextBox.TabIndex = 6;
            firstNameTextBox.Text = "Имя";
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 282);
            Controls.Add(firstNameTextBox);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label1);
            Controls.Add(lastNameTextBox);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTextBox;
        private Label label1;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private TextBox firstNameTextBox;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}