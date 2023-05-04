using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OvitaForms
{
    public partial class AccountForm : Form
    {
        List<Product> products;
        Account account;
        BDConnection connection;
        bool toView;
        public AccountForm(Account account, BDConnection connection, bool toView = false)
        {
            InitializeComponent();
            this.account = account;
            this.toView = toView;
            this.updateUserButton.Visible = toView;
            this.deleteUserButton.Visible = toView;
            this.connection = connection;
            this.accountImagePictureBox.Image = account.Image;
            this.accountNameLabel.Text = account.LastName + " " + account.FirstName;
            this.accoutnPhoneLinkLabel.Text = "+" + account.Phone;
            this.accountEmailLinkLabel.Text = account.Email;
            this.products = connection.SelectSimilarProducts("account_id", account.Id.ToString());
            for (int i = 0; i < products.Count; i++)
            {
                listView1.Items.Add(products[i].ToString());
                listView1.Items[i].Tag = products[i].Id;
            }
        }

        private void accountImagePictureBox_Click(object sender, EventArgs e)
        {
            if (toView)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    account.Image = new Bitmap(openFileDialog.FileName);
                    accountImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
                    connection.UpdateUserImage(openFileDialog.FileName, account.Id);
                    this.accountImagePictureBox.Refresh();
                }
            }else { }
        }

        private int FindIndex()
        {
            if (listView1.Items.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected == true)
                        return i;
                }
            }
            return 0;
        }

        private Product FindProduct()
        {
            foreach (var i in products)
            {
                if (i.Id == (int)listView1.Items[FindIndex()].Tag)
                    return i;
            }
            return null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductViewForm productViewForm = new ProductViewForm(FindProduct(), connection);
            productViewForm.ShowDialog();

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(connection, account,  true);
            registrationForm.ShowDialog();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            List<Product> products = connection.SelectSimilarProducts("id", account.Id.ToString());
            for (int i = 0; i < products.Count; i++)
            {
                connection.Delete("Products", products[i].Id);
            }
            connection.Delete("Users", account.Id);
        }
    }
}
