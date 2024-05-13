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
			
			Console.WriteLine("Nombre \tDNI \t\tLEGAJO \tPROMEDIO:");
			Console.WriteLine(a1.getNombre+" \t"+a1.getDni+" \t"+a1.getLegajo+" \t"+a1.getPromedio);
			Console.WriteLine(a2.getNombre+" \t"+a2.getDni+" \t"+a2.getLegajo+" \t"+a2.getPromedio);
			Console.WriteLine("\n__________________________________________________________");
			Console.WriteLine("compara por legajo: 1ro contra 2do");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			Console.WriteLine("\n__________________________________________________________");
			a1.cambiarComparar("2");
			Console.WriteLine("compara por Promedio: 1ro contra 2do");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			Console.WriteLine("\n__________________________________________________________");
			a1.cambiarComparar("3");
			Console.WriteLine("compara por Dni: 1ro contra 2do");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			Console.WriteLine("\n__________________________________________________________");
			a1.cambiarComparar("4");
			Console.WriteLine("compara por Nombre: 1ro contra 2do");
			Console.WriteLine("\tSos igual: "+a1.sosIgual(a2));
			Console.WriteLine("\tSos menor: "+a1.sosMenor(a2));
			Console.WriteLine("\tSos mayor: "+a1.sosMayor(a2));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			Console.Clear();
			//************EJERCICIO 2*****************
			
			//coleccion multiple de Alumnos
			Console.WriteLine("\n*********************************************************");
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
			Console.Clear();
			
			//crear varias clave valor
			Console.WriteLine("\n*********************************************************");
			Console.WriteLine("CLAVE VALOR");
			RandomUnico r= new RandomUnico(unicoRandomGlobal);
			int nvalor= r.legajoRandom();
			Numero n= new Numero(nvalor);
			//int nvalor2= r.legajoRandom();
			int nvalor2= 15123;
			Numero n2= new Numero(nvalor2);
			
			Numero comparable1= new Numero(r.numeroRandom());
			ClaveValor ClVconjunto= new ClaveValor(comparable1, n);
			ClaveValor ClVconjunto2= new ClaveValor(a1, n2);
			Console.WriteLine("nro sosIgual "+comparable1.sosIgual(n2));
			Console.WriteLine("Clave valor 1 igual a 2? :"+ ClVconjunto.sosIgual(ClVconjunto2));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			Console.Clear();
			
			//crear conjunto
			Console.WriteLine("\n*********************************************************");
			Console.WriteLine("CREO CONJUNTO");
			Conjunto conj= new Conjunto();
			conj.agregar(ClVconjunto2);
			conj.agregar(ClVconjunto);
			//probar metodos
			Console.WriteLine("cuantos "+conj.cuantos());
			conj.minimo();
			conj.maximo();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("\n*********************************************************");
			//crear diccionario
			Console.WriteLine("CREO DICCIONARIO");
			Diccionario dicc= new Diccionario();
			dicc.agregar(comparable1, n);
			Console.WriteLine("Agrego Clave: {0} valor: {1}",comparable1.getValor, n.getValor);
			
			dicc.agregar(a1, n2);
			Console.WriteLine("Agrego Clave: {0} valor: {1}",a1.getNombre, n2.getValor);
			
			Console.WriteLine("\npruebo clave agregada");
			dicc.agregar(comparable1,n2);
			Console.WriteLine("Agrego Clave: {0} valor: {1}",comparable1.getValor, n2.getValor);
			
			Console.WriteLine("\npruebo valorDe {0}",comparable1.getValor);
			Numero nValorDe=dicc.valorDe(comparable1);
			Console.WriteLine("el valor asociado es: "+ nValorDe.getValor);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("\n*********************************************************");
			Console.WriteLine("IMPRESORA");
			impresora i= new impresora();
			
			Console.WriteLine("IMPRIMIR CONJUNTO");
			i.imprimirElementos(conj);
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
			Console.WriteLine("\n__________________________________________________________");
			Console.WriteLine("IMPRIMIR PILA");
			i.imprimirElementos(p2);
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
			Console.WriteLine("\n__________________________________________________________");
			Console.WriteLine("IMPRIMIR COLA");
			i.imprimirElementos(col2);
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
			Console.WriteLine("\n__________________________________________________________");
			Console.WriteLine("IMPRIMIR DICCIONARIO");
			i.imprimirElementos(dicc);
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("\n*********************************************************");
			Console.WriteLine("9- CAMBIO DE ESTRATEGIA");
			Console.WriteLine("cambio coleccionable solo con alumnos");
			cambiarEstrategia(p2,"1");
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
			
			Console.WriteLine("\n_________________________________________________________");
			Console.WriteLine("cambio coleccionable sin alumnos");
			Cola c3= new Cola();
			llenarPersonas(c3);
			cambiarEstrategia(c3,"3");
			
			Console.WriteLine("\n*********************************************************");
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
					Console.WriteLine("Valor Máximo: "+((Numero)c.maximo()).getValor);
					break;
				case "practica2.Persona":
					Console.WriteLine("Nombre Mínimo: "+((Persona)c.minimo()).getNombre);
					Console.WriteLine("Nombre Máximo: "+((Persona)c.maximo()).getNombre);
					break;
				case "practica2.Alumno":
					Console.WriteLine("Legajo Mínimo: "+((Alumno)c.minimo()).getLegajo);
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
		
		public static void cambiarEstrategia(coleccionable c, string i){
			IteradorDePaginas ite = c.crearIterador();
			Console.WriteLine("cambiando estrategia ");
			while(! ite.fin()){
				if (ite.actual().GetType().ToString()=="practica2.Alumno") {
					((Alumno)ite.actual()).cambiarComparar(i);
					Console.WriteLine("Se cambio la estrategia a: "+((Alumno)ite.actual()).getNombre);
					ite.siguiente();
				}else{
					Console.WriteLine("No era alumno, no se pudo cambiar la estrategia");
					ite.siguiente();
				}
				
			}
			
		}
		
	}
}