using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OvitaForms
{
    public partial class RegistrationForm : Form
    {
        bool isLogged = false;
        BDConnection connection;
        bool toUpdate;
        public RegistrationForm(BDConnection connection, bool toUpdate = false)
        {
            InitializeComponent();
            this.toUpdate = toUpdate;
            this.connection = connection;
            label1.Text = (!toUpdate) ? "Регистрация" : "Изменить";
            registerButton.Text = (!toUpdate) ? "Регистрация" : "Сохранить";
            // lastName
            this.lastNameTextBox.Enter += new EventHandler(lastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new EventHandler(lastNameTextBox_Leave);
            lastNameTextBox_SetText();
            // firstName
            this.firstNameTextBox.Enter += new EventHandler(firstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new EventHandler(firstNameTextBox_Leave);
            firstNameTextBox_SetText();
            // phone
            this.phoneTextBox.Enter += new EventHandler(phoneTextBox_Enter);
            this.phoneTextBox.Leave += new EventHandler(phoneTextBox_Leave);
            phoneTextBox_SetText();
            // email
            this.emailTextBox.Enter += new EventHandler(emailTextBox_Enter);
            this.emailTextBox.Leave += new EventHandler(emailTextBox_Leave);
            emailTextBox_SetText();
            // password
            this.passwordTextBox.Enter += new EventHandler(passwordTextBox_Enter);
            this.passwordTextBox.Leave += new EventHandler(passwordTextBox_Leave);
            passwordTextBox_SetText();

            lastNameTextBox.Validating += lastNameTextBox_TextChanged;
            firstNameTextBox.Validating += firstNameTextBox_TextChanged;
            phoneTextBox.Validating += phoneTextBox_TextChanged;
            emailTextBox.Validating += emailTextBox_TextChanged;
            passwordTextBox.Validating += passwordTextBox_TextChanged;

        }
        Account account;
        public RegistrationForm(BDConnection connection, Account account,  bool toUpdate = false)
        {
            InitializeComponent();
            this.account = account;
            this.toUpdate = toUpdate;
            this.connection = connection;
            label1.Text = (!toUpdate) ? "Регистрация" : "Изменить";
            registerButton.Text = (!toUpdate) ? "Регистрация" : "Сохранить";
            // lastName
            this.lastNameTextBox.Enter += new EventHandler(lastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new EventHandler(lastNameTextBox_Leave);
            lastNameTextBox_SetText();
            // firstName
            this.firstNameTextBox.Enter += new EventHandler(firstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new EventHandler(firstNameTextBox_Leave);
            firstNameTextBox_SetText();
            // phone
            this.phoneTextBox.Enter += new EventHandler(phoneTextBox_Enter);
            this.phoneTextBox.Leave += new EventHandler(phoneTextBox_Leave);
            phoneTextBox_SetText();
            // email
            this.emailTextBox.Enter += new EventHandler(emailTextBox_Enter);
            this.emailTextBox.Leave += new EventHandler(emailTextBox_Leave);
            emailTextBox_SetText();
            // password
            this.passwordTextBox.Enter += new EventHandler(passwordTextBox_Enter);
            this.passwordTextBox.Leave += new EventHandler(passwordTextBox_Leave);
            passwordTextBox_SetText();

            lastNameTextBox.Validating += lastNameTextBox_TextChanged;
            firstNameTextBox.Validating += firstNameTextBox_TextChanged;
            phoneTextBox.Validating += phoneTextBox_TextChanged;
            emailTextBox.Validating += emailTextBox_TextChanged;
            passwordTextBox.Validating += passwordTextBox_TextChanged;

        }

        //---------------------------------------------------------------------------------------------------------
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTextBox.Text) || lastNameTextBox.Text == "Фамилия")
            {
                errorProvider1.SetError(lastNameTextBox, "Не указана фамилия!");
            }
            else if (lastNameTextBox.Text.Length < 2)
            {
                errorProvider1.SetError(lastNameTextBox, "Слишком короткая фамилия!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        protected void lastNameTextBox_SetText()
        {
            this.lastNameTextBox.Text = (!toUpdate) ? "Фамилия": account.LastName;
            lastNameTextBox.ForeColor = Color.Gray;
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.ForeColor == Color.Black)
                return;
            lastNameTextBox.Text = "";
            lastNameTextBox.ForeColor = Color.Black;
        }
        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.Trim() == "")
                lastNameTextBox_SetText();
        }
        //---------------------------------------------------------------------------------------------------------
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNameTextBox.Text) || firstNameTextBox.Text == "Имя")
            {
                errorProvider2.SetError(firstNameTextBox, "Не указано имя!");
            }
            else if (firstNameTextBox.Text.Length < 2)
            {
                errorProvider2.SetError(firstNameTextBox, "Слишком короткое имя!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        protected void firstNameTextBox_SetText()
        {
            this.firstNameTextBox.Text = (!toUpdate) ? "Имя": account.FirstName;
            firstNameTextBox.ForeColor = Color.Gray;
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.ForeColor == Color.Black)
                return;
            firstNameTextBox.Text = "";
            firstNameTextBox.ForeColor = Color.Black;
        }
        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Trim() == "")
                firstNameTextBox_SetText();
        }
        //---------------------------------------------------------------------------------------------------------
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(phoneTextBox.Text) || phoneTextBox.Text == "Телефон")
            {
                errorProvider3.SetError(phoneTextBox, "Не указан телефон!");
            }
            else if (phoneTextBox.Text.Length != 11 || CheckPhone(phoneTextBox.Text))
            {
                errorProvider3.SetError(phoneTextBox, "Номер телефона указан неверно!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        bool CheckPhone(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < 48 || phone[i] > 57)
                    return false;
            }
            return true;
        }

        protected void phoneTextBox_SetText()
        {
            this.phoneTextBox.Text = (!toUpdate) ? "Телефон" : account.Phone;
            phoneTextBox.ForeColor = Color.Gray;
        }

        private void phoneTextBox_Enter(object sender, EventArgs e)
        {
            if (phoneTextBox.ForeColor == Color.Black)
                return;
            phoneTextBox.Text = "";
            phoneTextBox.ForeColor = Color.Black;
        }
        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            if (phoneTextBox.Text.Trim() == "")
                phoneTextBox_SetText();
        }

        //---------------------------------------------------------------------------------------------------------
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                errorProvider4.SetError(emailTextBox, "Не указан email!");
            }
            else if (emailTextBox.Text.Length < 2)
            {
                errorProvider4.SetError(emailTextBox, "Слишком короткий email!");
            }
            else if (!emailTextBox.Text.Contains('@'))
            {
                errorProvider4.SetError(emailTextBox, "Неверно указан email!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        protected void emailTextBox_SetText()
        {
            this.emailTextBox.Text = (!toUpdate) ? "E-mail" : account.Email;
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
        //---------------------------------------------------------------------------------------------------------
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                errorProvider5.SetError(passwordTextBox, "Не указан пароль!");
            }
            else if (passwordTextBox.Text.Length < 2)
            {
                errorProvider5.SetError(passwordTextBox, "Слишком короткий пароль!");
            }
            else if (CheckPassword(passwordTextBox.Text))
            {
                errorProvider5.SetError(passwordTextBox, "Пароль должен содержать только латинские буквы, цифры или символы \"!@#$%&*\"");
            }
            else
            {
                errorProvider5.Clear();
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
            this.passwordTextBox.Text = (!toUpdate) ? "Пароль" : account.Password;
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
        //---------------------------------------------------------------------------------------------------------
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (this.connection.DoesExistItem("phone", phoneTextBox.Text) && phoneTextBox.Text != account.Phone)
            {
                ErrorForm error = new ErrorForm("Пользователя с таким номером телефона уже существует");
                error.ShowDialog();
            }
            else {
                if (phoneTextBox.Text.Length != 11)
                {
                    ErrorForm error = new ErrorForm("Номер телефона введен неверно!");
                    error.ShowDialog();
                }
                else
                {
                    if (this.connection.DoesExistItem("email", emailTextBox.Text) && emailTextBox.Text != account.Email)
                    {
                        ErrorForm error = new ErrorForm("Пользователя с такой электронной почтой уже существует");
                        error.ShowDialog();
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text.Length < 2 || CheckPassword(passwordTextBox.Text))
                        {
                            ErrorForm error = new ErrorForm("Пароль введен неверно!");
                            error.ShowDialog();
                        }
                        else
                        {
                            if (!this.toUpdate)
                            {
                                isLogged = true;
                                connection.InsertUser(lastNameTextBox.Text, firstNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
                                //Form1 mainForm = new Form1(isLogged);
                                Form1 mainForm = new Form1(connection.GetUser(connection.GetUserId("email", emailTextBox.Text)), isLogged);
                                mainForm.Show();
                                this.Close();
                            }
                            else
                            {
                                connection.UpdateAtribute("Users", account.Id, "last_name", lastNameTextBox.Text);
                                connection.UpdateAtribute("Users", account.Id, "first_name", firstNameTextBox.Text);
                                connection.UpdateAtribute("Users", account.Id, "phone", phoneTextBox.Text);
                                connection.UpdateAtribute("Users", account.Id, "email", emailTextBox.Text);
                                connection.UpdateAtribute("Users", account.Id, "pswrd", passwordTextBox.Text);
                                account.LastName = lastNameTextBox.Text;
                                account.FirstName = firstNameTextBox.Text;
                                account.Phone = phoneTextBox.Text;
                                account.Email = emailTextBox.Text;
                                this.Close();
                            }
                        }
                    }
                }
            }
            this.Close();
        }

    }
}
