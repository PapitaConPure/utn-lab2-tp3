using System.IO;
using System.Windows.Forms;

namespace tp2.Formularios {
	public partial class FAyuda: Form {
		public FAyuda() {
			this.InitializeComponent();

			string ruta = Path.Combine(Application.StartupPath, "Ayuda", "index.html");
			this.browser.Navigate(ruta);
		}
	}
}
