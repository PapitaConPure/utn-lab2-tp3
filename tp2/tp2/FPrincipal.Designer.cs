
namespace tp2 {
	partial class FPrincipal {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.ofdElegirImagen = new System.Windows.Forms.OpenFileDialog();
			this.btnAgregarCasa = new System.Windows.Forms.Button();
			this.btnAgregarHotel = new System.Windows.Forms.Button();
			this.cbPropiedades = new System.Windows.Forms.ComboBox();
			this.lbPropiedades = new System.Windows.Forms.Label();
			this.btnBorrarPropiedad = new System.Windows.Forms.Button();
			this.btnModificarPropiedad = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ofdElegirImagen
			// 
			this.ofdElegirImagen.DefaultExt = "*.png";
			this.ofdElegirImagen.Filter = "Imagen PNG | *.png | Imagen JPG | *.jpg | Todos los archivos | *.*";
			this.ofdElegirImagen.InitialDirectory = ".";
			// 
			// btnAgregarCasa
			// 
			this.btnAgregarCasa.Location = new System.Drawing.Point(50, 38);
			this.btnAgregarCasa.Name = "btnAgregarCasa";
			this.btnAgregarCasa.Size = new System.Drawing.Size(95, 50);
			this.btnAgregarCasa.TabIndex = 2;
			this.btnAgregarCasa.Text = "Agregar Casa";
			this.btnAgregarCasa.UseVisualStyleBackColor = true;
			this.btnAgregarCasa.Click += new System.EventHandler(this.btnAgregarCasa_Click_1);
			// 
			// btnAgregarHotel
			// 
			this.btnAgregarHotel.Location = new System.Drawing.Point(165, 38);
			this.btnAgregarHotel.Name = "btnAgregarHotel";
			this.btnAgregarHotel.Size = new System.Drawing.Size(95, 50);
			this.btnAgregarHotel.TabIndex = 3;
			this.btnAgregarHotel.Text = "Agregar Hotel";
			this.btnAgregarHotel.UseVisualStyleBackColor = true;
			this.btnAgregarHotel.Click += new System.EventHandler(this.btnAgregarHotel_Click_1);
			// 
			// cbPropiedades
			// 
			this.cbPropiedades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPropiedades.FormattingEnabled = true;
			this.cbPropiedades.Location = new System.Drawing.Point(119, 117);
			this.cbPropiedades.Name = "cbPropiedades";
			this.cbPropiedades.Size = new System.Drawing.Size(201, 28);
			this.cbPropiedades.TabIndex = 4;
			// 
			// lbPropiedades
			// 
			this.lbPropiedades.AutoSize = true;
			this.lbPropiedades.Location = new System.Drawing.Point(21, 120);
			this.lbPropiedades.Name = "lbPropiedades";
			this.lbPropiedades.Size = new System.Drawing.Size(92, 20);
			this.lbPropiedades.TabIndex = 5;
			this.lbPropiedades.Text = "Propiedades";
			// 
			// btnBorrarPropiedad
			// 
			this.btnBorrarPropiedad.Location = new System.Drawing.Point(337, 117);
			this.btnBorrarPropiedad.Name = "btnBorrarPropiedad";
			this.btnBorrarPropiedad.Size = new System.Drawing.Size(75, 28);
			this.btnBorrarPropiedad.TabIndex = 6;
			this.btnBorrarPropiedad.Text = "Eliminar Propiedad";
			this.btnBorrarPropiedad.UseVisualStyleBackColor = true;
			this.btnBorrarPropiedad.Click += new System.EventHandler(this.btnBorrarPropiedad_Click);
			// 
			// btnModificarPropiedad
			// 
			this.btnModificarPropiedad.Location = new System.Drawing.Point(431, 116);
			this.btnModificarPropiedad.Name = "btnModificarPropiedad";
			this.btnModificarPropiedad.Size = new System.Drawing.Size(102, 28);
			this.btnModificarPropiedad.TabIndex = 7;
			this.btnModificarPropiedad.Text = "Modificar";
			this.btnModificarPropiedad.UseVisualStyleBackColor = true;
			this.btnModificarPropiedad.Click += new System.EventHandler(this.btnModificarPropiedad_Click);
			// 
			// btnVer
			// 
			this.btnVer.Location = new System.Drawing.Point(337, 80);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(75, 31);
			this.btnVer.TabIndex = 8;
			this.btnVer.Text = "Ver detalles";
			this.btnVer.UseVisualStyleBackColor = true;
			this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 575);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnModificarPropiedad);
			this.Controls.Add(this.btnBorrarPropiedad);
			this.Controls.Add(this.lbPropiedades);
			this.Controls.Add(this.cbPropiedades);
			this.Controls.Add(this.btnAgregarHotel);
			this.Controls.Add(this.btnAgregarCasa);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 614);
			this.Name = "FPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Empresa de Alquileres";
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog ofdElegirImagen;
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.Button btnAgregarHotel;
        private System.Windows.Forms.ComboBox cbPropiedades;
        private System.Windows.Forms.Label lbPropiedades;
        private System.Windows.Forms.Button btnBorrarPropiedad;
        private System.Windows.Forms.Button btnModificarPropiedad;
        private System.Windows.Forms.Button btnVer;
	}
}

