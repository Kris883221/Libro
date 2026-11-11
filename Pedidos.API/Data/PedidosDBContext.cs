using Microsoft.EntityFrameworkCore;
using Pedidos.API.Models;

namespace Pedidos.API.Data
{
    public class PedidosDBContext : DbContext
    {
        public PedidosDBContext(DbContextOptions<PedidosDBContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}