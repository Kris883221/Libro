using Libro.API.Data;
using Libro.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Libro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly LibroDBContext _context;

        public LibrosController(LibroDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libros>>> GetLibros()
        { //progrmación asincrona
            var libros = await _context.Libros
                .AsNoTracking()
                .ToListAsync();
            return Ok(libros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Libros>> GetLibros(int id)
        {
            var libro = await _context.Libros
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.IdLibro == id);
            if (libro == null) return NotFound(); //es una abreviacón
            return Ok(libro);
        }

        [HttpPost]
        public async Task<ActionResult<Libros>> CrearLibro(Libros libro) { 
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();

            return Ok(libro);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarLibro(
            int id,
            Libros libro
            )
        {
            if(id != libro.IdLibro) return BadRequest();

            _context.Entry(libro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent(); //número de estado de NoContent 204
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarLibro(int id)
        {
            var libro = await _context.Libros.FindAsync(id);

            if(libro == null) return NotFound();

            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
