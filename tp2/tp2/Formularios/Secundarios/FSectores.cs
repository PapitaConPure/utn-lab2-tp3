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

			int x = (int)(this.Width * 0.2);
			int y = (int)(this.Height * 0.2);
			int h = (int)(this.Height * 0.65);
			int w = (int)(this.Width * 0.55);
			Rectangle rectangulo = new Rectangle(x, y, w, h);

			int total = 0;

			foreach(Sector sector in this.sectores)
				total += sector.Peso;

			if(total == 0) {
				g.FillPie(new SolidBrush(Color.Gray), rectangulo, 0, 360);
				return;
			}

			Brush brushSector;
			float ánguloInicio;
			float ánguloFin = 0f;
			int i = 0;
			foreach(Sector sector in this.sectores) {
				if(i > 1) break;
				brushSector = new SolidBrush(sector.Color);
				int cantidad = sector.Peso;
				ánguloInicio = ánguloFin;

				if(i < this.sectores.Length - 1)
					ánguloFin = ánguloInicio + 360f * cantidad / total;
				else
					ánguloFin = 360f;

				if(ánguloInicio != ánguloFin)
					g.FillPie(brushSector, rectangulo, ánguloInicio, ánguloFin);

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
