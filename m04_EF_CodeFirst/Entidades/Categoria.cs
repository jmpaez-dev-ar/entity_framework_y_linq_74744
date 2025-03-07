namespace m04_EF_CodeFirst.Entidades
{
	public class Categoria
	{
		public int Id { get; set; }
		public string Codigo { get; set; } = null!; 
		public string Nombre { get; set; } = null!;

		public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
	}
}
