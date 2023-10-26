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
			this.ofdElegirImagen.InitialDirectory = Environment.CurrentDirectory;

			string rutaDir = Application.StartupPath;
			this.rutaBin = Path.Combine(rutaDir, "config.dat");

			FileStream fs = null;

			try {
				if(File.Exists(rutaBin)) {
					fs = new FileStream(rutaBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.sistema = bf.Deserialize(fs) as Sistema;
				}
			} catch(IOException) {

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
				fs = new FileStream(rutaBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, this.sistema);
			} catch(IOException) {

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

		private void btnAgregarCasa_Click_1(object sender, EventArgs e) {
			FAgregarCasa fcasa = new FAgregarCasa();
            if (fcasa.ShowDialog() == DialogResult.OK)
            {

				if(fcasa.rbCasa.Checked)
				{
					casa = new Casa(Convert.ToInt32(fcasa.nudNroPropiedad.Text),
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
					casa = new CasaFinde(Convert.ToInt32(fcasa.nudNroPropiedad.Text),
											fcasa.tbDireccionCasa.Text, 3,
											Convert.ToInt32(fcasa.nudDNI.Value),
											fcasa.tbNombre.Text,Convert.ToInt64(fcasa.nudTel.Value),
											fcasa.tbApellido.Text,
											fcasa.Imágenes);
				}

				if (fcasa.chbGarage.Checked) casa.AgregarServicio("Cochera");
				if (fcasa.chbDesayuno.Checked) casa.AgregarServicio("Desayuno");
				if (fcasa.chbLimpieza.Checked) casa.AgregarServicio("Limpieza");
				if (fcasa.chbPermiteMascotas.Checked) casa.AgregarServicio("Mascotas");
				if (fcasa.chbPileta.Checked) casa.AgregarServicio("Pileta");
				if (fcasa.chbWIFI.Checked) casa.AgregarServicio("Wi-Fi");

				sistema.AgregarPropiedad(casa);
				cbPropiedades.Items.Add(casa);
				
            }
        }

		private void btnAgregarHotel_Click_1(object sender, EventArgs e) {
			FAgregarHotel fhotel = new FAgregarHotel();
			if(fhotel.ShowDialog() == DialogResult.OK)
            {
				hotel = new Hotel(Convert.ToInt32(fhotel.nudNroPropiedad.Value),
									fhotel.tbDireccionHotel.Text, Convert.ToInt32(fhotel.nudEstrellas.Value),
									Convert.ToInt16(fhotel.nudSimples.Value),
									Convert.ToInt16(fhotel.nudDobles.Value),
									Convert.ToInt16(fhotel.nudTriples.Value),
									new Image[] { });
				if (fhotel.chbGarage.Checked) hotel.AgregarServicio("Cochera");
				if (fhotel.chbDesayuno.Checked) hotel.AgregarServicio("Desayuno");
				if (fhotel.chbLimpieza.Checked) hotel.AgregarServicio("Limpieza");
				if (fhotel.chbPermiteMascotas.Checked) hotel.AgregarServicio("Mascotas");
				if (fhotel.chbPileta.Checked) hotel.AgregarServicio("Pileta");
				if (fhotel.chbWIFI.Checked) hotel.AgregarServicio("Wi-Fi");

				sistema.AgregarPropiedad(hotel);
				cbPropiedades.Items.Add(hotel);
			}
		}

        private void btnBorrarPropiedad_Click(object sender, EventArgs e)
        {
			Residencia aBorrar = cbPropiedades.SelectedItem as Residencia;
            if (aBorrar != null)
            {
				if (sistema.QuitarPropiedad(aBorrar.Número))
				{
					MessageBox.Show("Propiedad Eliminada");
					cbPropiedades.Items.Remove(aBorrar);
				}
				else
					MessageBox.Show("No se ha podido eliminar");
				cbPropiedades.SelectedIndex = -1;
			}
            else
            {
				MessageBox.Show("No existe la propiedad");
            }
			
		}

        private void btnModificarPropiedad_Click(object sender, EventArgs e) {
			Residencia aModificar = cbPropiedades.SelectedItem as Residencia;
			if(aModificar is Hotel) {
				FAgregarHotel fhotel = new FAgregarHotel();
				fhotel.tbDireccionHotel.Enabled = false;
				fhotel.nudNroPropiedad.Enabled = false;
			    fhotel.nudEstrellas.Enabled = false;

                if (fhotel.ShowDialog() == DialogResult.OK) {
					((Hotel)aModificar).CntSimple += Convert.ToInt32(fhotel.nudSimples.Value);
					((Hotel)aModificar).CntDoble += Convert.ToInt32(fhotel.nudDobles.Value);
					((Hotel)aModificar).CntTriple += Convert.ToInt32(fhotel.nudTriples.Value);

					if (fhotel.chbGarage.Checked)
                    {
						BuscarServicio(aModificar, "Cochera");
					}
					if (fhotel.chbDesayuno.Checked)
					{
						BuscarServicio(aModificar, "Desayuno");
					}
					if (fhotel.chbLimpieza.Checked)
                    {
						BuscarServicio(aModificar, "Limpieza");
					}
					if (fhotel.chbPermiteMascotas.Checked)
                    {
						BuscarServicio(aModificar, "Mascotas");
					}
					if (fhotel.chbPileta.Checked)
                    {
                        BuscarServicio(aModificar,"Pileta");
                    }
                    if (fhotel.chbWIFI.Checked)
                    {
						BuscarServicio(aModificar, "WIFI");
					}
				}
			} else if(aModificar is Casa) {
				FAgregarCasa fcasa = new FAgregarCasa();
				fcasa.rbCasa.Enabled = false;
				fcasa.rbCasaFinde.Enabled = false;
				fcasa.tbDireccionCasa.Enabled = false;
				fcasa.nudNroPropiedad.Enabled = false;
				fcasa.nudDNI.Enabled = false;
				fcasa.nudTel.Enabled = false;
				fcasa.tbApellido.Enabled = false;
				fcasa.tbNombre.Enabled = false;

				if(fcasa.ShowDialog() == DialogResult.OK)
                {
					((Casa)aModificar).ModificarCamas(Convert.ToInt32(fcasa.nudCantCamas.Value));
					((Casa)aModificar).ModificarDias(Convert.ToInt32(fcasa.nudMinDias.Value));
					if (fcasa.chbGarage.Checked)
					{
						BuscarServicio(aModificar, "Cochera");
					}
					if (fcasa.chbDesayuno.Checked)
					{
						BuscarServicio(aModificar, "Desayuno");
					}
					if (fcasa.chbLimpieza.Checked)
					{
						BuscarServicio(aModificar, "Limpieza");
					}
					if (fcasa.chbPermiteMascotas.Checked)
					{
						BuscarServicio(aModificar, "Mascotas");
					}
					if (fcasa.chbPileta.Checked)
					{
						BuscarServicio(aModificar, "Pileta");
					}
					if (fcasa.chbWIFI.Checked)
					{
						BuscarServicio(aModificar, "WIFI");
					}
				}
				
			}
        }

        private void BuscarServicio(Residencia aModificar, string buscado) {
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

        private void btnVer_Click(object sender, EventArgs e) {
			FDetalles detail = new FDetalles();
			Residencia aVer = cbPropiedades.SelectedItem as Residencia;

			detail.lbDetalles.Items.Add($"Nro Propiedad: {aVer.Número}");
			detail.lbDetalles.Items.Add($"Direccion: {aVer.Dirección}");

			if(aVer is Hotel)
            {
				detail.lbDetalles.Items.Add($"Estrellas: {((Hotel)aVer).Estrellas}");
				detail.lbDetalles.Items.Add($"Cantidad de habitaciones:");
				detail.lbDetalles.Items.Add($"Simples: {((Hotel)aVer).CntSimple}");
				detail.lbDetalles.Items.Add($"Dobles: {((Hotel)aVer).CntDoble}");
				detail.lbDetalles.Items.Add($"triples: {((Hotel)aVer).CntTriple}");
			}
			else if(aVer is Casa)
            {
				detail.lbDetalles.Items.Add($"Minimo de dias: {((Casa)aVer).MínimoPermitido}");
				detail.lbDetalles.Items.Add($"Cantidad de camas: {((Casa)aVer).CamasDisponibles}");
				detail.lbDetalles.Items.Add($"Propietario:");
				detail.lbDetalles.Items.Add($"Apellido: {((Casa)aVer).Propietario.Apellido}, Nombre: {((Casa)aVer).Propietario.Nombre}");
				detail.lbDetalles.Items.Add($"Dni: {((Casa)aVer).Propietario.Dni}, Tel:{((Casa)aVer).Propietario.Tel}");
			}

			detail.lbDetalles.Items.Add($"Servicios:");
			foreach(string s in aVer.VerServicios())
				if(s != null) detail.lbDetalles.Items.Add(s);

			detail.pbImagen1.Image = aVer.Imágenes[0];
			detail.pbImagen2.Image = aVer.Imágenes[1];

			detail.ShowDialog();
			detail.Close();
		}

		private void btnImportar_Click(object sender, EventArgs e) {

		}

		private void btnExportar_Click(object sender, EventArgs e) {

		}
	}
}
