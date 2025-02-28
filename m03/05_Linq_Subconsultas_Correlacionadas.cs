using m03.Demos.Clases;

namespace m03
{
	public class _05_Linq_Subconsultas_Correlacionadas
	{
		// Una subconsulta correlacionada es una consulta anidada que depende de los valores de la fila actual de la consulta principal. Se ejecuta una vez por cada fila de la consulta principal y sus resultados varían según los valores de esa fila específica.
		public static void Demos()
		{
			// Obtener la lista de todos los estudiantes
			List<Estudiante> estudiantes = Estudiante.ObtenerTodos();

			// Obtener la lista de todas las calificaciones
			List<Calificacion> calificaciones = Calificacion.ObtenerTodos();

			// Definir una consulta LINQ que selecciona cada estudiante y calcula su puntuación máxima utilizando query syntax

			var estudiantesConPuntuacionMaximaSql =
						from estudiante in estudiantes
						select new
						{
							EstudianteId = estudiante.Id,
							Nombre = estudiante.Nombre,
							PuntuacionMaxima = (from calificacion in calificaciones
												where calificacion.EstudianteId == estudiante.Id
												select calificacion.Puntuacion).Max()
						};

			// Iterar sobre los resultados de la consulta y mostrar la información de cada estudiante
			foreach (var item in estudiantesConPuntuacionMaximaSql)
				Console.WriteLine($"Estudiante ID: {item.EstudianteId}," +
					$" nombre {item.Nombre} " +
					$" Puntuación Máxima: {item.PuntuacionMaxima}");

			Console.WriteLine("--------------------------------------------------");


			var estudiantesConPuntuacionMaximaMth =
					estudiantes.Select(estudiante => new
					{
						EstudianteId = estudiante.Id,
						Nombre = estudiante.Nombre,
						PuntuacionMaxima = calificaciones
												.Where(calificacion => calificacion.EstudianteId == estudiante.Id)
												.Max(calificacion => calificacion.Puntuacion)
					});

			// Iterar sobre los resultados de la consulta y mostrar la información de cada estudiante
			foreach (var item in estudiantesConPuntuacionMaximaMth)
				Console.WriteLine($"Estudiante ID: {item.EstudianteId}," +
					$" nombre {item.Nombre} " +
					$" Puntuación Máxima: {item.PuntuacionMaxima}");
		}
	}
}
