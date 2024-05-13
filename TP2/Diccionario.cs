/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 29/4/2024
 * Hora: 22:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario: coleccionable
	{
		private Conjunto conj;
		
		public Diccionario()
		{
			this.conj = new Conjunto();
		}
		public void agregar(comparable clave, Numero valor){
			Console.WriteLine("\nAgrego al diccionario");
			foreach (ClaveValor el in conj.Lista) {
				if (el.Clave.sosIgual(clave)) {
					Console.WriteLine("La clave pertenece al diccionario");
					el.Valor=valor;
					Console.WriteLine("Se actualizó valor asociado");
				}
			}
			
			ClaveValor cl= new ClaveValor(clave, valor);
			conj.agregar(cl);
		}
		public Numero valorDe(comparable clave){
			Numero o=new Numero(0);
			if (this.cotiene(clave)) {
				foreach (ClaveValor el in this.conj.Lista) {
					if ((el.Clave).sosIgual(clave)) {
						Console.WriteLine("contiene, devuelvo valor asociado");
						return el.Valor;
					}
				}
				return o;
			}else{return o;}
		}
		
		public int cuantos(){
			return conj.cuantos();
		}
		
		public comparable minimo(){
			return conj.minimo();
		}
		
		public comparable maximo(){
			return conj.maximo();
		}
		
		public void agregar(comparable a){
			Console.WriteLine("\nAgrego al diccionario");
			if (!this.cotiene(a)) {
				this.conj.agregar(a);
			}
		}
			
		public bool cotiene(comparable a){
			foreach (ClaveValor el in conj.Lista) {
				if ((el.Clave).sosIgual(a)) {
					return true;
				}
			}
			return false;
		}//fin cotiene
		
		
		public IteradorDePaginas crearIterador(){
			return new IteradorDeList(conj.getLista);
		}
		
		
	}//fin class
}//fin namespace
