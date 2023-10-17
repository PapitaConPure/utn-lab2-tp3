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
        public FPrincipal() {
			this.InitializeComponent();
		}
		private void FPrincipal_Load(object sender, EventArgs e) {
			this.ofdElegirImagen.InitialDirectory = Environment.CurrentDirectory;
			this.mcReservas.MinDate = DateTime.Now;
			this.mcReservas.MaxDate = DateTime.Now.AddMonths(3);
			sistema = new Sistema();
		}

		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}

		private void BtnElegirImagen_Click(object sender, EventArgs e) {

		}

		private void BtnAgregarCasa_Click(object sender, EventArgs e) {
            casa = new Casa(Convert.ToInt32(nudNroPropiedad.Text), tbDirección.Text);//para q no se me rompa xd
			sistema.AgregarPropiedad(casa);
        }

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			
		}

		private void BtnConsultarAlquiler_Click(object sender, EventArgs e) {
			if (sistema.ConsultarPropiedad(Convert.ToInt32(nudNroPropiedadAlquiler.Value)) != null)
			{
				MessageBox.Show("La propiedad está disponible.");
			}
			else
			{
				MessageBox.Show("La propiedad no está disponible.");
			}

		}


        private void btnCancelarAlquiler_Click(object sender, EventArgs e)
        {
			if(sistema.CancelarAlquiler(Convert.ToInt32(nudNroPropiedadAlquiler), Convert.ToInt32(nudNroAlquiler.Value))) MessageBox.Show("El alquiler fue cancelado con éxito.");
			
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
			alquiler = new Alquiler(Convert.ToInt32(nudNroPropiedadAlquiler.Value),DateTime.Now,mcReservas.SelectionStart,mcReservas.SelectionEnd,casa);
			if (sistema.AlquilarPropiedad(alquiler.Número, alquiler)) MessageBox.Show("Propiedad Alquilada.");
        }




























        private List<string> Servicios()
        {
            List<string> servicios = new List<string>();
            if (cbCochera.Checked) servicios.Add("Cochera");
            if (cbDesayuno.Checked) servicios.Add("Desayuno");
            if (cbLimpieza.Checked) servicios.Add("Limpieza");
            if (cbMascotas.Checked) servicios.Add("Mascotas");
            if (cbPileta.Checked) servicios.Add("Pileta");
            if (cbWifi.Checked) servicios.Add("Wi Fi");
            return servicios;
        }

        
    }
}
