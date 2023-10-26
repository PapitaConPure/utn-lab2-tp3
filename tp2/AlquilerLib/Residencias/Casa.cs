using System;
using System.Drawing;

namespace AlquilerLib {
	[Serializable]
	public class Casa: Residencia, IImprimible {
		public int MínimoPermitido { get; private set; }
		public int CamasDisponibles { get; private set; }
		public Persona Propietario;
		public Casa(int número,string dirección,int mínimoPermitido,int camasDisponibles, int dni, string nombre, long tel ,string apellido, Image[] imágenes): base(número, dirección, imágenes) 
		{
			this.CamasDisponibles= camasDisponibles;
			this.MínimoPermitido = mínimoPermitido;
			this.Propietario = new Persona(dni, nombre, tel, apellido);
        }

		public override double PrecioPorDía(int nroAlquiler) {
			//Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			//TimeSpan diferencia = alquiler.CheckOut.Subtract(alquiler.CheckIn); //Es lo mismo que fechasalida-fechaentrada
			return (1 + this.CamasDisponibles * 0.07) * (1 + this.CServicios * 0.14);
		}

        public override double PrecioTotal(int nroAlquiler)
        {
			Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.CheckOut.Subtract(alquiler.CheckIn);
			double PrecioFinal = this.PrecioPorDía(nroAlquiler) * (diferencia.Days-this.MínimoPermitido) * 0.9 + this.PrecioPorDía(nroAlquiler) * this.MínimoPermitido;
			return PrecioFinal;
        }

        public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler);
		}

		public void ModificarDias(int dias)
        {
			this.MínimoPermitido = dias;
        }
		public void ModificarCamas(int camas)
        {
			this.CamasDisponibles = camas;
		}

		public override string ToString()
        {
			return $"Casa: {this.Dirección}, {this.Número}";
        }
    }
}
