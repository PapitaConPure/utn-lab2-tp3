﻿using System;
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

					foreach(Residencia residencia in this.sistema.Residencias)
						this.cmbResidencias.Items.Add(residencia);
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
			FDetalles detail = new FDetalles();
			Residencia aVer = (Residencia)this.cmbResidencias.SelectedItem;

			if(aVer is null)
				return;

			detail.lbDetalles.Items.Add($"Nro Propiedad: {aVer.Número}");
			detail.lbDetalles.Items.Add($"Direccion: {aVer.Dirección}");

			if(aVer is Hotel) {
				Hotel hotel = aVer as Hotel;
				detail.lbDetalles.Items.Add($"Estrellas: {hotel.Estrellas}");
				detail.lbDetalles.Items.Add($"Cantidad de habitaciones:");
				detail.lbDetalles.Items.Add($"Simples: {hotel.CntSimple}");
				detail.lbDetalles.Items.Add($"Dobles: {hotel.CntDoble}");
				detail.lbDetalles.Items.Add($"triples: {hotel.CntTriple}");
			} else if(aVer is Casa) {
				Casa casa = aVer as Casa;
				detail.lbDetalles.Items.Add($"Minimo de dias: {casa.MínimoPermitido}");
				detail.lbDetalles.Items.Add($"Cantidad de camas: {casa.CamasDisponibles}");
				detail.lbDetalles.Items.Add($"Propietario:");
				detail.lbDetalles.Items.Add($"Apellido: {casa.Propietario.Apellido}, Nombre: {casa.Propietario.Nombre}");
				detail.lbDetalles.Items.Add($"Dni: {casa.Propietario.Dni}, Tel:{casa.Propietario.Teléfono}");
			}

			detail.lbDetalles.Items.Add($"Servicios:");
			foreach(string s in aVer.VerServicios())
				if(s != null) detail.lbDetalles.Items.Add(s);

			detail.pbImagen1.Image = aVer.Imágenes[0];
			detail.pbImagen2.Image = aVer.Imágenes[1];

			detail.ShowDialog();
			detail.Close();
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
			this.cmbResidencias.Items.Clear();

			foreach(Residencia residencia in this.sistema.Residencias)
				this.cmbResidencias.Items.Add(residencia);
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
