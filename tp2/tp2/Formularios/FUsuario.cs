using System;
using System.Drawing;
using System.Windows.Forms;
using AlquilerLib;
using UtilidadesForms;

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
			new ArrastradorVentana(this);
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
            int cantidad = this.sistema.Usuarios.Count, contador=0;
            while (contador<cantidad && !encontro)
            {
                if (this.sistema.Usuarios[contador].Contraseña == contraseña
                   && this.sistema.Usuarios[contador].Nombre == usuario)
                {
                    encontro = true;
                    aux = this.sistema.Usuarios[contador];
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
