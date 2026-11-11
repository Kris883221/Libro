using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.API.Models
{
    [Table("Existencias")]
    public class Existencias
    {
        [Key]
        [Column("IdExistencia")]
        public int IdExistencia { get; set; }

        [Column("IdBodega")]
        public int IdBodega { get; set; }

        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Column("Cantidad")]
        public int Cantidad { get; set; }
    }
}