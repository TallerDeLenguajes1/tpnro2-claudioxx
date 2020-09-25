using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NLog;

namespace Empleado
{
	class Program
	{
		private static Logger Logger = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			List<Empleado> empleados = new List<Empleado>();
			try
			{				
				empleados.Add(generarEmpleado());
			}
			catch (Exception ex)
			{
				Logger.Error("se produjo " + ex.ToString() + "\n *****DIVISION EN 0*****");
				Console.WriteLine("Ocurrio un error: " + ex.Message + "\n");
			}

			foreach (Empleado unEmpleado in empleados)
			{
				unEmpleado.mostrarEmpleado();
			}
		}

		public static Empleado generarEmpleado()
		{
			Console.Write("NUEVO EMPLEADO:\n\tapellido y nombre: ");
			string apellNombre_nuevo = Console.ReadLine();
			Console.Write("\tedad: ");
			int edad_nuevo = Convert.ToInt32(Console.ReadLine());
			Console.Write("\tdireccion: ");
			string direccion_nuevo = Console.ReadLine();
			Console.Write("\t  numero de calle: ");
			int numCalle_nuevo = Convert.ToInt32(Console.ReadLine());
			Console.Write("\tfecha de ingreso (dd/mm/aaaa) : ");
			DateTime fechaIngreso_nuevo = Convert.ToDateTime(Console.ReadLine());
			Console.Write("\tsalario: ");
			float sueldo_nuevo = float.Parse(Console.ReadLine());
			Empleado unEmpleado = new Empleado(apellNombre_nuevo, edad_nuevo, direccion_nuevo, numCalle_nuevo, fechaIngreso_nuevo, sueldo_nuevo);
			unEmpleado.suministrarInfo();
			return unEmpleado;
		}
	}
}
