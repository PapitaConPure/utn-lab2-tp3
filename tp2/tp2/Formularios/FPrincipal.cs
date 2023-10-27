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
		private Hotel hotel;
		private Casa casa;
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

		#region ABC de Propiedades
		private void BtnAgregarCasa_Click(object sender, EventArgs e) {
			FAgregarCasa fCasa = new FAgregarCasa();
            if(fCasa.ShowDialog() == DialogResult.OK) {
				if(fCasa.rbCasa.Checked) {
					this.casa = new Casa(
						(int)fCasa.nudNroResidencia.Value,
						fCasa.tbDirección.Text,
						(int)fCasa.nudMinDias.Value,
						(int)fCasa.nudCantCamas.Value,
						(int)fCasa.nudDNI.Value,
						fCasa.tbNombre.Text,
						(long)fCasa.nudTel.Value,
						fCasa.tbApellido.Text,
						fCasa.Imágenes);
				} else if(fCasa.rbCasaFinde.Checked) {
					this.casa = new CasaFinde(
						(int)fCasa.nudNroResidencia.Value,
						fCasa.tbDirección.Text, 3,
						(int)fCasa.nudDNI.Value,
						fCasa.tbNombre.Text,
						(long)fCasa.nudTel.Value,
						fCasa.tbApellido.Text,
						fCasa.Imágenes);
				}

				if(fCasa.chbGarage.Checked) this.casa.AgregarServicio("Cochera");
				if(fCasa.chbDesayuno.Checked) this.casa.AgregarServicio("Desayuno");
				if(fCasa.chbLimpieza.Checked) this.casa.AgregarServicio("Limpieza");
				if(fCasa.chbPermiteMascotas.Checked) this.casa.AgregarServicio("Mascotas");
				if(fCasa.chbPileta.Checked) this.casa.AgregarServicio("Pileta");
				if(fCasa.chbWIFI.Checked) this.casa.AgregarServicio("Wi-Fi");

				this.sistema.AgregarResidencia(this.casa);
				this.cmbResidencias.Items.Add(this.casa);
            }
        }

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			FAgregarHotel fHotel = new FAgregarHotel();
			if(fHotel.ShowDialog() == DialogResult.OK) {
				this.hotel = new Hotel(
					(int)fHotel.nudNroPropiedad.Value,
					fHotel.tbDireccionHotel.Text,
					fHotel.trbEstrellas.Value,
					(int)fHotel.nudSimples.Value,
					(int)fHotel.nudDobles.Value,
					(int)fHotel.nudTriples.Value,
					fHotel.Imágenes);
				if (fHotel.chbGarage.Checked) this.hotel.AgregarServicio("Cochera");
				if (fHotel.chbDesayuno.Checked) this.hotel.AgregarServicio("Desayuno");
				if (fHotel.chbLimpieza.Checked) this.hotel.AgregarServicio("Limpieza");
				if (fHotel.chbPermiteMascotas.Checked) this.hotel.AgregarServicio("Mascotas");
				if (fHotel.chbPileta.Checked) this.hotel.AgregarServicio("Pileta");
				if (fHotel.chbWIFI.Checked) this.hotel.AgregarServicio("Wi-Fi");

				this.sistema.AgregarResidencia(this.hotel);
				this.cmbResidencias.Items.Add(this.hotel);
			}
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

			if(aModificar is Hotel) {
				FAgregarHotel fhotel = new FAgregarHotel(aModificar as Hotel);

				if(fhotel.ShowDialog() == DialogResult.OK) {
					Hotel hotel = aModificar as Hotel;
					hotel.CntSimple += (int)fhotel.nudSimples.Value;
					hotel.CntDoble += (int)fhotel.nudDobles.Value;
					hotel.CntTriple += (int)fhotel.nudTriples.Value;

					if(fhotel.chbGarage.Checked)          aModificar.AgregarServicio("Cochera");
					if(fhotel.chbDesayuno.Checked)        aModificar.AgregarServicio("Desayuno");
					if(fhotel.chbLimpieza.Checked)        aModificar.AgregarServicio("Limpieza");
					if(fhotel.chbPermiteMascotas.Checked) aModificar.AgregarServicio("Mascotas");
					if(fhotel.chbPileta.Checked)          aModificar.AgregarServicio("Pileta");
					if(fhotel.chbWIFI.Checked)            aModificar.AgregarServicio("WIFI");
				}
			} else if(aModificar is Casa) {
				FAgregarCasa fcasa = new FAgregarCasa(aModificar as Casa);

				if(fcasa.ShowDialog() == DialogResult.OK) {
					Casa casa = aModificar as Casa;
					casa.CamasDisponibles = (int)fcasa.nudCantCamas.Value;
					casa.MínimoPermitido = (int)fcasa.nudMinDias.Value;

					if (fcasa.chbGarage.Checked)          aModificar.AgregarServicio("Cochera");
					if (fcasa.chbDesayuno.Checked)        aModificar.AgregarServicio("Desayuno");
					if (fcasa.chbLimpieza.Checked)        aModificar.AgregarServicio("Limpieza");
					if (fcasa.chbPermiteMascotas.Checked) aModificar.AgregarServicio("Mascotas");
					if (fcasa.chbPileta.Checked)          aModificar.AgregarServicio("Pileta");
					if (fcasa.chbWIFI.Checked)            aModificar.AgregarServicio("WIFI");
				}
			}
        }

        private void BtnVerPropiedad_Click(object sender, EventArgs e) {
			FDetalles detail = new FDetalles();
			Residencia aVer = this.cmbResidencias.SelectedItem as Residencia;

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
				detail.lbDetalles.Items.Add($"Dni: {casa.Propietario.Dni}, Tel:{casa.Propietario.Tel}");
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

			FileStream fs = null;
			StreamReader sr = null;
			int n = 1;

			try {
				fs = new FileStream(this.ofdDatos.FileName, FileMode.Open, FileAccess.Read);
				sr = new StreamReader(fs);

				Residencia residencia;
				Alquiler alquiler;
				string linea;
				while(!sr.EndOfStream) {
					linea = sr.ReadLine();
					n++;
					string[] datos = linea.Split(';');
					if(datos.Length == 8) {
						residencia = this.sistema.VerResidencia(Convert.ToInt32(datos[0]));
						alquiler = new Alquiler(
							Convert.ToInt32(datos[1]),
							Convert.ToDateTime(datos[3]),
							Convert.ToDateTime(datos[4]),
							Convert.ToDateTime(datos[5]),
							//PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE
							new Cliente(Convert.ToInt32(datos[2]), 0, 0, "", "", 0),
							//PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE PENDIENTE
							this.sistema.PrecioBase);

						residencia.Alquilar(alquiler);
					} else
						throw new ArgumentException("Cantidad de datos inválida");
				}
			} catch(FormatException ex) {
				MessageBox.Show($"Línea {n}: {ex.Message}", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(IOException ex) {
				MessageBox.Show($"Línea {n}: {ex.Message}", "Error de Lectura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show($"Línea {n}: {ex.Message}", "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show($"Línea {n}: {ex.Message}", "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if(fs != null) {
					if(sr != null)
						sr.Close();

					fs.Close();
				}
			}
		}

		private void BtnExportar_Click(object sender, EventArgs e) {
			if(this.sfdDatos.ShowDialog() != DialogResult.OK)
				return;

			FileStream fs = null;
			StreamWriter sw = null;

			try {
				fs = new FileStream(this.sfdDatos.FileName, FileMode.OpenOrCreate, FileAccess.Write);
				sw = new StreamWriter(fs);

				foreach(Residencia residencia in this.sistema.Residencias) {
					foreach(Alquiler alquiler in residencia.Alquileres) {
						sw.WriteLine(alquiler.Imprimir());
					}
				}
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Escritura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if(fs != null) {
					if(sw != null)
						sw.Close();

					fs.Close();
				}
			}
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
