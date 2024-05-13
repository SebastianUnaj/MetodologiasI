/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 2/5/2024
 * Hora: 23:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace practica2
{
	/// <summary>
	/// Description of IteradorList.
	/// </summary>
	/// 
	
	public class IteradorDeList : IteradorDePaginas {
		private List<comparable> list; //pila, cola
		private int dl;
		private int indice;
		
		
		public IteradorDeList(List<comparable> lista){
			this.list=lista;
			this.dl= lista.Count;
			indice = 0;
		}
		
		public comparable actual(){
			return list[indice];
		}
		
		public void siguiente(){
			indice++;
		}
		
		public bool fin(){
			return indice >= dl;
		}
	}
	
	
	
}
