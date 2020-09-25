using System;
using NLog;

namespace Ejercicio2
{
	class Program
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			Console.WriteLine("Insertar dos numeros para dividir:");
			try
			{
				Console.Write("DIVIDENDO: ");
				int num = Convert.ToInt32(Console.ReadLine());
				Console.Write("DIVISOR: ");
				int num2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(num + " dividido en " +num2+ " = " + num/num2);
			}
			catch (Exception ex)
			{
				Logger.Error("se produjo " + ex.ToString()+ "\n *****ERROR AL CREAR UN OBJETO EMPLEADO*****");
				Console.WriteLine("Ocurrio un error: " +ex.Message+ "\n");
			}
		}
	}
}
