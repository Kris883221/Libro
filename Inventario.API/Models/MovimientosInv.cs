using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.API.Models
{
    [Table("MovimientosInv")]
    public class MovimientosInv
    {
        [Key]
        [Column("IdMovimientoInv")]
        public int IdMovimientoInv { get; set; }

        [Column("IdBodega")]
        public int IdBodega { get; set; }

        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(20)]
        [Column("TipoMovimiento")]
        public string TipoMovimiento { get; set; } = string.Empty;

        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Column("FechaMovimiento")]
        public DateTime FechaMovimiento { get; set; }
    }
}