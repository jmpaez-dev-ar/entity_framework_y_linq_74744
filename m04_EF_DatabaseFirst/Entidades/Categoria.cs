using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace m04_EF_DatabaseFirst.Entidades;

[Index("Codigo", Name = "UQ_Categorias_Codigo", IsUnique = true)]
public partial class Categoria
{
	[Key]
	public int Id { get; set; }

	[StringLength(10)]
	[Unicode(false)]
	public string Codigo { get; set; } = null!;

	[StringLength(50)]
	[Unicode(false)]
	public string Nombre { get; set; } = null!;

	public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
