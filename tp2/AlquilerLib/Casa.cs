using System;

namespace AlquilerLib {
	public class Casa: Propiedad, IImprimible {
		private int camasDisponibles;
		private string dirección;
		public int MínimoDías { get; }
		public int CamasDisponibles {
			get { return this.camasDisponibles; }
			set { this.camasDisponibles = value; }
        }
		
		public Casa(int número,string dirección): base(número) 
		{
			MínimoDías = 5;//es un ejemplo
            this.dirección = dirección;
        }

		///Cuestionar
		public  double PrecioPorDía(int nroAlquiler) {
			Alquiler alquiler = VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.FechaSalida.Subtract(alquiler.FechaEntrada);// Es lo mismo que fechasalida-fechaentrada
			return Sistema.PrecioBase * (1 + camasDisponibles * 0.07) * (1 + CServicios * 0.14) * (int)diferencia.TotalDays;
		}

		public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler);
		}

		public override string Imprimir() {
			return "uwu";
        }
    }
}
