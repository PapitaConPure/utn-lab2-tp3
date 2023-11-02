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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using AlquilerLib;
using System.Runtime.Serialization;

namespace tp2 {
	public partial class FPrincipal: Form {
		private Sistema sistema;
		private string rutaBin;

        public FPrincipal() {
			this.InitializeComponent();
		}

		#region Persistencia de Sistema
		private void FPrincipal_Load(object sender, EventArgs e) {
			string rutaDir = Application.StartupPath;
			this.rutaBin = Path.Combine(rutaDir, "config.dat");

			FileStream fs = null;

			try {
				if(File.Exists(this.rutaBin)) {
					fs = new FileStream(this.rutaBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.sistema = bf.Deserialize(fs) as Sistema;
					this.sistema.CargarNroResidenciaSerializado();

					foreach(Residencia residencia in this.sistema.Residencias) {
						this.cmbResidencias.Items.Add(residencia);
						if(!this.cbDestinos.Items.Contains(residencia.Dirección))
							this.cbDestinos.Items.Add(residencia.Dirección);
					}
				}
			} catch(IOException) {
				MessageBox.Show("No se pudieron cargar los datos previos", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("No se pudieron cargar los datos previos", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(SerializationException) {
				MessageBox.Show("No se pudieron cargar los datos previos", "Error de Deserialización", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} finally {
				if(fs != null)
					fs.Close();
			}

			if(this.sistema == null) {
				FNuevoSistema fNuevoSistema = new FNuevoSistema();

				if(fNuevoSistema.ShowDialog() == DialogResult.OK)
					this.sistema = fNuevoSistema.Sistema;
				else
					Application.Exit();

				fNuevoSistema.Dispose();
			}
		}

		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			if(this.sistema is null)
				return;

			FileStream fs = null;
			try {
				fs = new FileStream(this.rutaBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
				this.sistema.GuardaNúmeroResidenciaSerializado();
				bf.Serialize(fs, this.sistema);
			} catch(IOException) {
				MessageBox.Show("No se pudieron guardar los datos", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("No se pudieron guardar los datos", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} finally {
				if(fs != null)
					fs.Close();
			}
		}
		#endregion

		#region ABM de Residencias
		private void BtnAgregarCasa_Click(object sender, EventArgs e) {
			FAgregarCasa fCasa = new FAgregarCasa(this.sistema);

            if(fCasa.ShowDialog() == DialogResult.OK) {
				MessageBox.Show(
					"La casa fue registrada exitosamente",
					"Casa agregada",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				this.ActualizarListaResidencias();
				this.cmbResidencias.SelectedIndex = this.cmbResidencias.Items.Count - 1;
			}

			fCasa.Dispose();
		}

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			FAgregarHotel fHotel = new FAgregarHotel(this.sistema);

			if(fHotel.ShowDialog() == DialogResult.OK) {
				MessageBox.Show(
					"El hotel fue registrado exitosamente",
					"Hotel agregado",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				this.ActualizarListaResidencias();
				this.cmbResidencias.SelectedIndex = this.cmbResidencias.Items.Count - 1;
			}

			fHotel.Dispose();
		}

		private void BtnBorrarPropiedad_Click(object sender, EventArgs e) {
			Residencia aBorrar = this.cmbResidencias.SelectedItem as Residencia;

            if(aBorrar is Residencia) {
				if(this.sistema.QuitarResidencia(aBorrar.Número)) {
					MessageBox.Show("Residencia eliminada");
					this.cmbResidencias.Items.Remove(aBorrar);
				} else
					MessageBox.Show("No se ha podido eliminar la residencia");
				this.cmbResidencias.SelectedIndex = -1;
			} else {
				MessageBox.Show("No existe la residencia");
            }
		}

        private void BtnModificarPropiedad_Click(object sender, EventArgs e) {
			Residencia aModificar = this.cmbResidencias.SelectedItem as Residencia;
			Form fModif = null;

			if(aModificar is Hotel)
				fModif = new FAgregarHotel(this.sistema, aModificar as Hotel);
			else if(aModificar is Casa)
				fModif = new FAgregarCasa(this.sistema, aModificar as Casa);

			if(fModif != null) {
				fModif.ShowDialog();
				fModif.Dispose();
			}
		}

		private void BtnVerPropiedad_Click(object sender, EventArgs e) {
			Residencia aVer = this.cmbResidencias.SelectedItem as Residencia;

			if(aVer is null)
				return;

			FDetalles detail = new FDetalles(this.sistema, aVer);

			detail.pbImagen1.Image = aVer.Imágenes[0];
			detail.pbImagen2.Image = aVer.Imágenes[1];

			detail.ShowDialog();
			detail.Close();
		}

		private void BtnAlquilar_Click(object sender, EventArgs e) {
			//if(this.lbResidencias.SelectedItem == null) {
			//	MessageBox.Show("Elija una propiedad");
			//	return;
			//}

			//Residencia r = this.lbResidencias.SelectedItem as Residencia;
			//FAlquiler falquilar = new FAlquiler(this.sistema, this.residencia);
			//falquilar.ShowDialog();
			//falquilar.Dispose();
		}
		#endregion

		#region Filtro
		private void BtnBuscarResidencias_Click(object sender, EventArgs e) {
			this.ActualizarListaResidencias();
		}

		private void BtnLimpiarFiltros_Click(object sender, EventArgs e) {
			this.cbDestinos.SelectedIndex = -1;
			this.nudCantPersonas.Value = this.nudCantPersonas.Minimum;
			this.nudMaxPrice.Value = this.nudMaxPrice.Minimum;
			this.nudMinPrice.Value = this.nudMinPrice.Minimum;
			this.rbCasa.Checked = false;
			this.rbCasaFinde.Checked = false;
			this.rbHotel.Checked = false;
		}

		private bool VerificarTipo(Residencia r) {
			if(!this.rbHotel.Checked && !this.rbCasa.Checked && !this.rbCasaFinde.Checked)
				return true;

			return (this.rbHotel.Checked && r is Hotel)
				|| (this.rbCasaFinde.Checked && r is CasaFinde)
				|| (this.rbCasa.Checked && r is Casa);
		}

		private bool VerificarPlazas(Residencia r) {
			int cant = (int)this.nudCantPersonas.Value;
			bool valido = false;
			if(this.nudCantPersonas.Value == 0)
				valido = true;
			else {
				if(r is Casa) {
					if((r as Casa).CamasDisponibles >= cant)
						valido = true;
				} else if(r is Hotel) {
					valido = (cant <= 2 && (r as Hotel).CntSimple > 0)
						  || (cant <= 4 && (r as Hotel).CntDoble > 0)
						  || (cant <= 6 && (r as Hotel).CntTriple > 0);
				}
			}
			return valido;
		}
		#endregion

		#region Importar y Exportar CSV
		private void BtnImportar_Click(object sender, EventArgs e) {
			if(this.ofdDatos.ShowDialog() != DialogResult.OK)
				return;

			try {
				this.sistema.ImportarAlquileres(this.ofdDatos.FileName);
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Lectura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(FormatException ex) {
				MessageBox.Show(ex.Message, "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(InvalidOperationException ex) {
				MessageBox.Show(ex.Message, "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnExportar_Click(object sender, EventArgs e) {
			if(this.sfdDatos.ShowDialog() != DialogResult.OK)
				return;

			try {
				this.sistema.ExportarAlquileres(this.sfdDatos.FileName);
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Escritura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Utilidades
		private void ActualizarListaResidencias() {
			//Viejo
			this.cmbResidencias.Items.Clear();
			this.cbDestinos.Items.Clear();
			foreach (Residencia residencia in this.sistema.Residencias)
            {
				this.cmbResidencias.Items.Add(residencia); 
				if (!this.cbDestinos.Items.Contains(residencia.Dirección))
					this.cbDestinos.Items.Add(residencia.Dirección);
			}

			//Nuevo
			this.lbResidencias.Items.Clear();

			double max = 0, min = 0;
			if(this.nudMaxPrice.Value != 0) max = (double)this.nudMaxPrice.Value;
			if(this.nudMinPrice.Value != 0) min = (double)this.nudMinPrice.Value;

			string destino = "";
			if(this.cbDestinos.SelectedItem != null) destino = this.cbDestinos.SelectedItem as string;

			foreach(Residencia re in this.sistema.Residencias) {
				if(this.VerificarTipo(re) &&
					(destino == "" || destino == re.Dirección) &&
					(re.CalcularPrecioTotal() * this.sistema.PrecioBase <= max || max == 0) &&
					(re.CalcularPrecioTotal() * this.sistema.PrecioBase >= min || min == 0) &&
					this.VerificarPlazas(re))
					this.lbResidencias.Items.Add(re);
			}

			if(this.lbResidencias.Items.Count == 0)
				this.lbResidencias.Items.Add("No hay resultados");
		}
		#endregion

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
