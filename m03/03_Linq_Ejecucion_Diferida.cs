namespace m03
{
	public class _03_Linq_Ejecucion_Diferida
	{
		// La ejecución diferida en LINQ retrasa la evaluación de una consulta hasta que se necesita el resultado. Esto ocurre porque muchas operaciones devuelven secuencias que implementan IEnumerable<T>, y la consulta solo se ejecuta al iterar sobre esa secuencia.

		public static void Demos()
		{
			Console.WriteLine("--------------------------");
			Console.WriteLine("Ejecución Diferida");
			Console.WriteLine("--------------------------");

			var secuenciaNumeros = Enumerable.Range(1, 10).ToList();

			// Filtra la secuencia para obtener solo números pares
			// Esta consulta no se ejecuta inmediatamente
			var numerosFiltrados = secuenciaNumeros.Where(n => n % 2 == 0);

			Console.WriteLine("Antes de modificar la lista:");
			// Itera sobre la secuencia filtrada y ejecuta la consulta
			foreach (var numero in numerosFiltrados)
				Console.WriteLine(numero);

			Console.WriteLine("--------------------------");

			// Modifica la lista original, por ejemplo, agregando un número par
			secuenciaNumeros.Add(12);

			Console.WriteLine("Después de modificar la lista:");
			// Itera sobre la secuencia filtrada nuevamente y ejecuta la consulta
			foreach (var numero in numerosFiltrados)
				Console.WriteLine(numero);
		}
	}
}
