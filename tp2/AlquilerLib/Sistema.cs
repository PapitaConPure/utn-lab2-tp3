using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	/// <summary>
	/// Representa un sistema de alquileres
	/// </summary>
	[Serializable]
	public class Sistema {
		private List<Residencia> residencias;

		/// <summary>
		/// Crea un sistema de alquileres con una lista de residencias vacía
		/// </summary>
		/// <param name="precioBase">Residencia a incorporar</param>
		public Sistema(double precioBase) {
			this.residencias = new List<Residencia>();
			this.PrecioBase = precioBase;
		}

		/// <summary>
		/// El precio base con el que trabajan todas las residencias del sistema
		/// </summary>
		public double PrecioBase { get; private set; }

		/// <summary>
		/// Vector de todos los objetos <see cref="Residencia"/> actuales del sistema
		/// </summary>
		/// <remarks>Se realiza una copia de todas las referencias al llamar la propiedad. Llamar con cuidado</remarks>
		public Residencia[] Residencias {
			get { return this.residencias.ToArray(); }
		}

		/// <summary>
		/// Agrega una residencia al sistema
		/// </summary>
		/// <param name="propiedad">Residencia a incorporar</param>
		public void AgregarResidencia(Residencia propiedad) {
			this.residencias.Add(propiedad);
		}

		/// <summary>
		/// Quita la <see cref="Residencia"/> bajo el número indicado
		/// </summary>
		/// <param name="nroResidencia"></param>
		/// <returns><see langword="true"/> si se pudo quitar la <see cref="Residencia"/></returns>
		public bool QuitarResidencia(int nroResidencia) {
			Residencia propiedad = this.VerResidencia(nroResidencia);
			if(propiedad != null) {
				this.residencias.Remove(propiedad);
				return true;
			} else {
				return false;
			}
		}

		/// <summary>
		/// Consulta una propiedad por número de residencia
		/// </summary>
		/// <param name="nroResidencia">Número de residencia a buscar</param>
		/// <returns>La <see cref="Residencia"/> bajo el número indicado, o <see langword="null"/> si no se encuentra</returns>
		public Residencia VerResidencia(int nroResidencia) {
			this.residencias.Sort();

			Residencia buscada = new Casa(nroResidencia);
			int idx = this.residencias.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.residencias[idx];
		}

		/// <summary>
		/// Alquila la <see cref="Residencia"/> bajo el número indicado si existe
		/// </summary>
		/// <param name="nroResidencia">Número de la residencia a alquilar</param>
		/// <param name="alquiler">Alquiler a relacionar con la propiedad</param>
		/// <returns><see langword="true"/> si se pudo alquilar la <see cref="Residencia"/></returns>
		public bool AlquilarResidencia(int nroResidencia, DateTime fechaReserva, DateTime checkIn, DateTime checkOut, int cantPasajeros, int dni, string nombre, string apellido, long tel) {
			Residencia residencia = this.VerResidencia(nroResidencia);

            if(residencia is null)
                return false;

			return residencia.Alquilar(fechaReserva, checkIn, checkOut, cantPasajeros, dni, nombre, apellido, tel, this.PrecioBase, out _);
		}

		/// <summary>
		/// Cancela el alquiler indicado para la residencia indicada
		/// </summary>
		/// <param name="nroResidencia"></param>
		/// <param name="nroAlquiler"></param>
		/// <returns><see langword="true"/> si se pudo cancelar el alquiler</returns>
		public bool CancelarAlquiler(int nroResidencia, int nroAlquiler) {
			Residencia propiedad = this.VerResidencia(nroResidencia);

			if(propiedad is null)
				return false;

			propiedad.QuitarAlquiler(nroAlquiler);
			return true;
		}

		public void ImportarAlquileres(string ruta) {
			FileStream fs = null;
			StreamReader sr = null;

			try {
				fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
				sr = new StreamReader(fs);

				int n = 0;
				string linea;
				while(!sr.EndOfStream) {
					linea = sr.ReadLine();
					n++;
					string[] datos = linea.Split(';');
					if(datos.Length == 8) {
						if(!this.AlquilarResidencia(
						Convert.ToInt32(datos[0]),
						Convert.ToDateTime(datos[6]),
						Convert.ToDateTime(datos[7]),
						Convert.ToDateTime(datos[8]),
						Convert.ToInt32(datos[5]),
						Convert.ToInt32(datos[1]),
						datos[2],
						datos[3],
						Convert.ToInt64(datos[4]))) {
							throw new InvalidOperationException($"El alquiler ya existe (Línea {n})");
						}
					} else
						throw new ArgumentException($"Cantidad de datos inválida (Línea {n})");
				}
			} finally {
				if(fs != null) {
					if(sr != null)
						sr.Close();

					fs.Close();
				}
			}
		}

		public void ExportarAlquileres(string ruta) {
			FileStream fs = null;
			StreamWriter sw = null;

			try {
				fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);
				sw = new StreamWriter(fs);

				foreach(Residencia residencia in this.Residencias) {
					foreach(Alquiler alquiler in residencia.Alquileres) {
						sw.WriteLine(alquiler.Imprimir());
					}
				}
			} finally {
				if(fs != null) {
					if(sw != null)
						sw.Close();

					fs.Close();
				}
			}
		}
	}
}
