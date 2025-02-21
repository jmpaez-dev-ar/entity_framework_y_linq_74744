namespace m02
{
	public class ExpresionesLambda
	{
		// EXPRESIONES LAMBDA
		// Las expresiones lambda son una forma concisa y flexible de definir funciones anónimas. Son útiles para escribir código breve y claro, especialmente en operaciones con colecciones, eventos y consultas LINQ.
		/*
		 Principales características:
				Definición compacta: (parámetros) => expresión o bloque.
				Manejo de colecciones: Filtrado, proyección, ordenación y agrupación.
				Eventos: Simplifican la suscripción y manejo de eventos.
				Consultas LINQ: Facilitan consultas y transformaciones de datos.
				Callbacks: Permiten implementar funciones que responden a eventos o condiciones específicas.

		 SINTAXIS:
			La sintaxis básica de una expresión lambda es la siguiente:
				(parametros) => expresion
			 Donde:
					parametros son los parámetros que toma la función lambda.
					expresion es la expresión que se ejecutará cuando se invoque la función lambda.
		*/
		public static void Demos()
		{
			Console.WriteLine("Expresiones Lambda");
			Console.WriteLine("-----------------------------------\n");

			// DemoExpresionesLambda1();
			// DemoExpresionesLambda2();
			DemoExpresionesLambda3();
		}

		#region DemoExpresionesLambda1
		private static void DemoExpresionesLambda1()
		{
			// Lista de números
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine("Números:");
			// numeros.ForEach((n) => { Console.WriteLine(n); });
			numeros.ForEach(n => Console.WriteLine(n));

			// Filtrar números mayores que un umbral
			int umbral = 9;

			List<int> mayoresQueUmbral = numeros.Where(n => n > umbral).ToList();

			Console.WriteLine($"\nNúmeros mayores que {umbral}:");
			mayoresQueUmbral.ForEach(n => Console.WriteLine(n));
		}
		#endregion

		#region DemoExpresionesLambda2
		// Ordenar una Lista de Enteros con Expresión Lambda
		private static void DemoExpresionesLambda2()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			numeros.ForEach(n => Console.WriteLine(n));

			Console.WriteLine("------");

			numeros.Sort((a, b) => a.CompareTo(b));

			numeros.ForEach(n => Console.WriteLine(n));
		}
		#endregion

		#region DemoExpresionesLambda3
		// Iterar y Agregar Elementos con Expresiones Lambda
		private static void DemoExpresionesLambda3()
		{
			List<int> numeros = new List<int> { 7, 2, 8, 1, 5 };
			numeros.ForEach(n => Console.WriteLine(n));
			Console.WriteLine("------");

			int suma = numeros.Aggregate( (a, b) => a + b );
			Console.WriteLine(suma);
		}
		#endregion
	}
}
