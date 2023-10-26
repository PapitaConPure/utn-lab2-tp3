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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.anterior = new System.Windows.Forms.Button();
			this.siguiente = new System.Windows.Forms.Button();
			this.Ver = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCargarImagen
			// 
			this.btnCargarImagen.Location = new System.Drawing.Point(107, 12);
			this.btnCargarImagen.Name = "btnCargarImagen";
			this.btnCargarImagen.Size = new System.Drawing.Size(157, 46);
			this.btnCargarImagen.TabIndex = 0;
			this.btnCargarImagen.Text = "Cargar Imagen";
			this.btnCargarImagen.UseVisualStyleBackColor = true;
			this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(9, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(365, 241);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// anterior
			// 
			this.anterior.Location = new System.Drawing.Point(25, 62);
			this.anterior.Name = "anterior";
			this.anterior.Size = new System.Drawing.Size(75, 23);
			this.anterior.TabIndex = 2;
			this.anterior.Text = "Anterior";
			this.anterior.UseVisualStyleBackColor = true;
			this.anterior.Click += new System.EventHandler(this.anterior_Click);
			// 
			// siguiente
			// 
			this.siguiente.Location = new System.Drawing.Point(271, 62);
			this.siguiente.Name = "siguiente";
			this.siguiente.Size = new System.Drawing.Size(75, 23);
			this.siguiente.TabIndex = 3;
			this.siguiente.Text = "Siguiente";
			this.siguiente.UseVisualStyleBackColor = true;
			this.siguiente.Click += new System.EventHandler(this.siguiente_click);
			// 
			// Ver
			// 
			this.Ver.Location = new System.Drawing.Point(150, 62);
			this.Ver.Name = "Ver";
			this.Ver.Size = new System.Drawing.Size(75, 23);
			this.Ver.TabIndex = 4;
			this.Ver.Text = "Ver";
			this.Ver.UseVisualStyleBackColor = true;
			this.Ver.Click += new System.EventHandler(this.Ver_Click);
			// 
			// FImagen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 344);
			this.Controls.Add(this.Ver);
			this.Controls.Add(this.siguiente);
			this.Controls.Add(this.anterior);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCargarImagen);
			this.Name = "FImagen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Button Ver;
    }
}

