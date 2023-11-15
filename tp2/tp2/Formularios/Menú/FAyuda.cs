using System;
using System.IO;
using System.Windows.Forms;

namespace tp2.Formularios {
	public partial class FAyuda: Form {
		private static string rutaInicio = Path.Combine(Application.StartupPath, "Ayuda", "index.html");

		public FAyuda() {
			this.InitializeComponent();
			this.webView.Source = new Uri(rutaInicio);
		}

		private void BtnInicio_Click(object sender, EventArgs e) {
			this.webView.Source = new Uri(rutaInicio);
		}

		private void BtnAnterior_Click(object sender, EventArgs e) {
			if(this.webView.CanGoBack)
				this.webView.GoBack();
		}

		private void BtnSiguiente_Click(object sender, EventArgs e) {
			if(this.webView.CanGoForward)
				this.webView.GoForward();
		}
	}
}
