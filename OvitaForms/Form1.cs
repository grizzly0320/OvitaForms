using System.Diagnostics.Eventing.Reader;

namespace OvitaForms
{
    public partial class Form1 : Form
    {
        Account account;
        BDConnection connection;
        bool isLogged;
        List<Product> products;
        public Form1(bool isLogged = false)
        {
            InitializeComponent();
            this.isLogged = isLogged;
            this.âîéòèToolStripMenuItem1.Visible = !isLogged;
            this.ğåãèñòğàöèÿToolStripMenuItem.Visible = !isLogged;
            this.ìîéÏğîôèëüToolStripMenuItem.Visible = isLogged;
            this.ìîèÎáúÿâëåíèÿToolStripMenuItem.Visible = isLogged;
            connection = new BDConnection();
            this.products = connection.SelectAllProducts();
            for (int i = 0; i < connection.FindTableCount("Products"); i++)
            {
                listView1.Items.Add(products[i].ToString());
                listView1.Items[i].Tag = products[i].Id;
            }
        }
        public Form1(Account account, bool isLogged = false)
        {
            InitializeComponent();
            this.account = account;
            this.isLogged = isLogged;
            this.âîéòèToolStripMenuItem1.Visible = !isLogged;
            this.ğåãèñòğàöèÿToolStripMenuItem.Visible = !isLogged;
            this.ìîéÏğîôèëüToolStripMenuItem.Visible = isLogged;
            this.ìîèÎáúÿâëåíèÿToolStripMenuItem.Visible = isLogged;
            connection = new BDConnection();
            this.products = connection.SelectAllProducts();
            for (int i = 0; i < connection.FindTableCount("Products"); i++)
            {
                listView1.Items.Add(products[i].ToString());
                listView1.Items[i].Tag = products[i].Id;
            }

            this.àêêàóíòToolStripMenuItem.Text = this.account.LastName + " " + account.FirstName;
        }
        private void âîéòèToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(connection);
            loginForm.ShowDialog();
        }

        private void ğåãèñòğàöèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(connection);
            registrationForm.ShowDialog();
        }

        private void äîáàâèòüÎáúÿâëåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm(connection, this.account);
            productAddForm.ShowDialog();
        }

        private void ìîéÏğîôèëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm myAccoutnForm = new AccountForm(this.account, connection, true);
            myAccoutnForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm clothes = new CategoryForm(connection, 1);
            clothes.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm transport = new CategoryForm(connection, 2);
            transport.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm work = new CategoryForm(connection, 3);
            work.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm forHome = new CategoryForm(connection, 4);
            forHome.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm realty = new CategoryForm(connection, 5);
            realty.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm electronics = new CategoryForm(connection, 6);
            electronics.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm hobby = new CategoryForm(connection, 7);
            hobby.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm animals = new CategoryForm(connection, 8);
            animals.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm services = new CategoryForm(connection, 9);
            services.ShowDialog();
        }

        private void ìîèÎáúÿâëåíèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalProducts personalProducts = new PersonalProducts(account, connection);
            personalProducts.ShowDialog();
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductViewForm productViewForm = new ProductViewForm(FindProduct(), connection);
            productViewForm.ShowDialog();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}