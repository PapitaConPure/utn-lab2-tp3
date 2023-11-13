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
		private static readonly Color colorTextoAlt = Color.FromArgb(182, 158, 158);
		private static readonly Font fuenteSector = new Font("Segoe UI Semibold", 11);

		private readonly Sector[] sectores = {
			new Sector("Casas", Color.FromArgb(219, 64, 69)),
			new Sector("Casas Finde", Color.FromArgb(40, 185, 86)),
			new Sector("Hoteles", Color.FromArgb(87, 156, 179)),
			//new Sector("Habitaciones", Color.FromArgb(240, 208, 0)),
		};

		private readonly Sistema sistema;

		public FSectores() {
			this.InitializeComponent();
		}

		public FSectores(Sistema sis): this() {
			this.sistema = sis;

			foreach(Residencia residencia in this.sistema.Residencias) {
				if(residencia is CasaFinde)
					this.sectores[1].Peso += residencia.Alquileres.Length;
				else if(residencia is Casa)
					this.sectores[0].Peso += residencia.Alquileres.Length;
				else if(residencia is Hotel)
					this.sectores[2].Peso += residencia.Alquileres.Length;
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
			int cx = this.pnlSectores.Width / 2;
			int cy = this.pnlSectores.Height / 2;
			int x = cx - sm;
			int y = cy - sm;
			Rectangle rectangulo = new Rectangle(x, y, ss, ss);

			int total = 0;
			Sector primero = null;
			foreach(Sector sector in this.sectores) {
				total += sector.Peso;
				if(sector.Peso > 0 && primero is null)
					primero = sector;
			}

			if(total == 0) {
				g.FillEllipse(new SolidBrush(Color.Gray), rectangulo);
				return;
			}

			if(total == primero.Peso) {
				Size tt = TextRenderer.MeasureText(primero.Nombre, fuenteSector);
				g.FillEllipse(new SolidBrush(primero.Color), rectangulo);
				g.DrawString(
					primero.Nombre,
					fuenteSector,
					new SolidBrush(Color.White),
					cx - tt.Width / 2,
					cy - tt.Height / 2);

				return;
			}

			Sector[] sectores = this.SectoresOrdenados();

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
			foreach(Sector sector in sectores) {
				int cantidad = sector.Peso;
				ánguloInicio = ánguloFin;

				if(i < sectores.Length - 1)
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
			float radioExTextos = 1.02f;
			float aumentoRadioEx = 0.06f;
			string texto;
			Size tamañoTexto;
			PointF puntoTextoSector;
			ánguloFin = desplazamiento;
			i = 0;
			foreach(Sector sector in sectores) {
				int cantidad = sector.Peso;
				ánguloInicio = ánguloFin;

				if(i < sectores.Length - 1)
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

				if(ángulo >= 18) {
					brushTextoSector = new SolidBrush(Color.White);
					puntoTextoSector = new PointF(
						cx + sm * radioTextos * seno - tamañoTexto.Width / 2,
						cy + sm * radioTextos * coseno - tamañoTexto.Height / 2);
				} else {
					float tw = tamañoTexto.Width / 2;
					float th = tamañoTexto.Height / 2;
					brushTextoSector = new SolidBrush(colorTextoAlt);
					puntoTextoSector = new PointF(
						cx + sm * radioExTextos * seno - tw + tw * seno,
						cy + sm * radioExTextos * coseno - th + th * coseno);
					radioExTextos += aumentoRadioEx;
				}

				g.DrawString(texto, fuenteSector, brushTextoSector, puntoTextoSector);

				i++;
			}
			#endregion
		}

		private Sector[] SectoresOrdenados() {
			Sector[] vec = new Sector[this.sectores.Length];
			this.sectores.CopyTo(vec, 0);

			int l = vec.Length;
			Sector aux;
			int i, j;

			for(i = 0; i < l - 1; i++) {
				aux = vec[i];
				for(j = i + 1; j < l; j++) {
					if(aux.Peso < vec[j].Peso) {
						vec[i] = vec[j];
						vec[j] = aux;
						aux = vec[i];
					}
				}
			}

			return vec;
		}

		#region Para pruebas
		private void PnlSectores_SizeChanged(object sender, EventArgs e) {
			this.pnlSectores.Invalidate();
		}

		private void btnap_Click(object sender, EventArgs e) {
			this.sectores[0].Peso++;
			this.pnlSectores.Invalidate();
		}

		private void btnbp_Click(object sender, EventArgs e) {
			this.sectores[1].Peso++;
			this.pnlSectores.Invalidate();
		}

		private void btncp_Click(object sender, EventArgs e) {
			this.sectores[2].Peso++;
			this.pnlSectores.Invalidate();
		}

		private void btnam_Click(object sender, EventArgs e) {
			if(this.sectores[0].Peso > 0)
				this.sectores[0].Peso--;
			this.pnlSectores.Invalidate();
		}

		private void btnbm_Click(object sender, EventArgs e) {
			if(this.sectores[1].Peso > 0)
				this.sectores[1].Peso--;
			this.pnlSectores.Invalidate();
		}

		private void btncm_Click(object sender, EventArgs e) {
			if(this.sectores[2].Peso > 0)
				this.sectores[2].Peso--;
			this.pnlSectores.Invalidate();
		}
		#endregion
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
