using OnlineShopping.DB;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{
    public partial class Products : Form
    {
        #region Fields
        List<Product> products = new();
        int userId;
        int existProductNumber;
        #endregion
        #region Constructor
        public Products(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        #endregion
        #region Methods
        public void ListProducts()
        {
            int result;
            if (!int.TryParse(tb_productItems.Text, out result) || cb_products.Text == "")
            {
                MessageBox.Show("Please enter the right type to Product items or Product Id", "Warning");
                return;
            }
            else
            {
                int id = Convert.ToInt32(cb_products.Text);
                int product_count = Convert.ToInt32(tb_productItems.Text);
                Product product = SupermarketDBContext.context.Products.Where(p => p.Id == id).SingleOrDefault();
                if (product.Number == product_count)
                {
                    SupermarketDBContext.context.Products.Remove(product);
                }
                if (product.Number < product_count)         
                {
                    MessageBox.Show("Please write correctly " + product.Id + " Id product items." +
                                "Items cannot exceed product number", "Information");
                    return;
                }

               var existProduct = products.Where(p => p.Id == product.Id).FirstOrDefault();

                if (existProduct is not null)
                {
                    existProductNumber = product_count + existProduct.Number;                     
                    existProduct.Number = existProductNumber;
                }
                else
                {
                    products.Add(new Product
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Number = Convert.ToInt32(tb_productItems.Text),
                        Price = product.Price
                    });
                }
                existProductNumber = product_count;
                int newNumber = product.Number - existProductNumber;
                product.Number = newNumber;
                addBasket();
            }
        }
        public void get_data()
        {
            dataGridView1.DataSource = SupermarketDBContext.context.Products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Number = p.Number
            }).ToList();
        }
        public void refresh_combobox()
        {
            cb_products.Text = "";
            cb_products.Items.Clear();
            comboBox_data();
        }
        public void addBasket()
        {
            dataGridView_basket.DataSource = products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Count = p.Number
            }).ToList();           
        }
        public void comboBox_data()
        {
            var products = SupermarketDBContext.context.Products.ToList();
            foreach (var product in products)
            {
                cb_products.Items.Add(product.Id);
            }
        }
        #endregion
        #region Event
        private void btn_orders_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("The basket is null");
                return;
            }
            Order order = new()
            {
                CustomerId = userId,
                History = DateTime.Now,
                Status = "Order placed"
            };
            SupermarketDBContext.context.Orders.Add(order);
            SupermarketDBContext.context.SaveChanges();
            get_data();
            refresh_combobox();
            MessageBox.Show("Your order was completed successfully", "Thanks");
            products.Clear();
        }
        private void btn_buy_Click(object sender, EventArgs e)
        {
            ListProducts();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cb_products.Text == "")
            {
                MessageBox.Show("Please choose the Product Id", "Information");
                return;
            }
            int id = int.Parse(cb_products.Text);
            Product product = SupermarketDBContext.context.Products.AsNoTracking().Where(p => p.Id == id).SingleOrDefault();
            Image image = Image.FromFile(product.Picture);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure to delete your chosen products?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                products.Clear();
                dataGridView_basket.DataSource = null; 
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new();
                login.Show();
            }
        }
        private void Products_Load_1(object sender, EventArgs e)
        {
            get_data();
            comboBox_data();
        }
        #endregion
    }
}

