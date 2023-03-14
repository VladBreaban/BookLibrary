using BookLibrary.Models;

namespace BookLibrary.RepositoriesInterfaces
{
    public interface IBooksRepository
    {
        Task<List<Book>> GetAll();
        Task Create(Book book);

    }
}
