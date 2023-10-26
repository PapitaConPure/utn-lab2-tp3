using System;
using System.Drawing;

namespace AlquilerLib {
	[Serializable]
	public class CasaFinde: Casa {
		public CasaFinde(int número, string dirección,int camas,int dni,string nombre, long tel, string apellido, Image[] imágenes): base(número,dirección,3,camas,dni,nombre,tel,apellido, imágenes) {}

		public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler)
				&& this.EsFinde(alquiler.CheckIn)
				&& alquiler.CheckOut.Day < alquiler.CheckIn.Day + 3;
		}

		private bool EsFinde(DateTime fecha) {
			return fecha.DayOfWeek == DayOfWeek.Friday;
		}
	}
}
