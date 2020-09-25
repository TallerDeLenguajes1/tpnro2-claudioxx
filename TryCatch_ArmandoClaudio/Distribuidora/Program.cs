using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribuidora
{
	class Program
	{
		static public Random rand = new Random();

		static void Main(string[] args)
		{
			int cantTareas, i;
			List<Tarea> listaTareas = new List<Tarea>();
			List<Tarea> tareasRealizadas = new List<Tarea>();


			Console.Write("Ingrese la cantidad de tareas: ");
			cantTareas = Convert.ToInt32(Console.ReadLine());
			for (i = 0; i < cantTareas; i++)
			{
				Console.WriteLine("Ingrese la descripcion de la tarea " + (i + 1) + ":");
				string descripcion = Console.ReadLine();
				Tarea nuevaTarea = new Tarea(i + 1, descripcion, rand.Next(11, 100), estadoTarea.pendiente);
				listaTareas.Add(nuevaTarea);
			}

			Console.WriteLine("\nTareas:");
			foreach (Tarea tareaX in listaTareas)
			{
				Console.WriteLine(tareaX.Id + ":");
				tareaX.mostrarTarea();
				Console.Write("¿Esta tarea fue realizada? (S/N) : ");
				string respuesta = Console.ReadLine();
				if (respuesta == "S" || respuesta == "s")
				{
					tareaX.Estado = estadoTarea.realizada;
					int index = listaTareas.IndexOf(tareaX);
					tareasRealizadas.Add(listaTareas[index]);
				}
				Console.WriteLine("");
			}
			listaTareas.RemoveAll(tareaX => tareaX.Estado == estadoTarea.realizada);

			/*foreach (Tarea tareaX in listaTareas.Reverse<Tarea>())
			 {
				 if(tareaX.Estado == estadoTarea.realizada)
				 {
					 listaTareas.Remove(tareaX);
				 }
			 }*/

			 Console.WriteLine("\nTAREAS REALIZADAS:");
			foreach (Tarea tareaX in tareasRealizadas)
			{
				Console.WriteLine(tareaX.Id+ ":");
				tareaX.mostrarTarea();
			}

			Console.WriteLine("\nTAREAS PENDIENTES:");
			foreach (Tarea tareaX in listaTareas)
			{
				Console.WriteLine(tareaX.Id + ":");
				tareaX.mostrarTarea();
			}

			Console.Write("\nIngrese el id de la tarea a buscar: ");
			int idBuscar = Convert.ToInt32(Console.ReadLine());
			Tarea tareaEncontrada = Helper.BusquedaPorId(idBuscar, listaTareas);
			if (tareaEncontrada != null)
				tareaEncontrada.mostrarTarea();

			Console.Write("\nIngrese la palabra de la tarea a buscar: ");
			string palabraBuscar = Console.ReadLine();
			Tarea tareaEncontrada2 = Helper.BusquedaPorPalabra(palabraBuscar, listaTareas);
			if (tareaEncontrada != null)
				tareaEncontrada.mostrarTarea();
		}
	}
}
