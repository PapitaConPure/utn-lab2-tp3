using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AlquilerLib;

namespace tp2.Formularios.Secundarios
{
    public partial class FBarras : Form {
		private readonly Sistema sistema;
		private readonly string[] nombresBarra;
		private readonly int[] cantidades;

		public FBarras() {
            this.InitializeComponent();
		}

        public FBarras(Sistema sis): this() {
            this.sistema = sis;
			
			//Para agregar nuevas barras, solo modificar acá
			List<Barra> barras = new List<Barra>();
			barras.Add(new Barra(2, 0));
			barras.Add(new Barra(3, 0));
			barras.Add(new Barra(4, 0));
			barras.Add(new Barra(5, 0));
			barras.Add(new Barra(6, 0));

			int cntPasajeros;
			Barra búsqueda;
			foreach(Residencia r in this.sistema.Residencias) {
                foreach(Alquiler a in r.Alquileres) {
					cntPasajeros = a.Cliente.CantPasajeros;
					búsqueda = new Barra(cntPasajeros, 0);

					barras.Add(new Barra(a.Cliente.CantPasajeros, 1));
                }
            }

			barras.Sort();
			Barra removida;
			for(int i = 1; i < barras.Count; i++) {
				if(barras[i].CompareTo(barras[i - 1]) == 0) {
					removida = barras[i];
					barras.RemoveAt(i);
					barras[--i].Valor += removida.Valor;
				}
			}

			this.nombresBarra = new string[barras.Count];
			this.cantidades = new int[barras.Count];
			int c = 0;
			foreach(Barra barra in barras) {
				this.nombresBarra[c] = barra.Clase;
				this.cantidades[c++] = barra.Valor;
			}
		}

        private void PnlBarras_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;

			Brush brushRellenoBarras = new SolidBrush(Estilos.PrimaryColor);
			//Brush brushSombraBarras = new SolidBrush(Estilos.BackgroundColorDark2);
			Brush brushTextoBarras = new SolidBrush(Estilos.TextColor);
			Brush brushTextoBaseBarras = new SolidBrush(Estilos.AccentColor);

			float margenH = 0.1f;
			float margenV = 0.15f;
			float x = this.pnlBarras.Width * margenH;
			float y = this.pnlBarras.Height * (1 - margenV);
			float w = this.pnlBarras.Width * (1 - margenH * 2);
			float h = this.pnlBarras.Height * (1 - margenV * 2);
			float anchoBarra = 16;

			float espaciadoBarra = w / (this.cantidades.Length - 1f);

			int mayor = 0, total = 0;
			foreach(int cantidad in this.cantidades) {
				total += cantidad;
				if(mayor < cantidad)
					mayor = cantidad;
			}
			
			float muestra = 0.8f * mayor + 0.2f * total;
			float xBarra, hBarra;

			Font fuenteBarra = new Font(Estilos.SegoeUI, 11);
			string textoBarra;
			Size tamañoTexto;
			RectangleF rectBarra/*, rectSombra*/;
			for(int i = 0; i < this.cantidades.Length; i++) {
				int cantidad = this.cantidades[i];
				xBarra = x + i * espaciadoBarra;
				hBarra = this.CalcularAltura(cantidad, muestra, h);

				if(hBarra > 0) {
					rectBarra = new RectangleF(
						xBarra - anchoBarra * 0.5f,
						y - hBarra,
						anchoBarra,
						hBarra + 2f);

					//rectSombra = rectBarra;
					//rectSombra.Offset(4f, 3f);

					//g.FillRectangle(brushSombraBarras, rectSombra);
					g.FillRectangle(brushRellenoBarras, rectBarra);
				}

				textoBarra = cantidad.ToString();
				tamañoTexto = TextRenderer.MeasureText(textoBarra, fuenteBarra);
				g.DrawString(
					textoBarra,
					fuenteBarra,
					brushTextoBarras,
					new PointF(
						xBarra + 2f - tamañoTexto.Width * 0.5f,
						y - hBarra - tamañoTexto.Height - 2f));

				Font fuenteBaseBarra = new Font(Estilos.LatoBlack, 10);
				textoBarra = this.nombresBarra[i];
				tamañoTexto = TextRenderer.MeasureText(textoBarra, fuenteBaseBarra);
				g.DrawString(
					textoBarra,
					fuenteBaseBarra,
					brushTextoBaseBarras,
					new PointF(
						xBarra + 2f - tamañoTexto.Width * 0.5f,
						y + 6f));
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

	class Barra: IComparable {
		private int clase;

		public string Clase {
			get { return this.clase.ToString(); }
		}

		public int Valor { get; set; }

		public Barra(int clase, int valor) {
			this.clase = clase;
			this.Valor = valor;
		}

		public int CompareTo(object obj) {
			int ret = -1;

			if(obj is Barra)
				ret = this.clase.CompareTo((obj as Barra).clase);

			return ret;
		}
	}
}
