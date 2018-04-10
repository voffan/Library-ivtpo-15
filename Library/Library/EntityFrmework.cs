public class ProductContext : DbContext
{
    public DbSet<Book> Book { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<BookStatus> BookStatuss { get; set; }
    public DbSet<city> city { get; set; }
    public DbSet<country> country { get; set; }
    public DbSet<Lending> Lending { get; set; }
    public DbSet<library> library { get; set; }
    public DbSet<ms> ms { get; set; }

    public DbSet<Order> Order { get; set; }
    public DbSet<Position> Position { get; set; }
    public DbSet<Program> Program { get; set; }
    public DbSet<Publisher> Publisher { get; set; }
    public DbSet<Reader> Reader { get; set; }
    public DbSet<ReadengRoom> ReadengRoom { get; set; }
    public DbSet<User> User { get; set; }

}