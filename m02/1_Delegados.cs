

namespace m02
{
	public class Delegados
	{
		// DELEGADOS
		// Los delegados son un tipo especial de objeto que se utiliza para representar y referenciar métodos. Actúan como punteros a funciones, pero son seguros en cuanto a tipos.

		// Sintaxis básica de un delegado:
		//		delegate tipoDeRetorno NombreDelegado(parametros);
		// Donde:
		//		- tipoDeRetorno es el tipo de dato que el delegado devolverá.
		//		- NombreDelegado es el nombre que le das al delegado.
		//	- parametros son los parámetros que toma el delegado. Pueden ser opcionales según el caso.


		public static void Demos()
		{
			Console.WriteLine("Delegados");
			Console.WriteLine("-----------------------------------\n");

			// DemoDelegadosBasicos1();

			DemoDelegadosBasicos2();
		}

		#region DemoDelegadosBasicos1
		delegate void MiDelegado(string mensaje);

		private static void DemoDelegadosBasicos1()
		{
			// Crear una instancia del delegado y asignarle un método	
			MiDelegado delegado = MostrarMensaje;

			// Invocar el delegado
			delegado("Hola desde el delegado!");

			// Asignar otro método al delegado
			delegado = MostrarMensajeEnMayusculas;

			// Invocar el delegado
			delegado("Hola desde el delegado en mayúsculas!");
		}
		public static void MostrarMensaje(string mensaje)
		{
			Console.WriteLine(mensaje);
		}

		public static void MostrarMensajeEnMayusculas(string mensaje)
		{
			Console.WriteLine(mensaje.ToUpper());
		}
		#endregion

		#region DemoDelegadosBasicos2

		public delegate void ImprimirMensaje(string mensaje);

		private static void DemoDelegadosBasicos2()
		{
			Console.WriteLine("Delegados Básicos 2");
			Console.WriteLine("-----------------------------------\n");

			// Creación de una instancia del delegado y asignación de un método
			ImprimirMensaje imprimir = ImprimirEnConsola;


			// Llamada al delegado para imprimir un mensaje en la consola
			imprimir("Hola, mundo!");

			// Reasignación del delegado a otro método
			imprimir = ImprimirEnArchivo;

			// Llamada al delegado para imprimir un mensaje en un archivo
			imprimir("Este mensaje se guarda en un archivo.");
		}

		public static void ImprimirEnConsola(string mensaje)
		{
			Console.WriteLine("Imprimiendo en la consola: " + mensaje);
		}

		public static void ImprimirEnArchivo(string mensaje)
		{
			string filePath = "mensaje.txt";
			using (StreamWriter writer = new StreamWriter(filePath, true))
			{
				writer.WriteLine(mensaje);
			}
			Console.WriteLine("Guardando en un archivo: " + mensaje);
		}
		#endregion
	}
}
