using Catalogo.API.Data;
using Catalogo.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly CatalogoDBContext _context;

        public MarcaController(CatalogoDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marca>>> GetMarcas()
        {
            return await _context.Marca.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Marca>> GetMarca(int id)
        {
            var marca = await _context.Marca.FindAsync(id);
            if (marca == null) return NotFound();
            return marca;
        }

        [HttpPost]
        public async Task<ActionResult<Marca>> CrearMarca(Marca marca)
        {
            _context.Marca.Add(marca);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMarca), new { id = marca.IdMarca }, marca);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarMarca(int id, Marca marca)
        {
            if (id != marca.IdMarca) return BadRequest();
            _context.Entry(marca).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarMarca(int id)
        {
            var marca = await _context.Marca.FindAsync(id);
            if (marca == null) return NotFound();
            _context.Marca.Remove(marca);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}