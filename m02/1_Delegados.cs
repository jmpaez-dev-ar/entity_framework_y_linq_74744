




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

			// DemoDelegadosBasicos2();

			// DemoDelegadosBasicos3();

			// DemoDelegadosConGenerics();

			DemoDelegadosAvanzados1();
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

		#region DemoDelegadosBasicos3
		delegate double OperacionMatematica(double a, double b);
		private static void DemoDelegadosBasicos3()
		{
			Console.WriteLine("Delegados Básicos 3");
			Console.WriteLine("-----------------------------------\n");

			OperacionMatematica operacion;
			double resultado;

			operacion = Sumar;
			resultado = operacion(10, 7);
			Console.WriteLine($"Operación: {operacion.Method.Name} | resultado: {resultado}");

			operacion = Restar;
			resultado = operacion(8, 4);
			Console.WriteLine($"Operación: {operacion.Method.Name} | resultado: {resultado}");

			operacion = Multiplicar;
			resultado = operacion(15, 3);
			Console.WriteLine($"Operación: {operacion.Method.Name} | resultado: {resultado}");

			operacion = Dividir;
			resultado = operacion(30, 5);
			Console.WriteLine($"Operación: {operacion.Method.Name} | resultado: {resultado}");
		}
		static double Sumar(double a, double b) { return a + b; }
		static double Restar(double a, double b) { return a - b; }
		static double Multiplicar(double x, double y) { return x * y; }
		static double Dividir(double x, double y) { return x / y; }

		#endregion

		#region DemoDelegadosConGenerics
		// Definimos un delegado genérico que toma un parámetro de tipo T y devuelve un resultado de tipo R
		public delegate R ConvertirElemento<T, R>(T elemento);

		// Método genérico que transforma una lista de elementos de tipo T en una lista de elementos de tipo R
		public static List<R> ConvertirLista<T, R>(List<T> lista, ConvertirElemento<T, R> convertirElemento)
		{
			var resultado = new List<R>();
			foreach (var elemento in lista)
			{
				resultado.Add(convertirElemento(elemento));
			}
			return resultado;
		}
		// Método que calcula el cuadrado de un entero
		public static int Cuadrado(int x) { return x * x; }

		// Método que calcula la longitud de una cadena
		public static int Longitud(string s) { return s.Length; }

		private static void DemoDelegadosConGenerics()
		{
			Console.WriteLine("Delegados Generics ");
			Console.WriteLine("-----------------------------------\n");

			// Lista de enteros
			var numeros = new List<int> { 1, 2, 3, 4, 5 };
			Console.WriteLine("Números:");
			numeros.ForEach(Console.WriteLine);

			// Delegado para transformar enteros a sus cuadrados
			ConvertirElemento<int, int> cuadrado = Cuadrado;
			var cuadrados = ConvertirLista(numeros, cuadrado);
			Console.WriteLine("\nCuadrados:");
			cuadrados.ForEach(Console.WriteLine);


			Console.WriteLine("\n-----------------------------------\n");

			// Lista de cadenas
			var nombres = new List<string> { "Juan", "Sandra", "Carlos" };
			Console.WriteLine("Nombres:");
			nombres.ForEach(Console.WriteLine);

			// Delegado para transformar cadenas a su longitud
			ConvertirElemento<string, int> longitud = Longitud;

			var longitudes = ConvertirLista(nombres, longitud);
			Console.WriteLine("\nLongitudes de nombres:");
			longitudes.ForEach(Console.WriteLine);
		}
		#endregion

		#region DemoDelegadosAvanzados1

		public delegate void NotificacionHandler(string mensaje);

		public class NotificacionEmail
		{
			public void EnviarEmail(string mensaje)
			{
				Console.WriteLine($"Enviando correo electrónico: {mensaje}");
			}
		}
		public class NotificacionSMS
		{
			public void EnviarSMS(string mensaje)
			{
				Console.WriteLine($"Enviando SMS: {mensaje}");
			}
		}

		public class ProcesadorTransacciones
		{
			public NotificacionHandler Notificacion { get; set; }

			public void ProcesarTransaccion(string transaccion)
			{
				Console.WriteLine($"Procesando transacción: {transaccion}");
				Notificacion?.Invoke($"Transacción {transaccion} procesada con éxito.");
			}
		}

		private static void DemoDelegadosAvanzados1()
		{
			Console.WriteLine("Delegados Avanzados 1");
			Console.WriteLine("-----------------------------------\n");

			// Crear instancias de las clases de notificación
			var notificadorEmail = new NotificacionEmail();
			var notificadorSMS = new NotificacionSMS();

			// Instanciar el procesador de transacciones
			var procesador = new ProcesadorTransacciones();

			// Agregar métodos al delegado multicast
			procesador.Notificacion += notificadorEmail.EnviarEmail;
			procesador.Notificacion += notificadorSMS.EnviarSMS;

			// Procesar una transacción
			procesador.ProcesarTransaccion("12345");

			// Eliminar un método del delegado
			procesador.Notificacion -= notificadorSMS.EnviarSMS;

			// Procesar otra transacción
			Console.WriteLine("\nDespués de eliminar el método SMS:");
			procesador.ProcesarTransaccion("67890");
		}
		#endregion


	}
}
