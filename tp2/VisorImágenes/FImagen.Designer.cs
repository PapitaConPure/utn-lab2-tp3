namespace cargandoImagenes
{
    partial class FImagen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnCargarImagen = new System.Windows.Forms.Button();
			this.pbVisor = new System.Windows.Forms.PictureBox();
			this.anterior = new System.Windows.Forms.Button();
			this.btnQuitarImágenes = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCantImágenes = new System.Windows.Forms.Button();
			this.siguiente = new System.Windows.Forms.Button();
			this.ofdElegirImagen = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbVisor)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCargarImagen
			// 
			this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnCargarImagen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCargarImagen.FlatAppearance.BorderSize = 0;
			this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCargarImagen.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCargarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnCargarImagen.Image = global::VisorImágenes.Properties.Resources.plusblack24;
			this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCargarImagen.Location = new System.Drawing.Point(4, 4);
			this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4);
			this.btnCargarImagen.Name = "btnCargarImagen";
			this.btnCargarImagen.Size = new System.Drawing.Size(107, 42);
			this.btnCargarImagen.TabIndex = 0;
			this.btnCargarImagen.Text = "      Cargar";
			this.btnCargarImagen.UseVisualStyleBackColor = false;
			this.btnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
			// 
			// pbVisor
			// 
			this.pbVisor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbVisor.Location = new System.Drawing.Point(12, 12);
			this.pbVisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbVisor.Name = "pbVisor";
			this.pbVisor.Size = new System.Drawing.Size(356, 313);
			this.pbVisor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbVisor.TabIndex = 1;
			this.pbVisor.TabStop = false;
			// 
			// anterior
			// 
			this.anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.anterior.Dock = System.Windows.Forms.DockStyle.Right;
			this.anterior.FlatAppearance.BorderSize = 0;
			this.anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.anterior.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.anterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.anterior.Location = new System.Drawing.Point(234, 4);
			this.anterior.Margin = new System.Windows.Forms.Padding(4);
			this.anterior.Name = "anterior";
			this.anterior.Size = new System.Drawing.Size(42, 42);
			this.anterior.TabIndex = 2;
			this.anterior.Text = "◄";
			this.anterior.UseVisualStyleBackColor = false;
			this.anterior.Click += new System.EventHandler(this.BtnAnterior_Click);
			// 
			// btnQuitarImágenes
			// 
			this.btnQuitarImágenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
			this.btnQuitarImágenes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitarImágenes.FlatAppearance.BorderSize = 0;
			this.btnQuitarImágenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuitarImágenes.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnQuitarImágenes.ForeColor = System.Drawing.Color.White;
			this.btnQuitarImágenes.Image = global::VisorImágenes.Properties.Resources.xwhite24;
			this.btnQuitarImágenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuitarImágenes.Location = new System.Drawing.Point(119, 4);
			this.btnQuitarImágenes.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuitarImágenes.Name = "btnQuitarImágenes";
			this.btnQuitarImágenes.Size = new System.Drawing.Size(107, 42);
			this.btnQuitarImágenes.TabIndex = 1;
			this.btnQuitarImágenes.Text = "      Quitar";
			this.btnQuitarImágenes.UseVisualStyleBackColor = false;
			this.btnQuitarImágenes.Click += new System.EventHandler(this.BtnQuitarImágenes_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.btnCantImágenes, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.siguiente, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCargarImagen, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.anterior, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnQuitarImágenes, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 50);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// btnCantImágenes
			// 
			this.btnCantImágenes.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCantImágenes.FlatAppearance.BorderSize = 0;
			this.btnCantImágenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.btnCantImágenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.btnCantImágenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCantImágenes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.btnCantImágenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(101)))));
			this.btnCantImágenes.Location = new System.Drawing.Point(334, 4);
			this.btnCantImágenes.Margin = new System.Windows.Forms.Padding(4);
			this.btnCantImágenes.Name = "btnCantImágenes";
			this.btnCantImágenes.Size = new System.Drawing.Size(42, 42);
			this.btnCantImágenes.TabIndex = 4;
			this.btnCantImágenes.TabStop = false;
			this.btnCantImágenes.Text = "0";
			this.btnCantImágenes.UseVisualStyleBackColor = false;
			// 
			// siguiente
			// 
			this.siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.siguiente.Dock = System.Windows.Forms.DockStyle.Right;
			this.siguiente.FlatAppearance.BorderSize = 0;
			this.siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.siguiente.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.siguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.siguiente.Location = new System.Drawing.Point(284, 4);
			this.siguiente.Margin = new System.Windows.Forms.Padding(4);
			this.siguiente.Name = "siguiente";
			this.siguiente.Size = new System.Drawing.Size(42, 42);
			this.siguiente.TabIndex = 3;
			this.siguiente.Text = "►";
			this.siguiente.UseVisualStyleBackColor = false;
			this.siguiente.Click += new System.EventHandler(this.BtnSiguiente_click);
			// 
			// ofdElegirImagen
			// 
			this.ofdElegirImagen.DefaultExt = "*.png";
			this.ofdElegirImagen.Filter = "Imagen PNG (*.png)|*.png|Imagen JPG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jp" +
    "e;*.jfif|Secuencia GIF (*.gif)|*.gif|Todos los archivos (*.*)|*.*";
			this.ofdElegirImagen.InitialDirectory = ".";
			this.ofdElegirImagen.Title = "Elegir imagen";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pbVisor);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 50);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(12);
			this.panel1.Size = new System.Drawing.Size(380, 337);
			this.panel1.TabIndex = 6;
			// 
			// FImagen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(380, 387);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(254, 254);
			this.Name = "FImagen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visor de Imágenes";
			((System.ComponentModel.ISupportInitialize)(this.pbVisor)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pbVisor;
        private System.Windows.Forms.Button anterior;
		private System.Windows.Forms.Button btnQuitarImágenes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button siguiente;
		private System.Windows.Forms.OpenFileDialog ofdElegirImagen;
		private System.Windows.Forms.Button btnCantImágenes;
		private System.Windows.Forms.Panel panel1;
	}
}

