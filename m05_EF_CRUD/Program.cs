using m04_EF_DatabaseFirst.Entidades;

namespace m05_EF_CRUD
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			// Demo de CRUD con las entidades de la base de datos

			#region CRUD Categorias
			// Categoria
			var categoriaService = new CategoriaService();

			// READ
			var categorias = await categoriaService.GetAllCategoriasAsync();
			foreach (var categoriaItem in categorias)
			{
				MostrarDatosCategoria(categoriaItem);
			}

			var categoria = await categoriaService.GetCategoriaByIdAsync(1);
			MostrarDatosCategoria(categoria);

			// CREATE
			var categoriaNueva = new Categoria { Codigo = "C20", Nombre = "Categoria 20" };
			await categoriaService.CreateCategoriaAsync(categoriaNueva);
			MostrarDatosCategoria(categoriaNueva);

			// UPDATE
			categoria = await categoriaService.GetCategoriaByIdAsync(11);
			categoria.Codigo = "C21";
			categoria.Nombre = "Categoria 21";
			await categoriaService.UpdateCategoriaAsync(categoria);
			MostrarDatosCategoria(categoria);

			// DELETE
			await categoriaService.DeleteCategoriaAsync(11);

		}
		private static void MostrarDatosCategoria(Categoria categoria)
		{
			Console.WriteLine($"Categoría: {categoria.Id}, {categoria.Codigo}, {categoria.Nombre}");
			Console.WriteLine("\n----------------------------------------\n");
		}
	}
	#endregion
}
