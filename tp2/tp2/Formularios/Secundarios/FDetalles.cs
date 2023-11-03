using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerLib;
namespace tp2
{
    public partial class FDetalles : Form
    {
        private readonly Sistema sistema;
        private readonly Residencia residencia;

        public FDetalles() {
            this.InitializeComponent();
        }

        public FDetalles(Sistema sistema, Residencia residencia): this() {
            this.sistema = sistema;
            this.residencia = residencia;
			this.RefrescarDetalles();
			this.RefrescarListaAlquileres();
			this.pbImagen1.Image = residencia.Imágenes[0];
			this.pbImagen2.Image = residencia.Imágenes[1];
		}

		private void BtnAlquilar_Click(object sender, EventArgs e) {
			FAlquiler fAlquiler = new FAlquiler(this.sistema, this.residencia);

			fAlquiler.ShowDialog();
			fAlquiler.Dispose();

			this.RefrescarListaAlquileres();
		}

		private void BtnCancelarAlquiler_Click(object sender, EventArgs e) {
			bool pudo = this.residencia.QuitarAlquiler((int)this.nudNroAlquiler.Value);

			if(pudo)
				MessageBox.Show("El alquiler ha sido cancelado", "Alquiler cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("El alquiler no se ha podido cancelar", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.RefrescarListaAlquileres();
		}

		private void BtnModificarAlquiler_Click(object sender, EventArgs e) {
            Alquiler alquiler = this.residencia.VerAlquiler(Convert.ToInt32(this.nudNroAlquiler.Value));

			if(alquiler is null) {
				MessageBox.Show("No se encontró el alquiler", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

            FAlquiler nuevo = new FAlquiler(this.sistema, this.residencia, alquiler);

            if(nuevo.ShowDialog() != DialogResult.OK)
                MessageBox.Show("No se ha modificado el alquiler", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.sistema.ModificarAlquiler(
				this.residencia.Número,
				alquiler.Número,nuevo.Calendario.DíaSeleccionado,
				nuevo.Calendario.DíaSeleccionado.AddDays(Convert.ToInt32(nuevo.nudCantDias.Value)));

            MessageBox.Show($"Se aplicaron los cambios", "Alquiler modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nuevo.Dispose();

			this.RefrescarListaAlquileres();
		}

		#region Refrescar Información
		private void RefrescarDetalles() {
			this.lsbDetalles.Items.Add($"Nro Propiedad: {this.residencia.Número}");
			this.lsbDetalles.Items.Add($"Direccion: {this.residencia.Dirección}");
			this.lsbDetalles.Items.Add($"Precio: {this.residencia.CalcularPrecioTotal() * this.sistema.PrecioBase}");

			if(this.residencia is Hotel) {
				Hotel hotel = this.residencia as Hotel;
				this.lsbDetalles.Items.Add($"Estrellas: {hotel.Estrellas}");
				this.lsbDetalles.Items.Add($"Cantidad de habitaciones:");
				this.lsbDetalles.Items.Add($"Simples: {hotel.CntSimple}");
				this.lsbDetalles.Items.Add($"Dobles: {hotel.CntDoble}");
				this.lsbDetalles.Items.Add($"Triples: {hotel.CntTriple}");
			} else if(this.residencia is Casa) {
				Casa casa = this.residencia as Casa;
				this.lsbDetalles.Items.Add($"Minimo de dias: {casa.MínimoPermitido}");
				this.lsbDetalles.Items.Add($"Cantidad de camas: {casa.CamasDisponibles}");
				this.lsbDetalles.Items.Add($"Propietario:");
				this.lsbDetalles.Items.Add($"Apellido: {casa.Propietario.Apellido}, Nombre: {casa.Propietario.Nombre}");
				this.lsbDetalles.Items.Add($"Dni: {casa.Propietario.Dni}, Tel:{casa.Propietario.Teléfono}");
			}

			StringBuilder stringServicios = new StringBuilder();
			foreach(string s in this.residencia.VerServicios()) {
				if(s != null) {
					if(stringServicios.Length > 0)
						stringServicios.Append(", ");

					stringServicios.Append(s);
				}
			}
			this.lsbDetalles.Items.Add($"Servicios: {stringServicios}");
		}

		private void RefrescarListaAlquileres() {
			Alquiler[] alquileres = this.residencia.Alquileres;
			this.lsbAlquileres.Items.Clear();

			if(alquileres.Length == 0) {
				this.lsbAlquileres.Items.Add("Esta residencia no ha sido alquilada...");
				return;
			}

			foreach(Alquiler al in alquileres) {
				this.lsbAlquileres.Items.Add($"Nro de alquiler: {al.Número}");
				if(this.residencia is Hotel) {
					this.lsbAlquileres.Items.Add($"Habitacion: {al.Habitacion.Tipo}");
				}
				this.lsbAlquileres.Items.Add($"Fecha de CheckIn: {al.CheckIn:d}");
				this.lsbAlquileres.Items.Add($"Fecha de CheckOut: {al.CheckOut:d}");
				this.lsbAlquileres.Items.Add($"Fecha de Reserva: {al.FechaReserva:g}");
				this.lsbAlquileres.Items.Add($"Precio Total: ${al.PrecioTotal:F2}");
				this.lsbAlquileres.Items.Add($"Nombre del cliente: {al.Cliente.Nombre} {al.Cliente.Apellido}");
				this.lsbAlquileres.Items.Add($"Dni: {al.Cliente.Dni:00,000,000}");
				this.lsbAlquileres.Items.Add("----------------------------------------------------------------");
			}
		}
		#endregion
	}
}
