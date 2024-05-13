using System;

namespace practica2
{
	/// <summary>
	/// comparable:
	/// sosIgual(comparable c)
	/// sosMenor(comparable c)
	/// sosMayor(comparable c)
	/// </summary>
	public interface comparable
	{
		bool sosIgual(comparable c);
		bool sosMenor(comparable c);
		bool sosMayor(comparable c);
	}
}
