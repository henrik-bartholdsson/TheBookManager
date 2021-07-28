using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public class BookManagerDbContext : DbContext
    {
        public BookManagerDbContext(DbContextOptions<BookManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
