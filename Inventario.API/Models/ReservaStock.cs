using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.API.Models
{
    [Table("ReservaStock")]
    public class ReservaStock
    {
        [Key]
        [Column("IdReservaStock")]
        public int IdReservaStock { get; set; }

        [Column("IdBodega")]
        public int IdBodega { get; set; }

        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Column("CantidadReservada")]
        public int CantidadReservada { get; set; }

        [Column("FechaReserva")]
        public DateTime FechaReserva { get; set; }

        [StringLength(20)]
        [Column("Estado")]
        public string? Estado { get; set; }
    }
}