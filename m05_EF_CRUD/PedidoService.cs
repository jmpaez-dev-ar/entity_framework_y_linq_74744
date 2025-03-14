using m04_EF_DatabaseFirst.Data;
using m04_EF_DatabaseFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace m05_EF_CRUD
{
	internal class PedidoService
	{
		private readonly ApplicationDbContext _context;
		public PedidoService()
		{
			_context = new ApplicationDbContext();
		}

		// CREATE (Maestro-Detalle)
		public async Task<Pedido> CreatePedidoAsync(Pedido pedido)
		{
			if (pedido == null) throw new ArgumentNullException(nameof(pedido));

			foreach (var detalle in pedido.DetallesPedido)
			{
				detalle.Pedido = pedido; // Asegurar la relación
			}

			await _context.Pedidos.AddAsync(pedido);
			await _context.SaveChangesAsync();

			return pedido;
		}

		// READ
		public async Task<List<Pedido>> GetAllPedidosAsync()
		{
			return await _context.Pedidos.Include(p => p.DetallesPedido).ToListAsync();
		}

		public async Task<Pedido?> GetPedidoByIdAsync(int id)
		{
			return await _context.Pedidos
				.Include(p => p.Cliente)
				.Include(p => p.DetallesPedido)
					.ThenInclude(dp => dp.Producto)
				.FirstOrDefaultAsync(p => p.Id == id);
		}

		// UPDATE (Maestro-Detalle)
		public async Task<Pedido> UpdatePedidoAsync(Pedido pedido)
		{
			if (pedido == null) throw new ArgumentNullException(nameof(pedido));

			var existingPedido = await _context.Pedidos.Include(p => p.DetallesPedido).FirstOrDefaultAsync(p => p.Id == pedido.Id);
			if (existingPedido == null) throw new KeyNotFoundException("Pedido no encontrado.");

			// Actualizar detalles existentes
			foreach (var detalle in pedido.DetallesPedido)
			{
				var existingDetalle = existingPedido.DetallesPedido.FirstOrDefault(d => d.Id == detalle.Id);
				if (existingDetalle != null)
				{
					_context.Entry(existingDetalle).CurrentValues.SetValues(detalle);
				}
				else
				{
					detalle.PedidoId = existingPedido.Id;
					_context.DetallesPedido.Add(detalle);
				}
			}

			// Remover detalles eliminados
			var detallesToRemove = existingPedido.DetallesPedido.Where(d => !pedido.DetallesPedido.Any(nd => nd.Id == d.Id)).ToList();
			_context.DetallesPedido.RemoveRange(detallesToRemove);

			// Actualizar pedido
			_context.Entry(existingPedido).CurrentValues.SetValues(pedido);
			await _context.SaveChangesAsync();

			return existingPedido;
		}

		// DELETE (Maestro-Detalle)
		public async Task DeletePedidoAsync(int id)
		{
			var pedido = await _context.Pedidos.Include(p => p.DetallesPedido).FirstOrDefaultAsync(p => p.Id == id);
			if (pedido == null) throw new KeyNotFoundException("Pedido no encontrado.");

			_context.DetallesPedido.RemoveRange(pedido.DetallesPedido);
			_context.Pedidos.Remove(pedido);
			await _context.SaveChangesAsync();
		}
	}
}
