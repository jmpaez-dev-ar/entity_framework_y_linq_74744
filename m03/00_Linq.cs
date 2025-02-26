namespace m03
{
	public class _00_Linq
	{
		// DATOS COMPATIBLES CON LINQ 
		/*
			LINQ  es compatible con una amplia variedad de fuentes de datos.:

			1.  Colecciones de objetos: puede utilizarse para consultar y manipular colecciones de objetos, 
				como List, Array, Dictionary, y otros tipos de colecciones.

			2.	Bases de datos relacionales: LINQ to SQL es un componente de .NET 
				que permite consultar y manipular bases de datos relacionales utilizando LINQ. 

			3.	Archivos XML: LINQ to XML permite consultar y manipular documentos XML utilizando LINQ.

			4.	Servicios web: LINQ to XML y LINQ to DataSet permiten consultar y manipular servicios web 
				que devuelven datos en formato XML o DataSet.

			5.	IQueryable: IQueryable es una interfaz que permite interactuar con proveedores de datos remotos, 
				como servicios web RESTful o bases de datos no relacionales.

			En general, LINQ puede utilizarse para consultar y manipular cualquier fuente de datos que implemente la interfaz IEnumerable,
			incluyendo aquellas fuentes de datos que no están incluidas en la lista anterior.
		*/

		// ENCADENAMIENTO DE OPERADORES DE CONSULTA 
		/*
				El encadenamiento de operadores de consulta es una técnica que se utiliza 
				para combinar múltiples operadores de consulta en una sola expresión. 

				En el encadenamiento de operadores de consulta, 
				cada operador de consulta se aplica a la secuencia de resultados devuelta por el operador de consulta anterior. 


				var productosFiltradosYOrdenados = productos.Where(p => p.Precio > 50)
															.OrderBy(p => p.Nombre)
															
		*/


		//  OPERADORES DE CONSULTA ESTÁNDAR 
		/*
				Existen varios operadores de consulta estándar que se pueden utilizar para realizar operaciones comunes 
				en colecciones de objetos. Algunos de estos operadores incluyen:

				1.  Where: se utiliza para filtrar elementos en una secuencia que cumplan con una condición determinada.

				2.	OrderBy y OrderByDescending: se utilizan para ordenar los elementos de una secuencia en orden ascendente o descendente según una determinada clave.

				3.	Select: se utiliza para proyectar los elementos de una secuencia en un nuevo tipo de datos.

				4.	GroupBy: se utiliza para agrupar elementos en una secuencia según una determinada clave y crear grupos de elementos relacionados.

				5.	Join y GroupJoin: se utilizan para combinar dos secuencias en una sola secuencia, basándose en una relación común entre los elementos de las secuencias.

				6.	Aggregate: se utiliza para aplicar una función acumulativa a los elementos de una secuencia y producir un resultado acumulado.

				7.	Distinct: se utiliza para eliminar elementos duplicados de una secuencia.

				8.	Skip y Take: se utilizan para saltar un número determinado de elementos o tomar un número determinado de elementos de una secuencia.

				9.	Any y All: se utilizan para determinar si hay algún elemento en una secuencia que cumpla una determinada condición o si todos los elementos de una secuencia cumplen una determinada condición.

				10.	Count y Sum: se utilizan para contar el número de elementos en una secuencia o sumar los valores de una determinada propiedad de los elementos de una secuencia.

				La combinación de estos operadores permite construir consultas complejas y obtener datos de diversas fuentes de manera clara y legible.
		*/

		// IEnumerable 
		/*
				IEnumerable es una interfaz que forma parte del framework de .NET en C#. 
				Es utilizada en LINQ (Language Integrated Query) para representar una secuencia de elementos que se pueden iterar uno por uno.

				Una secuencia en LINQ es una colección de objetos que implementan la interfaz IEnumerable. 
				La interfaz IEnumerable proporciona un método GetEnumerator() que permite al código iterar sobre la secuencia, 
				lo que significa que se puede acceder a cada elemento de la secuencia de forma secuencial.

				La interfaz IEnumerable se utiliza en LINQ para representar cualquier objeto que se pueda iterar y que permita acceder a sus elementos de forma secuencial.
		*/

		// IQueryable
		/*
			IQueryable es una interfaz de LINQ en C# que representa una consulta que se ejecuta en una fuente de datos. 
			Es similar a IEnumerable, pero en lugar de realizar la consulta en memoria, se puede realizar la consulta en una base de datos o cualquier otra fuente de datos externa.

			La principal ventaja de IQueryable es que permite al proveedor de datos (por ejemplo, una base de datos) optimizar la consulta y devolver solo los datos necesarios para cumplir con la consulta. 

			IQueryable también se utiliza comúnmente en combinación con LINQ to SQL o Entity Framework 
			para realizar consultas en una base de datos relacional. 
			Al utilizar IQueryable, es posible construir consultas complejas de manera programática y, al mismo tiempo, mantener la capacidad de optimización de consultas del proveedor de datos subyacente.
		*/
	}
}
