using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSplash
{
    public class BarraBonita : ProgressBar
    { // ← Nótese la herencia del control ProgressBar. Esto es básicamente una barra extendida
        public BarraBonita()
        {
            //Permite que se llame el método OnPaint para dibujar el control (por ende, permitiendo que el override funcione)
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            //Elimina algunos errores visuales
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //Número del 0 al 1 (0-100%) que indica el porcentaje de carga de la barra
            double progreso = 1.0 * this.Value / this.Maximum;

            //Ancho de la barra de progreso de carga, en pixeles
            int anchoCarga = (int)(this.Width * progreso);

            //Determinar área sobre la cual pintar el fondo de la barra (que no ha cargado) y barra de carga (que ya cargó)
            Rectangle áreaFondoBarra = new Rectangle(anchoCarga, 0, this.Width - anchoCarga, this.Height);
            Rectangle áreaCargaBarra = new Rectangle(0, 0, anchoCarga, this.Height);

            //Brochas de colores para dibujar las áreas determinadas
            Brush brochaFondoBarra = new SolidBrush(Color.FromArgb(35, 35, 72)); //13, 235, 94
            Brush brochaCargaBarra = new SolidBrush(Color.FromArgb(13, 235, 94)); //199, 44, 48

			//Pintar el área del fondo con la brocha del fondo
			graphics.FillRectangle(brochaFondoBarra, áreaFondoBarra);

            //Pintar el área del progreso de carga con la brocha del progreso de carga
            if (this.Value > 0)
                graphics.FillRectangle(brochaCargaBarra, áreaCargaBarra);
        }
    }
}
