using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedidos.API.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(150)]
        [Column("Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(150)]
        [Column("Correo")]
        public string? Correo { get; set; }

        [StringLength(20)]
        [Column("Telefono")]
        public string? Telefono { get; set; }
    }
}