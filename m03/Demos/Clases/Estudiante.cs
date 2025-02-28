namespace m03.Demos.Clases
{
	public class Estudiante
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		public Estudiante() { }
		public Estudiante(int id, string nombre, string apellido, int edad)
		{
			Id = id;
			Nombre = nombre;
			Apellido = apellido;
			Edad = edad;
		}

		public static List<Estudiante> ObtenerTodos()
		{
			var estudiantes = new List<Estudiante>();
			estudiantes.Add(new Estudiante(1, "Carlos", "Perez", 20));
			estudiantes.Add(new Estudiante(2, "Ana", "Lopez", 22));
			estudiantes.Add(new Estudiante(3, "Luis", "Gonzalez", 19));
			estudiantes.Add(new Estudiante(4, "Maria", "Martinez", 21));
			estudiantes.Add(new Estudiante(5, "Jose", "Hernandez", 23));
			estudiantes.Add(new Estudiante(6, "Lucia", "Fernandez", 20));
			estudiantes.Add(new Estudiante(7, "David", "Garcia", 22));
			estudiantes.Add(new Estudiante(8, "Sofia", "Alvarez", 19));
			estudiantes.Add(new Estudiante(9, "Daniel", "Romero", 21));
			estudiantes.Add(new Estudiante(10, "Laura", "Torres", 23));
			estudiantes.Add(new Estudiante(11, "Sergio", "Sánchez", 20));
			estudiantes.Add(new Estudiante(12, "Andrea", "Gutierrez", 22));
			estudiantes.Add(new Estudiante(13, "Fernando", "Ruiz", 19));
			estudiantes.Add(new Estudiante(14, "Carmen", "Diaz", 21));
			estudiantes.Add(new Estudiante(15, "Pablo", "Moreno", 23));
			return estudiantes;
		}
	}
}
