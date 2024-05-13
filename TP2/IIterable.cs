/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 2/5/2024
 * Hora: 21:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	/// <summary>
	/// Description of IteradorDePaginas.
	/// </summary>
	public interface IteradorDePaginas //iterador de comparables
	{
		comparable actual();
		void siguiente();
		bool fin();
	}
	/// <summary>
	/// Description of IIterable.
	/// </summary>
	/// 
	public interface Iterable
	{
		IteradorDePaginas crearIterador();
	}
}
