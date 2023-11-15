using System;
using System.Text.RegularExpressions;
using AlquilerLib.Constructores;
using AlquilerLib.Utilidades;

namespace AlquilerLib {
	[Serializable]
	public class Persona: IExportable, IGuardable {
		private static readonly Regex regexLetras = new Regex("[A-Za-zÁÉÍÓÚáéíóú ]+");

		private string apellido;
		private string nombre;

		/// <summary>
		/// Crea una nueva persona con los datos personales especificados
		/// </summary>
		/// <param name="dni">DNI de la persona</param>
		/// <param name="nombre">Nombre de la persona</param>
		/// <param name="tel">Teléfono de la persona</param>
		/// <param name="apellido">Apellido de la persona</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FormatException"></exception>
		public Persona(DatosPersona datos) {
			this.Dni = datos.Dni;
			this.Nombre = datos.Nombre;
			this.Teléfono = datos.Teléfono;
			this.Apellido = datos.Apellido;
			this.FechaNacimiento = datos.FechaNacimiento;
		}
		

		public int Dni { get; private set; }
		public DateTime FechaNacimiento { get; private set; }

		public string Apellido {
			get { return this.apellido; }
			private set {
				value = value.Trim().Substring(0, 16);

				if(value.Length == 0)
					throw new ArgumentException("El apellido no puede estar vacío");

				if(!regexLetras.IsMatch(value))
					throw new FormatException("El apellido solo puede tener letras");

				this.apellido = Texto.CapitalizarPalabras(value);
			}
		}

		public string Nombre {
			get { return this.nombre; }
			set {
				value = value.Trim().Substring(0, 16);

				if(value.Length == 0)
					throw new ArgumentException("El nombre no puede estar vacío");

				if(!regexLetras.IsMatch(value))
					throw new FormatException("El nombre solo puede tener letras");

				this.nombre = Texto.CapitalizarPalabras(value);
			}
		}

		public long Teléfono { get; set; }

		public virtual string Exportar() {
			return string.Join(";", this.Dni, this.Nombre, this.Apellido, this.Teléfono);
		}

		public virtual string Guardar()
        {
			return string.Join(";", this.Dni, this.Nombre, this.Apellido);
		}
	}
}
