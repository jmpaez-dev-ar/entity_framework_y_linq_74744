using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m02
{
	public class MetodosAnonimos
	{
		// MÉTODOS ANÓNIMOS
		// Los métodos anónimos son funciones sin nombre definidas directamente en el lugar donde se necesitan, sin declarar un método por separado.Son útiles para tareas simples y locales, como:
		//	1. Callbacks: Pasar funciones como argumentos para responder a eventos o condiciones.
		//	2. Expresiones Lambda: Facilitan código conciso y legible, especialmente con LINQ y eventos.
		//	3. Funciones Locales: Permiten encapsular lógica dentro del alcance de un método, organizando mejor el código.
		// Proporcionan una forma concisa y flexible de trabajar con delegados y eventos.

		public static void Demos()
		{
			Console.WriteLine("Métodos Anónimos");
			Console.WriteLine("-----------------------------------\n");

			DemoMetodosSinAnonimos();
			DemoMetodosConAnonimos();
		}

		#region DemoMetodosSinAnonimos
		delegate void Operacion(int n);
		private static void DemoMetodosSinAnonimos()
		{
			Console.WriteLine("Métodos Sin Anónimos y Delegados");
			Console.WriteLine("-----------------------------------\n");

			// Lista de números
			var numeros = new List<int> { 1, 2, 3, 4, 5 };
			Console.WriteLine("Números:");
			numeros.ForEach(Console.WriteLine);

			Operacion cuadrado = Cuadrado;

			// Recorrer la lista y aplicar la operación
			Console.WriteLine("\nCuadrados:");
			foreach (int numero in numeros)
			{
				cuadrado(numero);
			}
		}
		public static void Cuadrado(int x) { Console.WriteLine(x * x); }
		#endregion


		private static void DemoMetodosConAnonimos()
		{
			Console.WriteLine("Métodos Con Anónimos y Delegados");
			Console.WriteLine("-----------------------------------\n");

			// Lista de números
			var numeros = new List<int> { 1, 2, 3, 4, 5 };
			Console.WriteLine("Números:");
			numeros.ForEach(Console.WriteLine);

			Operacion cuadrado = delegate (int x)
												{
													Console.WriteLine(x * x);
												};

			// Recorrer la lista y aplicar la operación
			Console.WriteLine("\nCuadrados:");
			foreach (int numero in numeros)
			{
				cuadrado(numero);
			}
		}

	}
}
