using m04_EF_DatabaseFirst.Data;
using m04_EF_DatabaseFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace m05_EF_CRUD
{
	public class ClienteService
	{
		private readonly ApplicationDbContext _context;
		public ClienteService()
		{
			_context = new ApplicationDbContext();
		}

		// CREATE
		public async Task<Cliente> CreateClienteAsync(Cliente cliente)
		{
			if (cliente == null) throw new ArgumentNullException(nameof(cliente));

			await _context.Clientes.AddAsync(cliente);
			await _context.SaveChangesAsync();
			return cliente;
		}

		// READ
		public async Task<List<Cliente>> GetAllClientesAsync()
		{
			return await _context.Clientes.ToListAsync();
		}

		public async Task<Cliente?> GetClienteByIdAsync(int id)
		{
			return await _context.Clientes.FindAsync(id);
		}

		public async Task<Cliente?> GetClienteByCodigoAsync(string codigo)
		{
			if (string.IsNullOrEmpty(codigo)) throw new ArgumentNullException(nameof(codigo));

			return await _context.Clientes.FirstOrDefaultAsync(c => c.Codigo == codigo);
		}

		// UPDATE
		public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
		{
			if (cliente == null) throw new ArgumentNullException(nameof(cliente));

			var existingCliente = await _context.Clientes.FindAsync(cliente.Id);
			if (existingCliente == null) throw new KeyNotFoundException("Cliente no encontrado.");

			_context.Entry(existingCliente).CurrentValues.SetValues(cliente);
			await _context.SaveChangesAsync();

			return existingCliente;
		}

		// DELETE
		public async Task DeleteClienteAsync(int id)
		{
			var cliente = await _context.Clientes.FindAsync(id);
			if (cliente == null) throw new KeyNotFoundException("Cliente no encontrado.");

			_context.Clientes.Remove(cliente);
			await _context.SaveChangesAsync();
		}
	}
}
