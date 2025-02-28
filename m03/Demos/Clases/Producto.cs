namespace m03.Demos.Clases
{
	public class Producto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public int Cantidad { get; set; }
		public double Precio { get; set; }

		public Producto() { }
		public Producto(int id, string nombre, int cantidad, double precio)
		{
			Id = id;
			Nombre = nombre;
			Cantidad = cantidad;
			Precio = precio;
		}
		public static List<Producto> ObtenerTodos()
		{
			{
				var productos = new List<Producto>();

				productos.Add(new Producto(1, "Lapiz", 100, 0.50));
				productos.Add(new Producto(2, "Cuaderno", 50, 1.50));
				productos.Add(new Producto(3, "Borrador", 150, 0.25));
				productos.Add(new Producto(4, "Tijeras", 30, 2.00));
				productos.Add(new Producto(5, "Pegamento", 80, 0.75));
				productos.Add(new Producto(6, "Regla", 70, 0.60));
				productos.Add(new Producto(7, "Marcador", 90, 1.20));
				productos.Add(new Producto(8, "Mochila", 40, 15.00));
				productos.Add(new Producto(9, "Carpeta", 60, 2.50));
				productos.Add(new Producto(10, "Libro", 20, 12.00));
				productos.Add(new Producto(11, "Lapicera", 110, 1.00));
				productos.Add(new Producto(12, "Calculadora", 25, 20.00));
				productos.Add(new Producto(13, "Papel", 200, 0.10));
				productos.Add(new Producto(14, "Engrapadora", 35, 5.00));
				productos.Add(new Producto(15, "Corrector", 45, 1.75));

				return productos;
			}

		}
	}
}
