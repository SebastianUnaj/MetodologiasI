/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 29/4/2024
 * Hora: 22:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor: comparable
	{
		private comparable clave;
		//probar con Numero luego con cualquier objeto
		private Numero valor;
		
		public ClaveValor(comparable clave, Numero valor)
		{
			this.clave=clave;
			this.valor=valor;
		}
		public comparable Clave{
			get{return clave;}
			set{clave= value;}
		}
		public Numero Valor{
			get{return valor;}
			set{this.valor= value;}
		}
		
		
		public bool sosIgual(comparable cl){
			//como saber si object == object/ uso metodo equals
			
			//si clave es igual verificar valor??????
			return this.clave.sosIgual(cl);
		}
		public bool sosIgual(ClaveValor cl){
			bool igual=false;
			//como saber si comparable == comparable
			//como saber si var == var
			if (this.clave.GetType()==cl.Clave.GetType()) {
				//Console.WriteLine("clave igual?"+ clave.sosIgual(cl.Clave));
				igual=true;
			}
			if (this.valor.GetType()==cl.Valor.GetType()) {
				//Console.WriteLine("valor igual?"+ valor.sosIgual(cl.Valor));
				igual=true;
			}
			return igual;
		}
		public bool sosMenor(comparable c){return false;}
		public bool sosMayor(comparable c){return false;}
		//agregar un metodo imprimir que muestre el tipo de la clave y del valor
		
	}
}
