using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib
{
    [Serializable]
    public class Usuario
    {
        public string Nombre { get; }
        public string Contraseña { get; private set; }
        public string Tipo { get; }
        public Usuario(string n, string c, string t)
        {
            Nombre = n;
            Contraseña = c;
            Tipo = t;
        }
        public void CambiarContraseña(string nueva)
        {
            this.Contraseña = nueva;
        }
    }
}
