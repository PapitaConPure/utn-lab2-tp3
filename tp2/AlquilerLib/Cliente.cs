using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public class Cliente:Persona {
		public int CantPasajeros
		{
			get;
		}
		public Cliente(int cantPasajeros,int dni,string nombre,string apellido,int tel):base(dni,nombre,tel,apellido) 
		{
		CantPasajeros=cantPasajeros;
		}

	}
}
