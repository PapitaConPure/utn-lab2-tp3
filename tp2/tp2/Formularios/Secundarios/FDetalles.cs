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
using System.Drawing.Printing;
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
			Alquiler alq = residencia.VerAlquiler((int)this.nudNroAlquiler.Value);
			bool pudo = this.residencia.QuitarAlquiler((int)this.nudNroAlquiler.Value);
			if (this.sistema.UsuarioActual.Tipo != "Administrador")
				pudo = false;
            if (pudo)
            {
				MessageBox.Show("El alquiler ha sido cancelado", "Alquiler cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("El alquiler no se ha podido cancelar", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.RefrescarListaAlquileres();
		}
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			PrintDocument aImprimir = new PrintDocument();
			PrintPreviewDialog previo = new PrintPreviewDialog();
			aImprimir.PrintPage += this.Imprimir_PrintPage;
			try
			{

				previo.Document = aImprimir;
				if (previo.ShowDialog() == DialogResult.OK)
				{
					aImprimir.Print();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
            finally
            {
				previo.Dispose();
				esPrimera = true;
			}

		}
		public bool esPrimera=true;
		private void Imprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
			Graphics g = e.Graphics;
			Alquiler alq = residencia.VerAlquiler((int)this.nudNroAlquiler.Value);
			Font encabezado = new Font("Arial", 14, FontStyle.Bold);
			Font encabezado2 = new Font("Arial", 12, FontStyle.Bold);
			Font cuerpo = new Font("Arial", 11, FontStyle.Regular);
			Image foto1 = residencia.Imágenes[0];
			Image foto2 = residencia.Imágenes[1];
			int ancho = 800;
			int y = 20;

			Pen lapiz = new Pen(Color.Black);
			Brush brush = new SolidBrush(Color.Black);
			string str;
			if (esPrimera)
			{
				str = "Original";
				e.HasMorePages = true;
			}
			else str = "Copia";

			g.DrawString(str, encabezado,brush,380,20);
			g.DrawRectangle(lapiz, 50, 50, 750, 1000);
			g.DrawImage(foto1,60,100,300,180);
			g.DrawImage(foto2, 480, 100, 300, 180);
			Image i = global::tp2.Properties.Resources.logo;
			g.DrawImage(i, 255, 550);

			string tipo;
			if (residencia is Hotel)
			{
				tipo = "Hotel";
				g.DrawString("Tipo Habitación: "+ alq.Habitacion.Tipo, encabezado2, brush, 60, 540);
			}
			else if (residencia is CasaFinde) tipo = "Casa de Fin de semana";
			else tipo = "Casa";
			int n = residencia.Número;
			string d = residencia.Dirección;
			string t = "Propiedad: " + tipo + ", Nro: " + n + ", Dirección: " + d;
			Size s = TextRenderer.MeasureText(t, encabezado);
			int x = e.PageBounds.Width / 2 - s.Width / 2;
			g.DrawString(t, encabezado, brush,
						new Rectangle(x,y+=40,ancho,y));
			y = 300;
			g.DrawString("Fecha entrada: "+alq.CheckIn.ToShortDateString(), encabezado2, brush, 60, y);
			g.DrawString("Fecha salida: " + alq.CheckOut.ToShortDateString(), encabezado2, brush, 60, y+=30);
			g.DrawString("Responsable: " + alq.Cliente.Apellido+" "+alq.Cliente.Nombre, encabezado2, brush, 60, y += 30);
			g.DrawString("Dni: " + alq.Cliente.Dni, encabezado2, brush, 60, y += 30);
			g.DrawString("Teléfono: " + alq.Cliente.Teléfono, encabezado2, brush, 60, y += 30);
			g.DrawString("Cantidad de pasajeros: " + alq.Cliente.CantPasajeros, encabezado2, brush, 60, y += 30);
			g.DrawString("Alquiler realizado el día: " + alq.FechaReserva.ToShortDateString(), encabezado2, brush, 60, y += 30);
			g.DrawString("Precio Total: $" + alq.PrecioTotal, encabezado2, brush, 60, y += 30);

			t = "Firma de la empresa";
			s = TextRenderer.MeasureText(t, cuerpo);
			g.DrawLine(lapiz, 100, 980, s.Width+100, 980);
			g.DrawString(t, cuerpo, brush, 100, 980);

			t = "Firma del cliente";
			s = TextRenderer.MeasureText(t, cuerpo);
			g.DrawLine(lapiz, 580, 980, s.Width+600, 980);
			g.DrawString(t, cuerpo, brush, 580, 980);

			esPrimera = false;
		}

		private void BtnModificarAlquiler_Click(object sender, EventArgs e) {
            Alquiler alquiler = this.residencia.VerAlquiler(Convert.ToInt32(this.nudNroAlquiler.Value));
			
			if(alquiler is null) {
				MessageBox.Show("No se encontró el alquiler", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

            FAlquiler nuevo = new FAlquiler(this.sistema, this.residencia, alquiler);

            if(nuevo.ShowDialog() != DialogResult.OK || !nuevo.Calendario.HayDíaSeleccionado) {
                MessageBox.Show("No se ha modificado el alquiler", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			this.sistema.ModificarAlquiler(
				this.residencia.Número,
				alquiler.Número,
				nuevo.Calendario.DíaSeleccionado,
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
				this.lsbAlquileres.Items.Add($"Inquilinos: {al.Cliente.CantPasajeros}");
				this.lsbAlquileres.Items.Add("----------------------------------------------------------------");
			}
		}
        #endregion

        
    }
}
