
using System;
using System.Collections.Generic;

namespace practica2
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple :coleccionable
	{
		private Pila pCM; //PilaColeccionMultiple
		private Cola cCM; //ColaColeccionMultiple
			
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pCM= p;
			this.cCM= c;
		}
		
		public int cuantos(){
			return pCM.cuantos() + cCM.cuantos();
		}
		
		public comparable minimo(){
			if (pCM.minimo().sosMenor(cCM.minimo())) {
				return pCM.minimo();
			} else {
				return cCM.minimo();
			}
		}
		
		public comparable maximo(){
			
				if (pCM.minimo().sosMayor(cCM.minimo())) {
					return pCM.maximo();
				} else {
					return cCM.maximo();
				}
		}
		
		public void agregar(comparable a){
			
		}
		
		public bool cotiene(comparable a){
			return pCM.cotiene(a) || cCM.cotiene(a);
		}
		
	}
}
