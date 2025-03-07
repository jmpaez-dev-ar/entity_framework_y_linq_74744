using m03.Demos.Clases;

namespace m03
{
	public class _13_Linq_Operadores_Particion
	{
		// Los operadores de partición en LINQ dividen una secuencia en subconjuntos según una cantidad o condición, permitiendo tomar o excluir elementos, útiles para paginación o filtrado dinámico.

		/*
		 Operadores de partición en LINQ:

			Take: Devuelve los primeros n elementos.
			TakeWhile: Devuelve elementos mientras se cumple una condición.
			Skip: Omite los primeros n elementos.
			SkipWhile: Omite elementos mientras se cumple una condición.
			ElementAt: Devuelve el elemento en una posición específica.
			First: Devuelve el primer elemento que cumple una condición.
			Last: Devuelve el último elemento que cumple una condición.
			Single: Devuelve el único elemento que cumple una condición.
		 */
		public static void Demos()
		{
			Console.WriteLine("Operadores de Partición");
			// Crear una lista de números
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			
			// Take
			//      Toma los primeros 3 elementos de la lista
			var take = numeros.Take(3);
			Console.WriteLine("Take:");
			foreach (var numero in take)
				Console.WriteLine(numero);

			// TakeWhile
			//      Toma los elementos de la lista mientras
			//      el número sea menor a 5
			var takeWhile = numeros.TakeWhile(n => n < 5);
		}
	}
}
