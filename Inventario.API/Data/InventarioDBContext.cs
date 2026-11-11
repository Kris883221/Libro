using Inventario.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.API.Data
{
    public class InventarioDBContext : DbContext
    {
        public InventarioDBContext(DbContextOptions<InventarioDBContext> options) : base(options)
        {
        }

        public DbSet<Inventarios> Inventarios { get; set; }

        // Nuevas tablas de la arquitectura de microservicios
        public DbSet<Bodega> Bodega { get; set; }
        public DbSet<Existencias> Existencias { get; set; }
        public DbSet<MovimientosInv> MovimientosInv { get; set; }
        public DbSet<ReservaStock> ReservaStock { get; set; }
    }
}