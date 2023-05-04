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
    public partial class CategoryForm : Form
    {
        BDConnection connection;
        List<Product> products;
        public CategoryForm(BDConnection connection, int categoryId)
        {
            InitializeComponent();
            this.categoryLabel.Text = connection.GetAtribute("Category", categoryId, "name");
            this.connection = connection;
            this.products = connection.SelectSimilarProducts("category_id", categoryId.ToString());
            for (int i = 0; i < products.Count; i++)
            {
                listView1.Items.Add(products[i].ToString());
                listView1.Items[i].Tag = products[i].Id;
            }
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
    }
}
