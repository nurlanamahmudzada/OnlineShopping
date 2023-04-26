using OnlineShopping.DB;
using Microsoft.EntityFrameworkCore;
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
    public partial class Orders : Form
    {
        int indexRow;
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            show_order_by_customerId();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_delete_order_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please choose the Customer Id");
                return;
            }
            DialogResult result = MessageBox.Show("Do you sure want to delete Customer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(comboBox1.Text);
                var data = SupermarketDBContext.context.Customers.Where(c => c.Id == id).FirstOrDefault();
                SupermarketDBContext.context.Remove(data);
                SupermarketDBContext.context.SaveChanges();
            }
            comboBox1.Items.Clear();
            show_order_by_customerId();
            dataGridView1.DataSource = null;
        }
        public void getData()
        {
            int id = Convert.ToInt32(comboBox1.Text);
            dataGridView1.DataSource = SupermarketDBContext.context.Orders.Select(o => new
            {
                Id = o.Id,
                CustomerId = o.CustomerId,
                History = o.History,
                Status = o.Status
            }).Where(o => o.CustomerId == id).ToList();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please choose the Customer Id", "Information");
                return;
            }
            else
            {
                getData();
            }
        }
        public List<int> list_customerId()
        {
            List<Order> datas = SupermarketDBContext.context.Orders.ToList();
            List<int> cdata = new();

            foreach (var data in datas)
            {
                cdata.Add(data.CustomerId);
            }
            List<int> distinctcdata = cdata.Distinct().ToList();
            return distinctcdata;
        }
        public void show_order_by_customerId()
        {
            foreach (int cId in list_customerId())
            {
                comboBox1.Items.Add(cId);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new();
            adminPage.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void tb_confirm_Click(object sender, EventArgs e)
        {
            if (cb_status.Text != "")
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                int id = Convert.ToInt32(row.Cells[0].Value);
                var data = SupermarketDBContext.context.Orders.Where(o => id == o.Id).SingleOrDefault();
                data.Status = cb_status.Text;
                SupermarketDBContext.context.SaveChanges();
                getData();
            }
            else
                MessageBox.Show("Please, enter the order status", "Warning");
        }
    }
}
