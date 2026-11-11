using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedidos.API.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [Column("IdPedido")]
        public int IdPedido { get; set; }

        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Column("FechaPedido")]
        public DateTime FechaPedido { get; set; }

        [Column("Total", TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
    }
}