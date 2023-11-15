using System.Drawing;
using System.Windows.Forms;

namespace UtilidadesForms {
	/// <summary>
	/// Permite arrastrar una ventana al clickear en el contenido de la misma en lugar de la barra superior
	/// </summary>
	public sealed class ArrastradorVentana {
		private bool arrastraVentana = false;
		private Point arrastreMouse;
		private Form objetivo;

		/// <summary>
		/// Inicializa una nueva instancia de arrastre de ventanas con la ventana <paramref name="objetivo"/> indicada
		/// y la suscribe a una serie de eventos para arrastrarla
		/// </summary>
		/// <remarks>Crear una instancia en el constructor con una referencia a la ventana debería ser más que suficiente</remarks>
		/// <param name="objetivo"></param>
		public ArrastradorVentana(Form objetivo) {
			this.objetivo = objetivo;
			this.objetivo.MouseDown += this.Comenzar;
			this.objetivo.MouseUp += this.Detener;
			this.objetivo.MouseMove += this.Arrastrar;

			foreach(Control control in this.objetivo.Controls) {
				if(control.BackColor == this.objetivo.BackColor) {
					control.MouseDown += this.Comenzar;
					control.MouseUp += this.Detener;
					control.MouseMove += this.Arrastrar;
				}
			}
		}

		public void Liberar() {
			if(this.objetivo != null) {
				this.objetivo.MouseDown -= this.Comenzar;
				this.objetivo.MouseUp -= this.Detener;
				this.objetivo.MouseMove -= this.Arrastrar;
				this.objetivo = null;
			}
		}

		private void Comenzar(object sender, MouseEventArgs e) {
			this.arrastraVentana = true;
			this.arrastreMouse = this.objetivo.PointToClient(Control.MousePosition);
		}

		private void Detener(object sender, MouseEventArgs e) {
			this.arrastraVentana = false;
		}

		private void Arrastrar(object sender, MouseEventArgs e) {
			if(this.arrastraVentana)
				this.objetivo.Location = new Point(
					Control.MousePosition.X - this.arrastreMouse.X,
					Control.MousePosition.Y - this.arrastreMouse.Y);
		}
	}
}
