using m03.Demos.Clases;

namespace m03
{
	public class _11_Linq_Operadores_Agregacion
	{
		// Los operadores de agregación en LINQ realizan cálculos sobre una secuencia y devuelven un valor único, como total, promedio, cantidad, máximo o mínimo.

		/*
		 Operadores de agregación en LINQ:

			Count: Cuenta los elementos.
			Sum: Calcula la suma.
			Average: Calcula el promedio.
			Max: Devuelve el valor máximo.
			Min: Devuelve el valor mínimo.
		 */
		public static void Demos()
		{
			Console.WriteLine("Operadores de Agregación");

			// Crear una lista de números
			var numeros = new List<int> { 200, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Count: cuenta el número de elementos en la lista 'numeros'
			var cantidad = numeros.Count();
			Console.WriteLine($"cantidad = {cantidad}");

			// Sum: calcula la suma de todos los elementos en la lista 'numeros'
			var suma = numeros.Sum();
			Console.WriteLine($"suma = {suma}");

			// Average: calcula el promedio de todos los elementos en la lista 'numeros'
			var promedio = numeros.Average();
			Console.WriteLine($"promedio = {promedio}");

			// Max: devuelve el valor máximo en la lista 'numeros'
			var maximo = numeros.Max();
			Console.WriteLine($"maximo = {maximo}");

			// Min: devuelve el valor mínimo en la lista 'numeros'
			var minimo = numeros.Min();
			Console.WriteLine($"minimo = {minimo}");

			// Crear una lista de productos
			var productos = Producto.ObtenerTodos();

			// Count: cuenta el número de elementos en la lista 'productos'
			var cantidadproductos = productos.Count();
			Console.WriteLine($"cantidadproductos = {cantidadproductos}");

			// Sum: calcula la suma total del inventario (Cantidad * Precio) de todos los productos en la lista 'productos'
			var totalInventario = productos.Sum(p => p.Cantidad * p.Precio);
			Console.WriteLine($"totalInventario = {totalInventario}");
		}
	}
}
