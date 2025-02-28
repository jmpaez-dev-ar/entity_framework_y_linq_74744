namespace m03
{
	public class _04_Linq_Ejecucion_Inmediata
	{
		// La ejecución inmediata en LINQ ocurre cuando una consulta se evalúa en el momento en que se define, en lugar de diferirse hasta acceder a los datos. Esto sucede al usar métodos como ToList(), ToArray(), Count() o First(), que ejecutan la consulta y devuelven los resultados de inmediato.

		public static void Demos()
		{
			Console.WriteLine("--------------------------");
			Console.WriteLine("Ejecución Inmediata");
			Console.WriteLine("--------------------------");

			var numeros = new List<int> { 100, 45, 78,  1, 2, 3, 4, 5 };

			// Filtra la secuencia para obtener solo números pares
			// Esta consulta se ejecuta inmediatamente
			var numerosFiltrados = numeros.Where(n => n % 2 == 0).ToList();

			Console.WriteLine("Antes de modificar la lista:");
			// Itera sobre los números filtrados y los imprime
			foreach (var numero in numerosFiltrados)
				Console.WriteLine(numero);

			Console.WriteLine("--------------------------");

			// Modifica la lista original, por ejemplo, agregando un número par
			numeros.Add(12);

			Console.WriteLine("Después de modificar la lista:");
			foreach (var numero in numerosFiltrados)
				Console.WriteLine(numero);
		}
	}
}
