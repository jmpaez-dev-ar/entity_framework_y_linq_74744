using m04_EF_DatabaseFirst.Entidades;

namespace m05_EF_CRUD
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			// Demo de CRUD con las entidades de la base de datos
			// DemoCRUD_Categorias();
			 await DemoCRUD_Pedidos();
		}

		static private async void DemoCRUD_Categorias()
		{
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


		static private async Task DemoCRUD_Pedidos()
		{
			var clienteService = new ClienteService();
			var productoService = new ProductoService();
			var pedidoService = new PedidoService();

			var clienteParaPedido = await clienteService.GetClienteByCodigoAsync("CLI010");

			var producto1ParaPedido = await productoService.GetProductoByIdAsync(1);
			var producto2ParaPedido = await productoService.GetProductoByIdAsync(2);
			var producto3ParaPedido = await productoService.GetProductoByIdAsync(3);


			// CREATE
			var pedido = new Pedido
			{
				ClienteId = clienteParaPedido.Id,
				Numero = 101,
				FechaPedido = DateOnly.FromDateTime(DateTime.Now),
				DetallesPedido = new List<DetallePedido>
									{
										new DetallePedido {
											ProductoId = producto1ParaPedido.Id,
											Cantidad = 3,
											PrecioUnitario = producto1ParaPedido.PrecioUnitario,
											DescuentoPorcentaje =0 },

										new DetallePedido {
											ProductoId = producto2ParaPedido.Id,
											Cantidad = 1,
											PrecioUnitario = producto2ParaPedido.PrecioUnitario,
											DescuentoPorcentaje =0 },

										new DetallePedido {
											ProductoId = producto3ParaPedido.Id,
											Cantidad = 2,
											PrecioUnitario = 200,
											DescuentoPorcentaje =10}
									}
			};
			pedido.Total = pedido.DetallesPedido.Sum(d => d.Cantidad * d.PrecioUnitario * (1 - (d.DescuentoPorcentaje / 100.0m)));

			await pedidoService.CreatePedidoAsync(pedido);

			// READ
			pedido = await pedidoService.GetPedidoByIdAsync(pedido.Id);
			MostrarDatosPedido(pedido);
		}
		private static void MostrarDatosPedido(Pedido pedido)
		{
			Console.WriteLine($"Pedido: {pedido.Id}, {pedido.Numero}, {pedido.FechaPedido}, {pedido.Total}");
			Console.WriteLine($"	Cliente: {pedido.Cliente.Id}, {pedido.Cliente.Nombre}");
			foreach (var detalle in pedido.DetallesPedido)
			{
				Console.WriteLine($"Detalle: {detalle.Id}, Producto: {detalle.Producto.Nombre}, Cantidad: {detalle.Cantidad}, Precio Unitario: {detalle.PrecioUnitario}, Descuento: {detalle.DescuentoPorcentaje}%");
			}
		}

		static private async void DemoCRUD_Clientes()
		{
			//----------------------------------------------------------------------------------------------
			// Cliente
			//----------------------------------------------------------------------------------------------
			var clienteService = new ClienteService();

			// READ
			var clientes = await clienteService.GetAllClientesAsync();
			foreach (var clienteItem in clientes)
			{
				Console.WriteLine($"{clienteItem.Id}, {clienteItem.Nombre}");
			}

			// CREATE
			var cliente1 = new Cliente
			{
				Codigo = "C01",
				Nombre = "Juan",
				Apellido = "Pérez",
				Ciudad = "Buenos Aires",
				Direccion = "Calle Falsa 123",
				Telefono = "01112345678",
				Email = "juan.perez@gmail.com"
			};
			await clienteService.CreateClienteAsync(cliente1);
			Console.WriteLine("Cliente agregado");
			MostrarDatosCliente(cliente1);

			// UPDATE
			cliente1.Nombre = "Cliente 21";
			await clienteService.UpdateClienteAsync(cliente1);
			Console.WriteLine("Cliente actualizado");
			MostrarDatosCliente(cliente1);

			// DELETE
			await clienteService.DeleteClienteAsync(cliente1.Id);
			Console.WriteLine("Cliente eliminado");
			MostrarDatosCliente(cliente1);
		}
		private static void MostrarDatosCliente(Cliente cliente)
		{
			Console.WriteLine($"Cliente: {cliente.Id}, {cliente.Nombre}, {cliente.Direccion}, {cliente.Telefono}, {cliente.Email}");
			Console.WriteLine("\n----------------------------------------\n");
		}

		static private async void DemoCRUD_Productos()
		{
			//----------------------------------------------------------------------------------------------
			// Producto
			//----------------------------------------------------------------------------------------------
			var productoService = new ProductoService();

			// READ
			var productos = await productoService.GetAllProductosAsync();
			foreach (var productoItem in productos)
			{
				MostrarDatosProducto(productoItem);
			}

			// CREATE
			var producto1 = new Producto { Codigo = "P21", Nombre = "Producto 21", PrecioUnitario = 100, CategoriaId = 1 };
			await productoService.CreateProductoAsync(producto1);
			Console.WriteLine("Producto agregado");
			MostrarDatosProducto(producto1);


			// UPDATE
			producto1.PrecioUnitario = 200;
			await productoService.UpdateProductoAsync(producto1);
			Console.WriteLine("Producto actualizado");
			MostrarDatosProducto(producto1);

			// DELETE
			await productoService.DeleteProductoAsync(producto1.Id);
			Console.WriteLine("Producto eliminado");
			MostrarDatosProducto(producto1);
		}
		private static void MostrarDatosProducto(Producto producto)
		{
			Console.WriteLine($"Producto: {producto.Id}, {producto.Codigo}, {producto.Nombre}, {producto.PrecioUnitario}");
			Console.WriteLine("\n----------------------------------------\n");
		}
	}
}