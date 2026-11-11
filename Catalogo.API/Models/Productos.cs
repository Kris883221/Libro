using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.API.Models
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(150)]
        [Column("Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("Precio", TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        [Column("IdMarca")]
        public int IdMarca { get; set; }

        [Column("IdCategoria")]
        public int IdCategoria { get; set; }
    }
}