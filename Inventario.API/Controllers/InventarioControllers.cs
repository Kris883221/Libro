using Inventario.API.Data;
using Inventario.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventariosController : ControllerBase
    {
        private readonly InventarioDBContext _context;

        public InventariosController(InventarioDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventarios>>> GetInventarios()
        { // programación asíncrona
            var inventarios = await _context.Inventarios
                .AsNoTracking()
                .ToListAsync();
            return Ok(inventarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Inventarios>> GetInventarios(int id)
        {
            var inventario = await _context.Inventarios
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.IdInventario == id);

            if (inventario == null) return NotFound(); // es una abreviación

            return Ok(inventario);
        }

        [HttpPost]
        public async Task<ActionResult<Inventarios>> CrearInventario(Inventarios inventario)
        {
            _context.Inventarios.Add(inventario);
            await _context.SaveChangesAsync();

            return Ok(inventario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarInventario(
            int id,
            Inventarios inventario
            )
        {
            if (id != inventario.IdInventario) return BadRequest();

            _context.Entry(inventario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent(); // número de estado de NoContent 204
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarInventario(int id)
        {
            var inventario = await _context.Inventarios.FindAsync(id);

            if (inventario == null) return NotFound();

            _context.Inventarios.Remove(inventario);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}