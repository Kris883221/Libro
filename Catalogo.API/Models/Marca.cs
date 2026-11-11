using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.API.Models
{
    [Table("Marca")]
    public class Marca
    {
        [Key]
        [Column("IdMarca")]
        public int IdMarca { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Nombre")]
        public string Nombre { get; set; } = string.Empty;
    }
}