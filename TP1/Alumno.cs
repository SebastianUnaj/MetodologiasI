using System;
using System.Collections.Generic;

namespace TP1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: IPersona, comparable
	{
		private string nombre;
		private int dni;
		private int legajo;
		private double promedio;		
		
		public Alumno(string nombre, int dni, int legajo, double promedio)
		{
			this.nombre=nombre;
			this.dni=dni;
			this.legajo=legajo;
			this.promedio=promedio;
		}
		
		public int getLegajo{
			get{return legajo;}
		}
		
		public double getPromedio{
			get{return promedio;}
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
			return ((Alumno)c).promedio>this.getPromedio;
		}//fin soloMenor
		public bool sosMayor(comparable c){
			return ((Alumno)c).promedio<this.getPromedio;
		}//fin soloMayor
		public bool sosIgual(comparable c){
			return ((Alumno)c).legajo==this.getLegajo;
		}//fin sosIgual
		
	}
}
