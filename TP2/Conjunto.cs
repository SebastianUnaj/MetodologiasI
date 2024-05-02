/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 29/4/2024
 * Hora: 21:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace practica2
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto: coleccionable
	{
		private List<comparable> lista;
		
		public Conjunto()
		{
			this.lista= new List<comparable>();
		}
		
		public List<comparable> Lista{
			get{return lista;}
		}
		
		public int cuantos(){ return lista.Count;}
		
		//si es clave valor siempre dará falso
		public comparable minimo(){
			comparable aux=lista[0];
			for (int i = 1; i < lista.Count; i++) {
				if (lista[i].sosMenor(lista[i-1])) {
					aux=lista[i];
				}
			}
			return aux;
		}//fin minimo
		
		public comparable maximo(){
			comparable aux=lista[0];
			for (int i = 1; i <lista.Count; i++) {
				if (lista[i].sosMayor(lista[i-1])) {
					aux=lista[i];
				}
			}
			return aux;
		}
		
		public void agregar(comparable a){
			if (!this.cotiene(a)) {
				lista.Add(a);
				Console.WriteLine("agregado al conjunto");
			}
		}
		
		public bool pertenece(comparable a){
			return this.cotiene(a);
		}
		
		public bool cotiene(comparable a){
			bool contiene=false;
			foreach (comparable el in lista) {
				if (el.GetType()==a.GetType()){
					if (el.sosIgual(a))
						contiene= true;
				}
			}
			return contiene;
		}
	}
}
