using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using AlquilerLib;
using System.Runtime.Serialization;
using ProyectoSplash;
using tp2.Formularios;
using tp2.Formularios.Secundarios;

namespace tp2 {
	public partial class FPrincipal: Form {
		private Sistema sistema;
		private string rutaBin;

        public FPrincipal() {
			this.InitializeComponent();
		}

		#region Persistencia de Sistema
		private void FPrincipal_Load(object sender, EventArgs e) {
			string rutaDir = Application.StartupPath;
			this.rutaBin = Path.Combine(rutaDir, "config.dat");

			FileStream fs = null;

			try {
				if(File.Exists(this.rutaBin)) {
					fs = new FileStream(this.rutaBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.sistema = bf.Deserialize(fs) as Sistema;
					this.sistema.CargarNroResidenciaSerializado();
					this.ActualizarListadoResidencias();
				}
			} catch(IOException) {
				MessageBox.Show("No se pudieron cargar los datos previos", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("No se pudieron cargar los datos previos", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(SerializationException) {
				MessageBox.Show("No se pudieron cargar los datos previos", "Error de Deserialización", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} finally {
				if(fs != null)
					fs.Close();
			}

			if(this.sistema == null) {
				FNuevoSistema fNuevoSistema = new FNuevoSistema();

				if(fNuevoSistema.ShowDialog() == DialogResult.OK)
					this.sistema = fNuevoSistema.Sistema;
				else
					Application.Exit();

				fNuevoSistema.Dispose();
			}

			this.Hide();
			new FSplash(0.001, 50).ShowDialog(); //Ponerle 3.25 después. Ya no aguanto lo que tarda en arrancar lpm
			FUsuario f = new FUsuario(this.sistema);
			DialogResult dr = f.ShowDialog();
			string tipoUsuario;
			if (dr == DialogResult.OK)
			{
				tipoUsuario = "Administrador";
				this.btnAgregarCasa.Enabled = this.btnAgregarHotel.Enabled = this.btnModificarPropiedad.Enabled = true;
				agregarUsuarioToolStripMenuItem.Enabled = eliminarUsuarioToolStripMenuItem.Enabled = true;
				this.btnBorrarPropiedad.Enabled = true;
			}
			else 
			{ 
				tipoUsuario = "Empleado";
				this.btnAgregarCasa.Enabled = this.btnAgregarHotel.Enabled = 
				this.btnModificarPropiedad.Enabled = this.btnBorrarPropiedad.Enabled = false;
				agregarUsuarioToolStripMenuItem.Enabled = eliminarUsuarioToolStripMenuItem.Enabled = false;
			}
			sistema.UsuarioActual = sistema.VerUsuario(f.tbUsuario.Text, f.tbContraseña.Text);
			f.Dispose();
			barraEstado.Items.Clear();
            barraEstado.Items.Add("Usuario: " + sistema.UsuarioActual.Nombre+" - "+tipoUsuario);
            this.Show();
		}

		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			if(this.sistema is null)
				return;

			FileStream fs = null;
			try {
				fs = new FileStream(this.rutaBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
				this.sistema.GuardaNúmeroResidenciaSerializado();
				bf.Serialize(fs, this.sistema);
			} catch(IOException) {
				MessageBox.Show("No se pudieron guardar los datos", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("No se pudieron guardar los datos", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} finally {
				if(fs != null)
					fs.Close();
			}
		}
		#endregion

		#region ABM de Residencias
		private void BtnAgregarCasa_Click(object sender, EventArgs e) {
			FAgregarCasa fCasa = new FAgregarCasa(this.sistema);

            if(fCasa.ShowDialog() == DialogResult.OK) {
				MessageBox.Show(
					"La casa fue registrada exitosamente",
					"Casa agregada",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				this.ActualizarListadoResidencias();
			}

			fCasa.Dispose();
		}

		private void BtnAgregarHotel_Click(object sender, EventArgs e) {
			FAgregarHotel fHotel = new FAgregarHotel(this.sistema);

			if(fHotel.ShowDialog() == DialogResult.OK) {
				MessageBox.Show(
					"El hotel fue registrado exitosamente",
					"Hotel agregado",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				this.ActualizarListadoResidencias();
			}

			fHotel.Dispose();
		}

		private void BtnBorrarPropiedad_Click(object sender, EventArgs e) {
			Residencia aBorrar = this.lsbResidencias.SelectedItem as Residencia;

			if(aBorrar is null) {
				MessageBox.Show("No se encontró una residencia", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(!this.sistema.QuitarResidencia(aBorrar.Número))
				MessageBox.Show("No se ha podido eliminar la residencia");

			MessageBox.Show("Residencia eliminada");
			this.cmbDestinos.Items.Clear();
			this.ActualizarListadoResidencias();
		}

        private void BtnModificarPropiedad_Click(object sender, EventArgs e) {
			Residencia aModificar = this.lsbResidencias.SelectedItem as Residencia;

			if(aModificar is null) {
				MessageBox.Show("No se encontró una residencia", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Form fModificar = null;

			if(aModificar is Hotel)
				fModificar = new FAgregarHotel(this.sistema, aModificar as Hotel);
			else if(aModificar is Casa)
				fModificar = new FAgregarCasa(this.sistema, aModificar as Casa);

			if(fModificar != null) {
				fModificar.ShowDialog();
				fModificar.Dispose();
			}
		}

		private void BtnConsultarPropiedad_Click(object sender, EventArgs e) {
			Residencia aVer = this.lsbResidencias.SelectedItem as Residencia;

			if(aVer is null) {
				MessageBox.Show("No se encontró una residencia", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			FDetalles fDetalles = new FDetalles(this.sistema, aVer);
			fDetalles.ShowDialog();
			fDetalles.Dispose();
		}
		#endregion

		#region Filtro
		private void BtnBuscarResidencias_Click(object sender, EventArgs e) {
			this.ActualizarListadoResidencias();
		}

		private bool VerificarFecha(Residencia r,DateTime ingreso, DateTime salida)
        {
            if (this.cbFecha.Checked)
            {
				Alquiler t = new Alquiler(ingreso, salida,0,"n","ap",0,0);
				if (r.PuedeAlquilar(t))
					return true;
				else
					return false;
			}
			else
				return true;
		}

		private void BtnLimpiarFiltros_Click(object sender, EventArgs e) {
			this.cmbDestinos.SelectedIndex = -1;
			this.nudCantPersonas.Value = this.nudCantPersonas.Minimum;
			this.nudMaxPrice.Value = this.nudMaxPrice.Minimum;
			this.nudMinPrice.Value = this.nudMinPrice.Minimum;
			this.rbCasa.Checked = false;
			this.rbCasaFinde.Checked = false;
			this.rbHotel.Checked = false;
			this.cbFecha.Checked = false;
			this.gpFecha.Enabled = false;
			this.ActualizarListadoResidencias();
			this.lsbResidencias.Items.Clear();
		}

		private bool VerificarTipo(Residencia r) {
			if(!this.rbHotel.Checked && !this.rbCasa.Checked && !this.rbCasaFinde.Checked)
				return true;

			return (this.rbHotel.Checked && r is Hotel)
				|| (this.rbCasaFinde.Checked && r is CasaFinde)
				|| (this.rbCasa.Checked && r is Casa && !(r is CasaFinde));
		}

		private bool VerificarPlazas(Residencia r) {
			int cant = (int)this.nudCantPersonas.Value;
			bool valido = false;
			if(this.nudCantPersonas.Value == 0)
				valido = true;
			else {
				if(r is Casa) {
					if((r as Casa).CamasDisponibles >= cant)
						valido = true;
				} else if(r is Hotel) {
					valido = (cant >= 5 && (r as Hotel).CntTriple > 0)
						  || (cant >= 3 && (r as Hotel).CntDoble > 0)
						  || (cant >= 1 && (r as Hotel).CntSimple > 0);
				}
			}
			return valido;
		}
		#endregion

		#region Importar y Exportar CSV
		private void BtnImportar_Click(object sender, EventArgs e) {
			if(this.ofdDatos.ShowDialog() != DialogResult.OK)
				return;

			try {
				this.sistema.ImportarAlquileres(this.ofdDatos.FileName);
				MessageBox.Show("Se importaron los alquileres", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.ActualizarListadoResidencias();
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Lectura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(FormatException ex) {
				MessageBox.Show(ex.Message, "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(InvalidOperationException ex) {
				MessageBox.Show(ex.Message, "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnExportar_Click(object sender, EventArgs e) {
			if(this.sfdDatos.ShowDialog() != DialogResult.OK)
				return;

			try {
				this.sistema.ExportarAlquileres(this.sfdDatos.FileName);
				MessageBox.Show("Se exportaron los alquileres.\nTambién fueron limpiados de la aplicación", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Escritura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Utilidades
		private void ActualizarListadoResidencias() {
			Residencia[] residencias = this.sistema.Residencias;

			foreach(Residencia residencia in residencias)
				if(!this.cmbDestinos.Items.Contains(residencia.Dirección))
					this.cmbDestinos.Items.Add(residencia.Dirección);

			this.lsbResidencias.Items.Clear();

			string destino = this.cmbDestinos.SelectedItem as string;
			double max = (double)this.nudMaxPrice.Value;
			double min = (double)this.nudMinPrice.Value;

			foreach(Residencia residencia in residencias) {
				if(this.VerificarTipo(residencia)
				&& (destino is null || destino == residencia.Dirección)
				&& (max == 0 || residencia.CalcularPrecioTotal() * this.sistema.PrecioBase <= max)
				&& (min == 0 || residencia.CalcularPrecioTotal() * this.sistema.PrecioBase >= min)
				&& this.VerificarPlazas(residencia)
				&& this.VerificarFecha(residencia,this.dtpIngreso.Value, this.dtpSalida.Value))
					this.lsbResidencias.Items.Add(residencia);
			}

			if(this.lsbResidencias.Items.Count == 0)
				this.lsbResidencias.Items.Add("No hay resultados...");
		}
		#endregion

		#region Calidad de vida
		private void SeleccionarTextBox(object sender, EventArgs e) {
			(sender as TextBox).SelectAll();
		}

		private void SeleccionarNumericUpDown(object sender, EventArgs e) {
			(sender as NumericUpDown).Select(0, 20);
		}
        #endregion

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			AcercaDe fAcercaDe = new AcercaDe();
			fAcercaDe.Show();
        }

        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
			this.pnlFecha.Enabled = this.cbFecha.Checked;
        }

        private void propiedadesReservadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FSectores FS = new FSectores(this.sistema);
			FS.ShowDialog();
			FS.Dispose();
        }

        private void cantidadPasajaerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FBarras FB = new FBarras(this.sistema);
			FB.ShowDialog();
			FB.Dispose();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FUsuario f = new FUsuario(this.sistema);
			f.btnIngresar.Visible = false;
			f.btnAceptar.Visible = f.btnCancelar.Visible = true;
			f.rbAdministrador.Visible = f.rbEmpleado.Visible = f.lbTipoUsuario.Visible = true;
			if(f.ShowDialog() == DialogResult.No)
            {
				string tipo="";
				if (f.rbAdministrador.Checked) tipo = "Administrador";
				else tipo = "Empleado";
				
				Usuario nuevo = new Usuario(f.tbUsuario.Text, f.tbContraseña.Text, tipo);
				sistema.AgregarUsuario(nuevo);
				MessageBox.Show("Usuario agregado");
            }
            else
            {
				f.Dispose();
            }
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FUsuario f = new FUsuario(this.sistema);
            f.btnIngresar.Visible = false;
			f.btnAceptar.Visible = f.btnCancelar.Visible = true;
			if (f.ShowDialog() == DialogResult.No)
			{
				Usuario aux = sistema.VerUsuario(f.tbUsuario.Text, f.tbContraseña.Text);
				if(aux == null)
                {
					MessageBox.Show("El usuario no existe");
					return;
                }
                else
                {
					sistema.EliminarUsuario(aux);
					MessageBox.Show("El usuario "+ aux.Nombre +" a sido eliminado");
				}
			}
		}

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FUsuario f = new FUsuario(this.sistema);
			f.btnIngresar.Visible = false;
			f.btnAceptar.Visible = f.btnCancelar.Visible = true;
			f.tbUsuario.Text = sistema.UsuarioActual.Nombre;
			f.tbUsuario.Enabled = false;
			if(f.ShowDialog() == DialogResult.No)
            {
				sistema.UsuarioActual.CambiarContraseña(f.tbContraseña.Text);
				MessageBox.Show("La contraseña ha sido actualizada correctamente");
            }
            else
            {
				f.Dispose();
            }
        }
    }
}
