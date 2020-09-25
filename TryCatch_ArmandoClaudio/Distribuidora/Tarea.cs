using System;

namespace Distribuidora
{
	public enum estadoTarea
	{
		pendiente = 0,
		realizada = 1,
	}

	class Tarea
	{
		private int id;
		private string descripcion;
		private int duracion;
		private estadoTarea estado;

		public Tarea(int id, string descripcion, int duracion, estadoTarea estado)
		{
			Id = id;
			Descripcion = descripcion;
			Duracion = duracion;
			Estado = estado;
		}
		public int Id { get => id; set => id = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public int Duracion { get => duracion; set => duracion = value; }
		public estadoTarea Estado { get => estado; set => estado = value; }

		public void mostrarTarea()
		{
			Console.WriteLine("ID: " + id);
			Console.WriteLine("Descripcion: " + descripcion);
			Console.WriteLine("Duracion: " + duracion);
		}

	}
}
