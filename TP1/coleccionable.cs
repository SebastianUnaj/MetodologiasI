
using System;

namespace TP1
{
	/// <summary>
	/// Description of coleccionable.
	/// </summary>
	public interface coleccionable
	{
		int cuantos();
		comparable minimo();
		comparable maximo();
		void agregar(comparable a);
		bool cotiene(comparable a);
	}
}
