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

		//	if(this.sistema.CancelarAlquiler(Convert.ToInt32(this.nudNroPropiedadAlquiler), Convert.ToInt32(this.nudNroAlquiler.Value)))
		//		MessageBox.Show("El alquiler fue cancelado con éxito.");
		}

		private void BtnAlquilar_Click(object sender, EventArgs e) {
			if (!this.calendario.HayDíaSeleccionado) {
				MessageBox.Show("No hay día seleccionado");
				return;
			}


			DateTime fechaReserva = DateTime.Now;
			DateTime checkIn = calendario.DíaSeleccionado;
			DateTime checkOut = checkIn.AddDays((double)nudCantDias.Value);

			int cantPasajeros = (int)nudCantPasajeros.Value;
			int telefono = (int)nudTel.Value;
			int dni = (int)nudDNI.Value;
			string nom = tbNombre.Text;
			string apellido = tbApellido.Text;



			if (this.sistema.AlquilarResidencia(this.residencia.Número, fechaReserva, checkIn, checkOut, cantPasajeros, dni, nom, apellido, telefono))
			{ 
				MessageBox.Show(
				$"Desde:{checkIn:dd/MM} hasta {checkOut:dd/MM}",
				"Residencia alquilada",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("No se puede alquilar la propiedad en este periodo de tiempo o la propiedad no existe");


			nudCantDias.Value = nudCantDias.Minimum;
			nudTel.Value = nudTel.Minimum;
			nudDNI.Value = nudDNI.Minimum;
			tbApellido.Clear();
			tbNombre.Clear();
		}

		private void CmbMes_SelectedIndexChanged(object sender, EventArgs e) {
			if(this.calendario == null)
				return;

			int idx = this.cmbMes.SelectedIndex;
			DateTime mes = this.meses[idx];
			this.calendario.MostrarMes(mes.Month, mes.Year);
		}

        private void dgvCalendario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
