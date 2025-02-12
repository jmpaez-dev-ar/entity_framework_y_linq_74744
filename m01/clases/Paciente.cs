namespace m01.clases
{
	public class Paciente
	{
		public Paciente()
		{
			Nombre = string.Empty;
			Email = string.Empty;
		}
		public Paciente(int id, string nombre)
		{
			Id = id;
			Nombre = nombre;
		}

		public Paciente(int id, string nombre, string email)
		{
			Id = id;
			Nombre = nombre;
			Email = email;
		}
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Email { get; set; }
		public bool? Activo { get; set; } = true;
		public string? Domicilio { get; set; }
	}
}
