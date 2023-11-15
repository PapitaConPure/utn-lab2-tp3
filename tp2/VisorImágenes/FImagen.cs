using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesForms;

namespace cargandoImagenes
{
    public partial class FImagen : Form
    {
		private int cantidadImágenes;
        private int imagenActual;

		public FImagen() {
            this.InitializeComponent();
			this.Imágenes = new Image[2];
			this.cantidadImágenes = 0;
			this.imagenActual = 0;

			this.btnQuitarImágenes.Enabled = false;
		}

		public FImagen(Image[] imágenes): this() {
			new ArrastradorVentana(this);

			for(int i = 0; i < this.Imágenes.Length; i++) {
				this.Imágenes[i] = imágenes[i];
				this.cantidadImágenes++;
			}

			if(this.cantidadImágenes > 0) {
				this.pbVisor.Image = this.Imágenes[0];
			}

			if(this.cantidadImágenes > 0) {
				this.btnQuitarImágenes.Enabled = true;

				if(this.cantidadImágenes == this.Imágenes.Length)
					this.btnCargarImagen.Enabled = false;
			}

			this.btnCantImágenes.Text = this.cantidadImágenes.ToString();
		}

		public Image[] Imágenes { get; private set; }

		private void BtnCargarImagen_Click(object sender, EventArgs e) {
			if(this.cantidadImágenes == this.Imágenes.Length)
				return;

            if(this.ofdElegirImagen.ShowDialog() == DialogResult.OK) {
				try {
					this.Imágenes[this.cantidadImágenes] = Image.FromFile(this.ofdElegirImagen.FileName);
					this.pbVisor.Image = this.Imágenes[this.cantidadImágenes];

					if(this.cantidadImágenes > 0)
						this.imagenActual++;

					this.cantidadImágenes++;

					if(this.cantidadImágenes == this.Imágenes.Length)
						this.btnCargarImagen.Enabled = false;
					this.btnQuitarImágenes.Enabled = true;
				} catch(OutOfMemoryException) {
					MessageBox.Show("La imagen es demasiado grande o no es de un formato de imagen reconocible", "Archivo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			this.btnCantImágenes.Text = this.cantidadImágenes.ToString();
		}

		private void BtnQuitarImágenes_Click(object sender, EventArgs e) {
			if(this.cantidadImágenes == 0)
				return;

			this.Imágenes[this.imagenActual] = this.Imágenes[--this.cantidadImágenes];

			if(this.imagenActual > 0)
				this.imagenActual--;

			if(this.cantidadImágenes > 0) {
				this.pbVisor.Image = this.Imágenes[this.imagenActual];
			} else {
				this.pbVisor.Image = null;
			}

			if(this.cantidadImágenes == 0)
				this.btnQuitarImágenes.Enabled = false;
			this.btnCargarImagen.Enabled = true;

			this.btnCantImágenes.Text = this.cantidadImágenes.ToString();
		}

		private void BtnSiguiente_click(object sender, EventArgs e)
        {
            if(this.imagenActual < this.cantidadImágenes - 1) {
                this.pbVisor.Image = this.Imágenes[++this.imagenActual];
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if(this.imagenActual > 0)
            {
                this.pbVisor.Image = this.Imágenes[--this.imagenActual];
            }
        }
	}
}
