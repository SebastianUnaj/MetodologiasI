/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 13/5/2024
 * Hora: 00:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	/// <summary>
	/// Description of impresora.
	/// </summary>
	public class impresora
	{
		public void imprimirElementos(coleccionable doc){
			IteradorDePaginas ite = doc.crearIterador();
			Console.WriteLine("Imprimiendo documento ");
			while(! ite.fin()){
				this.imprimirPagina(ite.actual());
				ite.siguiente();
			}
		}
		
		private void imprimirPagina(comparable p){
			Console.WriteLine("\tImprimiendo " + p);
		}
	}
	
}
