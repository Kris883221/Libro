using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.API.Models
{
    [Table("Inventarios")]
    public class Inventarios
    {
        [Key]
        [Column("IdInventario")]
        public int IdInventario { get; set; }

        [Column("IdLibro")]
        public int IdLibro { get; set; }

        [Column("Stock")]
        public int Stock { get; set; }

        [Column("StockMinimo")]
        public int StockMinimo { get; set; }

        [StringLength(100)]
        [Column("Ubicacion", TypeName = "nvarchar(100)")]
        public string? Ubicacion { get; set; }
    }
}