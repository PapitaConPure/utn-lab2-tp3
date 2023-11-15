using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlquilerLib;

namespace tp2.Formularios.Secundarios
{
    public partial class FBarras : Form {
		private static readonly Color colorPrimario = Color.FromArgb(255, 190, 70);
		private static readonly Color colorSecundario = Color.FromArgb(211, 197, 197);
		private static readonly Color colorInformación = Color.FromArgb(84, 180, 211);
		private static readonly Color colorFrente = Color.FromArgb(236, 236, 236);
		private static readonly Font fuenteBarra = new Font(Estilos.SegoeUI, 11);
		private static readonly Font fuenteBaseBarra = new Font(Estilos.LatoBlack, 10);

		private readonly Sistema sistema;
		private readonly string[] nombresBarra;
		private readonly int[] cantidades;
		private readonly Color colorSombra;

		public FBarras() {
            this.InitializeComponent();
		}

        public FBarras(Sistema sis): this() {
            this.sistema = sis;

			this.colorSombra = Color.FromArgb(
				(int)(this.BackColor.R * 0.72),
				(int)(this.BackColor.G * 0.69),
				(int)(this.BackColor.B * 0.80));
			
			//Para agregar nuevas barras, solo modificar acá
			Dictionary<string, int> barras = new Dictionary<string, int>();
			barras.Add("2", 0);
			barras.Add("3", 0);
			barras.Add("4", 0);
			barras.Add("5", 0);
			barras.Add("6+", 0);

			foreach(Residencia r in this.sistema.Residencias) {
                foreach(Alquiler a in r.Alquileres) {
                    switch(a.Cliente.CantPasajeros) {
                    case 1:
                    case 2:
						barras["2"]++;
                        break;

                    case 3:
						barras["3"]++;
                        break;

                    case 4:
						barras["4"]++;
                        break;

                    case 5:
						barras["5"]++;
                        break;

                    default:
						if(a.Cliente.CantPasajeros >= 6)
							barras["6+"]++;
                        break;
                    }
                }
            }

			this.nombresBarra = new string[barras.Count];
			this.cantidades = new int[barras.Count];
			int c = 0;
			foreach(KeyValuePair<string, int> barra in barras) {
				this.nombresBarra[c] = barra.Key;
				this.cantidades[c++] = barra.Value;
			}
		}

        private void PnlBarras_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;

			Brush brushRellenoBarras = new SolidBrush(colorPrimario);
			Brush brushSombraBarras = new SolidBrush(this.colorSombra);
			Brush brushTextoBarras = new SolidBrush(colorFrente);
			Brush brushTextoBaseBarras = new SolidBrush(colorInformación);

			float margenH = 0.1f;
			float margenV = 0.1f;
			float x = this.pnlBarras.Width * margenH;
			float y = this.pnlBarras.Height * (1 - margenV);
			float w = this.pnlBarras.Width * (1 - margenH * 2);
			float h = this.pnlBarras.Height * (1 - margenV * 2);
			float anchoBarra = 16;

			float espaciadoBarra = w / (cantidades.Length - 1f);

			int mayor = 0, total = 0;
			foreach(int cantidad in cantidades) {
				total += cantidad;
				if(mayor < cantidad)
					mayor = cantidad;
			}
			
			float muestra = 0.75f * mayor + 0.25f * total;

			float xBarra, hBarra;
			Size tamañoTexto;
			string textoBarra;
			RectangleF rectBarra, rectSombra;
			for(int i = 0; i < cantidades.Length; i++) {
				int cantidad = cantidades[i];
				xBarra = x + i * espaciadoBarra;
				hBarra = this.CalcularAltura(cantidad, muestra, h);

				rectBarra = new RectangleF(
					xBarra - anchoBarra * 0.5f,
					y - hBarra,
					anchoBarra,
					hBarra + 2f);

				rectSombra = rectBarra;
				rectSombra.Offset(2f, 2f);

				g.FillRectangle(brushSombraBarras, rectSombra);
				g.FillRectangle(brushRellenoBarras, rectBarra);

				textoBarra = cantidad.ToString();
				tamañoTexto = TextRenderer.MeasureText(textoBarra, fuenteBarra);
				g.DrawString(
					textoBarra,
					fuenteBarra,
					brushTextoBarras,
					new PointF(
						xBarra + 2f - tamañoTexto.Width * 0.5f,
						y - hBarra - tamañoTexto.Height));

				textoBarra = nombresBarra[i];
				tamañoTexto = TextRenderer.MeasureText(textoBarra, fuenteBaseBarra);
				g.DrawString(
					textoBarra,
					fuenteBaseBarra,
					brushTextoBaseBarras,
					new PointF(
						xBarra + 2f - tamañoTexto.Width * 0.5f,
						y + 2f));
			}
		}

		private void PnlBarras_SizeChanged(object sender, EventArgs e) {
			this.pnlBarras.Invalidate();
		}

		private float CalcularAltura(int clase, float muestra, float alturaMáxima) {
			if(muestra == 0)
				return 1f;

			return clase * alturaMáxima / muestra;
		}
	}
}
