/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 27/4/2024
 * Hora: 19:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Alumno a1= new Alumno("al"+1,23111222, 11222, 0.7);
			Alumno a2= new Alumno("al"+1,3111222, 1222, 0.7);
			
			Console.WriteLine("Nombre DNI LEGAJO PROMEDIO:");
			Console.WriteLine(a1.getNombre+" "+a1.getDni+" "+a1.getLegajo+" "+a1.getPromedio);
			Console.WriteLine(a2.getNombre+" "+a2.getDni+" "+a2.getLegajo+" "+a2.getPromedio);
			
			Console.WriteLine("compara por legajo");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			
			a1.cambiarComparar("2");
			//Console.WriteLine("compara por Promedio");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			
			a1.cambiarComparar("3");
			//Console.WriteLine("compara por Dni");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			
			a1.cambiarComparar("4");
			//Console.WriteLine("compara por Nombre");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			
			//************EJERCICIO 2*****************/
			
			//coleccion multiple de Alumnos
			
			Pila p2= new Pila();
			Cola col2=new Cola();
			ColeccionMultiple cM2= new ColeccionMultiple(p2, col2);
			llenarAlumnos(p2);
			llenarAlumnos(col2);
			Console.WriteLine("INFORMO COLECCION MULTIPLE de Alumnos");
			//Type myType = typeof(practica2.Program);
        	 //Console.WriteLine("   Namespace: {0}.", myType.Namespace);
			Console.WriteLine("tipo coleccion multiple: "+ cM2.GetType().ToString());
			informar(cM2);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		
		
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
				case "practica2.Numero":
					Console.WriteLine("Valor Mínimo: "+((Numero)c.minimo()).getValor);
					break;
				case "practica2.Persona":
					Console.WriteLine("Nombre Mínimo: "+((Persona)c.minimo()).getNombre);
					break;
				case "practica2.Alumno":
					Console.WriteLine("Legajo Mínimo: "+((Alumno)c.minimo()).getLegajo);
					break;
			}
			switch (c.maximo().GetType().ToString()) {
				case "practica2.Numero":
					Console.WriteLine("Valor Máximo: "+((Numero)c.maximo()).getValor);
					break;
				case "practica2.Persona":
					Console.WriteLine("Nombre Máximo: "+((Persona)c.maximo()).getNombre);
					break;
				case "practica2.Alumno":
					Console.WriteLine("Legajo Máximo: "+((Alumno)c.maximo()).getLegajo);
					break;
			}
			Console.Write("contiene: ");
			string contien= Console.ReadLine();
			comparable a=null;
			
			switch (c.maximo().GetType().ToString()) {
				case "practica2.Numero":
					a= new Numero(Int32.Parse(contien));
					break;
				case "practica2.Persona":
					a= new Persona(contien, 11111111);
					break;
				case "practica2.Alumno":
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
				Alumno AlumAux= new Alumno (nom, dni, legaj, prom);
				int strategia= (i*3)%4+1;//para obtener valores alternos entre 1 y 4 que cambien la estrategia
				AlumAux.cambiarComparar(strategia.ToString());
				comparable comp= AlumAux;
				col.agregar(comp);
			}
		}//llenarAlumnos
	}
}