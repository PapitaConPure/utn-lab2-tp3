﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	/// <summary>
	/// Representa un sistema de alquileres
	/// </summary>
	[Serializable]
	public class Sistema {
		/// <summary>
		/// El precio base con el que trabajan todas las propiedades del sistema
		/// </summary>
		public static double PrecioBase;
		List<Residencia> propiedades;

		/// <summary>
		/// Crea un sistema de propiedades con una lista de propiedades vacía
		/// </summary>
		public Sistema() {
			this.propiedades = new List<Residencia>();
		}

		/// <summary>
		/// Agrega una propiedad al sistema
		/// </summary>
		/// <param name="propiedad">propiedad a incorporar</param>
		public void AgregarPropiedad(Residencia propiedad) {
			this.propiedades.Add(propiedad);
		}

		/// <summary>
		/// Consulta una propiedad por número de propiedad
		/// </summary>
		/// <param name="nroPropiedad">número de propiedad a buscar</param>
		/// <returns>La <see cref="Residencia"/> bajo el número indicado, o <see langword="null"/> si no se encuentra</returns>
		public Residencia VerPropiedad(int número) {
			this.propiedades.Sort();

			Residencia buscada = new Casa(número, "",0,0,0,"",0,"", new Image[] { });
			int idx = this.propiedades.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.propiedades[idx];
		}

		/// <summary>
		/// Alquila la propiedad bajo el número indicado si existe
		/// </summary>
		/// <param name="nroPropiedad">número de la propiedad a alquilar</param>
		/// <param name="alquiler">alquiler a relacionar con la propiedad</param>
		/// <returns><see langword="true"/> si se pudo alquilar la <see cref="Residencia"/></returns>
		/// 

		public bool AlquilarPropiedad(int nroPropiedad, Alquiler alquiler) {
			Residencia propiedad = this.VerPropiedad(nroPropiedad);

            if (propiedad is null)
                return false;

            if (!propiedad.PuedeAlquilar(alquiler))
				return false;

			propiedad.Alquilar(alquiler);
			return true;
		}
		public bool QuitarPropiedad(int nroPropiedad)
		{
			Residencia propiedad = this.VerPropiedad(nroPropiedad);
			if (propiedad != null)
			{
				this.propiedades.Remove(propiedad);
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// Cancela el alquiler indicado para la propiedad indicada
		/// </summary>
		/// <param name="nroPropiedad"></param>
		/// <param name="nroAlquiler"></param>
		/// <returns><see langword="true"/> si se pudo cancelar el Alquiler</returns>
		public bool CancelarAlquiler(int nroPropiedad, int nroAlquiler) {
			Residencia propiedad = this.VerPropiedad(nroPropiedad);

			if(propiedad is null)
				return false;

			propiedad.QuitarAlquiler(nroAlquiler);
			return true;
		}
		
	}
}
