/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 27/4/2024
 * Hora: 20:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	public interface EstrategiaComparacionAlumno{
		bool sosIgual(comparable c,comparable dis);
		bool sosMenor(comparable c,comparable dis);
		bool sosMayor(comparable c,comparable dis);
	}
	
	public class porLegajo : EstrategiaComparacionAlumno
	{
		public bool sosIgual(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getLegajo==((Alumno)dis).getLegajo;
			}else{return false;}
			
		}
		public bool sosMenor(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getLegajo>((Alumno)dis).getLegajo;
			}else{return false;}
		}
		public bool sosMayor(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getLegajo<((Alumno)dis).getLegajo;
			}else{return false;}
		}
	}
	public class porPromedio : EstrategiaComparacionAlumno
	{
		public bool sosIgual(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getPromedio.Equals(((Alumno)dis).getPromedio);
			}else{return false;}
		}
		public bool sosMenor(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getPromedio>((Alumno)dis).getPromedio;
			}else{return false;}
		}
		public bool sosMayor(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getPromedio<((Alumno)dis).getPromedio;
			}else{return false;}
		}
	}
	public class porDni : EstrategiaComparacionAlumno
	{
		public bool sosIgual(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getDni==((Alumno)dis).getDni;
			}else{return false;}
		}
		public bool sosMenor(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getDni>((Alumno)dis).getDni;
			}else{return false;}
		}
		public bool sosMayor(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getDni<((Alumno)dis).getDni;
			}else{return false;}
		}
	}
	public class porNombre : EstrategiaComparacionAlumno
	{
		public bool sosIgual(comparable c,comparable dis){
			if (c.GetType()==dis.GetType()) {
				return ((Alumno)c).getNombre==((Alumno)dis).getNombre;
			}else{return false;}
		}
		public bool sosMenor(comparable c,comparable dis){
			return false;
		}
		public bool sosMayor(comparable c,comparable dis){
			return false;;
		}
	}



	
}
