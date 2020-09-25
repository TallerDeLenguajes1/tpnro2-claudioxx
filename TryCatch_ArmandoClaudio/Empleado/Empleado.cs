using System;
using System.Collections.Generic;
using System.Text;

namespace Empleado
{
	class Empleado
	{
		private string apellNombre;
		private int edad;
		private string direccion;
		private int numCalle;
		private DateTime fechaIngreso;
		private float sueldoBasico;
		private float salario;
		private bool casado;
		private int cantHijos;
		private bool divorciado;
		private DateTime fechaDivorcio;
		private bool universitario;
		private string titulo;
		private string universidad;

		public Empleado(string apellNombre, int edad , string direccion , int numCalle , DateTime fechaIngreso, float sueldoBasico)
		{
			this.ApellNombre = apellNombre;
			this.Edad = edad;
			this.Direccion = direccion;
			this.NumCalle = numCalle;
			this.FechaIngreso = fechaIngreso;
			this.sueldoBasico = sueldoBasico;
		}

		public string ApellNombre { get => apellNombre; set => apellNombre = value; }
		public int Edad { get => edad; set => edad = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int NumCalle { get => numCalle; set => numCalle = value; }
		public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
		public float Salario { get => salario; set => salario = value; }

		public int calcularAntiguedad()
		{
			int antiguedad = DateTime.Now.Year - this.fechaIngreso.Year;
			return antiguedad;
		}

		public float calcularSalario()
		{
			float adicional;
			float descuento = (float)(0.15 * this.sueldoBasico);
			if(calcularAntiguedad() < 20) {
				adicional = calcularAntiguedad() / 100 * this.sueldoBasico;
			}else {
				adicional = (float)(0.25 * this.sueldoBasico);
			}
			this.salario = this.sueldoBasico + adicional - descuento;
			return this.salario;
		}

		private bool respuesta(string pregunta)
		{
			while (true)
			{
				Console.Write("¿" +pregunta+ "? (S/N): " );
				string respuesta = Console.ReadLine().ToLower();
				if (respuesta.Equals("s") || respuesta.Equals("si"))
				{
					return true;
				}
				else if (respuesta.Equals("n") || respuesta.Equals("no"))
				{
					return false;
				}
				Console.WriteLine("Respuesta incorrecta. Reingrese su respuesta:");
			}
		}	

		public void suministrarInfo()
		{
			Console.WriteLine("\nSuministrar la siguiente informacion:");
			if( this.casado = respuesta("Es casado") == true)
			{
				Console.Write("  Cantidad de hijos: ");
				this.cantHijos = Convert.ToInt32(Console.ReadLine());
			}
			if (this.casado = respuesta("Es divorciado") == true)
			{
				Console.Write("  Fecha del divorcio (dd/mm/aaaa) : ");
				this.fechaDivorcio = Convert.ToDateTime(Console.ReadLine());
			}
			if (this.casado = respuesta("Tiene titutlo universitario") == true)
			{
				Console.WriteLine("  titulo: ");
				this.titulo = Console.ReadLine();
				Console.WriteLine("  universidad: ");
				this.universidad = Console.ReadLine();
			}
		}

		public void mostrarEmpleado()
		{
			Console.WriteLine("\npellido y nombre: " +this.apellNombre+ "\nedad:" +this.edad+ "\nAntiguedad: " +this.calcularAntiguedad()+ "\nSalario: " +this.calcularSalario()+ "\n");
		}

	}
}
