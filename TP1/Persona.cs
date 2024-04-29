
using System;
using System.Collections.Generic;


namespace TP1
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona:comparable
	{
		private string nombre;
		private int dni;
		
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		
		public string getNombre{
			get{return nombre;}
		}
		public int getDni{
			get{return dni;}
		}
		
		//metodos del comparable
		public bool sosIgual(comparable c){
			return ((Persona)c).getNombre==this.getNombre;
		}
		public bool sosMenor(comparable c){
			return ((Persona)c).dni>this.getDni;
		}
		public bool sosMayor(comparable c){
			return ((Persona)c).dni<this.getDni;
		}
	}
}
