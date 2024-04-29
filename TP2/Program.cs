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
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}