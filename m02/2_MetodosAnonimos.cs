using System.Timers;
using Timer = System.Timers.Timer;

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

		// CALLBACKS
		// Un callback es una función que se pasa como argumento a otra función y se invoca (llama) dentro de esa función para completar algún tipo de rutina o acción. Los callbacks son útiles para manejar eventos o condiciones que ocurren de manera asíncrona o en respuesta a ciertas acciones.

		public static void Demos()
		{
			Console.WriteLine("Métodos Anónimos");
			Console.WriteLine("-----------------------------------\n");

			DemoMetodosSinAnonimos();
			DemoMetodosConAnonimos();
			DemoMetodosAnonimos1();
			DemoMetodosAnonimos2();
			DemoMetodosAnonimosYEventos();
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

		#region DemoMetodosConAnonimos
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
		#endregion

		#region DemoMetodosAnonimos1
		// Filtrar Números Pares
		public static void DemoMetodosAnonimos1()
		{
			Console.WriteLine("Métodos Anónimos con Delegados 1");
			Console.WriteLine("-----------------------------------\n");

			// Lista de números
			List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
			Console.WriteLine("Números:");
			numeros.ForEach(Console.WriteLine);


			// Filtrar los números pares
			Console.WriteLine("\nPares:");

			var pares = numeros.FindAll(
								delegate (int x)
								{
									return x % 2 == 0;
								}
				);
			pares.ForEach(Console.WriteLine);
		}
		#endregion

		#region DemoMetodosAnonimos2
		// Ordenamiento Personalizado

		public static void DemoMetodosAnonimos2()
		{
			Console.WriteLine("Métodos Anónimos con Delegados 2");
			Console.WriteLine("-----------------------------------\n");

			// Lista de productos
			List<string> productos = new List<string> { "Notebook", "Monitor", "Mouse", "SSD", "Headset" };
			Console.WriteLine("Productos:");

			productos.ForEach(Imprimir);

			// Ordenar por longitud
			productos.Sort(delegate (string a, string b)
					{
						return a.Length.CompareTo(b.Length);
					}
				);

			Console.WriteLine("\nProductos Ordenados por Longitud:");
			productos.ForEach(Imprimir);
		}

		// Método que imprime un valor genérico
		public static void Imprimir<T>(T valor)
		{
			Console.WriteLine(valor);
		}
		#endregion

		#region DemoMetodosAnonimosYEventos
		// Eventos con Métodos Anónimos
		public static void DemoMetodosAnonimosYEventos()
		{
			Timer myTimer = new Timer(1000);
			myTimer.Elapsed += delegate (System.Object source, ElapsedEventArgs e)
											{
												Console.WriteLine("Un segundo ha pasado.");
											};
			myTimer.Start();

			Console.WriteLine("Presiona Enter para salir.");
			Console.ReadLine();

			myTimer.Stop();
		}
		#endregion
	}
}
