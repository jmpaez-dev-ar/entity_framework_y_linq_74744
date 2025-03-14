using m04_EF_DatabaseFirst.Data;
using m04_EF_DatabaseFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace m05_EF_CRUD
{
	internal class ProductoService
	{
		private readonly ApplicationDbContext _context;
		public ProductoService()
		{
			_context = new ApplicationDbContext();
		}
		// CREATE
		public async Task<Producto> CreateProductoAsync(Producto producto)
		{
			if (producto == null) throw new ArgumentNullException(nameof(producto));

			await _context.Productos.AddAsync(producto);
			await _context.SaveChangesAsync();
			return producto;
		}

		// READ
		public async Task<List<Producto>> GetAllProductosAsync()
		{
			return await _context.Productos.ToListAsync();
		}

		public async Task<Producto?> GetProductoByIdAsync(int id)
		{
			return await _context.Productos.FindAsync(id);
		}

		public async Task<Producto?> GetProductoByCodigoAsync(string codigo)
		{
			if (string.IsNullOrEmpty(codigo)) throw new ArgumentNullException(nameof(codigo));

			return await _context.Productos.FirstOrDefaultAsync(c => c.Codigo == codigo);
		}

		// UPDATE
		public async Task<Producto> UpdateProductoAsync(Producto producto)
		{
			if (producto == null) throw new ArgumentNullException(nameof(producto));

			var existingProducto = await _context.Productos.FindAsync(producto.Id);
			if (existingProducto == null) throw new KeyNotFoundException("Producto no encontrado.");

			_context.Entry(existingProducto).CurrentValues.SetValues(producto);
			await _context.SaveChangesAsync();

			return existingProducto;
		}

		// DELETE
		public async Task DeleteProductoAsync(int id)
		{
			var producto = await _context.Productos.FindAsync(id);
			if (producto == null) throw new KeyNotFoundException("Producto no encontrado.");

			_context.Productos.Remove(producto);
			await _context.SaveChangesAsync();
		}
	}
}
