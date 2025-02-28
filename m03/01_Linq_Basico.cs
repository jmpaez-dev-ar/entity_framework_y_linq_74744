namespace m03
{
	public class _01_Linq_Basico
	{
		public static void Demos()
		{
			Ejemplo1_ConsultaColeccion();
			Ejemplo2_GenerarRangoNumeros();
			Ejemplo3_UnionConsultas();
			Ejemplo4_ConsultaDistinct();
			Ejemplo5_ConsultaCadena();
			Ejemplo6_ConsultaElementos();
			Ejemplo7_ConsultaElementosTakeSkip();
		}
		private static void Ejemplo1_ConsultaColeccion()
		{
			// Ejemplo: Consultar una colección

			List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

			Console.WriteLine("Sintaxis Consulta");

			// Consulta utilizando sintaxis de consulta (similar a SQL)
			var consultaSql = from num in numeros
							  where num > 3
							  select num;

			foreach (int numero in consultaSql) Console.WriteLine(numero);

			Console.WriteLine("\n---------------------------------\n");

			Console.WriteLine("Sintaxis Método");

			// Consulta utilizando sintaxis de método
			var consultaMth = numeros.Where(num => num % 2 == 0);

			foreach (int numero in consultaMth) Console.WriteLine(numero);
		}

		private static void Ejemplo2_GenerarRangoNumeros()
		{
			// Ejemplo: Generar un rango de números del 1 al 30
			var rangoNumeros = Enumerable.Range(1, 30);

			Console.WriteLine("Números del 1 al 30:");
			foreach (var numero in rangoNumeros) Console.WriteLine(numero);
		}

		private static void Ejemplo3_UnionConsultas()
		{
			// Ejemplo: Unión de Consultas

			// Generar números pares del 1 al 10
			var otrosNumerosPares = Enumerable.Range(1, 10).Where(n => n % 2 == 0);

			// Generar números impares del 20 al 30
			var otrosNumerosImpares = Enumerable.Range(20, 30).Where(n => n % 2 != 0);

			// Combinar ambas secuencias
			var numerosCombinados = otrosNumerosPares.Concat(otrosNumerosImpares);

			foreach (var numero in numerosCombinados) Console.WriteLine(numero.ToString());
		}

		private static void Ejemplo4_ConsultaDistinct()
		{
			// Ejemplo: Consulta Distinct

			// Lista de colores con duplicados
			var colores = new List<string> { "rojo", "verde", "azul", "rojo", "amarillo", "verde" };

			// Obtener colores únicos
			var coloresUnicos = colores.Distinct();

			foreach (var color in coloresUnicos) Console.WriteLine(color);
		}

		private static void Ejemplo5_ConsultaCadena()
		{
			// Ejemplo: Consulta de Cadena

			// Lista de nombres
			var nombres = new List<string> { "Juan", "María", "Carlos", "Ana", "Abel", "Pedro" };

			// Filtrar nombres que contienen la letra 'a' (ignorando mayúsculas/minúsculas)
			var nombresConA = nombres.Where(nombre => nombre.Contains("a", StringComparison.OrdinalIgnoreCase));

			foreach (var nombre in nombresConA) Console.WriteLine(nombre);
		}

		private static void Ejemplo6_ConsultaElementos()
		{
			// Ejemplo: Consulta de Elementos con ElementAt

			// Generar un rango de números del 1 al 10
			var numeros = Enumerable.Range(1, 10);
			foreach (int numero in numeros) Console.WriteLine(numero);

			// Obtener el tercer número en la lista (índice 2)
			var tercerNumero = numeros.ElementAt(2);
			Console.WriteLine($"El tercer número en la lista es: {tercerNumero}");
		}

		private static void Ejemplo7_ConsultaElementosTakeSkip()
		{
			// Ejemplo: Consulta de Elementos con Take y Skip

			// Generar un rango de números del 1 al 10
			var numeros = Enumerable.Range(1, 10);
			foreach (int numero in numeros) Console.WriteLine(numero);

			// Tomar los primeros 3 números
			var primerosTresNumeros = numeros.Take(3);
			Console.WriteLine("\n---------------------------------\n");
			Console.WriteLine("Take");
			foreach (int numero in primerosTresNumeros) Console.WriteLine(numero);

			// Saltar los primeros 3 números y tomar el resto
			Console.WriteLine("\n---------------------------------\n");
			Console.WriteLine("Skip");
			var numerosSaltandoTres = numeros.Skip(3);
			foreach (int numero in numerosSaltandoTres) Console.WriteLine(numero);
		}
	}
}
