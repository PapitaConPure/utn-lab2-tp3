using System;
using System.Drawing;
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

		private FUsuario fUsuario;

        public FPrincipal() {
			this.InitializeComponent();
		}

		private void FPrincipal_Load(object sender, EventArgs e) {
			#region Serialización
			string rutaDir = Application.StartupPath;
			this.rutaBin = Path.Combine(rutaDir, "config.dat");

			FileStream fs = null;

			try {
				if(File.Exists(this.rutaBin)) {
					fs = new FileStream(this.rutaBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.sistema = bf.Deserialize(fs) as Sistema;
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
			bool primerInicio = false;
			if(this.sistema == null) {
				FNuevoSistema fNuevoSistema = new FNuevoSistema();
				
				if(fNuevoSistema.ShowDialog() == DialogResult.OK)
				{
					this.sistema = fNuevoSistema.Sistema;
					primerInicio = true;
				}
				else
					Application.Exit();

				fNuevoSistema.Dispose();
			}
			#endregion

			this.Hide();
			new FSplash(.01, 50).ShowDialog(); //Ponerle 3.25 después. Ya no aguanto lo que tarda en arrancar lpm

			#region Capas de Usuario
			string tipoUsuario = "";
			if (primerInicio || this.sistema.Usuarios.Count==0) {
				this.agregarUsuarioToolStripMenuItem.PerformClick();
			} else {
				this.fUsuario = new FUsuario(this.sistema);
				DialogResult dr = this.fUsuario.ShowDialog();
				
				if (dr == DialogResult.OK) {
					tipoUsuario = "Administrador";
					this.btnAgregarCasa.Enabled = this.btnAgregarHotel.Enabled = this.btnModificarPropiedad.Enabled = true;
					this.agregarUsuarioToolStripMenuItem.Enabled = this.eliminarUsuarioToolStripMenuItem.Enabled = true;
					this.btnBorrarPropiedad.Enabled = true;
					this.importarToolStripMenuItem.Enabled = true;
				} else {
					tipoUsuario = "Empleado";
					this.btnAgregarCasa.Enabled = this.btnAgregarHotel.Enabled =
					this.btnModificarPropiedad.Enabled = this.btnBorrarPropiedad.Enabled = false;
					this.importarToolStripMenuItem.Enabled = false;
					this.agregarUsuarioToolStripMenuItem.Enabled = this.eliminarUsuarioToolStripMenuItem.Enabled = false;
				}

				this.sistema.UsuarioActual = this.sistema.VerUsuario(this.fUsuario.tbUsuario.Text, this.fUsuario.tbContraseña.Text);
			}
			#endregion

			if(this.sistema.UsuarioActual is null) {
				Application.Exit();
				return;
			}

			foreach(ToolStripMenuItem item in this.barraMenú.Items)
				item.Font = new Font(Estilos.LatoBlack, 9);

			this.gbPrecio.Font = new Font(Estilos.LatoBlack, 9);
			this.gbFecha.Font = new Font(Estilos.LatoBlack, 9);

			#region Cargar barra de estado + estilo
			ToolStripStatusLabel labelTipoUsuario = new ToolStripStatusLabel(tipoUsuario.ToUpper());
			ToolStripStatusLabel labelNombreUsuario = new ToolStripStatusLabel(this.sistema.UsuarioActual.Nombre.ToUpper());
			labelTipoUsuario.ForeColor = Estilos.SecondaryColorLight3;
			labelNombreUsuario.ForeColor = Estilos.SecondaryColorLight2;
			this.barraEstado.Items.Add(labelTipoUsuario);
			this.barraEstado.Items.Add(labelNombreUsuario);
			foreach(ToolStripItem item in this.barraEstado.Items)
				item.Font = new Font(Estilos.LatoBlack, 9);
			#endregion

			#region Cargar estilo de tabla de búsqueda
			this.dgvResidencias.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle() {
				Alignment = DataGridViewContentAlignment.MiddleCenter,
				BackColor = Estilos.PrimaryColor,
				ForeColor = Estilos.TextColorDarkest,
				SelectionBackColor = Estilos.PrimaryColor,
				SelectionForeColor = Estilos.BackgroundColorDark2,
				Font = new Font(Estilos.SegoeUIBlack, 11),
			};

			this.dgvResidencias.DefaultCellStyle = new DataGridViewCellStyle() {
				Alignment = DataGridViewContentAlignment.MiddleCenter,
				BackColor = Estilos.BackgroundColorDark1,
				ForeColor = Estilos.TextColor,
				SelectionBackColor = Estilos.SecondaryColor,
				SelectionForeColor = Color.White,
				Font = new Font(Estilos.SegoeUI, 11),
			};
			#endregion
		}


		#region Persistencia de Sistema
		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			if(this.sistema is null)
				return;

			FileStream fs = null;
			try {
				fs = new FileStream(this.rutaBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
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
			FCasa fCasa = new FCasa(this.sistema);

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
			FHotel fHotel = new FHotel(this.sistema);

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
			if(this.dgvResidencias.SelectedCells.Count == 0) {
				MessageBox.Show("Selecciona una residencia en la tabla", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DialogResult confirmación = MessageBox.Show(
				"¿De verdad quieres eliminar esta residencia?\nEsta acción no puede deshacerse",
				"Confirmar eliminar",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(confirmación != DialogResult.Yes)
				return;

			int nroResidencia = (int)this.dgvResidencias.SelectedRows[0].Cells[2].Value;
			Residencia residencia = this.sistema.VerResidencia(nroResidencia);
			if(residencia is null) {
				MessageBox.Show("No se encontró una residencia", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Alquiler[] reservas = residencia.Alquileres;
			if (reservas.Length > 0)
			{
				MessageBox.Show("No se puede eliminar una residencia con reservas activas.");
				return;
			}
			if(!this.sistema.QuitarResidencia(residencia.Número))
				MessageBox.Show("No se ha podido eliminar la residencia");

			MessageBox.Show("Residencia eliminada", "Acción concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.cmbDestinos.Items.Clear();
			this.ActualizarListadoResidencias();
		}

		private void BtnModificarPropiedad_Click(object sender, EventArgs e) {
			if(this.dgvResidencias.SelectedCells.Count == 0) {
				MessageBox.Show("Selecciona una residencia en la tabla", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int nroResidencia = (int)this.dgvResidencias.SelectedRows[0].Cells[2].Value;
			Residencia residencia = this.sistema.VerResidencia(nroResidencia);

			if(residencia is null) {
				MessageBox.Show("No se encontró una residencia", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Form fModificar = null;

			if(residencia is Hotel)
				fModificar = new FHotel(this.sistema, residencia as Hotel);
			else if(residencia is Casa)
				fModificar = new FCasa(this.sistema, residencia as Casa);

			if(fModificar != null) {
				fModificar.ShowDialog();
				fModificar.Dispose();
			}
		}

		private void DgvResidencias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
			this.btnConsultarPropiedad.PerformClick();
		}

		private void BtnConsultarPropiedad_Click(object sender, EventArgs e) {
			if(this.dgvResidencias.SelectedCells.Count == 0) {
				MessageBox.Show("Selecciona una residencia en la tabla", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int nroResidencia = (int)this.dgvResidencias.SelectedRows[0].Cells[2].Value;
			Residencia residencia = this.sistema.VerResidencia(nroResidencia);

			if(residencia is null) {
				MessageBox.Show("No se encontró una residencia", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			FDetalles fDetalles = new FDetalles(this.sistema, residencia);
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
			this.rbCualquiera.Checked = true;
			this.cbFecha.Checked = false;
			this.ActualizarListadoResidencias();
		}

		private void CbFecha_CheckedChanged(object sender, EventArgs e) {
			this.pnlFechas.Enabled = this.cbFecha.Checked;
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
		private void AlquileresToolStripMenuItem_Click(object sender, EventArgs e) {
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

		private void AlquileresToolStripMenuItem1_Click(object sender, EventArgs e) {
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

		#region Barra de Menú
		private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
			AcercaDe fAcercaDe = new AcercaDe();
			fAcercaDe.ShowDialog();
		}

		private void PropiedadesReservadasToolStripMenuItem_Click(object sender, EventArgs e) {
			FSectores fSectores = new FSectores(this.sistema);
			fSectores.ShowDialog();
			fSectores.Dispose();
		}

		private void CantidadPasajaerosToolStripMenuItem_Click(object sender, EventArgs e) {
			FBarras fBarras = new FBarras(this.sistema);
			fBarras.ShowDialog();
			fBarras.Dispose();
		}

		private void AgregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
			this.fUsuario.btnIngresar.Visible = false;
			this.fUsuario.tlpBotonesAlt.Visible = true;
			this.fUsuario.tlpTipoUsuario.Visible = true;
			this.fUsuario.gbUsuario.Enabled = true;
			this.fUsuario.gbContraseña.Enabled = true;

			this.fUsuario.lblTítulo.Text = "Agregar Usuario";
			this.fUsuario.btnAceptar.Text = "Agregar";
			this.fUsuario.btnAceptar.BackColor = Estilos.PrimaryColor;
			this.fUsuario.btnAceptar.ForeColor = Estilos.TextColorDarkest;

			if(this.fUsuario.ShowDialog() == DialogResult.No) {
				string tipo;
				if(this.fUsuario.rbAdministrador.Checked) tipo = "Administrador";
				else tipo = "Empleado";

				Usuario nuevo = new Usuario(this.fUsuario.tbUsuario.Text, this.fUsuario.tbContraseña.Text, tipo);
				this.sistema.AgregarUsuario(nuevo);
				MessageBox.Show("Usuario agregado");
			}
		}

		private void EliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
			this.fUsuario.btnIngresar.Visible = false;
			this.fUsuario.tlpBotonesAlt.Visible = true;
			this.fUsuario.tlpTipoUsuario.Visible = false;
			this.fUsuario.gbUsuario.Enabled = true;
			this.fUsuario.gbContraseña.Enabled = true;

			this.fUsuario.lblTítulo.Text = "Eliminar Usuario";
			this.fUsuario.btnAceptar.Text = "Eliminar";
			this.fUsuario.btnAceptar.BackColor = Estilos.DangerSemanticColor;
			this.fUsuario.btnAceptar.ForeColor = Color.White;

			if(this.fUsuario.ShowDialog() == DialogResult.No) {
				Usuario aux = this.sistema.VerUsuario(this.fUsuario.tbUsuario.Text, this.fUsuario.tbContraseña.Text);
				if(aux == null) {
					MessageBox.Show("El usuario no existe");
					return;
				} else {
					this.sistema.EliminarUsuario(aux);
					MessageBox.Show($"El usuario {aux.Nombre} ha sido eliminado");
				}
			}
		}

		private void CambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e) {
			this.fUsuario.btnIngresar.Visible = false;
			this.fUsuario.tlpBotonesAlt.Visible = true;
			this.fUsuario.tlpTipoUsuario.Visible = false;
			this.fUsuario.tbUsuario.Text = this.sistema.UsuarioActual.Nombre;
			this.fUsuario.gbUsuario.Enabled = false;
			this.fUsuario.gbContraseña.Enabled = true;

			this.fUsuario.lblTítulo.Text = "Cambiar contraseña";
			this.fUsuario.btnAceptar.Text = "Cambiar";
			this.fUsuario.btnAceptar.BackColor = Estilos.PrimaryColor;
			this.fUsuario.btnAceptar.ForeColor = Estilos.TextColorDarkest;

			if(this.fUsuario.ShowDialog() == DialogResult.No) {
				this.sistema.UsuarioActual.CambiarContraseña(this.fUsuario.tbContraseña.Text);
				MessageBox.Show("La contraseña ha sido actualizada correctamente");
			}
		}

		private void AyudaToolStripMenuItem_Click(object sender, EventArgs e) {
			FAyuda fAyuda = new FAyuda();
			fAyuda.ShowDialog();
			fAyuda.Dispose();
		}

		private void GuardarToolStripMenuItem_Click(object sender, EventArgs e) {
			FileStream fs = null;
			BinaryFormatter bf;
			try {
				fs = new FileStream(this.rutaBin, FileMode.OpenOrCreate, FileAccess.Write);
				bf = new BinaryFormatter();
				bf.Serialize(fs, this.sistema);
			} catch(IOException) {
				MessageBox.Show("No se pudieron guardar los datos", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("No se pudieron guardar los datos", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} finally {
				if(fs != null)
					fs.Close();
			}

			if(this.sfdDatos.ShowDialog() != DialogResult.OK)
				return;

			try {
				this.sistema.GuardarLista(this.sfdDatos.FileName);
				MessageBox.Show("Se Guardaron los alquileres y clientes.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(IOException ex) {
				MessageBox.Show(ex.Message, "Error de Escritura", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException ex) {
				MessageBox.Show(ex.Message, "Error de Permisos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			} catch(ArgumentException ex) {
				MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			DateTime horaRespaldo = DateTime.Now;
			ToolStripLabel texto = new ToolStripLabel($"ÚLTIMO RESPALDO: {horaRespaldo:HH:mm:ss}");
			texto.ForeColor = Color.FromArgb(211, 197, 197);
			texto.Font = new Font(Estilos.LatoBlack, 9);
			texto.Alignment = ToolStripItemAlignment.Right;
			this.barraEstado.Items.Add(texto);
		}
		#endregion

		#region Utilidades
		private void ActualizarListadoResidencias() {
			Residencia[] residencias = this.sistema.Residencias;

			foreach(Residencia residencia in residencias)
				if(!this.cmbDestinos.Items.Contains(residencia.Dirección))
					this.cmbDestinos.Items.Add(residencia.Dirección);

			this.dgvResidencias.Rows.Clear();

			string destino = this.cmbDestinos.SelectedItem as string;
			double max = (double)this.nudMaxPrice.Value;
			double min = (double)this.nudMinPrice.Value;

			foreach(Residencia residencia in residencias) {
				if(this.VerificarTipo(residencia)
				&& (destino is null || destino == residencia.Dirección)
				&& (max == 0 || residencia.CalcularPrecioTotal() * this.sistema.PrecioBase <= max)
				&& (min == 0 || residencia.CalcularPrecioTotal() * this.sistema.PrecioBase >= min)
				&& this.VerificarPlazas(residencia)
				&& this.VerificarFecha(residencia, this.dtpIngreso.Value, this.dtpSalida.Value)) {
					this.dgvResidencias.Rows.Add(
						residencia.GetType().Name,
						residencia.Dirección,
						residencia.Número,
						string.Join(", ", residencia.VerServicios()));
					this.dgvResidencias.Rows[this.dgvResidencias.Rows.Count - 1].Cells[0].Style.Font = new Font(Estilos.SegoeUI, 11, FontStyle.Bold);
				}
			}

			this.dgvResidencias.ClearSelection();
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
	}
}
