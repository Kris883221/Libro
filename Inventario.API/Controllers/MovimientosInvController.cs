using Inventario.API.Data;
using Inventario.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosInvController : ControllerBase
    {
        private readonly InventarioDBContext _context;

        public MovimientosInvController(InventarioDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovimientosInv>>> GetMovimientos()
        {
            return await _context.MovimientosInv.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<MovimientosInv>> CrearMovimiento(MovimientosInv movimiento)
        {
            _context.MovimientosInv.Add(movimiento);
            await _context.SaveChangesAsync();
            return Ok(movimiento);
        }
    }
}