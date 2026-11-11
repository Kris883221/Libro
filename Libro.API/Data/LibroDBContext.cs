using Libro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Libro.API.Data
{
    public class LibroDBContext : DbContext
    {
        public LibroDBContext(DbContextOptions<LibroDBContext> options): base(options)
        {

        }
        public DbSet<Libros> Libros { get; set; }


    }
}
