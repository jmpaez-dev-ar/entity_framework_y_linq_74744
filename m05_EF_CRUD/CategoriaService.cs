using m04_EF_DatabaseFirst.Data;
using m04_EF_DatabaseFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace m05_EF_CRUD
{
	public class CategoriaService
	{
		private readonly ApplicationDbContext _context;

		public CategoriaService()
		{
			_context = new ApplicationDbContext();
		}

		// CREATE
		public async Task<Categoria> CreateCategoriaAsync(Categoria categoria) {

			if (categoria == null) throw new ArgumentNullException(nameof(categoria));

			await _context.Categorias.AddAsync(categoria);
			await _context.SaveChangesAsync();
			return categoria;
		}

		// READ
		public async Task<List<Categoria>> GetAllCategoriasAsync()
		{
			return await _context.Categorias.OrderBy(c => c.Nombre).ToListAsync();
		}

		public async Task<Categoria?> GetCategoriaByIdAsync(int id) {
			return await _context.Categorias.FindAsync(id);
		}

		public async Task<List<Categoria>> GetAllCategoriasBySPAsync()
		{
			return await _context.Categorias.FromSqlRaw("EXECUTE dbo.GetAllCategorias").ToListAsync();
		}


		// UPDATE
		public async Task<Categoria> UpdateCategoriaAsync(Categoria categoria)
		{
			if (categoria == null) throw new ArgumentNullException(nameof(categoria));

			var existingCategoria = await _context.Categorias.FindAsync(categoria.Id);
			if (existingCategoria == null) throw new KeyNotFoundException("Categoria no encontrada.");


			_context.Entry(existingCategoria).CurrentValues.SetValues(categoria);
			await _context.SaveChangesAsync();
			return existingCategoria;

		}
		// DELETE
		public async Task DeleteCategoriaAsync(int id)
		{
			var categoria = await _context.Categorias.FindAsync(id);
			if (categoria == null) throw new KeyNotFoundException("Categoria no encontrada.");

			_context.Categorias.Remove(categoria);
			await _context.SaveChangesAsync();
		}
	}
}
