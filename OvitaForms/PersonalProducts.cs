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
    public partial class PersonalProducts : Form
    {
        Account account;
        BDConnection connection;
        public PersonalProducts(Account account, BDConnection connection)
        {
            InitializeComponent();
            this.account = account;
            this.connection = connection;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm(connection, account);
            productAddForm.ShowDialog();
        }
    }
}
