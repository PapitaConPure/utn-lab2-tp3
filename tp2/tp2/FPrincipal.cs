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
using AlquilerLib;

namespace tp2 {
	public partial class FPrincipal: Form {
		Sistema sistema;
		Alquiler alquiler;
		Casa casa;
		Calendario calendario;
		DateTime[] meses;

        public FPrincipal() {
			this.InitializeComponent();
		}

		private void FPrincipal_Load(object sender, EventArgs e) {
			this.ofdElegirImagen.InitialDirectory = Environment.CurrentDirectory;

			this.meses = new DateTime[3];
			DateTime fecha = DateTime.Now;
			for(int i = 0; i < 3; i++) {
				this.meses[i] = fecha;
				this.cmbMes.Items.Add((Calendario.NombreMes)fecha.Month);
				fecha = fecha.AddMonths(1);
			}
			this.cmbMes.SelectedIndex = 0;

			this.sistema = new Sistema();
			this.calendario = new Calendario(this.dgvCalendario);
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
            casa = new Casa(Convert.ToInt32(nudNroPropiedad.Text), tbDirección.Text);//para q no se me rompa xd
			sistema.AgregarPropiedad(casa);
        }

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			
		}

		private void BtnConsultarAlquiler_Click(object sender, EventArgs e) {
			Propiedad propiedad = sistema.ConsultarPropiedad(Convert.ToInt32(nudNroPropiedadAlquiler.Value));

            if(propiedad!= null) {
				if(propiedad.Disponible)
					MessageBox.Show("La propiedad está disponible.");
				else
					MessageBox.Show("La propiedad no está disponible.");
			} else
				MessageBox.Show("La propiedad no existe.");
		}

        private void btnCancelarAlquiler_Click(object sender, EventArgs e) {
			if(this.sistema.CancelarAlquiler(Convert.ToInt32(this.nudNroPropiedadAlquiler), Convert.ToInt32(this.nudNroAlquiler.Value)))
				MessageBox.Show("El alquiler fue cancelado con éxito.");
        }

        private void btnAlquilar_Click(object sender, EventArgs e) {
			if(!this.calendario.HayDíaSeleccionado) {
				MessageBox.Show("No hay día seleccionado");
				return;
			}

			this.alquiler = new Alquiler(
				Convert.ToInt32(nudNroPropiedadAlquiler.Value),
				DateTime.Now,
				this.calendario.DíaSeleccionado,
				this.calendario.DíaSeleccionado.AddDays(3),
				casa);

			if(sistema.AlquilarPropiedad(alquiler.Número, alquiler))
				MessageBox.Show("Propiedad Alquilada.");
			else
				MessageBox.Show("No se puede alquilar la propiedad en este periodo de tiempo o la propiedad no existe");
        }

        private List<string> Servicios() {
            List<string> servicios = new List<string>();
            if (cbCochera.Checked) servicios.Add("Cochera");
            if (cbDesayuno.Checked) servicios.Add("Desayuno");
            if (cbLimpieza.Checked) servicios.Add("Limpieza");
            if (cbMascotas.Checked) servicios.Add("Mascotas");
            if (cbPileta.Checked) servicios.Add("Pileta");
            if (cbWifi.Checked) servicios.Add("Wi-Fi");
            return servicios;
        }

		private void CmbMes_SelectedIndexChanged(object sender, EventArgs e) {
			if(this.calendario == null)
				return;

			int idx = this.cmbMes.SelectedIndex;
			DateTime mes = this.meses[idx];
			this.calendario.MostrarMes(mes.Month, mes.Year);
		}
	}
}
