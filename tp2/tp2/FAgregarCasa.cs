using cargandoImagenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2
{
    public partial class FAgregarCasa : Form
    {
        public FAgregarCasa()
        {
            InitializeComponent();
            rbCasa.Enabled = true;
            rbCasaFinde.Enabled = true;
            tbDireccionCasa.Enabled = true;
            nudNroPropiedad.Enabled = true;
            nudDNI.Enabled = true;
            nudTel.Enabled = true;
            tbApellido.Enabled = true;
            tbNombre.Enabled = true;
        }
        FImagen fi = new FImagen();

        public bool ImágenesCargadas
        {
            get;private set;
        }
        public Image[] Imágenes
        {
            get { return fi.Imágenes; }
        }

        private void rbCasa_CheckedChanged(object sender, EventArgs e)
        {
            nudMinDias.Enabled = true;
        }

        private void rbCasaFinde_CheckedChanged(object sender, EventArgs e)
        {
            nudMinDias.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (fi.ShowDialog() == DialogResult.OK)
                this.ImágenesCargadas = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(!this.ImágenesCargadas)this.DialogResult=DialogResult.None;
        }
    }
}
