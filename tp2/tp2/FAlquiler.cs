using AlquilerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2 {
	public partial class FAlquiler: Form {
		Alquiler alquiler;
		Calendario calendario;
		DateTime[] meses;
		FFechaAlquiler ventana;
		Cliente cliente;
		Sistema sistema;
		Casa casa;

		public FAlquiler() {
			this.InitializeComponent();
		}

		public FAlquiler(Sistema sistema): this() {
			this.sistema = sistema;
		}

		private void FAlquilar_Load(object sender, EventArgs e) {
			this.meses = new DateTime[3];
			DateTime fecha = DateTime.Now;
			for(int i = 0; i < 3; i++) {
				this.meses[i] = fecha;
				this.cmbMes.Items.Add((Calendario.NombreMes)fecha.Month);
				fecha = fecha.AddMonths(1);
			}
			this.cmbMes.SelectedIndex = 0;
			this.calendario = new Calendario(this.dgvCalendario);
		}

		private void BtnConsultarAlquiler_Click(object sender, EventArgs e) {
			Residencia propiedad = sistema.VerPropiedad(Convert.ToInt32(nudNroPropiedadAlquiler.Value));

			if(propiedad != null) {
				MessageBox.Show("La propiedad existe.");
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
			int nroAlquiler = Convert.ToInt32(nudNroAlquiler.Value);
			ventana = new FFechaAlquiler();
			ventana.calindario.TodayDate = calendario.DíaSeleccionado;
			if(ventana.ShowDialog() == DialogResult.OK) {
				this.alquiler = new Alquiler(
					Convert.ToInt32(nudNroPropiedadAlquiler.Value),
					DateTime.Now,
					ventana.calindario.SelectionStart,
					ventana.calindario.SelectionEnd,
					casa,
					cliente
				);
				MessageBox.Show($@"Desde:{ventana.calindario.SelectionStart.Day}/{ventana.calindario.SelectionStart.Month}  hasta {ventana.calindario.SelectionEnd.Day}/{ventana.calindario.SelectionEnd.Month}");
			}

			try {

				if(sistema.AlquilarPropiedad(alquiler.Número, alquiler))
					MessageBox.Show("Propiedad Alquilada.");
				else
					MessageBox.Show("No se puede alquilar la propiedad en este periodo de tiempo o la propiedad no existe");
			} catch {
				MessageBox.Show("CASI EXPLOTA TODO.");
			}
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
