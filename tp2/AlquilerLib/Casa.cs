using System;

namespace AlquilerLib {
	class Casa: Propiedad, IImprimible {
		private int camasDisponibles;
		public int CamasDisponibles{get { return camasDisponibles; }set { camasDisponibles = value; }}
		public Casa(int número,string dirección,double precioBase):base(número,dirección,precioBase)
		{

		}
		public  double PrecioPorDía(int nroAlquiler)
		{
			Alquiler alquiler = VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.FechaSalida.Subtract(alquiler.FechaEntrada);// Es lo mismo que fechasalida-fechaentrada
			return precioBase*(int)diferencia.TotalDays;
		}
        public override string Imprimir()
        {
			return "uwu";
        }
    }
}
