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

namespace tp2 {
	public partial class FPrincipal: Form {
		private Sistema sistema;
		private Hotel hotel;
		private Casa casa;
		private string rutaBin;

        public FPrincipal() {
			this.InitializeComponent();
		}

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
			} finally {
				if(fs != null)
					fs.Close();
			}

			if(this.sistema == null)
				this.sistema = new Sistema();
		}

		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
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

		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}

		private void BtnAgregarCasa_Click(object sender, EventArgs e) {
			FAgregarCasa fcasa = new FAgregarCasa();
            if (fcasa.ShowDialog() == DialogResult.OK)
            {

				if(fcasa.rbCasa.Checked)
				{
					this.casa = new Casa(Convert.ToInt32(fcasa.nudNroPropiedad.Text),
									fcasa.tbDireccionCasa.Text,
									Convert.ToInt32(fcasa.nudMinDias.Value),
									Convert.ToInt32(fcasa.nudCantCamas.Value),
									Convert.ToInt32(fcasa.nudDNI.Value),
									fcasa.tbNombre.Text,Convert.ToInt64(fcasa.nudTel.Value),
									fcasa.tbApellido.Text,
									fcasa.Imágenes);
				}
				else if (fcasa.rbCasaFinde.Checked)
				{
					this.casa = new CasaFinde(Convert.ToInt32(fcasa.nudNroPropiedad.Text),
											fcasa.tbDireccionCasa.Text, 3,
											Convert.ToInt32(fcasa.nudDNI.Value),
											fcasa.tbNombre.Text,Convert.ToInt64(fcasa.nudTel.Value),
											fcasa.tbApellido.Text,
											fcasa.Imágenes);
				}

				if (fcasa.chbGarage.Checked) this.casa.AgregarServicio("Cochera");
				if (fcasa.chbDesayuno.Checked) this.casa.AgregarServicio("Desayuno");
				if (fcasa.chbLimpieza.Checked) this.casa.AgregarServicio("Limpieza");
				if (fcasa.chbPermiteMascotas.Checked) this.casa.AgregarServicio("Mascotas");
				if (fcasa.chbPileta.Checked) this.casa.AgregarServicio("Pileta");
				if (fcasa.chbWIFI.Checked) this.casa.AgregarServicio("Wi-Fi");

				this.sistema.AgregarResidencia(this.casa);
				this.cmbResidencias.Items.Add(this.casa);
				
            }
        }

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			FAgregarHotel fhotel = new FAgregarHotel();
			if(fhotel.ShowDialog() == DialogResult.OK)
            {
				this.hotel = new Hotel(Convert.ToInt32(fhotel.nudNroPropiedad.Value),
									fhotel.tbDireccionHotel.Text, fhotel.trbEstrellas.Value,
									Convert.ToInt16(fhotel.nudSimples.Value),
									Convert.ToInt16(fhotel.nudDobles.Value),
									Convert.ToInt16(fhotel.nudTriples.Value),
									new Image[] { });
				if (fhotel.chbGarage.Checked) this.hotel.AgregarServicio("Cochera");
				if (fhotel.chbDesayuno.Checked) this.hotel.AgregarServicio("Desayuno");
				if (fhotel.chbLimpieza.Checked) this.hotel.AgregarServicio("Limpieza");
				if (fhotel.chbPermiteMascotas.Checked) this.hotel.AgregarServicio("Mascotas");
				if (fhotel.chbPileta.Checked) this.hotel.AgregarServicio("Pileta");
				if (fhotel.chbWIFI.Checked) this.hotel.AgregarServicio("Wi-Fi");

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
					hotel.CntSimple += Convert.ToInt32(fhotel.nudSimples.Value);
					hotel.CntDoble += Convert.ToInt32(fhotel.nudDobles.Value);
					hotel.CntTriple += Convert.ToInt32(fhotel.nudTriples.Value);

					if (fhotel.chbGarage.Checked)
                    {
						this.ComprobarYAgregarServicio(aModificar, "Cochera");
					}
					if (fhotel.chbDesayuno.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "Desayuno");
					}
					if (fhotel.chbLimpieza.Checked)
                    {
						this.ComprobarYAgregarServicio(aModificar, "Limpieza");
					}
					if (fhotel.chbPermiteMascotas.Checked)
                    {
						this.ComprobarYAgregarServicio(aModificar, "Mascotas");
					}
					if (fhotel.chbPileta.Checked)
                    {
						this.ComprobarYAgregarServicio(aModificar, "Pileta");
                    }
                    if (fhotel.chbWIFI.Checked)
                    {
						this.ComprobarYAgregarServicio(aModificar, "WIFI");
					}
				}
			} else if(aModificar is Casa) {
				FAgregarCasa fcasa = new FAgregarCasa(aModificar as Casa);

				if(fcasa.ShowDialog() == DialogResult.OK) {
					Casa casa = aModificar as Casa;
					casa.ModificarCamas(Convert.ToInt32(fcasa.nudCantCamas.Value));
					casa.ModificarDias(Convert.ToInt32(fcasa.nudMinDias.Value));
					if (fcasa.chbGarage.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "Cochera");
					}
					if (fcasa.chbDesayuno.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "Desayuno");
					}
					if (fcasa.chbLimpieza.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "Limpieza");
					}
					if (fcasa.chbPermiteMascotas.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "Mascotas");
					}
					if (fcasa.chbPileta.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "Pileta");
					}
					if (fcasa.chbWIFI.Checked)
					{
						this.ComprobarYAgregarServicio(aModificar, "WIFI");
					}
				}
			}
        }

        private void ComprobarYAgregarServicio(Residencia aModificar, string buscado) {
			string[] serv;
			bool rep;
            rep = false;
            serv = aModificar.VerServicios();
            foreach (string s in serv)
                if (s == buscado)
                    rep = true;
            if (!rep)
                aModificar.AgregarServicio(buscado);
        }

        private void BtnVer_Click(object sender, EventArgs e) {
			FDetalles detail = new FDetalles();
			Residencia aVer = this.cmbResidencias.SelectedItem as Residencia;

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

		private void BtnImportar_Click(object sender, EventArgs e) {
			if(this.ofdDatos.ShowDialog() != DialogResult.OK)
				return;

			FileStream fs = null;
			StreamReader sr = null;

			try {
				fs = new FileStream(this.ofdDatos.FileName, FileMode.Open, FileAccess.Read);
				sr = new StreamReader(fs);

				Residencia residencia;
				string linea;
				int i = 0;
				while(!sr.EndOfStream) {
					linea = sr.ReadLine();
					i++;
					string[] datos = linea.Split(';');
					if(datos.Length == 13) {
						Residencia p = this.sistema.VerResidencia(Convert.ToInt32(datos[0]));
						residencia = new Hotel(
							Convert.ToInt32(datos[0]),
							datos[1],
							Convert.ToInt32(datos[2]),
							((Hotel)p).CntSimple,
							((Hotel)p).CntDoble,
							((Hotel)p).CntTriple,
							((Hotel)p).Imágenes
							);
					}
				}
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Lectura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
