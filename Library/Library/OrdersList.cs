using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class OrdersList : Form
    {
        LibraryContext context;

        OrderRepository repo;

        public OrdersList()
        {
            context = new LibraryContext();
            repo = new OrderRepository(context);
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void заказы_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            List<Order> ol = (List<Order>) repo.GetObjects();
            dataGridView1.DataSource = ol;
        }
    }
}
