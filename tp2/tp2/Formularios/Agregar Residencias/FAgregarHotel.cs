using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerLib;
using cargandoImagenes;

namespace tp2 {
    public partial class FAgregarHotel : Form {
		FImagen fImagen;

		public FAgregarHotel() {
			this.Inicializar();
			this.fImagen = new FImagen();
		}

		public FAgregarHotel(Hotel hotel) {
			this.Inicializar();
			this.fImagen = new FImagen(hotel.Imágenes);

			this.gbDatos.Enabled
			= this.gbEstrellas.Enabled
				= false;

			this.tbDireccionHotel.Text = hotel.Dirección;
			this.nudNroPropiedad.Value = hotel.Número;
		}

		public Image[] Imágenes {
			get { return this.fImagen.Imágenes; }
		}

		private void FAgregarHotel_Shown(object sender, EventArgs e) {
			this.tbMuestraEstrellas.Text = this.trbEstrellas.Value.ToString();
		}

		private void TrbEstrellas_ValueChanged(object sender, EventArgs e) {
			this.tbMuestraEstrellas.Text = this.trbEstrellas.Value.ToString();
		}

		private void BtnAgregarImagen_Click(object sender, EventArgs e) {
			this.fImagen.ShowDialog();
		}

		private void BtnCrear_Click(object sender, EventArgs e) {
			if(this.fImagen.CargóTodas)
				this.DialogResult = DialogResult.None;
		}

		private void Inicializar() {
			this.InitializeComponent();
			this.tbDireccionHotel.Enabled = true;
			this.nudNroPropiedad.Enabled = true;
			this.trbEstrellas.Enabled = true;
		}
	}
}
