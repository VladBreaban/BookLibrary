using BookLibrary.ApiModels;
using BookLibrary.Models;
using BookLibrary.RepositoriesInterfaces;
using BookLibrary.ServicesInterfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookLibrary.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _booksRepository;
        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        public async Task<Guid> AddBook(BookApiModel book)
        {
            try
            {
                if (book != null)
                {
                    Book bookEntity = new Book();
                    bookEntity.Id = Guid.NewGuid();
                    bookEntity.Author = book.Author;
                    bookEntity.Date = book.Date;
                    bookEntity.Description = book.Description;

                    await _booksRepository.Create(bookEntity).ConfigureAwait(false);
                    return bookEntity.Id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex?.InnerException?.Message);
            }

            return Guid.Empty;
        }

        public async Task<List<BookApiModel>> GetAll()
        {
            List<BookApiModel> result = new List<BookApiModel>();
             var books = await _booksRepository.GetAll();
            if (books.Count != 0)
            {
                foreach (var bookEntity in books)
                {
                    var book = new BookApiModel
                    {
                        Id = bookEntity.Id,
                        Author = bookEntity.Author,
                        Date = bookEntity.Date,
                        Description = bookEntity.Description,
                    };
                    result.Add(book);
                }
            }
            return result;
        }
    }
}
