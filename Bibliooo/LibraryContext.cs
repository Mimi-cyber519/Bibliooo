using Microsoft.EntityFrameworkCore;
using Bibliooo.Models;
namespace Bibliooo
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Loan> Loans { get; set; }
        public DbSet<Member> Members { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {
            
        }
    }
}
