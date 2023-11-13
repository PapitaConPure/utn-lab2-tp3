using System;
using System.Collections.Generic;
using System.IO;
using AlquilerLib.Utilidades;

namespace AlquilerLib {
	/// <summary>
	/// Representa un sistema de alquileres
	/// </summary>
	[Serializable]
	public class Sistema {
		static int nroResidencia = 0;

		public Usuario UsuarioActual { get; set; }
		List<Usuario> usuarios = new List<Usuario>();
		public List<Usuario> Usuarios { get { return this.usuarios; } }
		public Usuario VerUsuario(string n, string c)
        {
			Usuario usuario=null;
			bool encontro = false;
			int i=0;
			while(!encontro && i < Usuarios.Count)
            {
				if (Usuarios[i].Nombre == n && Usuarios[i].Contraseña == c)
				{ 
					encontro = true;
					usuario = Usuarios[i];
				}
				i++;
            }
			return usuario;
        }
		public void AgregarUsuario(Usuario nuevo)
        {
			usuarios.Add(nuevo);
        }
		public void EliminarUsuario(Usuario aEliminar)
        {
			usuarios.Remove(aEliminar);
        }

		private readonly List<Residencia> residencias;
		private int nroResidenciaSerializado;

		/// <summary>
		/// Crea un sistema de alquileres con una lista de residencias vacía
		/// </summary>
		/// <param name="precioBase">Residencia a incorporar</param>
		public Sistema(double precioBase) {
			this.residencias = new List<Residencia>();
			this.PrecioBase = precioBase;
			this.usuarios = new List<Usuario>();
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

			return propiedad.QuitarAlquiler(nroAlquiler);
		}

		public bool ModificarAlquiler(int nroResidencia, int nroAlquiler, DateTime checkin, DateTime checkout)
        {
			Residencia propiedad = this.VerResidencia(nroResidencia);
			if (propiedad is null)
				return false;
            else
            {
				Alquiler alq = propiedad.VerAlquiler(nroAlquiler);
				if (alq is null)
					return false;

				alq.Modificar(checkin, checkout);
				return true;
            }
		}

		public void CargarNroResidenciaSerializado() {
			nroResidencia = this.nroResidenciaSerializado;
		}

		public void GuardaNúmeroResidenciaSerializado() {
			this.nroResidenciaSerializado = nroResidencia;
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

					Residencia residencia = this.VerResidencia(Convert.ToInt32(datos[0]));
                    
                    if (datos.Length == 12 && residencia != null) {
						if(residencia.Alquilar(
						  Convert.ToInt32(datos[1]),
						  Convert.ToDateTime(datos[7]),
						  Convert.ToDateTime(datos[8]),
						  Convert.ToDateTime(datos[9]),
						  Convert.ToInt32(datos[6]),
						  Convert.ToInt32(datos[2]),
						  datos[3],
						  datos[4],
						  Convert.ToInt64(datos[5]),
						  this.PrecioBase,
						  out _)) {
							
						} else 
							throw new InvalidOperationException($"El alquiler ya existe (Línea {n})");
					} else
						throw new ArgumentException($"Residencia o cantidad de datos inválida (Línea {n})");
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
                if (File.Exists(ruta)) { File.Delete(ruta); }
                fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
				sw = new StreamWriter(fs);

				foreach(Residencia residencia in this.Residencias) {
					foreach(Alquiler alquiler in residencia.Alquileres) {
						sw.WriteLine(alquiler.Exportar());
					}
					//residencia.LimpiarAlquileres();
				}
			} finally {
				if(fs != null) {
					if(sw != null)
						sw.Close();

					fs.Close();
				}
			}
		}
		public void GuardarLista(string ruta)
        {
			FileStream fs = null;
			StreamWriter sw = null;
			try
			{
				if (File.Exists(ruta)) { File.Delete(ruta); }
				fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
				sw = new StreamWriter(fs);
				List<Alquiler> alq = new List<Alquiler>();
				List<Cliente> cl = new List<Cliente>();
				foreach (Residencia residencia in residencias)
				{
					foreach (Alquiler alquiler in residencia.Alquileres)
					{
						alq.Add(alquiler);
						cl.Add(alquiler.Cliente);
					}
				}
				sw.WriteLine("Alquileres");
				sw.WriteLine(string.Join(";","Id alojamiento","Dni cliente","CheckIn","Checkout"));
				foreach (Alquiler alquiler in alq)
				{
					sw.WriteLine(alquiler.Guardar());
				}
				sw.WriteLine("Clientes");
				sw.WriteLine(string.Join(";", "Dni Cliente", "Nombre", "Apellido"));
				foreach(Cliente c in cl)
                {
					sw.WriteLine(c.Guardar());
                }
					//residencia.LimpiarAlquileres();
				
			}
			finally
			{
				if (fs != null)
				{
					if (sw != null)
						sw.Close();

					fs.Close();
				}
			}
		}

		public bool VerificarDni(int dni)
		{
			if (dni < 10000000 || dni > 80000000)
			{
				throw new DniException("El dni es invalido");
			}
			else
				return true;
		}
	}
}
