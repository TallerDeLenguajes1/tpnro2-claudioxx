using System;
using System.Collections.Generic;
using System.Text;

namespace Distribuidora
{
	static class Helper
	{
		public static Tarea BusquedaPorId(int idBuscar, List<Tarea> listaTareas)
		{
			foreach (Tarea unaTarea in listaTareas)
			{
				if(unaTarea.Id == idBuscar)
				{
					return unaTarea;
				}
			}
			Console.WriteLine("No se Encontro la tarea");
			return null;
		}

		public static Tarea BusquedaPorPalabra(string palabraBuscar, List<Tarea> listaTareas)
		{
			foreach (Tarea unaTarea in listaTareas)
			{
				if (unaTarea.Descripcion.Contains(palabraBuscar))
				{
					return unaTarea;
				}
			}
			Console.WriteLine("No se Encontro la tarea");
			return null;
		}
	}
}
