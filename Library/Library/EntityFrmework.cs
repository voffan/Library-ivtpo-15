using System.Data.Entity;

namespace Library
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookStatus> BookStatuses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<library> Libraries { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBooks> OrderBooks { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<ReadingRoom> ReadingRooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}