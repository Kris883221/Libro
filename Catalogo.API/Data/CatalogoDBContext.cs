using Catalogo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.API.Data
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        {
        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }
}