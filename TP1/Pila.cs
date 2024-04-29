using System;
using System.Collections.Generic;

namespace TP1
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila: coleccionable
	{
		private List<comparable> lista;
		
				
		public Pila()
		{
			this.lista= new List<comparable>();
		}
		
		public List<comparable> getLista{
			get{return lista;}
		}

		public bool esVacia(){
			return lista.Count==0;
		}
		
		public void encolar(comparable agregado){
			lista.Add(agregado);
		}
		
		public comparable desencolar(){
			//saca el ultimo elemento
			comparable desencolado=lista[lista.Count-1];
			lista.RemoveAt(lista.Count-1);
			return desencolado;
		}
		
		public void pop(){
			Console.Write(lista[lista.Count-1]);
		}
		
		public int cuantos(){
			return lista.Count;
		}
		
		public comparable minimo(){
			comparable aux=lista[0];
			for (int i = 1; i < lista.Count; i++) {
				if (lista[i].sosMenor(lista[i-1])) {
					aux=lista[i];
				}
			}
			return aux;
		}
		
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
			this.encolar(a);
		}
		
		public bool cotiene(comparable a){
			foreach (comparable el in lista) {
				if (el.sosIgual(a)) {
					return true;
				}
			}
			return false;
		}
		
	}
}
