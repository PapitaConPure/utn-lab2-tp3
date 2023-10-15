using System;

namespace AlquilerLib {
	class CasaFinde: Casa {
		public CasaFinde(int número,string dirección,double precioBase):base(número,dirección,precioBase)
		{

		}
		public bool EsIntervaloVálido(DateTime inicio,DateTime fin)
		{
			return inicio <= fin;
		}
		private bool EsFinde(DateTime fecha)
		{
			return fecha.DayOfWeek == DayOfWeek.Friday;
        }
	}
}
