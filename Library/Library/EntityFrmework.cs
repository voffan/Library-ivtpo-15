using System.Data.Entity;

namespace Library
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<BookStatus> BookStatuss { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<Lending> Lending { get; set; }
        public DbSet<library> library { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Reader> Reader { get; set; }
        public DbSet<ReadingRoom> ReadengRoom { get; set; }
        public DbSet<User> User { get; set; }

    }
}