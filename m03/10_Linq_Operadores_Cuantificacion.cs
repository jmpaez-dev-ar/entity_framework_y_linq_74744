using m03.Demos.Clases;

namespace m03
{
	public class _10_Linq_Operadores_Cuantificacion
	{
		// Los operadores de cuantificación en LINQ verifican condiciones en una secuencia y devuelven un valor booleano según si alguno, todos o un elemento cumple una condición.

		/*
		 Operadores de cuantificación en LINQ:

			Any: Verifica si al menos un elemento cumple una condición.
			All: Verifica si todos los elementos cumplen una condición.
			Contains: Verifica si un elemento específico está en la secuencia.
		 */
		public static void Demos()
		{
			Console.WriteLine("Operadores de Cuantificación");

			// Obtener la lista de todos los estudiantes
			var estudiantes = Estudiante.ObtenerTodos();

			// Comprobar si hay al menos un estudiante con una edad específica (20 años en este caso):
			bool tieneEstudiantesDe20 = estudiantes.Any(e => e.Edad == 20);

			// Verificar si todos los estudiantes tienen más de 18 años:
			bool todosMayoresDe18 = estudiantes.All(e => e.Edad > 18);

			// Comprobar si la lista de estudiantes contiene un estudiante específico (por ID):
			Estudiante estudianteBuscado = new Estudiante(/* ... */);
			bool contieneEstudiante = estudiantes.Contains(estudianteBuscado);

			// Comprobar si una lista específica de IDs de estudiantes está presente en la lista de estudiantes:
			List<int> idsBuscados = new List<int> { 1, 3, 5 };
			bool todosPresentes = idsBuscados.All(id => estudiantes.Select(e => e.Id).Contains(id));

			// Determinar si al menos un estudiante con nombres específicos está en la lista:
			List<string> nombresBuscados = new List<string> { "Carlos", "Ana" };
			bool algunoPresente = nombresBuscados.Any(nombre => estudiantes.Select(e => e.Nombre).Contains(nombre));
		}
	}
}
