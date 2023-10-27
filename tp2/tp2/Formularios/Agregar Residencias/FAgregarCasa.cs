using cargandoImagenes;
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

namespace tp2 {
    public partial class FAgregarCasa: Form {
		private readonly Sistema sistema;
		private readonly FImagen fImagen;
		private CheckBox[] servicios;
		private Casa casa;

		public FAgregarCasa() {
			this.InitializeComponent();

			this.servicios = new CheckBox[] {
				this.chbGarage,
				this.chbDesayuno,
				this.chbLimpieza,
				this.chbPermiteMascotas,
				this.chbPileta,
				this.chbWIFI,
			};

			this.rbCasa.Enabled = true;
			this.rbCasaFinde.Enabled = true;
			this.tbDirección.Enabled = true;
			this.nudNroResidencia.Enabled = true;
			this.nudDNI.Enabled = true;
			this.nudTel.Enabled = true;
			this.tbApellido.Enabled = true;
			this.tbNombre.Enabled = true;
		}

		public FAgregarCasa(Sistema sistema): this() {
			this.sistema = sistema;
			this.fImagen = new FImagen();
		}

		public FAgregarCasa(Sistema sistema, Casa casa): this() {
			this.sistema = sistema;
			this.fImagen = new FImagen(casa.Imágenes);
			this.casa = casa;

			this.gbDatos.Enabled
			= this.tlpTipoCasa.Enabled
			= this.nudDNI.Enabled
			= this.tbApellido.Enabled
			= this.gbMinDías.Enabled
				= false;

			this.tbDirección.Text = casa.Dirección;
			this.nudNroResidencia.Value = casa.Número;
			this.rbCasaFinde.Checked = casa is CasaFinde;
			this.nudCantCamas.Value = casa.CamasDisponibles;
			this.nudMinDias.Value = casa.MínimoPermitido;
			this.nudDNI.Value = casa.Propietario.Dni;
			this.tbApellido.Text = casa.Propietario.Apellido;
			this.tbNombre.Text = casa.Propietario.Nombre;
			this.nudTel.Value = casa.Propietario.Teléfono;

			string[] serviciosCasa = casa.VerServicios();
			foreach(CheckBox servicio in this.servicios) {
				servicio.Checked = serviciosCasa.Contains(servicio.Text);
			}
		}

		public Image[] Imágenes {
            get { return this.fImagen.Imágenes; }
		}

		public List<string> ServiciosCargados {
			get {
				List<string> resultado = new List<string>();

				foreach(CheckBox servicio in this.servicios)
					if(servicio.Checked)
						resultado.Add(servicio.Text);

				return resultado;
			}
		}

		private void BtnCrear_Click(object sender, EventArgs e) {
			try {
				if(this.casa is null) {
					#region Copipegar despué'
					//if(this.tbDirección.TextLength == 0) {
					//	this.tbDirección.Focus();
					//	throw new InvalidOperationException("Debes ingresar una dirección de residencia válida");
					//}

					//if(this.tbApellido.TextLength == 0) {
					//	this.tbApellido.Focus();
					//	throw new InvalidOperationException("Debes ingresar el apellido del propietario de la casa");
					//}

					//if(this.tbNombre.TextLength == 0) {
					//	this.tbNombre.Focus();
					//	throw new InvalidOperationException("Debes ingresar el/los nombre/s del propietario de la casa");
					//}

					//if(!this.fImagen.CargóTodas) {
					//	this.btnAgregarImágen.Focus();
					//	throw new InvalidOperationException("Debes cargar 2 imágenes para la residencia");
					//}
					#endregion

					if(this.rbCasa.Checked) {
						this.casa = new Casa(
							(int)this.nudNroResidencia.Value,
							this.tbDirección.Text,
							(int)this.nudMinDias.Value,
							(int)this.nudCantCamas.Value,
							(int)this.nudDNI.Value,
							this.tbNombre.Text,
							(long)this.nudTel.Value,
							this.tbApellido.Text,
							this.Imágenes);
					} else {
						this.casa = new CasaFinde(
							(int)this.nudNroResidencia.Value,
							this.tbDirección.Text, 3,
							(int)this.nudDNI.Value,
							this.tbNombre.Text,
							(long)this.nudTel.Value,
							this.tbApellido.Text,
							this.Imágenes);
					}

					foreach(CheckBox servicio in this.servicios) {
						if(servicio.Checked)
							this.casa.AgregarServicio(servicio.Text);
					}

					this.sistema.AgregarResidencia(this.casa);
				} else {
					this.casa.CamasDisponibles = (int)this.nudCantCamas.Value;
					this.casa.MínimoPermitido = (int)this.nudMinDias.Value;
					this.casa.Propietario.Nombre = this.tbNombre.Text;
					this.casa.Propietario.Teléfono = (int)this.nudTel.Value;

					this.casa.LimpiarServicios();
					foreach(CheckBox servicio in this.servicios) {
						if(servicio.Checked)
							this.casa.AgregarServicio(servicio.Text);
					}
				}
			} catch(Exception ex) {
				MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
		}

		private void RbCasa_CheckedChanged(object sender, EventArgs e)
        {
            this.gbMinDías.Enabled = true;
        }

        private void RbCasaFinde_CheckedChanged(object sender, EventArgs e)
        {
            this.gbMinDías.Enabled = false;
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e) {
			this.fImagen.ShowDialog();
        }

		#region Calidad de vida
		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}
		#endregion
	}
}
