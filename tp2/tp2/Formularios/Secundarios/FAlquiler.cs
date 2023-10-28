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
		private readonly Sistema sistema;
		private readonly Residencia residencia;
		private Calendario calendario;
		private DateTime[] meses;

		public FAlquiler() {
			this.InitializeComponent();
		}

		public FAlquiler(Sistema sistema, Residencia residencia): this() {
			this.sistema = sistema;
			this.residencia = residencia;
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

		private void BtnCancelarAlquiler_Click(object sender, EventArgs e) {
			//if(this.sistema.CancelarAlquiler(Convert.ToInt32(this.nudNroPropiedadAlquiler), Convert.ToInt32(this.nudNroAlquiler.Value)))
			//	MessageBox.Show("El alquiler fue cancelado con éxito.");
		}

		private void BtnAlquilar_Click(object sender, EventArgs e) {
			if(!this.calendario.HayDíaSeleccionado) {
				MessageBox.Show("No hay día seleccionado");
				return;
			}

			FFechaAlquiler ventana = new FFechaAlquiler();
			ventana.calendario.TodayDate = this.calendario.DíaSeleccionado;

			if(ventana.ShowDialog() == DialogResult.OK) {
				DateTime checkIn = ventana.calendario.SelectionStart;
				DateTime checkOut = ventana.calendario.SelectionEnd;

				MessageBox.Show(
					$"Desde:{checkIn:dd/MM} hasta {checkOut:dd/MM}",
					"Residencia alquilada",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				//if(this.sistema.AlquilarResidencia((int)this.nudNroPropiedadAlquiler.Value,  alquiler))
				//	MessageBox.Show("Propiedad Alquilada.");
				//else
				//	MessageBox.Show("No se puede alquilar la propiedad en este periodo de tiempo o la propiedad no existe");
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
