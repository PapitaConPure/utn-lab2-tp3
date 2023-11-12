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
using System.Drawing.Drawing2D;

namespace tp2.Formularios.Secundarios {
	public partial class FSectores: Form {
		private static readonly Color colorTextoAlt = Color.FromArgb(22, 22, 22);
		private static readonly Font fuenteSector = new Font("Segoe UI Semibold", 11);

		private readonly Sector[] sectores = {
			new Sector("Casas", Color.FromArgb(219, 64, 69)),
			new Sector("Casas Finde", Color.FromArgb(56, 214, 98)),
			new Sector("Hoteles", Color.FromArgb(84, 180, 211)),
		};

		private readonly Sistema sistema;

		public FSectores() {
			this.InitializeComponent();
		}

		public FSectores(Sistema sis): this() {
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
		}

		private void FSectores_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias; //Le mete borde suavecito :3

			int s;
			if(this.pnlSectores.Width < this.pnlSectores.Height)
				s = this.pnlSectores.Width;
			else
				s = this.pnlSectores.Height;

			double margen = 0.15;
			int ss = (int)(s * (1 - margen * 2));
			int sm = ss / 2;
			int x = this.pnlSectores.Width / 2 - sm;
			int y = this.pnlSectores.Height / 2 - sm;
			Rectangle rectangulo = new Rectangle(x, y, ss, ss);

			int total = 0;

			foreach(Sector sector in this.sectores)
				total += sector.Peso;

			if(total == 0) {
				g.FillPie(new SolidBrush(Color.Gray), rectangulo, 0, 360);
				return;
			}

			//Desplazamiento del ángulo inicial: 0 = Este, 90 = Sur, 180 = Oeste, 270 = Norte
			float desplazamiento = 270f;
			float ánguloInicio;
			float ánguloFin = desplazamiento;
			float ángulo;
			Pen penSector = new Pen(this.BackColor, 1f);
			Brush brushSector;
			Brush brushTextoSector;
			int i = 0;

			#region Rellenos de torta
			foreach(Sector sector in this.sectores) {
				int cantidad = sector.Peso;
				ánguloInicio = ánguloFin;

				if(i < this.sectores.Length - 1)
					ánguloFin = ánguloInicio + 360f * cantidad / total;
				else
					ánguloFin = desplazamiento + 360f;

				if(ánguloInicio == ánguloFin)
					continue;

				ángulo = ánguloFin - ánguloInicio;
				brushSector = new SolidBrush(sector.Color);
				g.FillPie(brushSector, rectangulo, ánguloInicio, ánguloFin - ánguloInicio);
				g.DrawPie(penSector, rectangulo, ánguloInicio, ánguloFin - ánguloInicio);

				i++;
			}
			#endregion

			#region Textos de Torta
			float ánguloMedio;
			float seno, coseno;
			float radioTextos = 0.6f; // Qué tan alejado está un texto del centro del pastel, del 0 al 1
			string texto;
			Size tamañoTexto;
			PointF puntoTextoSector;
			ánguloFin = desplazamiento;
			i = 0;
			foreach(Sector sector in this.sectores) {
				int cantidad = sector.Peso;
				ánguloInicio = ánguloFin;

				if(i < this.sectores.Length - 1)
					ánguloFin = ánguloInicio + 360f * cantidad / total;
				else
					ánguloFin = desplazamiento + 360f;

				if(ánguloInicio == ánguloFin)
					continue;

				ángulo = ánguloFin - ánguloInicio;
				ánguloMedio = (ánguloInicio + ánguloFin) * 0.5f;
				seno = (float)Math.Cos(ánguloMedio * Math.PI / 180);
				coseno = (float)Math.Sin(ánguloMedio * Math.PI / 180);

				texto = sector.Nombre;
				tamañoTexto = TextRenderer.MeasureText(texto, fuenteSector);

				if(ángulo >= 12) {
					brushTextoSector = new SolidBrush(Color.White);
					puntoTextoSector = new PointF(
						this.pnlSectores.Width / 2 + sm * radioTextos * seno - tamañoTexto.Width / 2,
						this.pnlSectores.Height / 2 + sm * radioTextos * coseno - tamañoTexto.Height / 2);
				} else {
					brushTextoSector = new SolidBrush(colorTextoAlt);
					puntoTextoSector = new PointF(
						this.pnlSectores.Width / 2 + sm * seno - tamañoTexto.Width / 2 + tamañoTexto.Width / 2 * seno,
						this.pnlSectores.Height / 2 + sm * coseno - tamañoTexto.Height / 2 + tamañoTexto.Height / 2 * coseno);
				}

				g.DrawString(texto, fuenteSector, brushTextoSector, puntoTextoSector);

				i++;
			}
			#endregion
		}

		private void PnlSectores_SizeChanged(object sender, EventArgs e) {
			this.pnlSectores.Invalidate();
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
