using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cargandoImagenes
{
    public partial class FImagen : Form
    {
		private int cantidadImágenes;
        private int imagenActual;

		public FImagen()
        {
            this.InitializeComponent();
			this.Imágenes = new Image[2];
			this.cantidadImágenes = 0;
			this.imagenActual = 0;
		}

		public FImagen(Image[] imágenes): this() {
			for(int i = 0; i < this.Imágenes.Length; i++) {
				this.Imágenes[i] = imágenes[i];
				this.cantidadImágenes++;
			}
		}

		public Image[] Imágenes { get; private set; }

		private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if(abrirImagen.ShowDialog() == DialogResult.OK)
            {
                this.Imágenes[this.cantidadImágenes] = Image.FromFile(abrirImagen.FileName);
				this.pbVisor.Image = Imágenes[this.cantidadImágenes];

				if(this.cantidadImágenes > 0)
					this.imagenActual++;

				this.cantidadImágenes++;
			}
		}

		private void btnQuitarImágenes_Click(object sender, EventArgs e) {
			if(this.cantidadImágenes > 0) {
				this.Imágenes[this.imagenActual] = this.Imágenes[--this.cantidadImágenes];

				if(this.imagenActual > 0)
					this.imagenActual--;

				if(this.cantidadImágenes > 0) {
					this.pbVisor.Image = this.Imágenes[this.imagenActual];
				} else {
					this.pbVisor.Image = null;
				}
			}

			MessageBox.Show(string.Join("\n", this.imagenActual, this.cantidadImágenes));
		}

		private void siguiente_click(object sender, EventArgs e)
        {
            if(this.imagenActual < this.cantidadImágenes - 1) {
                this.pbVisor.Image = this.Imágenes[++this.imagenActual];
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if(this.imagenActual > 0)
            {
                this.pbVisor.Image = this.Imágenes[--this.imagenActual];
            }
        }

        private void FImagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.cantidadImágenes == this.Imágenes.Length)
				this.DialogResult= DialogResult.OK;
        }
	}
}
