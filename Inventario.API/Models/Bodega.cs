using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.API.Models
{
    [Table("Bodega")]
    public class Bodega
    {
        [Key]
        [Column("IdBodega")]
        public int IdBodega { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(200)]
        [Column("Ubicacion")]
        public string? Ubicacion { get; set; }
    }
}