using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace m04_EF_DatabaseFirst.Entidades;

[Table("DetallesPedido")]
public partial class DetallePedido
{
    [Key]
    public int Id { get; set; }

    public int PedidoId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrecioUnitario { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal DescuentoPorcentaje { get; set; }

    [ForeignKey("PedidoId")]
    [InverseProperty("DetallesPedidos")]
    public virtual Pedido Pedido { get; set; } = null!;

    [ForeignKey("ProductoId")]
    [InverseProperty("DetallesPedidos")]
    public virtual Producto Producto { get; set; } = null!;
}
