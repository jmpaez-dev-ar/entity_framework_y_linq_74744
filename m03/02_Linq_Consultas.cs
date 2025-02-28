using m03.Demos.Clases;

namespace m03
{
	public class _02_Linq_Consultas
	{
		// En LINQ, las consultas permiten interactuar con colecciones de datos en C# y otros lenguajes .NET. Se pueden escribir de dos formas: Query Syntax y Method Syntax, que, aunque se escriben de manera diferente, producen los mismos resultados.

		/*
		 (Sintaxis de consulta)
			La Query Syntax en LINQ tiene una estructura similar a SQL, usando palabras clave como from, where y select, siendo intuitiva para quienes conocen SQL.
		*/

		/*
		 (Sintaxis de método)
				La Method Syntax en LINQ usa métodos de extensión como Where, OrderBy y Select, junto con expresiones lambda, siendo más programática.
		 */

		public static void Demos()
		{
			// Consultas para obtener nombres de estudiantes mayores de 20 años, ordenados por apellido
			var estudiantes = Estudiante.ObtenerTodos();

			foreach (var estudiante in estudiantes)
				Console.WriteLine($"Estudiante: {estudiante.Id} {estudiante.Nombre}, {estudiante.Apellido} | edad  {estudiante.Edad}");

			Console.WriteLine("\n---------------------------------\n");
			Console.WriteLine("Sintaxis Consulta\n");
			var consultaEstudiantesSql = from estudiante in estudiantes
										 where estudiante.Edad > 20
										 orderby estudiante.Apellido
										 select estudiante.Nombre;

			foreach (var nombreEstudiante in consultaEstudiantesSql)
				Console.WriteLine(nombreEstudiante);

			Console.WriteLine("\n---------------------------------\n");
			Console.WriteLine("Sintaxis Método\n");

			var consultaEstudiantesMth = estudiantes
													.Where(e => e.Edad > 20)
													.OrderBy(e => e.Apellido)
													.Select(e => e.Nombre);
			
			foreach (var nombreEstudiante in consultaEstudiantesMth)
				Console.WriteLine(nombreEstudiante);
		}
	}
}
