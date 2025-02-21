
namespace m02
{
	public class AccionYFunc
	{
		// Las clases Action<> y Func<> son delegados genéricos que permiten representar métodos con diversos parámetros y valores de retorno, ofreciendo flexibilidad en su manejo.

		// Action<>:
		/*
			Action<> es un delegado genérico en C# que representa un método que no devuelve un valor (void) y puede aceptar hasta 16 parámetros de entrada. Se utiliza para encapsular lógica que realiza acciones sin retornar resultados.

		Sintaxis:
			Action<parametro1, parametro2, ..., parametroN> nombreDelegado = (parametro1, parametro2, ..., parametroN) => {
				// Cuerpo del método
			};
		*/

		// Func<>:
		/*
		Func<> es un delegado genérico en C# que encapsula métodos con valores de retorno. Acepta de 0 a 16 parámetros de entrada, siendo el último tipo el tipo de retorno.

		Sintaxis:
			Func<parametro1, ..., parametroN, tipoDeRetorno> nombreDelegado = (param1, ..., paramN) => {
				return valorDeRetorno;
			};
		*/

		public static void Demos()
		{
			Console.WriteLine("Action<> y Func<>");
			Console.WriteLine("-----------------------------------\n");

			// DemoAccion1();

			// DemoAccion2();

			// DemoFunc1();

			DemoFunc2();
		}


		#region DemoAccion1
		private static void DemoAccion1()
		{
			Console.WriteLine("Demo Action<T>");

			// Definir un Action que acepta un parámetro de tipo string y no devuelve un valor
			Action<string> mostrarMensaje1 = (mensaje) =>
			{
				// Imprimir el mensaje en la consola
				Console.WriteLine(mensaje);
			};

			Action<string> mostrarMensaje2 = mensaje => Console.WriteLine(mensaje);


			// Invocar el Action con un mensaje específico
			mostrarMensaje1("Hola, mundo con Action<T>!");
			mostrarMensaje2("Hola, mundo con Action<T>!");

			Console.WriteLine("\n");
		}
		#endregion

		#region DemoAccion2
		public static void DemoAccion2()
		{
			Console.WriteLine("Demo Action<T> en Ciclos");

			// Definir un Action que acepta un entero como parámetro y lo imprime
			Action<int> imprimir = numero => Console.WriteLine(numero);

			// Usar un bucle for para llamar al Action con valores del 0 al 4
			for (int i = 0; i < 5; i++)
				imprimir(i);

			Console.WriteLine("\n");
		}
		#endregion

		#region DemoFunc1
		// Ejemplo de un Func<> sin parámetros que retorna un valor.
		private static void DemoFunc1()
		{
			// Declarar un Func que retorna una cadena sin tomar parámetros.

			// Func<string> obtenerSaludo = () => { return "Hola Mundo!"; };

			Func<string> obtenerSaludo = () => "Hola Mundo!";

			// Invocar la función y mostrar el resultado en la consola.
			Console.WriteLine(obtenerSaludo());
		}
		#endregion

		#region DemoFunc2
		//  Ejemplo de un Func<> con parámetros y retorno de valor.
		private static void DemoFunc2()
		{
			// Declarar un Func que toma dos enteros y retorna su suma.
			Func<int, int, int> sumar = (x, y) => x + y;

			// Invocar la función con dos números y mostrar el resultado en la consola.
			Console.WriteLine(sumar(5, 3));
		}

		#endregion

	}
}
