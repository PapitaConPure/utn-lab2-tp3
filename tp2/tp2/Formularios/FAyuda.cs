using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
