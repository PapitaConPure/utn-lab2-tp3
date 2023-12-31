﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerLib;
using cargandoImagenes;

namespace tp2 {
    public partial class FHotel : Form {
		private readonly Sistema sistema;
		private readonly FImagen fImagen;
		private CheckBox[] servicios;
		private Hotel hotel;

		public Image[] Imágenes {
			get { return this.fImagen.Imágenes; }
		}

		public FHotel() {
			this.InitializeComponent();

			this.servicios = new CheckBox[] {
				this.chbGarage,
				this.chbDesayuno,
				this.chbLimpieza,
				this.chbPermiteMascotas,
				this.chbPileta,
				this.chbWIFI,
			};

			this.tbDireccionHotel.Enabled = true;
			this.nudNroPropiedad.Enabled = true;
			this.trbEstrellas.Enabled = true;
		}

		public FHotel(Sistema sistema): this() {
			this.sistema = sistema;
			this.fImagen = new FImagen();
		}

		public FHotel(Sistema sistema, Hotel hotel): this() {
			this.sistema = sistema;
			this.fImagen = new FImagen(hotel.Imágenes);
			this.hotel = hotel;

			this.gbDatos.Enabled
			= this.gbEstrellas.Enabled
				= false;

			this.tbDireccionHotel.Text = hotel.Dirección;
			this.nudNroPropiedad.Value = hotel.Número;
		}

		~FHotel() {
			if(this.fImagen != null)
				this.fImagen.Dispose();
		}

		private void FAgregarHotel_Load(object sender, EventArgs e) {
			Font fuente = new Font(Estilos.LatoBlack, 9);
			this.gbDatos.Font = fuente;
			this.gbEstrellas.Font = fuente;
			this.gbPlazas.Font = fuente;
			this.gbServicios.Font = fuente;
		}

		private void FAgregarHotel_Shown(object sender, EventArgs e) {
			this.tbMuestraEstrellas.Text = this.trbEstrellas.Value.ToString();
		}

		private void TrbEstrellas_ValueChanged(object sender, EventArgs e) {
			this.tbMuestraEstrellas.Text = this.trbEstrellas.Value.ToString();
		}

		private void BtnAgregarImagen_Click(object sender, EventArgs e) {
			this.fImagen.ShowDialog();
		}

		private void BtnCrear_Click(object sender, EventArgs e) {
			try {
				if(this.hotel is null) {
					this.hotel = new Hotel(
						(int)this.nudNroPropiedad.Value,
						this.tbDireccionHotel.Text,
						this.trbEstrellas.Value,
						(int)this.nudSimples.Value,
						(int)this.nudDobles.Value,
						(int)this.nudTriples.Value,
						this.Imágenes);

					foreach(CheckBox servicio in this.servicios) {
						if(servicio.Checked)
							this.hotel.AgregarServicio(servicio.Text);
					}

					this.sistema.AgregarResidencia(this.hotel);
				} else {
					this.hotel.CntSimple += (int)this.nudSimples.Value;
					this.hotel.CntDoble += (int)this.nudDobles.Value;
					this.hotel.CntTriple += (int)this.nudTriples.Value;

					this.hotel.LimpiarServicios();
					foreach(CheckBox servicio in this.servicios) {
						if(servicio.Checked)
							this.hotel.AgregarServicio(servicio.Text);
					}
				}
			} catch(Exception ex) {
				MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
			}
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
