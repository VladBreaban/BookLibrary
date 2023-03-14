using BookLibrary.Models;
using BookLibrary.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BookLibrarydbContext _bookLibrarydbContext;
        public BooksRepository(BookLibrarydbContext bookLibrarydbContext)
        {
            _bookLibrarydbContext = bookLibrarydbContext;
        }
        public async Task Create(Book book)
        {
           _bookLibrarydbContext.Books.Add(book);

            await _bookLibrarydbContext.SaveChangesAsync();
        }

        public Task<List<Book>> GetAll()
        {
            return _bookLibrarydbContext.Books.ToListAsync();
        }
    }
}
