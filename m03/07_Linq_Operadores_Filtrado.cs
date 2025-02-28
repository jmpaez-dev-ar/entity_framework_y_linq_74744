using m03.Demos.Clases;

namespace m03
{
	public class _07_Linq_Operadores_Filtrado
	{
		// Los operadores de filtrado en LINQ seleccionan elementos de una secuencia que cumplen una condición específica, permitiendo extraer de manera eficiente solo los datos relevantes.

		/*
		 Operadores de filtrado en LINQ:

			Where: Filtra elementos según una condición.
			OfType: Filtra elementos por tipo específico.
			Take: Toma los primeros n elementos.
			Skip: Omite los primeros n elementos.
			Distinct: Elimina duplicados en la secuencia.
		 */
		public static void Demos()
		{
			Console.WriteLine("Operadores de Filtrado");

			// Obtener la lista de todos los estudiantes
			var estudiantes = Estudiante.ObtenerTodos();

			// Where: Filtrar estudiantes por una condición específica, como la edad menor a 22.
			var estudiantesJovenes = estudiantes.Where(e => e.Edad < 22);

			// Take: Tomar los primeros 5 elementos de la lista de estudiantes.
			var primerosCincoEstudiantes = estudiantes.Take(5);

			// Skip: Omitir los primeros 5 elementos y tomar el resto de la lista de estudiantes.
			var exceptoPrimerosCinco = estudiantes.Skip(5);

			// Distinct: Obtener una lista de estudiantes únicos, eliminando duplicados.
			var estudiantesUnicos = estudiantes.Distinct();

			// OfType: Filtrar los elementos de tipo string de una lista de objetos.
			List<object> objects = new List<object> { 1, "2", 3.0, "4.0", 1, 2, true };
			List<string> strings = objects.OfType<string>().ToList();
		}
	}
}
