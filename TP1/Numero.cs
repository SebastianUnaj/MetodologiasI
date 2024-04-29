using System;

namespace TP1
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
			return this.getValor==((Numero)C).valor;
		}
		
		public bool sosMenor(comparable C){
			return valor<((Numero)C).valor;
		}
		
		public bool sosMayor(comparable C){
			return valor>((Numero)C).valor;
		}
	}
}
