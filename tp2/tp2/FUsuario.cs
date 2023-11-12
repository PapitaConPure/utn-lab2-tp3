using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AlquilerLib;

namespace tp2
{
    public partial class FUsuario : Form
    {
        public FUsuario()
        {
            InitializeComponent();
        }
        Sistema sistema;
        public FUsuario(Sistema s) : this()
        {
            sistema = s;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text, contraseña=tbContraseña.Text;
            Usuario aux;
            bool encontro=false;
            bool admin = false;
            int cantidad = sistema.Usuarios.Count, contador=0;
            while (contador<cantidad && !encontro)
            {
                if (sistema.Usuarios[contador].Contraseña == contraseña
                   && sistema.Usuarios[contador].Nombre == usuario)
                {
                    encontro = true;
                    aux = sistema.Usuarios[contador];
                    if (aux.Tipo == "Administrador")
                    {
                        admin = true;
                    }
                }
                contador++;
            }
            if(encontro && admin)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (encontro)
            {
                this.DialogResult = DialogResult.Yes;
            }
            if(!encontro)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Contraseña o usuario invalido", "Error");
            }
        }
    }
}
