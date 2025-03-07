using m03.Demos.Clases;

namespace m03
{
	public class _14_Linq_Operadores_Elemento
	{
		// Los operadores de elemento en LINQ permiten acceder a elementos específicos de una secuencia según posición, condición o relación, recuperando un solo elemento de forma directa.

		/*
		 Operadores de Elemento en LINQ:
			First: Devuelve el primer elemento que cumple una condición o el primero de la secuencia. Lanza una excepción si no encuentra elementos.
		
			FirstOrDefault: Similar a First, pero devuelve el valor predeterminado si no hay elementos.
		
			Last: Devuelve el último elemento que cumple una condición o el último de la secuencia. Lanza una excepción si no hay elementos.
		
			LastOrDefault: Similar a Last, pero devuelve el valor predeterminado si no encuentra elementos.
		
			Single: Devuelve el único elemento que cumple una condición. Lanza una excepción si hay más de un elemento o si no hay ninguno.
		
			SingleOrDefault: Similar a Single, pero devuelve el valor predeterminado si no hay elementos o si hay más de uno.
		 */
		public static void Demos()
		{
			// Obtener la lista de todos los productos
			var productos = Producto.ObtenerTodos();

			// FirstOrDefault:
			/* 
				Devuelve el primer producto que tiene un precio mayor a 100.
				Si no se encuentra ningún producto que cumpla con la condición, devuelve el valor predeterminado (null para tipos de referencia).
			*/
			var primerProductoCaro = productos.FirstOrDefault(p => p.Precio > 100);

			// LastOrDefault:
			/*
				Devuelve el último producto que tiene un precio mayor a 100.
				Si no se encuentra ningún producto que cumpla con la condición, devuelve el valor predeterminado (null para tipos de referencia).
			*/
			var ultimoProductoCaro = productos.OrderBy(p => p.Id).LastOrDefault(p => p.Precio > 100);

			// SingleOrDefault:
			/* 
				Devuelve el producto con el Id = 1.
				Si no se encuentra ningún producto con el Id = 1, devuelve el valor predeterminado (null para tipos de referencia).
				Si hay más de un producto con el Id = 1, se produce una excepción.
			*/
			var producto = productos.SingleOrDefault(p => p.Id == 1);
		}
	}
}
