using cargandoImagenes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AlquilerLib;
using AlquilerLib.Constructores;
using AlquilerLib.Utilidades;

namespace tp2 {
    public partial class FCasa: Form {
		private readonly Sistema sistema;
		private readonly FImagen fImagen;
		private CheckBox[] servicios;
		private Casa casa;

		public Image[] Imágenes {
			get { return this.fImagen.Imágenes; }
		}

		public FCasa() {
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

		public FCasa(Sistema sistema): this() {
			this.sistema = sistema;
			this.fImagen = new FImagen();
		}

		public FCasa(Sistema sistema, Casa casa): this() {
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

		~FCasa() {
			if(this.fImagen != null)
				this.fImagen.Dispose();
		}

		private void FAgregarCasa_Load(object sender, EventArgs e) {
			Font fuente = new Font(Estilos.LatoBlack, 9);
			this.gbDatos.Font = fuente;
			this.gbPropietario.Font = fuente;
			this.gbCantCamas.Font = fuente;
			this.gbMinDías.Font = fuente;
			this.gbServicios.Font = fuente;
		}

		private void BtnCrear_Click(object sender, EventArgs e) {
			try {
				if(this.casa is null) {
					int dni=0;
					int nroResidencia = (int)this.nudNroResidencia.Value;
					string dirección = this.tbDirección.Text;
                    if (sistema.VerificarDni((int)this.nudDNI.Value))
                    {
						dni = (int)this.nudDNI.Value;
					}
					string nombre = this.tbNombre.Text;
					string apellido = this.tbApellido.Text;
					long teléfono = (long)this.nudTel.Value;
					DatosPersona datosPropietario = new DatosPersona(dni, nombre, apellido, teléfono);

					if(this.rbCasa.Checked) {
						int minDías = (int)this.nudMinDias.Value;
						int cantCamas = (int)this.nudCantCamas.Value;
						this.casa = new Casa(nroResidencia, dirección, minDías, cantCamas, datosPropietario, this.Imágenes);
					} else {
						this.casa = new CasaFinde(nroResidencia, dirección, 3, datosPropietario, this.Imágenes);
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
			} 
			catch(DniException ex)
            {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
			catch(Exception ex) 
			{
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
