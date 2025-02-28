using m03.Demos.Clases;

namespace m03
{
	public class _08_Linq_Operadores_Ordenamiento
	{
		// Los operadores de ordenamiento en LINQ organizan los elementos de una secuencia en orden ascendente o descendente, permitiendo también ordenamientos complejos con múltiples claves.

		/*
		 Operadores de ordenamiento en LINQ:

			OrderBy: Ordena en orden ascendente.
			OrderByDescending: Ordena en orden descendente.
			ThenBy: Ordena por una segunda clave en orden ascendente.
			ThenByDescending: Ordena por una segunda clave en orden descendente.
		 */
		public static void Demos()
		{
			var estudiantes = Estudiante.ObtenerTodos();

			// OrderBy(Ordenar Ascendente): Ordena los estudiantes por edad en orden ascendente.
			var estudiantesOrdenadosPorEdad = estudiantes.OrderBy(e => e.Edad).ToList();

			// OrderByDescending: Ordena los estudiantes por nombre en orden descendente.
			var estudiantesOrdenadosPorNombreDesc = estudiantes.OrderByDescending(e => e.Nombre).ToList();

			// ThenBy: Ordena los estudiantes por apellido en orden ascendente y luego por nombre en orden ascendente.
			var estudiantesOrdenadosPorApellidoYNombre = estudiantes.OrderBy(e => e.Apellido).ThenBy(e => e.Nombre).ToList();

			// ThenByDescending: Ordena los estudiantes por edad en orden ascendente y luego por nombre en orden descendente.
			var estudiantesOrdenadosPorEdadYNombreDesc = estudiantes.OrderBy(e => e.Edad).ThenBy(e => e.Apellido).ThenByDescending(e => e.Nombre).ToList();
		}
	}
}
