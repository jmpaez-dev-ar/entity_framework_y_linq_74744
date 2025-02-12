
using m01.clases;

namespace m01
{
	public class InicializadoresDeObjetosYColecciones
	{
		// INICIALIZADORES DE OBJETOS:
		// Permiten crear e inicializar objetos de forma concisa asignando valores a sus propiedades al momento de su creación, sin usar constructores o métodos adicionales.
		public static void Demos()
		{
			Console.WriteLine("Demo de Inicializadores de Objetos y Colecciones");
			Console.WriteLine("-----------------------------------------------\n");

			DemoInicializadorDeObjetos();

			DemoInicializadorDeColecciones();
		}

		private static void DemoInicializadorDeObjetos()
		{
			Paciente paciente0 = new Paciente();

			var paciente1 = new Paciente
			{
				Id = 1,
				Nombre = "Juan Perez",
				Email = "jperez@hotmail.com",
				Activo = true
			};

			var paciente2 = new Paciente { Id = 2, Nombre = "Mario Ramirez" };

			var paciente3 = new Paciente { Nombre = "Maria Sanchez" };

			Console.WriteLine($"Paciente 1: {paciente1.Id} - {paciente1.Nombre} - {paciente1.Email}");
			Console.WriteLine($"Paciente 2: {paciente2.Id} - {paciente2.Nombre} - {paciente2.Email}");
			Console.WriteLine($"Paciente 3: {paciente3.Id} - {paciente3.Nombre} - {paciente3.Email} - {paciente3.Activo} - {paciente3.Domicilio}");
		}

		private static void DemoInicializadorDeColecciones()
		{
			var numeros = new List<int> { 1, 2, 3, 4, 5 };

			var nombres = new List<string> { "Ana", "Luis", "Carlos" };

			var pacientes = new List<Paciente>
				{
				new Paciente { Id = 1, Nombre = "Juan Perez", Email = "juan.perez@hotmail.com" },
				new Paciente { Id = 2, Nombre = "Mario Ramirez" }
				};
		}
	}
}
