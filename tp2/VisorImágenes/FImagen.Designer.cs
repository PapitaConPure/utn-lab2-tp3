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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.siguiente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbVisor)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCargarImagen
			// 
			this.btnCargarImagen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCargarImagen.Location = new System.Drawing.Point(3, 3);
			this.btnCargarImagen.Name = "btnCargarImagen";
			this.btnCargarImagen.Size = new System.Drawing.Size(174, 30);
			this.btnCargarImagen.TabIndex = 0;
			this.btnCargarImagen.Text = "Cargar Imágenes";
			this.btnCargarImagen.UseVisualStyleBackColor = true;
			this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
			// 
			// pbVisor
			// 
			this.pbVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbVisor.Location = new System.Drawing.Point(12, 93);
			this.pbVisor.Name = "pbVisor";
			this.pbVisor.Size = new System.Drawing.Size(360, 239);
			this.pbVisor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbVisor.TabIndex = 1;
			this.pbVisor.TabStop = false;
			// 
			// anterior
			// 
			this.anterior.Dock = System.Windows.Forms.DockStyle.Fill;
			this.anterior.Location = new System.Drawing.Point(3, 3);
			this.anterior.Name = "anterior";
			this.anterior.Size = new System.Drawing.Size(174, 27);
			this.anterior.TabIndex = 2;
			this.anterior.Text = "Anterior";
			this.anterior.UseVisualStyleBackColor = true;
			this.anterior.Click += new System.EventHandler(this.anterior_Click);
			// 
			// btnQuitarImágenes
			// 
			this.btnQuitarImágenes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitarImágenes.Location = new System.Drawing.Point(183, 3);
			this.btnQuitarImágenes.Name = "btnQuitarImágenes";
			this.btnQuitarImágenes.Size = new System.Drawing.Size(174, 30);
			this.btnQuitarImágenes.TabIndex = 0;
			this.btnQuitarImágenes.Text = "Quitar Imágenes";
			this.btnQuitarImágenes.UseVisualStyleBackColor = true;
			this.btnQuitarImágenes.Click += new System.EventHandler(this.btnQuitarImágenes_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnCargarImagen, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnQuitarImágenes, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 36);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.siguiente, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.anterior, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 54);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 33);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// siguiente
			// 
			this.siguiente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.siguiente.Location = new System.Drawing.Point(183, 3);
			this.siguiente.Name = "siguiente";
			this.siguiente.Size = new System.Drawing.Size(174, 27);
			this.siguiente.TabIndex = 4;
			this.siguiente.Text = "Siguiente";
			this.siguiente.UseVisualStyleBackColor = true;
			this.siguiente.Click += new System.EventHandler(this.siguiente_click);
			// 
			// FImagen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 344);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pbVisor);
			this.Name = "FImagen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Imágenes";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FImagen_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pbVisor)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pbVisor;
        private System.Windows.Forms.Button anterior;
		private System.Windows.Forms.Button btnQuitarImágenes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button siguiente;
	}
}

