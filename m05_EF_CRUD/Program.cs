using m04_EF_DatabaseFirst.Entidades;

namespace m05_EF_CRUD
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			// Demo de CRUD con las entidades de la base de datos

			// Categoria
			var categoriaService = new CategoriaService();

			// READ
			var categorias = await categoriaService.GetAllCategoriasAsync();
			
			foreach (var categoriaItem in categorias)
			{
				MostrarDatosCategoria(categoriaItem);
			}
		}

		private static void MostrarDatosCategoria(Categoria categoria)
		{
			Console.WriteLine($"Categoría: {categoria.Id}, {categoria.Codigo}, {categoria.Nombre}");
			Console.WriteLine("\n----------------------------------------\n");
		}
	}
}
