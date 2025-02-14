
using System.Text.RegularExpressions;

namespace m01
{
	public class MetodosDeExtension
	{
		// MÉTODOS DE EXTENSIÓN:
		// Los métodos de extensión permiten añadir funcionalidades a tipos existentes sin modificar su definición original. Se implementan en clases estáticas con métodos estáticos y utilizan this en el primer parámetro para indicar el tipo extendido.

		// Características principales:
		// - No alteran el tipo original.
		// - Facilitan la reutilización del código.
		// - Mejoran la legibilidad al comportarse como métodos de instancia.

		public static void Demos()
		{
			Console.WriteLine("Demo de Métodos de Extensión");
			Console.WriteLine("-----------------------------\n");

			DemoMetodosExtensionCadenas();

			DemoMetodosExtensionFechas();

			DemoMetodosExtensionNumeros();
		}

		private static void DemoMetodosExtensionCadenas()
		{
			Console.WriteLine("Demo de Métodos de Extensión para Manejo de Cadenas");
			Console.WriteLine("---------------------------------------------------\n");

			string mensaje = "Hola, ¿Cómo están?";
			Console.WriteLine(mensaje);

			Console.WriteLine("\nMayusculas");
			Console.WriteLine(mensaje.Mayusculas());

			Console.WriteLine("\nMinusculas");
			Console.WriteLine(mensaje.Minusculas());

			Console.WriteLine("\nInvertir");
			Console.WriteLine(mensaje.Invertir());

			string email = "cliente@hotmail.com";
			bool esValido = email.EsEmailValido();
			Console.WriteLine($"\nEl email {email} es válido: {esValido}");
		}

		public static void DemoMetodosExtensionFechas()
		{
			Console.WriteLine("Demo de Métodos de Extensión para Manejo de Fechas");
			Console.WriteLine("--------------------------------------------------\n");

			DateTime fechaNacimiento = new DateTime(1990, 5, 15);
			int edad = fechaNacimiento.CalcularEdad();
			Console.WriteLine($"Edad calculada: {edad} años");

			DateTime hoy = DateTime.Today;
			bool esFinDeSemana = hoy.EsFinDeSemana();
			Console.WriteLine($"¿Hoy es fin de semana? {esFinDeSemana}");

			DateTime primerDia = hoy.PrimerDiaDelMes();
			Console.WriteLine($"Primer día del mes: {primerDia.ToShortDateString()}");

			DateTime ultimoDia = hoy.UltimoDiaDelMes();
			Console.WriteLine($"Último día del mes: {ultimoDia.ToShortDateString()}");
		}

		private static void DemoMetodosExtensionNumeros()
		{
			Console.WriteLine("Demo de Métodos de Extensión para Manejo de Números");
			Console.WriteLine("---------------------------------------------------\n");

			int numero = 42;
			Console.WriteLine($"El número {numero} es par: {numero.EsPar()}");

			numero = 33;
			Console.WriteLine($"El número {numero} es par: {numero.EsPar()}");
		}
	}

	public static class StringExtensions
	{
		// Método de extensión para convertir una cadena a mayúsculas
		public static string Mayusculas(this string value)
		{
			return value.ToUpper();
		}

		// Método de extensión para convertir una cadena a minúsculas
		public static string Minusculas(this string value)
		{
			return value.ToLower();
		}

		// Método de extensión para invertir una cadena
		public static string Invertir(this string value)
		{
			char[] array = value.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}

		// Método de extensión para validar un email
		public static bool EsEmailValido(this string email)
		{
			string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

			//var esValido = email.Contains("@");
			bool esValido = Regex.IsMatch(email, patronEmail);
			return esValido;
		}
	}

	public static class DateTimeExtensions
	{
		// Método de extensión para obtener la edad a partir de una fecha de nacimiento
		public static int CalcularEdad(this DateTime fechaNacimiento)
		{
			var hoy = DateTime.Today;
			var edad = hoy.Year - fechaNacimiento.Year;
			if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
			return edad;
		}


		// Método de extensión para verificar si una fecha es un fin de semana
		public static bool EsFinDeSemana(this DateTime fecha)
		{
			return fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday;
		}

		// Método de extensión para obtener el primer día del mes
		public static DateTime PrimerDiaDelMes(this DateTime fecha)
		{
			return new DateTime(fecha.Year, fecha.Month, 1);
		}

		// Método de extensión para obtener el último día del mes
		public static DateTime UltimoDiaDelMes(this DateTime fecha)
		{
			return new DateTime(fecha.Year, fecha.Month, DateTime.DaysInMonth(fecha.Year, fecha.Month));
		}
	}

	public static class IntExtensions
	{
		// Método de extensión para determinar si un número es par
		public static bool EsPar(this int numero)
		{
			return numero % 2 == 0;
		}
	}
}
