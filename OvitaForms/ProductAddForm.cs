using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OvitaForms
{
    public partial class ProductAddForm : Form
    {
        BDConnection connection;
        private string fileName;
        Account account;
        public ProductAddForm(BDConnection connection, Account accoutn)
        {
            InitializeComponent();
            this.connection = connection;
            this.account = accoutn;
        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.fileName = openFileDialog.FileName;
                productPictureBox.Image = new Bitmap(openFileDialog.FileName);
                this.productPictureBox.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.InsertLocation(cityTextBox.Text, regionTextBox.Text, countryTextBox.Text);
            connection.InsertProduct(this.fileName, typeTextBox.Text, makerTextBox.Text, modelTextBox.Text, descriptionRichTextBox.Text, account.Id, this.categotyComboBox.SelectedIndex + 1, Int32.Parse(priceTextBox.Text), 2, 0);
            this.Close();
        }
    }
}
//connection.GetLocationId(cityTextBox.Text, regionTextBox.Text, countryTextBox.Text)