using System;
using System.Drawing;
using System.Windows.Forms;
using UtilidadesForms;

namespace tp2 {
    public partial class FPasajero: Form {
        public FPasajero() {
            this.InitializeComponent();
			new ArrastradorVentana(this);
		}

		private void FPasajero_Load(object sender, EventArgs e) {
			this.gbDni.Font = new Font(Estilos.LatoBlack, 9);
			this.gbApellido.Font = new Font(Estilos.LatoBlack, 9);
			this.gbNombre.Font = new Font(Estilos.LatoBlack, 9);
			this.gbFechaNacimiento.Font = new Font(Estilos.LatoBlack, 9);
		}

		private void FPasajero_Shown(object sender, EventArgs e) {
			this.nudDniPasajero.Focus();
			this.nudDniPasajero.Select(0, 20);
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
