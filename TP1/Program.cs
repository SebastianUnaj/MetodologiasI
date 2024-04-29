using System;
using System.Collections.Generic;

namespace TP1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Creo un numero y le paso una funcion
			Console.WriteLine("interface comparable clase nuemero");
			Numero nro= new Numero(2);
			Numero nro2= new Numero(3);
			Console.WriteLine("2 y 3");
			Console.WriteLine(nro2.sosIgual(nro));
			
			
			
			//Creo Pila y Cola
			Pila p= new Pila();
			Cola col=new Cola();
			llenar(p);
			llenar(col);
			Console.WriteLine("INFORMO PILA");
			informar(p);
			Console.WriteLine("INFORMO COLA");
			informar(col);
			
			//creo coleccionable multiple
			ColeccionMultiple cM= new ColeccionMultiple(p, col);
			Console.WriteLine("INFORMO COLECCION MULTIPLE");
			informar(cM);
			
			//coleccion multiple de personas
			Pila p1= new Pila();
			Cola col1=new Cola();
			ColeccionMultiple cM1= new ColeccionMultiple(p1, col1);
			llenarPersonas(p1);
			llenarPersonas(col1);
			Console.WriteLine("INFORMO COLECCION MULTIPLE de personas");
			informar(cM1);
			
			//coleccion multiple de Alumnos
			
			Pila p2= new Pila();
			Cola col2=new Cola();
			ColeccionMultiple cM2= new ColeccionMultiple(p2, col2);
			llenarAlumnos(p2);
			llenarAlumnos(col2);
			Console.WriteLine("INFORMO COLECCION MULTIPLE de Alumnos");
			informar(cM2);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}///fin del main//
		
		
		/// <summary>
		/// METODOS STATICOS
		/// </summary>
		/// <param name="c"></param>
		 
		private static Random unicoRandomGlobal = new Random();
		
		public static void llenar(coleccionable c){
			for (int i = 0; i < 20; i++) {
				int auxi= (new RandomUnico(unicoRandomGlobal)).numeroRandom();
					Numero aux= new Numero(auxi);
				comparable a= aux;
				c.agregar(a);
			}
		}//fin llenar
		
		public static void informar(coleccionable c){
			Console.WriteLine("Cantidad de elementos: "+c.cuantos());
			//var tipo;
			switch (c.minimo().GetType().ToString()) {
				case "TP1.Numero":
					Console.WriteLine("Valor Mínimo: "+((Numero)c.minimo()).getValor);
					break;
				case "TP1.Persona":
					Console.WriteLine("Nombre Mínimo: "+((Persona)c.minimo()).getNombre);
					break;
				case "TP1.Alumno":
					Console.WriteLine("Legajo Mínimo: "+((Alumno)c.minimo()).getLegajo);
					break;
			}
			switch (c.maximo().GetType().ToString()) {
				case "TP1.Numero":
					Console.WriteLine("Valor Máximo: "+((Numero)c.maximo()).getValor);
					break;
				case "TP1.Persona":
					Console.WriteLine("Nombre Máximo: "+((Persona)c.maximo()).getNombre);
					break;
				case "TP1.Alumno":
					Console.WriteLine("Legajo Máximo: "+((Alumno)c.maximo()).getLegajo);
					break;
			}
			Console.Write("contiene: ");
			string contien= Console.ReadLine();
			comparable a=null;
			
			switch (c.maximo().GetType().ToString()) {
				case "TP1.Numero":
					a= new Numero(Int32.Parse(contien));
					break;
				case "TP1.Persona":
					a= new Persona(contien, 11111111);
					break;
				case "TP1.Alumno":
					a= new Alumno("comparale",11111111,Int32.Parse(contien),double.Parse(contien));
					break;
			}
			
			if (c.cotiene(a))
				Console.WriteLine("El elemento leído está en la colección");
			else
				Console.WriteLine("El elemento leído NO está en la colección");
			
		}//fin informar
		
		public static void llenarPersonas(coleccionable col){
			for (int i = 0; i < 10; i++) {
				RandomUnico r= new RandomUnico(unicoRandomGlobal);
				int dni= r.dniRandom();
				int np= r.numeroRandom();
				string nom= "Persona "+np;
				comparable comp= new Persona (nom, dni);
				col.agregar(comp);
			}
		}//llenarPersonas
		
		public static void llenarAlumnos(coleccionable col){
			for (int i = 0; i < 10; i++) {
				RandomUnico r= new RandomUnico(unicoRandomGlobal);
				int dni= r.dniRandom();
				int np= r.numeroRandom();
				string nom= "Alumno "+np;
				int legaj= r.legajoRandom();
				double prom= r.promedioRandom();
				
				comparable comp= new Alumno (nom, dni, legaj, prom);
				col.agregar(comp);
			}
		}//llenarAlumnos
	}
}