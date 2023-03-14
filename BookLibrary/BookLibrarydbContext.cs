using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookLibrary
{
    public class BookLibrarydbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookLibrarydbContext() : base() { }
        public BookLibrarydbContext(DbContextOptions<BookLibrarydbContext> options) : base(options) { }

    }
}


