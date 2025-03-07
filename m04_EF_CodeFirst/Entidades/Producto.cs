namespace m04_EF_CodeFirst.Entidades
{
	public class Producto
	{
		public int Id { get; set; }

		public string Codigo { get; set; } = null!;

		public string Nombre { get; set; } = null!;

		public decimal PrecioUnitario { get; set; }

		public int CategoriaId { get; set; }
		public virtual Categoria Categoria { get; set; } = null!;
	}
}
