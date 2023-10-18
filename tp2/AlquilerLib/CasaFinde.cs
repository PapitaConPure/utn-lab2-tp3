using System;

namespace AlquilerLib {
	public class CasaFinde: Casa {
		public CasaFinde(int número, string dirección): base(número,dirección) {

		}
		public bool EsIntervaloVálido(DateTime inicio,DateTime fin)
		{
			return inicio <= fin;
		}
		private bool EsFinde(DateTime fecha)
		{
			return fecha.DayOfWeek == DayOfWeek.Friday;
		}

		public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler)
				&& this.EsFinde(alquiler.FechaEntrada)
				&& alquiler.FechaSalida.Day < alquiler.FechaEntrada.Day + 3;
		}
	}
}
