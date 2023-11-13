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
using System.Security.Cryptography.X509Certificates;

namespace tp2
{
    public partial class FDetalles : Form
    {
        private readonly Sistema sistema;
        private readonly Residencia residencia;
		private Alquiler alquiler;
		private bool esPrimera;

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
			esPrimera = true;
		}

		private void BtnAlquilar_Click(object sender, EventArgs e) {
			FAlquiler fAlquiler = new FAlquiler(this.sistema, this.residencia);

			fAlquiler.ShowDialog();
			fAlquiler.Dispose();

			this.RefrescarListaAlquileres();
		}

		private void BtnCancelarAlquiler_Click(object sender, EventArgs e) {
			Alquiler alq = residencia.VerAlquiler((int)this.nudNroAlquiler.Value);
			bool pudo;
			if (this.sistema.UsuarioActual.Tipo != "Administrador")
				pudo = false;
			else
				 pudo = this.residencia.QuitarAlquiler((int)this.nudNroAlquiler.Value);
			
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
			this.alquiler = this.residencia.VerAlquiler((int)this.nudNroAlquiler.Value);
			if(this.alquiler is null) {
				MessageBox.Show("No se encontró el alquiler", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

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

        
        private void Imprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
			Graphics g = e.Graphics;
			Font encabezado = new Font("Segoe UI Black", 14, FontStyle.Bold);
			Font encabezado2 = new Font("Segoe UI", 12, FontStyle.Bold);
			Font cuerpo = new Font("Segoe UI", 12);
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
				esPrimera = false;
			}
			else
			{
				str = "Copia";
				e.HasMorePages = false;
				esPrimera = true;
			}

			int margenH = 50;
			int margenV = 50;
			int relleno = 10;
			Rectangle página = new Rectangle(
				e.PageBounds.Left + margenH,
				e.PageBounds.Top + margenV,
				e.PageBounds.Width - margenH * 2,
				e.PageBounds.Height - margenV * 2);

			g.DrawString(str, encabezado,brush,380,20);
			g.DrawRectangle(lapiz, página);
			g.DrawImage(foto1, página.Left + relleno, 100, 300, 180);
			g.DrawImage(foto2, página.Right - relleno - 300, 100, 300, 180);
			Image i = global::tp2.Properties.Resources.logo;

			int tamañoMarcaAgua = 640;
			g.DrawImage(i,
				e.PageBounds.Width / 2 - tamañoMarcaAgua / 2,
				640 - tamañoMarcaAgua / 2,
				tamañoMarcaAgua,
				tamañoMarcaAgua);

			string tipo;
			int rellenoInfo = 20;
			int xl = página.Left + rellenoInfo;
			int xr = página.Right - rellenoInfo;
			if(residencia is Hotel) {
				tipo = "Hotel";
				g.DrawString($"Habitación {this.alquiler.Habitacion.Tipo}", encabezado2, brush, xl, 540);
			} else if (residencia is CasaFinde) tipo = "Casa de fin de semana";
			else tipo = "Casa";
			int n = residencia.Número;
			string d = residencia.Dirección;
			string t = $"{tipo}   Nro: {n}   Dirección: {d}";
			Size s = TextRenderer.MeasureText(t, encabezado);
			int x = e.PageBounds.Width / 2 - s.Width / 2;
			g.DrawString(t, encabezado, brush,
						new Rectangle(x,y+=40,ancho,y));

			y = 300;
			string textoDerecha = this.alquiler.CheckIn.ToShortDateString();
			g.DrawString("Fecha de Check-in", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = this.alquiler.CheckOut.ToShortDateString();
			g.DrawString($"Fecha de Check-out", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = $"{this.alquiler.Cliente.Apellido} {this.alquiler.Cliente.Nombre}";
			g.DrawString("Responsable", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = this.alquiler.Cliente.Dni.ToString();
			g.DrawString("Dni", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = this.alquiler.Cliente.Teléfono.ToString();
			g.DrawString("Teléfono", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = this.alquiler.Cliente.CantPasajeros.ToString();
			g.DrawString("Cantidad de pasajeros", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = $"{this.alquiler.FechaReserva:dd/MM/yy HH:mm:ss}";
			g.DrawString("Fecha de reserva", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);
			y += 30;

			textoDerecha = $"${this.alquiler.PrecioTotal:F2}";
			g.DrawString("Precio Total", encabezado2, brush, xl, y);
			g.DrawString(textoDerecha, cuerpo, brush, xr - AnchoTexto(textoDerecha, cuerpo), y);

			int xx = página.Left + relleno;
			y = 560;
			g.DrawString("Inquilinos adicionales", encabezado2, brush, página.Left + relleno, y);
			y += 26;
			g.DrawString("Dni", encabezado2, brush, página.Left + relleno, y);
			xx += 100;
			g.DrawString("Nombre", encabezado2, brush, xx, y);
			xx += 250;
			g.DrawString("Apellido", encabezado2, brush, xx, y);
			xx += 250;
			g.DrawString("Nacimiento", encabezado2, brush, xx, y);
			y += 30;
			foreach(Persona p in this.alquiler.Cliente.Pasajeros) {
				xx = página.Left + relleno;
				g.DrawString($"{p.Dni:##,###,###}", cuerpo, brush, xx, y);
				xx += 100;
				g.DrawString(p.Nombre, cuerpo, brush, xx, y);
				xx += 250;
				g.DrawString(p.Apellido, cuerpo, brush, xx, y);
				xx += 250;
				g.DrawString(p.FechaNacimiento.ToShortDateString(), cuerpo, brush, xx, y);
				y += 26;
			}

			t = "Firma de la empresa";
			s = TextRenderer.MeasureText(t, cuerpo);
			g.DrawLine(lapiz, 100, 980, s.Width+100, 980);
			g.DrawString(t, cuerpo, brush, 100, 980);

			t = "Firma del cliente";
			s = TextRenderer.MeasureText(t, cuerpo);
			g.DrawLine(lapiz, 580, 980, s.Width+600, 980);
			g.DrawString(t, cuerpo, brush, 580, 980);
        }

		private static int AnchoTexto(string textoDerecha, Font cuerpo) => TextRenderer.MeasureText(textoDerecha, cuerpo).Width;

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
