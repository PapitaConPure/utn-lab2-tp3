using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2 {
	public partial class FPrincipal: Form {
		public FPrincipal() {
			this.InitializeComponent();
		}

        private void FPrincipal_Load(object sender, EventArgs e) {
			this.ofdElegirImagen.InitialDirectory = Environment.CurrentDirectory;

			this.mcReservas.MinDate = DateTime.Now;
			this.mcReservas.MaxDate = DateTime.Now.AddMonths(3);
		}

		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}

		private void BtnElegirImagen_Click(object sender, EventArgs e) {

		}

		private void BtnAgregarCasa_Click(object sender, EventArgs e) {

		}

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			
		}

		private void BtnConsultarAlquiler_Click(object sender, EventArgs e) {
			
		}

		private List<string>Servicios() {
			List<string> servicios = new List<string>();
			if (cbCochera.Checked)servicios.Add("Cochera");
			if (cbDesayuno.Checked) servicios.Add("Desayuno");
			if (cbLimpieza.Checked) servicios.Add("Limpieza");
			if (cbMascotas.Checked) servicios.Add("Mascotas");
			if (cbPileta.Checked) servicios.Add("Pileta");
			if (cbWifi.Checked) servicios.Add("Wi Fi");
			return servicios;
		}
	}
}
