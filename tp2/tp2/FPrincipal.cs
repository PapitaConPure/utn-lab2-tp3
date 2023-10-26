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
using AlquilerLib;
using cargandoImagenes;

namespace tp2 {
	public partial class FPrincipal: Form {
		Sistema sistema;
		Alquiler alquiler;
		Casa casa;
		Hotel hotel;
		Calendario calendario;
		DateTime[] meses;
		//FAlquiler ventana;
		Cliente cliente;
        public FPrincipal() {
			this.InitializeComponent();
		}
		//////// REHACER EL FORM...
		private void FPrincipal_Load(object sender, EventArgs e) {
			this.ofdElegirImagen.InitialDirectory = Environment.CurrentDirectory;

			this.meses = new DateTime[3];
			DateTime fecha = DateTime.Now;
			for(int i = 0; i < 3; i++) {
				this.meses[i] = fecha;
				this.cmbMes.Items.Add((Calendario.NombreMes)fecha.Month);
				fecha = fecha.AddMonths(1);
			}
			this.cmbMes.SelectedIndex = 0;

			this.sistema = new Sistema();
			this.calendario = new Calendario(this.dgvCalendario);
		}

		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}

		private void BtnElegirImagen_Click(object sender, EventArgs e) {

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

		private void BtnConsultarAlquiler_Click(object sender, EventArgs e) {
			Residencia propiedad = sistema.VerPropiedad(Convert.ToInt32(nudNroPropiedadAlquiler.Value));

            if(propiedad!= null) {
				MessageBox.Show("La propiedad existe.");
			} else
				MessageBox.Show("La propiedad no existe.");
		}

        private void btnCancelarAlquiler_Click(object sender, EventArgs e) {
			if(this.sistema.CancelarAlquiler(Convert.ToInt32(this.nudNroPropiedadAlquiler), Convert.ToInt32(this.nudNroAlquiler.Value)))
				MessageBox.Show("El alquiler fue cancelado con éxito.");
        }

   //     private void btnAlquilar_Click(object sender, EventArgs e) {
			//if(!this.calendario.HayDíaSeleccionado) {
			//	MessageBox.Show("No hay día seleccionado");
			//	return;
			//}
   //         ventana = new FAlquiler();
			//ventana.calindario.TodayDate = calendario.DíaSeleccionado;
			//if (ventana.ShowDialog() == DialogResult.OK)
			//{
			//	this.alquiler = new Alquiler(
			//		Convert.ToInt32(nudNroPropiedadAlquiler.Value),
			//		DateTime.Now,
			//		ventana.calindario.SelectionStart, ventana.calindario.SelectionEnd, casa,cliente
			//	);
			//	MessageBox.Show($@"Desde:{ventana.calindario.SelectionStart.Day}/{ventana.calindario.SelectionStart.Month}  hasta {ventana.calindario.SelectionEnd.Day}/{ventana.calindario.SelectionEnd.Month}");
			//}
			//try
			//{

			//if(sistema.AlquilarPropiedad(alquiler.Número, alquiler))
			//	MessageBox.Show("Propiedad Alquilada.");
			//else
			//	MessageBox.Show("No se puede alquilar la propiedad en este periodo de tiempo o la propiedad no existe");
			//}
			//catch
			//{
			//	MessageBox.Show("CASI EXPLOTA TODO.");
			//}
   //     }

        

		private void CmbMes_SelectedIndexChanged(object sender, EventArgs e) {
			if(this.calendario == null)
				return;

			int idx = this.cmbMes.SelectedIndex;
			DateTime mes = this.meses[idx];
			this.calendario.MostrarMes(mes.Month, mes.Year);
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

        private void btnModificarPropiedad_Click(object sender, EventArgs e)
        {
			Residencia aModificar = cbPropiedades.SelectedItem as Residencia;
			if(aModificar is Hotel)
            {
				FAgregarHotel fhotel = new FAgregarHotel();
				fhotel.tbDireccionHotel.Enabled = false;
				fhotel.nudNroPropiedad.Enabled = false;
			    fhotel.nudEstrellas.Enabled = false;

                if (fhotel.ShowDialog() == DialogResult.OK)
                {
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
			}
			else if(aModificar is Casa)
            {
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

        private void BuscarServicio(Residencia aModificar, string buscado)
        {
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

        private void btnVer_Click(object sender, EventArgs e)
        {
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
    }
}
