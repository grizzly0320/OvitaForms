using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OvitaForms
{
    public partial class ProductViewForm : Form
    {
        private Product product;
        BDConnection connection;
        public ProductViewForm(Product product, BDConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.product = product;
            this.productImagePictureBox.Image = product.Image;
            this.productNameLabel.Text = product.Type + " " + product.Maker + " " + product.Model;
            this.productCategoryLinkLabel.Text = connection.GetAtribute("Category", product.Category, "name");
            this.productSalerLinkLabel.Text = connection.GetAtribute("Users", product.Saler, "last_name") + " " + connection.GetAtribute("Users", product.Saler, "first_name");
            this.productLocationLinkLabel.Text = connection.GetAtribute("Location", product.Location, "city") + ", " + connection.GetAtribute("Location", product.Location, "region") + ", " + connection.GetAtribute("Location", product.Location, "country");
            this.productDescriptionRichTextBox.Text = product.Description;
            this.connection = connection;
        }

        private void productCategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(connection, product.Category);
            categoryForm.Show();
            this.Close();
        }

        private void productSalerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountForm accountForm = new AccountForm(connection.GetUser(product.Saler), connection);
            accountForm.Show();
        }
    }
}
