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
	public partial class FNuevoSistema: Form {
		public FNuevoSistema() {
			this.InitializeComponent();
			this.Sistema = null;
		}

		private void FNuevoSistema_Load(object sender, EventArgs e) {
			this.gbPrecioBase.Font = new Font(Estilos.LatoBlack, 9);
		}

		public Sistema Sistema { get; private set; }

		private void BtnAceptar_Click(object sender, EventArgs e) {
			double precioBase = (double)this.nudPrecioBase.Value;
			this.Sistema = new Sistema(precioBase);
		}
	}
}
