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
    public partial class CustomerPage : Form
    {
        int id;
        public CustomerPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            var orders = SupermarketDBContext.context.Orders.Where(o => o.CustomerId == id).Select(o => new
            {
                Id = o.Id,
                CustomerId = o.CustomerId,
                History = o.History,
                Status = o.Status
            }).ToList();
            dataGridView1.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products p = new Products(id);
            p.Show();
        }
    }
}
