using System;
using System.Collections.Generic;

namespace practica2
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: comparable
	{
		private string nombre;
		private int dni;
		private int legajo;
		private double promedio;		
		private EstrategiaComparacionAlumno comparar = new porLegajo();
		
		public Alumno(string nombre, int dni, int legajo, double promedio)
		{
			this.nombre=nombre;
			this.dni=dni;
			this.legajo=legajo;
			this.promedio=promedio;
		}
		public string getNombre{
			get{return nombre;}
		}
		public int getDni{
			get{return dni;}
		}
		public int getLegajo{
			get{return legajo;}
		}
		
		public double getPromedio{
			get{return promedio;}
		}
		public EstrategiaComparacionAlumno getComparar{
			get{return comparar;}
		}
		/// <summary>
	/// 1- legajo/ 2-Promedio/ 3-Dni/ 4-Nombre
	/// </summary>
		public void cambiarComparar(string  opcion){
			switch (opcion) {
				case "1":
					comparar= new porLegajo();
					Console.WriteLine("Compara por Legajo");
					break;
				case "2":
					comparar= new porPromedio();
					Console.WriteLine("Compara por Promedio");
					break;
				case "3":
					comparar= new porDni();
					Console.WriteLine("Compara por Dni");
					break;
				case "4":
					comparar= new porNombre();
					Console.WriteLine("Compara por Nombre");
					break;
			}
		}
		
		public bool soloIgual(comparable c){
			bool igual=false;
			Console.WriteLine("l:legajo o p:promedio");
			string opcion= Console.ReadLine();
			do {
				if (opcion=="l"){
					igual= ((Alumno)c).legajo==this.getLegajo;
					return igual;
				}
				if (opcion=="p"){
					igual=((Alumno)c).promedio==this.getPromedio;
					return igual;
				}
				Console.WriteLine("l:legajo o p:promedio");
				opcion= Console.ReadLine();
				
			}while (opcion!="l" || opcion!="p");
			return igual;
		}//fin sosIgual
		
		public bool soloMenor(comparable c){
			bool menor=false;
			Console.WriteLine("l:legajo o p:promedio");
			string opcion= Console.ReadLine();
			while (opcion=="l" || opcion=="p") {
				if (opcion=="l"){
					menor= ((Alumno)c).legajo>this.getLegajo;
					return menor;
				}
				if (opcion=="p") {
					menor= ((Alumno)c).promedio>this.getPromedio;
					return menor;
				}
			}
			return menor;
		}//fin sosMenor
		public bool soloMayor(comparable c){
			bool mayor=false;
			Console.WriteLine("l:legajo o p:promedio");
			string opcion= Console.ReadLine();
			while (opcion!="l" || opcion!="p") {
				if (opcion=="l"){
					mayor= ((Alumno)c).legajo<this.getLegajo;
					return mayor;
				}
				if (opcion=="p"){
					mayor= ((Alumno)c).promedio<this.getPromedio;
					return mayor;
				}
			}
			return mayor;
		}//fin sosMayor
		public bool sosMenor(comparable c){
			return comparar.sosMenor(c, this);
		}//fin soloMenor
		public bool sosMayor(comparable c){
			return comparar.sosMayor(c, this);
		}//fin soloMayor
		public bool sosIgual(comparable c){
			return comparar.sosIgual(c, this);
		}//fin sosIgual
		
	}
}
