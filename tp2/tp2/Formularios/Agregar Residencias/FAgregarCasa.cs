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
using AlquilerLib;

namespace tp2 {
    public partial class FAgregarCasa: Form {
		private readonly FImagen fImagen;

		public FAgregarCasa() {
			this.Inicializar();
			this.fImagen = new FImagen();
		}

		public FAgregarCasa(Casa casa) {
			this.Inicializar();
			this.fImagen = new FImagen(casa.Imágenes);

			this.gbDatos.Enabled
			= this.tlpTipoCasa.Enabled
			= this.nudDNI.Enabled
			= this.tbApellido.Enabled
			= this.gbMinDías.Enabled
				= false;

			this.tbDireccionCasa.Text = casa.Dirección;
			this.nudNroPropiedad.Value = casa.Número;
			this.rbCasaFinde.Checked = casa is CasaFinde;
			this.nudCantCamas.Value = casa.CamasDisponibles;
			this.nudMinDias.Value = casa.MínimoPermitido;
			this.nudDNI.Value = casa.Propietario.Dni;
			this.tbApellido.Text = casa.Propietario.Apellido;
			this.tbNombre.Text = casa.Propietario.Nombre;
			this.nudTel.Value = casa.Propietario.Tel;
		}

		public Image[] Imágenes {
            get { return this.fImagen.Imágenes; }
        }

        private void RbCasa_CheckedChanged(object sender, EventArgs e)
        {
            this.gbMinDías.Enabled = true;
        }

        private void RbCasaFinde_CheckedChanged(object sender, EventArgs e)
        {
            this.gbMinDías.Enabled = false;
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e) {
			this.fImagen.ShowDialog();
        }

        private void BtnCrear_Click(object sender, EventArgs e) {
            if(this.fImagen.CargóTodas)
				this.DialogResult = DialogResult.None;
        }

		private void Inicializar() {
			this.InitializeComponent();
			this.rbCasa.Enabled = true;
			this.rbCasaFinde.Enabled = true;
			this.tbDireccionCasa.Enabled = true;
			this.nudNroPropiedad.Enabled = true;
			this.nudDNI.Enabled = true;
			this.nudTel.Enabled = true;
			this.tbApellido.Enabled = true;
			this.tbNombre.Enabled = true;
		}
	}
}
