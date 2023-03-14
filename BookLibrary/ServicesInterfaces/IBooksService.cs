using BookLibrary.ApiModels;

namespace BookLibrary.ServicesInterfaces
{
    public interface IBooksService
    {
        Task<List<BookApiModel>> GetAll();     
        Task<Guid> AddBook(BookApiModel book);
    }
}
