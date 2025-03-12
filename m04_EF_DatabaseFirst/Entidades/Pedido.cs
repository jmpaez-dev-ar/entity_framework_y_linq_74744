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
    [InverseProperty("Pedidos")]
    public virtual Cliente Cliente { get; set; } = null!;

    [InverseProperty("Pedido")]
    public virtual ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();
}
