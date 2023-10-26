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
												Convert.ToInt32(fcasa.nudMinDias),
												Convert.ToInt32(fcasa.nudCantCamas),
												Convert.ToInt32(fcasa.nudDNI),
												fcasa.tbNombre.Text,Convert.ToInt64(fcasa.nudTel),
												fcasa.tbApellido.Text);
				}
				else if (fcasa.rbCasaFinde.Checked)
                {
					casa = new CasaFinde(Convert.ToInt32(fcasa.nudNroPropiedad.Text),
										 fcasa.tbDireccionCasa.Text, 3,
										 Convert.ToInt32(fcasa.nudDNI),
										 fcasa.tbNombre.Text,Convert.ToInt64(fcasa.nudTel),
										 fcasa.tbApellido.Text);
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

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			FAgregarHotel fhotel = new FAgregarHotel();
			if(fhotel.ShowDialog() == DialogResult.OK)
            {
				hotel = new Hotel(Convert.ToInt32(fhotel.nudNroPropiedad),
									fhotel.tbDireccionHotel.Text, Convert.ToInt32(fhotel.nudEstrellas),
									Convert.ToInt16(fhotel.nudSimples),
									Convert.ToInt16(fhotel.nudDobles),
									Convert.ToInt16(fhotel.nudTriples));
				if (fhotel.chbGarage.Checked) casa.AgregarServicio("Cochera");
				if (fhotel.chbDesayuno.Checked) casa.AgregarServicio("Desayuno");
				if (fhotel.chbLimpieza.Checked) casa.AgregarServicio("Limpieza");
				if (fhotel.chbPermiteMascotas.Checked) casa.AgregarServicio("Mascotas");
				if (fhotel.chbPileta.Checked) casa.AgregarServicio("Pileta");
				if (fhotel.chbWIFI.Checked) casa.AgregarServicio("Wi-Fi");

				sistema.AgregarHotel(hotel);
				cbPropiedades.Items.Add(hotel);
			}
		}

		private void BtnConsultarAlquiler_Click(object sender, EventArgs e) {
			Propiedad propiedad = sistema.VerPropiedad(Convert.ToInt32(nudNroPropiedadAlquiler.Value));

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
			Propiedad aBorrar = cbPropiedades.SelectedItem as Propiedad;
			if (sistema.QuitarPropiedad(aBorrar.Número))
				MessageBox.Show("Propiedad Eliminada");
			else
				MessageBox.Show("No se ha podido eliminar");
		}
    }
}
