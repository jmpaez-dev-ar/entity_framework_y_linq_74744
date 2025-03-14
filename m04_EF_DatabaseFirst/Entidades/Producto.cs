using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace m04_EF_DatabaseFirst.Entidades;

[Index("Codigo", Name = "UQ_Productos_Codigo", IsUnique = true)]
public partial class Producto
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrecioUnitario { get; set; }

    public int CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();
}
