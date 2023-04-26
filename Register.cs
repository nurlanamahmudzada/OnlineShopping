using OnlineShopping.DB;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = tb_name.Text;
            string password = tb_pass.Text;
            string cpassword = tb_confirmpass.Text;
            if (SupermarketDBContext.context.Customers.Any(n => n.Name == username))
            {
                link.Visible = true;
            }
            else if (password != cpassword)
            {
                MessageBox.Show("Passwords are not the same");
            }
            else
            {
                Customer customer = new()
                {
                    Name = username,
                    Password = password,
                    CPassword = cpassword
                };
                SupermarketDBContext.context.Customers.Add(customer);
                SupermarketDBContext.context.SaveChanges();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
