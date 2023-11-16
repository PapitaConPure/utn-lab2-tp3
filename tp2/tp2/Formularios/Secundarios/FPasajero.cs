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
    }
}
