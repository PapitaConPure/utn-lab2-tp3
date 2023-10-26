using System;

namespace AlquilerLib {
	public class Casa: Propiedad, IImprimible {
		public int MínimoPermitido { get; }
		public int CamasDisponibles { get; private set; }
		Persona propietario;
		public Casa(int número,string dirección,int mínimoPermitido,int camasDisponibles, int dni, string nombre, long tel ,string apellido): base(número,dirección) 
		{
			this.CamasDisponibles= camasDisponibles;
			this.MínimoPermitido = mínimoPermitido;
			propietario = new Persona(dni, nombre, tel, apellido);
        }

		public  double PrecioPorDía(int nroAlquiler) {
			Alquiler alquiler = VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.FechaSalida.Subtract(alquiler.FechaEntrada);// Es lo mismo que fechasalida-fechaentrada
			return Sistema.PrecioBase * (1 + CamasDisponibles * 0.07) * (1 + CServicios * 0.14) * (int)diferencia.TotalDays;
		}

		public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler);
		}
    }
}
