namespace m03.Demos.Clases
{
	public class Calificacion
	{
		public int EstudianteId { get; set; }
		public int Puntuacion { get; set; }

		public Calificacion() { }
		public Calificacion(int estudianteId, int puntuacion)
		{
			EstudianteId = estudianteId;
			Puntuacion = puntuacion;
		}
		public static List<Calificacion> ObtenerTodos()
		{
			List<Calificacion> calificaciones = new List<Calificacion>();
			calificaciones.Add(new Calificacion(1, 8));
			calificaciones.Add(new Calificacion(2, 7));
			calificaciones.Add(new Calificacion(3, 9));
			calificaciones.Add(new Calificacion(4, 6));
			calificaciones.Add(new Calificacion(5, 10));
			calificaciones.Add(new Calificacion(6, 5));
			calificaciones.Add(new Calificacion(7, 8));
			calificaciones.Add(new Calificacion(8, 7));
			calificaciones.Add(new Calificacion(9, 6));
			calificaciones.Add(new Calificacion(10, 5));
			calificaciones.Add(new Calificacion(11, 8));
			calificaciones.Add(new Calificacion(12, 9));
			calificaciones.Add(new Calificacion(13, 10));
			calificaciones.Add(new Calificacion(14, 4));
			calificaciones.Add(new Calificacion(15, 7));

			return calificaciones;
		}
	}
}
