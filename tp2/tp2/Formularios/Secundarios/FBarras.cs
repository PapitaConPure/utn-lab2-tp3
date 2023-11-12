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

namespace tp2.Formularios.Secundarios
{
    public partial class FBarras : Form {
		private static readonly Color colorPrimario = Color.FromArgb(255, 190, 70);
		private static readonly Color colorSecundario = Color.FromArgb(211, 197, 197);
		private static readonly Color colorInformación = Color.FromArgb(84, 180, 211);
		private static readonly Color colorFrente = Color.FromArgb(22, 22, 22);
		private static readonly Font fuenteBarra = new Font("Segoe UI", 11);
		private static readonly Font fuenteBaseBarra = new Font("Lato Black", 10);

		private readonly Sistema sistema;
        private readonly int cnt2, cnt3, cnt4, cnt5, cnt6;
		private readonly Color colorSombra;

		public FBarras() {
            this.InitializeComponent();
        }

        public FBarras(Sistema sis): this() {
            this.sistema = sis;
            this.Text = "Cantidad de pasajeros";

			this.colorSombra = Color.FromArgb(
				(int)(this.BackColor.R * 0.72),
				(int)(this.BackColor.G * 0.69),
				(int)(this.BackColor.B * 0.80));

            foreach(Residencia r in this.sistema.Residencias) {
                foreach(Alquiler a in r.Alquileres) {
                    switch(a.Cliente.CantPasajeros) {
                    case 1:
                    case 2:
                        this.cnt2++;
                        break;

                    case 3:
						this.cnt3++;
                        break;

                    case 4:
						this.cnt4++;
                        break;

                    case 5:
						this.cnt5++;
                        break;

                    default:
						if(a.Cliente.CantPasajeros >= 6)
							this.cnt6++;
                        break;
                    }
                }
            }
        }

        private void PnlBarras_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;

			Brush brushRellenoBarras = new SolidBrush(colorPrimario);
			Brush brushSombraBarras = new SolidBrush(this.colorSombra);
			Brush brushTextoBarras = new SolidBrush(colorFrente);
			Brush brushTextoBaseBarras = new SolidBrush(colorInformación);

			int muestra = 0;
			float margenH = 0.1f;
			float margenV = 0.1f;
			float x = this.pnlBarras.Width * margenH;
			float y = this.pnlBarras.Height * (1 - margenV);
			float w = this.pnlBarras.Width * (1 - margenH * 2);
			float h = this.pnlBarras.Height * (1 - margenV * 2);
			float anchoBarra = 16;

			string[] textoBase = { "2", "3", "4", "5", "6+" };
			int[] cantidades = { this.cnt2, this.cnt3, this.cnt4, this.cnt5, this.cnt6 };
			float espaciadoBarra = w / (cantidades.Length - 1f);

			foreach(int cantidad in cantidades)
				muestra += cantidad;

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

				textoBarra = textoBase[i];
				tamañoTexto = TextRenderer.MeasureText(textoBarra, fuenteBaseBarra);
				g.DrawString(
					textoBarra,
					fuenteBaseBarra,
					brushTextoBaseBarras,
					new PointF(
						xBarra + 4f - tamañoTexto.Width * 0.5f,
						y + 4f));
			}
		}

		private void PnlBarras_SizeChanged(object sender, EventArgs e) {
			this.pnlBarras.Invalidate();
		}

		private float CalcularAltura(int clase, int muestra, float alturaMáxima) {
			if(muestra == 0)
				return 1f;

			return clase * alturaMáxima / muestra;
		}
	}
}
