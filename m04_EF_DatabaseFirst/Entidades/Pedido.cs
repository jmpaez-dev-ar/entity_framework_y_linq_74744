using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace m04_EF_DatabaseFirst.Entidades;

[Index("Numero", Name = "IX_Pedidos_Numero", IsUnique = true)]
public partial class Pedido
{
    [Key]
    public int Id { get; set; }

    public DateOnly FechaPedido { get; set; }

    public int Numero { get; set; }

    public int ClienteId { get; set; }

    [ForeignKey("ClienteId")]
    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();

	public decimal Total { get; set; }
}
