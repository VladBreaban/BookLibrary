using BookLibrary.ApiModels;
using BookLibrary.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("GetAllBooks")]
        public async Task<ActionResult<List<BookApiModel>>> GetAllBooks()
        {
            return await _booksService.GetAll();
        }

        [HttpPost("CreateBook")]
        public async Task<ActionResult<BookApiModel>> CreateBook([FromBody] BookApiModel book)
        {

            try
            {
                var result = await _booksService.AddBook(book);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
