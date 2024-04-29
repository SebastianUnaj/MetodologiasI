/*
 * Creado por SharpDevelop.
 * Usuario: Seba Cacere
 * Fecha: 26/4/2024
 * Hora: 23:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica2
{
	/// <summary>
	/// Description of Random.
	/// </summary>
	public class RandomUnico
	{
		private Random randomUnicoDeInstancia = new Random();
		
		public RandomUnico(Random r = null){
			if(r != null)
				randomUnicoDeInstancia = r;
		}
		
		public int numeroRandom(){
			return (int)(randomUnicoDeInstancia.Next(100));
		}
		public int dniRandom(){
			return (int)(randomUnicoDeInstancia.Next(1000000,99999999));
		}
		public int legajoRandom(){
			return (int)(randomUnicoDeInstancia.Next(1000,99999));
		}
		public double promedioRandom(){
			return (double)(randomUnicoDeInstancia.Next(0,1));
		}
		public void testRandomUnico()
		{
			for(int x = 1; x <= 10; x++)
				Console.Write(randomUnicoDeInstancia.Next(100) + " - ");
			Console.WriteLine("\n");
		}
		
		public void testRandomSerieRepetida()
		{
			Random randomSerieRepetida = new Random();
			for(int x = 1; x <= 10; x++)
				Console.Write(randomSerieRepetida.Next(100) + " - ");
			Console.WriteLine("\n");
		}
		
		public void testRandomIguales()
		{
			for(int x = 1; x <= 10; x++){
				Random randomIguales = new Random();
				Console.Write(randomIguales.Next(100) + " - ");
			}
			Console.WriteLine("\n");
		}
	}
}
