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
using System.Drawing.Text;

namespace tp2
{
    public partial class FUsuario : Form
    {
        private readonly Sistema sistema;

        public FUsuario() {
            this.InitializeComponent();
        }

        public FUsuario(Sistema s): this() {
            this.sistema = s;
		}

		private void FUsuario_Load(object sender, EventArgs e) {
			this.gbUsuario.Font = new Font(Estilos.LatoBlack, 9);
			this.gbContraseña.Font = new Font(Estilos.LatoBlack, 9);
		}

		private void FUsuario_Shown(object sender, EventArgs e) {
			if(this.rbEmpleado.CanFocus)
				this.rbEmpleado.Focus();
			else if(this.tbUsuario.CanFocus)
				this.tbUsuario.Focus();
			else if(this.tbContraseña.CanFocus)
				this.tbContraseña.Focus();

			if(this.btnIngresar.Visible)
				this.AcceptButton = this.btnIngresar;
			else
				this.AcceptButton = this.btnAceptar;
		}

		private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text, contraseña = tbContraseña.Text;
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

		#region Arrastrado con mouse
		private bool arrastraVentana = false;
		private Point arrastreMouse;

		private void FUsuario_MouseDown(object sender, MouseEventArgs e) {
			this.arrastraVentana = true;
			this.arrastreMouse = this.PointToClient(MousePosition);
		}

		private void FUsuario_MouseUp(object sender, MouseEventArgs e) {
			this.arrastraVentana = false;
		}

		private void FUsuario_MouseMove(object sender, MouseEventArgs e) {
			if(this.arrastraVentana)
				this.Location = new Point(
					MousePosition.X - this.arrastreMouse.X,
					MousePosition.Y - this.arrastreMouse.Y);
		}
		#endregion

		#region Calidad de vida
		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}
		#endregion
	}
}
