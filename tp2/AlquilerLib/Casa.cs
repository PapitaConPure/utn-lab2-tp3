using System;

namespace AlquilerLib {
	class Casa: Propiedad, IImprimible {
		private int camasDisponibles;

		public int CamasDisponibles{
			get { return this.camasDisponibles; }
			set { this.camasDisponibles = value; }
		}

		public Casa(int número, string dirección, double precioBase): base(número, dirección) {}

		public  double PrecioPorDía(int nroAlquiler) {
			Alquiler alquiler = VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.FechaSalida.Subtract(alquiler.FechaEntrada);// Es lo mismo que fechasalida-fechaentrada
			return Sistema.PrecioBase * (1 + camasDisponibles * 0.07) * (1 + CServicios * 0.14) * (int)diferencia.TotalDays;
		}

        public override string Imprimir() {
			return "uwu";
        }
    }
}
