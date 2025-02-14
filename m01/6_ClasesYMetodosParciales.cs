

namespace m01
{
	public class ClasesYMetodosParciales
	{
		// CLASES PARCIALES:
		// Las clases parciales, definidas con la palabra clave 'partial', permiten dividir una clase en varios archivos dentro del mismo ensamblado y espacio de nombres. El compilador las combina en una única clase al compilar.

		// MÉTODOS PARCIALES:
		// Los métodos parciales, definidos con la palabra clave partial, permiten que una clase parcial tenga métodos opcionales. Si no se implementan, el compilador elimina sus llamadas sin impactar el rendimiento.
		public static void Demos()
		{
			Console.WriteLine("Demo de Clases y Métodos Parciales");
			Console.WriteLine("----------------------------------\n");

			// DemoClasesParciales();
			DemoMetodosParciales();
		}

		private static void DemoClasesParciales()
		{
			var persona = new Persona();
			persona.Nombre = "Juan";
			persona.Edad = 30;
			persona.MostrarInformacion();
		}

		private static void DemoMetodosParciales()
		{
			var producto = new Producto();
			producto.Nombre = "Notebook";
			producto.Precio = 1500;
			producto.MostrarInformacion();
		}
	}

	#region Persona
	// Primera clase parcial
	public partial class Persona
	{
		public string Nombre { get; set; }
	}

	// Segunda clase parcial
	public partial class Persona
	{
		public int Edad { get; set; }
	}

	// Tercera clase parcial
	public partial class Persona
	{
		public void MostrarInformacion()
		{
			Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
		}
	}
	#endregion Persona

	#region Producto
	public partial class Producto
	{
		public string Nombre { get; set; }
		public decimal Precio { get; set; }

		// Definición del método parcial:
		// En esta parte de la clase `Producto`, se define la firma del método parcial `OnPrecioChanged` usando la palabra clave `partial`. No se proporciona una implementación aquí, solo se declara el método.
		partial void OnPrecioChanged();

		public void MostrarInformacion()
		{
			Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}");
			OnPrecioChanged();
		}
	}

	//--------------------------------------------------------------------------------------------

	// Segunda clase parcial con implementación de métodos parciales
	public partial class Producto
	{
		// Implementación del método parcial:
		// En esta otra parte de la clase `Producto`, se proporciona la implementación del método parcial `OnPrecioChanged`. Aquí, el método simplemente imprime un mensaje indicando que el precio ha sido actualizado.
		partial void OnPrecioChanged()
		{
			Console.WriteLine("El precio ha sido actualizado.");
		}
	}

	#endregion
}
