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
    public partial class AddOrder : Form
    {
        OrderRepository orders;
        BookRepository books;
        ReaderRepository readers;

        public AddOrder(LibraryContext c)
        {
            InitializeComponent();
            orders = new OrderRepository(c);
            books = new BookRepository(c);
            readers = new ReaderRepository(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<Reader> r = (List<Reader>)readers.GetObjects();
            foreach(Reader reader in r)
            {
                comboBox1.Items.Add(reader.FullName);
            }
            List<Book> b = (List<Book>)books.GetObjects();
            comboBox4.Items.Clear();
            foreach(Book book in b)
            {
                comboBox4.Items.Add(book.Name);
            }
            comboBox1[]

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
