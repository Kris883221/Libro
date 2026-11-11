using Inventario.API.Data;
using Inventario.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExistenciasController : ControllerBase
    {
        private readonly InventarioDBContext _context;

        public ExistenciasController(InventarioDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Existencias>>> GetExistencias()
        {
            return await _context.Existencias.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Existencias>> GetExistencia(int id)
        {
            var existencia = await _context.Existencias.FindAsync(id);
            if (existencia == null) return NotFound();
            return existencia;
        }

        [HttpPost]
        public async Task<ActionResult<Existencias>> CrearExistencia(Existencias existencia)
        {
            _context.Existencias.Add(existencia);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetExistencia), new { id = existencia.IdExistencia }, existencia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarExistencia(int id, Existencias existencia)
        {
            if (id != existencia.IdExistencia) return BadRequest();
            _context.Entry(existencia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarExistencia(int id)
        {
            var existencia = await _context.Existencias.FindAsync(id);
            if (existencia == null) return NotFound();
            _context.Existencias.Remove(existencia);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}