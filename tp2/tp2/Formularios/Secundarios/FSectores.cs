using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp2.Formularios;
using AlquilerLib;

namespace tp2.Formularios.Secundarios {
	public partial class FSectores: Form {
		private static readonly Color colorPrimario = Color.FromArgb(255, 190, 70);
		private static readonly Color colorSecundario = Color.FromArgb(211, 197, 197);
		private static readonly Color colorInformación = Color.FromArgb(84, 180, 211);
		private static readonly Color colorFrente = Color.FromArgb(22, 22, 22);
		private static readonly Font fuenteSector = new Font("Segoe UI Semibold", 11);
		private static readonly Font fuenteDetalle = new Font("Lato Black", 10);

		private readonly Sector[] sectores = {
			new Sector("Casas", Color.FromArgb(240, 62, 67)),
			new Sector("Casas Finde", Color.FromArgb(62, 240, 109)),
			new Sector("Hoteles", Color.FromArgb(84, 180, 211)),
		};

		private readonly Sistema sistema;

		public FSectores() {
			this.InitializeComponent();
		}

		public FSectores(Sistema sis) : this() {
			this.sistema = sis;
			this.Text = "Cantidad de Reservas";

			foreach(Residencia residencia in this.sistema.Residencias) {
				if(residencia is Casa)
					this.sectores[0].Peso++;
				else if(residencia is CasaFinde)
					this.sectores[1].Peso++;
				else if(residencia is Hotel)
					this.sectores[2].Peso++;
			}

			this.lbCasas.Text = $"{this.sectores[0].Nombre}: {this.sectores[0].Peso}";
			this.lbHoteles.Text = $"{this.sectores[2].Nombre}: {this.sectores[2].Peso}";
		}

		private void FSectores_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;

			int s;
			if(this.Width < this.Height)
				s = this.Width;
			else
				s = this.Height;

			int x = (int)(s * 0.2);
			int y = (int)(s * 0.2);
			int h = (int)(s * 0.65);
			int w = (int)(s * 0.55);
			Rectangle rectangulo = new Rectangle(x, y, w, h);

			int total = 0;

			foreach(Sector sector in this.sectores)
				total += sector.Peso;

			if(total == 0) {
				g.FillPie(new SolidBrush(Color.Gray), rectangulo, 0, 360);
				return;
			}

			//Desplazamiento del ángulo inicial 0 = Este, 90 = Sur, 180 = Oeste, 270 = Norte
			float desplazamiento = 270f;
			float ánguloInicio;
			float ánguloFin = desplazamiento;
			float ángulo;
			Size tamañoTexto;
			string texto;
			Pen penSector = new Pen(this.BackColor, s * 0.01f);
			Brush brushSector;

			this.sectores[0].Peso = 3;
			this.sectores[1].Peso = 2;
			this.sectores[2].Peso = 1;

			int i = 0;
			foreach(Sector sector in this.sectores) {
				brushSector = new SolidBrush(sector.Color);
				int cantidad = sector.Peso;
				ánguloInicio = ánguloFin;

				if(i < this.sectores.Length - 1)
					ánguloFin = ánguloInicio + 360f * cantidad / total;
				else
					ánguloFin = desplazamiento + 360f;

				ángulo = ánguloFin - ánguloInicio;

				texto = sector.Nombre;
				if(ángulo >= 30) {
					tamañoTexto = TextRenderer.MeasureText(texto, fuenteSector);
				}

				if(ánguloInicio != ánguloFin) {
					g.DrawPie(penSector, rectangulo, ánguloInicio, ánguloFin - ánguloInicio);
					g.FillPie(brushSector, rectangulo, ánguloInicio, ánguloFin - ánguloInicio);
				}


				i++;
			}
		}
    }

	//Clase de utilidad para almacenar datos varios de un sector nomás
	//Se puede hacer sin ella pero queda más cómodo y fácil de trabajar así
	class Sector {
		public string Nombre { get; private set; }

		public Color Color { get; private set; }

		public int Peso { get; set; }

		public Sector(string nombre, Color color) {
			this.Nombre = nombre;
			this.Color = color;
			this.Peso = 0;
		}
	}
}
