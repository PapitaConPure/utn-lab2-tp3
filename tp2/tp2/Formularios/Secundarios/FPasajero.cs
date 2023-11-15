using System;
using System.Drawing;
using System.Windows.Forms;

namespace tp2 {
    public partial class FPasajero: Form {
        public FPasajero() {
            this.InitializeComponent();
        }

		private void FPasajero_Load(object sender, EventArgs e) {
			this.gbDni.Font = new Font(Estilos.LatoBlack, 9);
			this.gbApellido.Font = new Font(Estilos.LatoBlack, 9);
			this.gbNombre.Font = new Font(Estilos.LatoBlack, 9);
			this.gbFechaNacimiento.Font = new Font(Estilos.LatoBlack, 9);
		}

		#region Arrastrado con mouse
		private bool arrastraVentana = false;
		private Point arrastreMouse;

		private void FPasajero_MouseDown(object sender, MouseEventArgs e) {
			this.arrastraVentana = true;
			this.arrastreMouse = this.PointToClient(MousePosition);
		}

		private void FPasajero_MouseUp(object sender, MouseEventArgs e) {
			this.arrastraVentana = false;
		}

		private void FPasajero_MouseMove(object sender, MouseEventArgs e) {
			if(this.arrastraVentana)
				this.Location = new Point(
					MousePosition.X - this.arrastreMouse.X,
					MousePosition.Y - this.arrastreMouse.Y);
		}
		#endregion
	}
}
