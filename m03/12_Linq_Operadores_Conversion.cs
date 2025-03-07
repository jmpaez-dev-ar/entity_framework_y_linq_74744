using m03.Demos.Clases;

namespace m03
{
	public class _12_Linq_Operadores_Conversion
	{
		// Los operadores de conversión en LINQ transforman una secuencia a otro tipo de datos o formato, como array, lista o diccionario, facilitando su uso en distintos contextos o aplicaciones.

		/*
		Operadores de conversión en LINQ:

			Cast: Convierte la secuencia a otro tipo de datos.
			OfType: Filtra elementos por tipo de datos.
			ToArray, ToList, ToDictionary: Convierte la secuencia a un arreglo, lista o diccionario.
		 */
		public static void Demos()
		{
			// Crear un arreglo de números
			int[] numbers = { 1, 2, 9, 3, 4, 5 };

			//  ToList:
			//      Convierte un arreglo de números en una lista de números
			List<int> list1 = numbers.ToList();
			
			var list2 = numbers.ToList();

			IEnumerable<int> list3 = numbers.ToList();


			// ToArray:
			//      Convierte las estudiantes en un array de objetos.
			var estudiantes = Estudiante.ObtenerTodos();
			var estudiantesArray = estudiantes.ToArray();
		}
	}
}
