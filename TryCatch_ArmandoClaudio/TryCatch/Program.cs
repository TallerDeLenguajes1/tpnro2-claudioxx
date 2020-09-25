using NLog;
using System;

namespace Ejercicio1
{
	class Program
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			
			Console.WriteLine("Insertar numero entero:");
			try
			{
				int num = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("El cuadrado de " + num + " es: " + Math.Pow(num, 2));
			}
			catch (Exception ex)
			{
				Logger.Error("se produjo " + ex.GetType());
				Console.WriteLine(ex.Message);
				Console.WriteLine("Ocurrio un error");
			}
		}
	}
}
