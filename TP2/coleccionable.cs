
using System;

namespace practica2
{
	/// <summary>
	/// Description of coleccionable.
	/// </summary>
	public interface coleccionable: Iterable
	{
		int cuantos();
		comparable minimo();
		comparable maximo();
		void agregar(comparable a);
		bool cotiene(comparable a);
		
	}
}
