using Microsoft.AspNetCore.Mvc;
using BackendBooks.Data;
using BackendBooks.models;
using Microsoft.EntityFrameworkCore;

namespace BackendBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Constructor para la inyección de dependencias
        public BookController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBook()
        {
            return await _context.Books.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { id = book.Idbook }, book);
        }
    }
}
