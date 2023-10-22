using Catalog_DB.Entities;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Catalog_WinForm
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-IBRAHIM\\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListBoxData();
        }

        private void LoadListBoxData()
        {
            listBox.Items.Clear();
            connection.Open();
            List<Product> products = connection.Query<Product>("SELECT * FROM Products").ToList();
            connection.Close();
            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Id}-{product.Name}-{product.Country}-{product.Cost}");
            }

        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            productForm form2 = new productForm();
            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                Product newProduct = new Product
                {
                    Name = form2.ProductNamee,
                    Country = form2.Origin,
                    Cost = form2.ProductCost
                };

                connection.Execute("INSERT INTO Products (Name, Country, Cost) VALUES (@Name, @Country, @Cost)", newProduct);
                LoadListBoxData();
            }
        }
        private void removeProductButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                string selectedProduct = listBox.SelectedItem.ToString()!;
                int productId = Convert.ToInt32(selectedProduct!.Split('-')[0].Trim());

                connection.Execute("DELETE FROM Products WHERE Id = @productId", new { productId });
                LoadListBoxData();
            }
            else
            {
                MessageBox.Show("Please select a product to remove.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count>0)
            {
                connection.Execute("TRUNCATE TABLE Products");
                LoadListBoxData();
            }
            else
            {
                MessageBox.Show("No Items in Table to Clear!","No Product In Table",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex>=0)
            {
                string selectedProduct= listBox.SelectedItem.ToString()!;
                int productId = Convert.ToInt32(selectedProduct.Split('-')[0].Trim());

                using (productForm form=new productForm())
                {
                    var result= form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        connection.Execute("UPDATE Products SET Name=@Name,Country=@Origin,Cost=@Cost WHERE Id=@Id", new
                        {
                            Name = form.ProductNamee,
                            Origin=form.Origin,
                            Cost=form.ProductCost,
                            Id=productId
                        });
                        LoadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Please select a product to edit.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}