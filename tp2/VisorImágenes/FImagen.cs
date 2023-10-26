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
        public FImagen()
        {
            InitializeComponent();
        }
        private PictureBox[] imagenes = new PictureBox[2];
        private int cont = 0; 
        public Image[] Imágenes
        {
            get
            {
				Image[] ret = new Image[2];

				for(int i = 0; i < cont; i++)
					ret[i] = this.imagenes[i].Image;

                return ret;
            }
        }                 
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (cont < imagenes.Length)
            {
                OpenFileDialog abrirImagen = new OpenFileDialog();
                if (abrirImagen.ShowDialog() == DialogResult.OK)
                {
                    imagenes[cont] = new PictureBox();
                    imagenes[cont].Image = Image.FromFile(abrirImagen.FileName);
                    imagenes[cont].SizeMode = PictureBoxSizeMode.StretchImage;
                    cont++;

                    if (cont == imagenes.Length)
                    {
                        Ver.Enabled = true;
                        btnCargarImagen.Enabled = false;
                    }
                }
            }
        }

        private void siguiente_click(object sender, EventArgs e)
        {
            if (cont <imagenes.Length-1)
            {
                cont++;
                pictureBox1.Image = imagenes[cont].Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (cont>0)
            {
                cont--;
                pictureBox1.Image = imagenes[cont].Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siguiente.Enabled = false;
            anterior.Enabled = false;
            Ver.Enabled = false;
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            siguiente.Enabled = true;
            anterior.Enabled = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = imagenes[0].Image;
            cont = 0;
            Ver.Enabled = false;
        }

        private void FImagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(cont==this.imagenes.Length-1)this.DialogResult= DialogResult.OK;
        }
    }
}
