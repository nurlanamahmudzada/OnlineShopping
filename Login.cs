using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineShopping.DB;

namespace OnlineShopping
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var admin = SupermarketDBContext.context.Admins
              .Where(c => c.Name == tb_username.Text && c.Password == tb_pass.Text)
              .FirstOrDefault();
            var user = SupermarketDBContext.context.Customers
                .Where(c => c.Name == tb_username.Text && c.Password == tb_pass.Text)
                .FirstOrDefault();

            if (cb_role.Text == "admin" && admin != null)
            {
                this.Hide();
                AdminPage bs = new AdminPage();
                bs.Show();
            }
            else if (cb_role.Text == "user" && user != null)
            {
                this.Hide();
                CustomerPage cp = new CustomerPage(user.Id);
                cp.Show();
            }
            else
            {
                MessageBox.Show("Username or password is wrong", "Warning");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tb_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null,null);
            }
        }
        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }
    }
}
