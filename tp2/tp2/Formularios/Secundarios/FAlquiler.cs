using AlquilerLib;
using System;
using System.Windows.Forms;
using AlquilerLib.Utilidades;
using AlquilerLib.Constructores;
using System.Drawing;

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
			this.gbCantPasajeros.Enabled = false;
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

			Button[] botonesMeses = { this.btnMes1, this.btnMes2, this.btnMes3 };
			for(int i = 0; i < 3; i++) {
				this.meses[i] = fecha;
				botonesMeses[i].Text = ((Calendario.NombreMes)fecha.Month).ToString().Substring(0, 3).ToUpper();
				fecha = fecha.AddMonths(1);
			}

			this.calendario = new Calendario(this.dgvCalendario);
			this.RefrescarCalendario(0);

			Font fuente = new Font(Estilos.LatoBlack, 9);
			this.gbPropietario.Font = fuente;
			this.gbCantPasajeros.Font = fuente;
			this.gbCantDías.Font = fuente;
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
				if (this.sistema.VerificarDni((int)this.nudDNI.Value))
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

				DatosPersona d;
				Alquiler alq = this.residencia.VerAlquiler(this.residencia.ContAlquileres-1);
				FPasajero nuevo;
				Persona aux;
				bool canceló = false;
				int cont = (int)this.nudCantPasajeros.Value;
				for (int i = 0; i < cont-1 && !canceló; i++)
				{
					nuevo = new FPasajero();
					while(nuevo.ShowDialog() != DialogResult.OK) {}

					d = new DatosPersona((int)nuevo.nudDniPasajero.Value,
										nuevo.tbNombrePasajero.Text, nuevo.tbApellido.Text,
										nuevo.dtpFechaNacimiento.Value);
					aux = new Persona(d);
					alq.Cliente.AgregarPasajero(aux);
					nuevo.Dispose();
				}

				MessageBox.Show(
					$"Desde:{checkIn:d} hasta {checkOut:d}",
					"Residencia alquilada",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			catch(DniException ex)
            {
				MessageBox.Show(ex.Message, "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
            catch (ArgumentException ex)
            {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
			catch(FormatException ex)
            {
				MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
		}

		private void RefrescarCalendario(int idx) {
			if(this.calendario is null || this.sistema is null || this.residencia is null)
				return;

			DateTime mes = this.meses[idx];
			this.calendario.CargarMes(mes.Month, mes.Year);

			foreach(Alquiler alquiler in this.residencia.Alquileres) {
				DateTime inicio = new DateTime(alquiler.CheckIn.Year, alquiler.CheckIn.Month, alquiler.CheckIn.Day);
				DateTime fin = new DateTime(alquiler.CheckOut.Year, alquiler.CheckOut.Month, alquiler.CheckOut.Day);

				for(DateTime día = inicio; día <= fin; día = día.AddDays(1))
					if(día.Month == mes.Month)
						this.calendario.Marcar(día.Day);
			}

			this.calendario.Refrescar();
		}

		private void BtnMes_Click(object sender, EventArgs e) {
			Button button = sender as Button;

			if(button == this.btnMes1)
				this.RefrescarCalendario(0);
			else if(button == this.btnMes2)
				this.RefrescarCalendario(1);
			else
				this.RefrescarCalendario(2);
		}
	}
}
