using m03.Demos.Clases;

namespace m03
{
	public class _06_Linq_Subconsultas_No_Correlacionadas
	{
		// Una subconsulta no correlacionada es independiente de la consulta principal, se ejecuta primero y sus resultados se utilizan en la consulta principal. No depende de los valores de la fila actual.
		public static void Demos()
		{
			EjemploSubconsultaNoCorrelacionadaSql();
			Console.WriteLine("\n--------------------------------------------------\n");
			EjemploSubconsultaNoCorrelacionadaMth();
		}

		private static void EjemploSubconsultaNoCorrelacionadaSql()
		{
			Console.WriteLine("SubConsultas No Correlacionadas - utilizando query syntax");

			// Obtener la lista de todos los estudiantes
			List<Estudiante> estudiantes = Estudiante.ObtenerTodos();

			// Obtener la lista de todas las calificaciones
			List<Calificacion> calificaciones = Calificacion.ObtenerTodos();

			// Calcula el promedio general de calificaciones
			var promedioGeneral = (from c in calificaciones
								   select c.Puntuacion).Average();

			Console.WriteLine($"promedioGeneral {promedioGeneral}");

			// Encuentra estudiantes con calificación superior al promedio general
			var estudiantesSobresalientes = (from e in estudiantes
											 where (from c in calificaciones
													where c.EstudianteId == e.Id && c.Puntuacion > promedioGeneral
													select c).Any()
											 select e).ToList();
			// Mostrar resultados
			foreach (var estudiante in estudiantesSobresalientes)
				Console.WriteLine($"Estudiante: {estudiante.Nombre} {estudiante.Apellido}");
		}

		private static void EjemploSubconsultaNoCorrelacionadaMth()
		{
			Console.WriteLine("SubConsultas No Correlacionadas - utilizando method syntax");

			// Obtener la lista de todos los estudiantes
			List<Estudiante> estudiantes = Estudiante.ObtenerTodos();

			// Obtener la lista de todas las calificaciones
			List<Calificacion> calificaciones = Calificacion.ObtenerTodos();

			// Calcula el promedio general de calificaciones
			var promedioGeneral = calificaciones.Average(c => c.Puntuacion);
			Console.WriteLine($"promedioGeneral {promedioGeneral}");

			// Encuentra estudiantes con calificación superior al promedio general
			var estudiantesSobresalientes = estudiantes
				.Where(e => calificaciones
						.Any(c => c.EstudianteId == e.Id && c.Puntuacion > promedioGeneral)
						)
				.ToList();

			// Mostrar resultados
			foreach (var estudiante in estudiantesSobresalientes)
				Console.WriteLine($"Estudiante: {estudiante.Nombre} {estudiante.Apellido}");
		}
	}
}
