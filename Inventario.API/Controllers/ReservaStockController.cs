using Inventario.API.Data;
using Inventario.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaStockController : ControllerBase
    {
        private readonly InventarioDBContext _context;

        public ReservaStockController(InventarioDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservaStock>>> GetReservas()
        {
            return await _context.ReservaStock.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ReservaStock>> CrearReserva(ReservaStock reserva)
        {
            _context.ReservaStock.Add(reserva);
            await _context.SaveChangesAsync();
            return Ok(reserva);
        }
    }
}