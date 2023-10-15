using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	abstract class Propiedad : IImprimible {
		private string dirección;
		private string[] servicios = new string[5];
		private int cServicios = 0;
		protected double precioBase;
		private int maxPasajeros;
		public int Número
		{
			get;private set;
		}
        public Propiedad(int número,string dirección,double precioBase)
		{
			this.Número = número;
			this.dirección = dirección;
			this.precioBase = precioBase;
		}
		public void AgregarServicio(string servicio)
		{
			servicios[cServicios++]= servicio;
		}
		public abstract double PrecioPorDía();
        public abstract string Imprimir();
	}
}
