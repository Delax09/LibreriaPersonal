using Microsoft.AspNetCore.Mvc;
using AprendizajeSoftware.Data;
using AprendizajeSoftware.Models;
using Microsoft.EntityFrameworkCore;

namespace AprendizajeSoftware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Constructor para la inyección de dependencias
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CreateUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.IdUsuario }, usuario);
        }
    }
}
