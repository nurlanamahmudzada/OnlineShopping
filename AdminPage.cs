using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineShopping.DB;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace OnlineShopping
{
    public partial class AdminPage : Form
    {
        #region Model
        /*class IsChanged
        {
            public bool idChanged;
            public bool nameChanged;
            public bool priceChanged;
            public bool amountChanged;
            public bool pictureChanged;
        }*/
        enum Operation
        {
            ADD,
            UPDATE,
            DELETE,
            SHOW
        }
        #endregion

        #region Field
        // IsChanged changing;
        /*string path = Path.Combine(@"D:\C#Projects\LoginRegisterApp\Uploaded\", Path.GetFileName(openFileDialog1.FileName));
        File.Copy(openFileDialog1.FileName, path, true);*/

        bool warning;
        #endregion

        #region Property
        /*public string ProductId
        {
            get { return tb_pId.Text; }
            set  
            {
                foreach (char item in value)
                {
                    if (!char.IsNumber(item))
                    {
                        tb_pId.Text = _productId.ToString();
                    }
                }
                _productId = int.Parse(value);
                tb_pId.Text = value;
            }
        }*/
        //public int MyProperty { get; set; }
        #endregion

        #region Constructor
        public AdminPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Custom Method
        public void getData()
        {
            dataGridView.DataSource = SupermarketDBContext.context.Products.Select(a => new
            {
                a.Id,
                a.Name,
                a.Price,
                a.Number
            }).ToList();
        }
        Operation operation;
        public void Validation()
        {
            if (operation == Operation.ADD)
            {         
                if (tb_pname.Text == "" || tb_price.Text == "" || tb_pcount.Text == ""
                    || openFileDialog1.FileName == "openFileDialog1")
                {
                    MessageBox.Show("Please fill in all product information", "Information");
                     warning = true;
                    return;
                }
                if (!int.TryParse(tb_pcount.Text, out int pcount) || !double.TryParse(tb_price.Text, out double price))
                {
                    MessageBox.Show("The product count or price is not in the correct data type.", "Information");
                    warning = true;
                    return;
                } 
            }
            else if (operation == Operation.UPDATE)
            {                      
                if (tb_pId.Text == "" || tb_pname.Text == "" || tb_price.Text == "" || tb_pcount.Text == ""
                    || openFileDialog1.FileName == "openFileDialog1")
                {
                    MessageBox.Show("Please fill in all product information", "Information");
                    warning = true;
                    return;
                }
                if (!int.TryParse(tb_pcount.Text, out int pcount) || !double.TryParse(tb_price.Text, out double price))
                {
                    MessageBox.Show("The product count or price is not in the correct data type.", "Information");
                    warning = true;
                    return;
                }
            }
            else if (operation == Operation.SHOW || operation == Operation.DELETE)
            {
                if (tb_pId.Text == "")
                {
                    MessageBox.Show("Fill the Id button", "Error");
                    warning = true;
                    return;
                }
                if (!int.TryParse(tb_pId.Text, out int pcount))
                {
                    MessageBox.Show("The Id is not in the correct data type.", "Information");
                    warning = true;
                    return;
                }
            }
        }
        #endregion

        #region Event
        private void AdminPage_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            warning = false;
            operation = Operation.ADD;
            Validation();
            if (warning == true) return;
            string path = Path.Combine(@"D:\C#Projects\OnlineShopping\Uploaded\", Path.GetFileName(openFileDialog1.FileName));
            File.Copy(openFileDialog1.FileName, path, true);
            Product product = new()
            {
                Name = tb_pname.Text,
                Price = Convert.ToDouble(tb_price.Text),
                Number = Convert.ToInt32(tb_pcount.Text),
                Picture = path
            };
            SupermarketDBContext.context.Products.Add(product);
            SupermarketDBContext.context.SaveChanges();
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        private void btn_choose_image_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Downloads";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearphoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            openFileDialog1.FileName = "openFileDialog1";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            warning = false;
            operation = Operation.UPDATE;
            Validation();
            if (warning == true) return;
            int id = Convert.ToInt32(tb_pId.Text);
            if (!SupermarketDBContext.context.Products.Any(p => p.Id == id))
            {
                MessageBox.Show(id + " Id Product has not in the table", "Error");
                return;
            }
            var data = SupermarketDBContext.context.Products.Find(id);           
            data.Name = tb_pname.Text;
            data.Number = Convert.ToInt32(tb_pcount.Text);
            data.Price = Convert.ToDouble(tb_price.Text);
            if (data.Picture == openFileDialog1.FileName) { }
            else
            {
                string path = Path.Combine(@"D:\C#Projects\OnlineShopping\Uploaded\", Path.GetFileName(openFileDialog1.FileName));
                File.Copy(openFileDialog1.FileName, path, true);
                data.Picture = path; 
            }
            SupermarketDBContext.context.SaveChanges();
            getData();
            MessageBox.Show("Product updated succesfully", "Information");
        }

        private void btn_show_products_Click(object sender, EventArgs e)
        {
            warning = false;
            operation = Operation.SHOW;
            Validation();
            if (warning==true) return;
            int id = Convert.ToInt32(tb_pId.Text);
            if (!SupermarketDBContext.context.Products.Any(p => p.Id == id))
            {
                MessageBox.Show(id + " Id Product has not in the table", "Error");
                return;
            }
            else
            {
                var product = SupermarketDBContext.context.Products.Where(p => p.Id == id).FirstOrDefault();
                tb_pname.Text = product.Name;
                tb_pcount.Text = Convert.ToString(product.Number);
                tb_price.Text = Convert.ToString(product.Price);
                Image image = Image.FromFile(product.Picture);
                openFileDialog1.FileName = product.Picture;
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            warning = false;
            operation = Operation.DELETE;
            Validation();
            if (warning == true) return;
            int id = Convert.ToInt32(tb_pId.Text);
            if (!SupermarketDBContext.context.Products.Any(p => p.Id == id))
            {
                MessageBox.Show(id + " Id Product has not in the table", "Error");
                return;
            }
            else
            {
                var data = SupermarketDBContext.context.Products.Find(id);
                SupermarketDBContext.context.RemoveRange(data);
                SupermarketDBContext.context.SaveChanges();
            }
            getData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.Show();
        }
        #endregion
    }
}
