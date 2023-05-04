using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OvitaForms
{
    public partial class LoginForm : Form
    {
        bool isLogged = false;
        BDConnection connection;
        public LoginForm(BDConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            // email
            this.emailTextBox.Enter += new EventHandler(emailTextBox_Enter);
            this.emailTextBox.Leave += new EventHandler(emailTextBox_Leave);
            emailTextBox_SetText();
            // password
            this.passwordTextBox.Enter += new EventHandler(passwordTextBox_Enter);
            this.passwordTextBox.Leave += new EventHandler(passwordTextBox_Leave);
            passwordTextBox_SetText();

            this.emailTextBox.Validating += emailTextBox_TextChanged;
            this.passwordTextBox.Validating += passwordTextBox_TextChanged;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(connection);
            registrationForm.ShowDialog();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (!connection.DoesExistItem("email", emailTextBox.Text))
            {
                ErrorForm error = new ErrorForm("Пользователя с такой электронной почтой не существует или вы ввели ее неверно");
                error.ShowDialog();
            }
            else
            {
                if (!connection.IsPasswordCorrect(emailTextBox.Text, passwordTextBox.Text))
                {
                    ErrorForm error = new ErrorForm("Пароль не совпадает или введен неверно");
                    error.ShowDialog();
                }
                else
                {
                    isLogged = true;
                    //Form1 mainForm = new Form1(isLogged);
                    Form1 mainForm = new Form1(connection.GetUser(connection.GetUserId("email", emailTextBox.Text)), isLogged);
                    mainForm.Show();
                    this.Close();
                }
            }
        }
        //-------------------------------------------------------------------------------------
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "Не указан email!");
            }
            else if (emailTextBox.Text.Length < 2)
            {
                errorProvider1.SetError(emailTextBox, "Слишком короткий email!");
            }
            else if (!emailTextBox.Text.Contains('@'))
            {
                errorProvider1.SetError(emailTextBox, "Неверно указан email!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        protected void emailTextBox_SetText()
        {
            this.emailTextBox.Text = "E-mail";
            emailTextBox.ForeColor = Color.Gray;
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.ForeColor == Color.Black)
                return;
            emailTextBox.Text = "";
            emailTextBox.ForeColor = Color.Black;
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Trim() == "")
                emailTextBox_SetText();
        }
        //-------------------------------------------------------------------------------------
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text == "Пароль")
            {
                errorProvider2.SetError(passwordTextBox, "Не указан пароль!");
            }
            else if (passwordTextBox.Text.Length < 2)
            {
                errorProvider2.SetError(passwordTextBox, "Слишком короткий пароль!");
            }
            else if (CheckPassword(passwordTextBox.Text))
            {
                errorProvider2.SetError(passwordTextBox, "Пароль должен содержать только латинские буквы, цифры или символы \"!@#$%&*\"");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private bool CheckPassword(string password)
        {
            for (int i = 0; i < password.Length; i++)
                if ((password[i] < 33 || password[i] > 38) && (password[i] < 65 || password[i] > 90) && (password[i] < 97 || password[i] > 122))
                    return false;
            return true;
        }
        protected void passwordTextBox_SetText()
        {
            this.passwordTextBox.Text = "Пароль";
            passwordTextBox.ForeColor = Color.Gray;
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.ForeColor == Color.Black)
                return;
            passwordTextBox.Text = "";
            passwordTextBox.ForeColor = Color.Black;
        }
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Trim() == "")
                passwordTextBox_SetText();
        }
    }
}
