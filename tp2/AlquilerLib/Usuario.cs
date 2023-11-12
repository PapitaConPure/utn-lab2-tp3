using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib
{
    public class Usuario
    {
        public string Nombre { get; }
        public string Contraseña { get; }
        public string Tipo { get; }
        public Usuario(string n, string c, string t)
        {
            Nombre = n;
            Contraseña = c;
            Tipo = t;
        }
    }
}
