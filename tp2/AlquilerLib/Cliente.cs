using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	class Cliente {
		public int Dni{get;private set;}
		public string Nombre{get;private set;}
		public string Apellido{get;private set;}
		public string Género{get;private set;}
		public int Tel{get;private set;}
		public string Dirección{ get; private set; }
		public Cliente(int dni,string nombre,string apellido,string género,int tel,string dirección)
		{
			this.Dni = dni;
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Género = género;
			this.Tel = tel;
			this.Dirección = dirección;
		}

	}
}
