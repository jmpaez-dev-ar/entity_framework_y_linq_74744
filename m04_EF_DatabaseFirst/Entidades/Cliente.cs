using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace m04_EF_DatabaseFirst.Entidades;

[Index("Codigo", Name = "UQ_Clientes_Codigo", IsUnique = true)]
public partial class Cliente
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string? CuitCuil { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RazonSocial { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
