using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib.Constructores {
	/// <summary>
	/// Representa los datos de una <see cref="Persona"/>.
	/// Sirve para pasar datos de forma compacta
	/// </summary>
	public sealed class DatosPersona {
		public int Dni;
		public string Nombre;
		public string Apellido;
		public long Teléfono;
		public DateTime FechaNacimiento;

		public DatosPersona(int dni, string nombre, string apellido, long teléfono) {
			this.Dni = dni;
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Teléfono = teléfono;
		}

		public DatosPersona(int dni, string nombre, string apellido, DateTime fecha)
		{
			this.Dni = dni;
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.FechaNacimiento = fecha;
		}
	}
}
