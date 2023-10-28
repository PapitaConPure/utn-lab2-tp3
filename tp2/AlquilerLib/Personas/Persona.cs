﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using AlquilerLib.Utilidades;

namespace AlquilerLib {
	[Serializable]
	public class Persona: IExportable {
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
		public Persona(int dni, string nombre, string apellido, long tel) {
			this.Dni = dni;
			this.Nombre = nombre;
			this.Teléfono = tel;
			this.Apellido = apellido;
		}

		public int Dni { get; private set; }

		public string Apellido {
			get { return this.apellido; }
			private set {
				value = value.Trim();

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
				value = value.Trim();

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
	}
}
