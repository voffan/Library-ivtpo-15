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
                AddOrder addorder = new AddOrder(context);
                addorder.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CityRepository c = new CityRepository(context);
            CountryRepository country = new CountryRepository(context);
            AuthorRepository a =new AuthorRepository(context);
            GenreRepository g = new GenreRepository(context);
            BookRepository books = new BookRepository(context);

            Country coun = new Country("Российская Федерация");
            country.InsertObject(coun);
            country.Save();

            City city = new City("Москва", coun);
            c.InsertObject(city);
            c.Save();

            Publisher p = new Publisher("Nauka");
            p.City = city;
            context.Publishers.Add(p);
            context.SaveChanges();

            Genre genre = new Genre("Detective");
            g.InsertObject(genre);
            g.Save();

            Author au = new Author("Ivan4", "Ivanov", "Petrovich", DateTime.Parse("01.02.1980"), DateTime.Now, coun);
            a.InsertObject(au);
            a.Save();
            
            for (int i = 0; i < 3; i++)
            {
                Book b = new Book("Book" + i.ToString(), 4, au, p);
                b.Genre = genre;
                books.InsertObject(b);
                books.Save();
            }
        }
    }
}
