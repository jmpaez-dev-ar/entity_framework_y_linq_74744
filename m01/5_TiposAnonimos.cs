


namespace m01
{
	public class TiposAnonimos
	{
		// TIPOS ANÓNIMOS:
		// Los tipos anónimos permiten crear objetos sin definir clases explícitas, encapsulando propiedades temporalmente.
		// Sus características incluyen:
		//	- Definición rápida: Usan var y una lista de propiedades entre { }.
		//	- Inmutabilidad: Sus propiedades son de solo lectura.
		//	- Tipado fuerte: El compilador infiere su tipo en tiempo de compilación.

		public static void Demos()
		{
			Console.WriteLine("Demo de Tipos Anónimos");
			Console.WriteLine("----------------------\n");

			DemoTiposAnonimos();
			DemoPasoParametrosTiposAnonimo();
		}

		private static void DemoTiposAnonimos()
		{
			Console.WriteLine("Ejemplo #1:");
			// Definición de un tipo anónimo con dos propiedades
			var anonimo1 = new
			{
				Id = 1,
				Message = "No sabes quien soy, ya que tengo mi máscara."
			};

			Console.WriteLine($"Id: {anonimo1.Id}");
			Console.WriteLine($"Message: {anonimo1.Message}");


			Console.WriteLine("\n----------------------\n");

			Console.WriteLine("Ejemplo #2:");

			// Definición de otro tipo anónimo con tres propiedades
			var reporteServicio = new
			{
				Cliente = "Ana",
				Servicio = "Rodriguez",
				Precio = 20.00m
			};

			Console.WriteLine($"Cliente: {reporteServicio.Cliente}");
			Console.WriteLine($"Servicio: {reporteServicio.Servicio}");
			Console.WriteLine($"Precio: {reporteServicio.Precio}");
		}
		private static void DemoPasoParametrosTiposAnonimo()
		{
			Console.WriteLine("Ejemplo #3:");

			// Definición de un tipo anónimo
			var persona = new
			{
				Nombre = "Carlos",
				Edad = 30
			};

			// Pasar parámetros de tipos anónimos a un método
			MostrarInformacion(persona);
		}

		private static void MostrarInformacion(dynamic persona)  // dynamic permite que parametro sea un objeto de cualquier tipo
		{
			Console.WriteLine($"Nombre: {persona.Nombre}");
			Console.WriteLine($"Edad: {persona.Edad}");
		}
	}
}
