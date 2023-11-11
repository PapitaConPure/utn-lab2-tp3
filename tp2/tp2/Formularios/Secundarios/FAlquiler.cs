using AlquilerLib;
using System;
using System.Windows.Forms;
using AlquilerLib.Utilidades;

namespace tp2 {
	public partial class FAlquiler: Form {
		private readonly Sistema sistema;
		private readonly Residencia residencia;
		private Calendario calendario;
		private DateTime[] meses;

        internal Calendario Calendario { get { return this.calendario; } }

        public FAlquiler() {
			this.InitializeComponent();
		}

		public FAlquiler(Sistema sistema, Residencia residencia): this() {
			this.sistema = sistema;
			this.residencia = residencia;
			this.btnAlquilar.Visible = true;
			this.btnModificar.Visible = false;
		}

		public FAlquiler(Sistema sistema, Residencia residencia, Alquiler alquiler): this(sistema, residencia) {
			this.gbPropietario.Enabled = false;
			this.nudCantPasajeros.Value = alquiler.Cliente.CantPasajeros;
			this.nudDNI.Value = alquiler.Cliente.Dni;
			this.nudTel.Value = alquiler.Cliente.Teléfono;
			this.tbApellido.Text = alquiler.Cliente.Apellido;
			this.tbNombre.Text = alquiler.Cliente.Nombre;
			this.btnAlquilar.Visible = false;
			this.btnModificar.Visible = true;
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
			this.RefrescarCalendario();
		}

		private void BtnAlquilar_Click(object sender, EventArgs e) {
			if(!this.calendario.HayDíaSeleccionado) {
				MessageBox.Show("Selecciona un día");
				this.DialogResult = DialogResult.None;
				return;
			}

			DateTime fechaReserva = DateTime.Now;
			DateTime checkIn = this.calendario.DíaSeleccionado;
			DateTime checkOut = checkIn.AddDays((double)this.nudCantDias.Value);
            try
            {
				int dni = 0;
				if (sistema.VerificarDni((int)this.nudDNI.Value))
                {
					dni = (int)this.nudDNI.Value;
				}
				int cantPasajeros = (int)this.nudCantPasajeros.Value;
				long telefono = (long)this.nudTel.Value;
				
				string nom = this.tbNombre.Text;
				string apellido = this.tbApellido.Text;
				bool pudoAlquilar =
					this.sistema.AlquilarResidencia(this.residencia.Número, fechaReserva, checkIn, checkOut, cantPasajeros, dni, nom, apellido, telefono);

				if (!pudoAlquilar)
				{
					MessageBox.Show("No se puede alquilar la propiedad en este periodo de tiempo o la propiedad no existe");
					this.DialogResult = DialogResult.None;
					return;
				}

				MessageBox.Show(
					$"Desde:{checkIn:d} hasta {checkOut:d}",
					"Residencia alquilada",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			catch(DniException ex)
            {
				MessageBox.Show(ex.Message, "Error en el DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
            catch (ArgumentException ex)
            {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
			catch(FormatException ex)
            {
				MessageBox.Show(ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
		}

		private void CmbMes_SelectedIndexChanged(object sender, EventArgs e) {
			this.RefrescarCalendario();
		}

        private void BtnCerrar_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void RefrescarCalendario() {
			if(this.calendario is null || this.sistema is null || this.residencia is null)
				return;

			int idx = this.cmbMes.SelectedIndex;
			DateTime mes = this.meses[idx];
			this.calendario.CargarMes(mes.Month, mes.Year);

			foreach(Alquiler alquiler in this.residencia.Alquileres) {
				DateTime fin = alquiler.CheckOut;

				for(DateTime día = alquiler.CheckIn; día <= fin; día = día.AddDays(1))
					if(día.Month == mes.Month)
						this.calendario.Marcar(día.Day);
			}

			this.calendario.Refrescar();
		}
	}
}
