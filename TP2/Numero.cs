using System;

namespace practica2
{
	
	public class Numero : comparable
	{
		private int valor;
		
		public Numero(int valor)
		{
			this.valor=valor;
		}
		
		public int getValor{
			get{return valor;}
		}
		
		public bool sosIgual(comparable C){
			if (C.GetType().ToString()=="practica2.Numero") {
				return this.valor==((Numero)C).valor;
			}else{return false;}
		}
		
		public bool sosMenor(comparable C){
			return this.valor<((Numero)C).valor;
		}
		
		public bool sosMayor(comparable C){
			return this.valor>((Numero)C).valor;
		}
	}
}
