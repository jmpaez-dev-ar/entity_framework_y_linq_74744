using m03.Demos.Clases;

namespace m03
{
	public class _15_Linq_Operadores_Proyeccion
	{
		// Los operadores de proyección en LINQ transforman y extraen datos de una secuencia, permitiendo seleccionar, mapear o proyectar datos específicos en una nueva forma.

		/*
		 Operadores de proyección en LINQ:

			Select: Selecciona propiedades específicas de una secuencia.
			SelectMany: Proyecta datos de secuencias anidadas.
			GroupBy: Agrupa una secuencia por una propiedad común y proyecta los resultados.
		 */
		public static void Demos()
		{
			// Obtener la lista de todos los productos
			var productos = Producto.ObtenerTodos();

			// Select #1
			//      Retorna una lista con los nombres de todos los productos.
			var nombresProductos = from p in productos
								   select p.Nombre;

			// Select #2
			//      Selecciona solo los precios de los productos.
			var preciosProductos = from p in productos
								   select p.Precio;

			// Select #3
			//      Selecciona el nombre del producto, su precio y calcula el precio con IVA (21%).
			var productosYprecios = from p in productos
									select new
									{
										Nombre = p.Nombre,
										Precio = p.Precio,
										PrecioConIva = p.Precio * 1.21
									};
		}
	}
}
