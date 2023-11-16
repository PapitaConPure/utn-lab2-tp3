
namespace tp2
{
    partial class FDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tlpImágenes = new System.Windows.Forms.TableLayoutPanel();
			this.pbImagen1 = new System.Windows.Forms.PictureBox();
			this.pbImagen2 = new System.Windows.Forms.PictureBox();
			this.lsbDetalles = new System.Windows.Forms.ListBox();
			this.gbAlquileres = new System.Windows.Forms.GroupBox();
			this.lsbAlquileres = new System.Windows.Forms.ListBox();
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.btnAlquilar = new System.Windows.Forms.Button();
			this.btnModificarAlquiler = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.gbNroAlquiler = new System.Windows.Forms.GroupBox();
			this.nudNroAlquiler = new System.Windows.Forms.NumericUpDown();
			this.btnCancelarAlquiler = new System.Windows.Forms.Button();
			this.pnlDetalles = new System.Windows.Forms.Panel();
			this.tlpImágenes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
			this.gbAlquileres.SuspendLayout();
			this.tlpBotones.SuspendLayout();
			this.gbNroAlquiler.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).BeginInit();
			this.pnlDetalles.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpImágenes
			// 
			this.tlpImágenes.AutoSize = true;
			this.tlpImágenes.ColumnCount = 1;
			this.tlpImágenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpImágenes.Controls.Add(this.pbImagen1, 0, 0);
			this.tlpImágenes.Controls.Add(this.pbImagen2, 0, 1);
			this.tlpImágenes.Dock = System.Windows.Forms.DockStyle.Right;
			this.tlpImágenes.Location = new System.Drawing.Point(545, 12);
			this.tlpImágenes.Name = "tlpImágenes";
			this.tlpImágenes.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.tlpImágenes.RowCount = 2;
			this.tlpImágenes.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpImágenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpImágenes.Size = new System.Drawing.Size(287, 555);
			this.tlpImágenes.TabIndex = 1;
			// 
			// pbImagen1
			// 
			this.pbImagen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
			this.pbImagen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbImagen1.Location = new System.Drawing.Point(6, 10);
			this.pbImagen1.Margin = new System.Windows.Forms.Padding(6);
			this.pbImagen1.Name = "pbImagen1";
			this.pbImagen1.Size = new System.Drawing.Size(275, 275);
			this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagen1.TabIndex = 0;
			this.pbImagen1.TabStop = false;
			// 
			// pbImagen2
			// 
			this.pbImagen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
			this.pbImagen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbImagen2.Location = new System.Drawing.Point(6, 297);
			this.pbImagen2.Margin = new System.Windows.Forms.Padding(6);
			this.pbImagen2.Name = "pbImagen2";
			this.pbImagen2.Size = new System.Drawing.Size(275, 252);
			this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagen2.TabIndex = 0;
			this.pbImagen2.TabStop = false;
			// 
			// lsbDetalles
			// 
			this.lsbDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
			this.lsbDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lsbDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbDetalles.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lsbDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lsbDetalles.FormattingEnabled = true;
			this.lsbDetalles.IntegralHeight = false;
			this.lsbDetalles.ItemHeight = 20;
			this.lsbDetalles.Location = new System.Drawing.Point(1, 9);
			this.lsbDetalles.Name = "lsbDetalles";
			this.lsbDetalles.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lsbDetalles.Size = new System.Drawing.Size(529, 182);
			this.lsbDetalles.TabIndex = 0;
			this.lsbDetalles.TabStop = false;
			// 
			// gbAlquileres
			// 
			this.gbAlquileres.Controls.Add(this.lsbAlquileres);
			this.gbAlquileres.Controls.Add(this.tlpBotones);
			this.gbAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbAlquileres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbAlquileres.Location = new System.Drawing.Point(12, 215);
			this.gbAlquileres.Name = "gbAlquileres";
			this.gbAlquileres.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.gbAlquileres.Size = new System.Drawing.Size(533, 352);
			this.gbAlquileres.TabIndex = 11;
			this.gbAlquileres.TabStop = false;
			this.gbAlquileres.Text = "ALQUILERES";
			// 
			// lsbAlquileres
			// 
			this.lsbAlquileres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
			this.lsbAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lsbAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbAlquileres.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lsbAlquileres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lsbAlquileres.FormattingEnabled = true;
			this.lsbAlquileres.IntegralHeight = false;
			this.lsbAlquileres.ItemHeight = 20;
			this.lsbAlquileres.Location = new System.Drawing.Point(6, 18);
			this.lsbAlquileres.Name = "lsbAlquileres";
			this.lsbAlquileres.ScrollAlwaysVisible = true;
			this.lsbAlquileres.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lsbAlquileres.Size = new System.Drawing.Size(521, 269);
			this.lsbAlquileres.TabIndex = 0;
			this.lsbAlquileres.TabStop = false;
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 5;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tlpBotones.Controls.Add(this.btnAlquilar, 0, 0);
			this.tlpBotones.Controls.Add(this.btnModificarAlquiler, 1, 0);
			this.tlpBotones.Controls.Add(this.btnImprimir, 2, 0);
			this.tlpBotones.Controls.Add(this.gbNroAlquiler, 4, 0);
			this.tlpBotones.Controls.Add(this.btnCancelarAlquiler, 3, 0);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tlpBotones.Location = new System.Drawing.Point(6, 287);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.tlpBotones.RowCount = 1;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Size = new System.Drawing.Size(521, 61);
			this.tlpBotones.TabIndex = 9;
			// 
			// btnAlquilar
			// 
			this.btnAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnAlquilar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAlquilar.FlatAppearance.BorderSize = 0;
			this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlquilar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAlquilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnAlquilar.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAlquilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlquilar.Location = new System.Drawing.Point(3, 7);
			this.btnAlquilar.Name = "btnAlquilar";
			this.btnAlquilar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btnAlquilar.Size = new System.Drawing.Size(108, 47);
			this.btnAlquilar.TabIndex = 0;
			this.btnAlquilar.Text = "      Nuevo";
			this.btnAlquilar.UseVisualStyleBackColor = false;
			this.btnAlquilar.Click += new System.EventHandler(this.BtnAlquilar_Click);
			// 
			// btnModificarAlquiler
			// 
			this.btnModificarAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnModificarAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnModificarAlquiler.FlatAppearance.BorderSize = 0;
			this.btnModificarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificarAlquiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnModificarAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnModificarAlquiler.Image = global::tp2.Properties.Resources.pencilwhite24;
			this.btnModificarAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificarAlquiler.Location = new System.Drawing.Point(117, 7);
			this.btnModificarAlquiler.Name = "btnModificarAlquiler";
			this.btnModificarAlquiler.Size = new System.Drawing.Size(108, 47);
			this.btnModificarAlquiler.TabIndex = 2;
			this.btnModificarAlquiler.Text = "      Modificar";
			this.btnModificarAlquiler.UseVisualStyleBackColor = false;
			this.btnModificarAlquiler.Click += new System.EventHandler(this.BtnModificarAlquiler_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnImprimir.Image = global::tp2.Properties.Resources.docwhite24;
			this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImprimir.Location = new System.Drawing.Point(231, 7);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(108, 47);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "      Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
			// 
			// gbNroAlquiler
			// 
			this.gbNroAlquiler.Controls.Add(this.nudNroAlquiler);
			this.gbNroAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbNroAlquiler.Location = new System.Drawing.Point(459, 7);
			this.gbNroAlquiler.Name = "gbNroAlquiler";
			this.gbNroAlquiler.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
			this.gbNroAlquiler.Size = new System.Drawing.Size(55, 47);
			this.gbNroAlquiler.TabIndex = 1;
			this.gbNroAlquiler.TabStop = false;
			this.gbNroAlquiler.Text = "NRO.";
			// 
			// nudNroAlquiler
			// 
			this.nudNroAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudNroAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudNroAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudNroAlquiler.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudNroAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudNroAlquiler.Location = new System.Drawing.Point(4, 18);
			this.nudNroAlquiler.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.nudNroAlquiler.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.nudNroAlquiler.Name = "nudNroAlquiler";
			this.nudNroAlquiler.Size = new System.Drawing.Size(47, 23);
			this.nudNroAlquiler.TabIndex = 1;
			this.nudNroAlquiler.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudNroAlquiler.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// btnCancelarAlquiler
			// 
			this.btnCancelarAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
			this.btnCancelarAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancelarAlquiler.FlatAppearance.BorderSize = 0;
			this.btnCancelarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarAlquiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCancelarAlquiler.ForeColor = System.Drawing.Color.White;
			this.btnCancelarAlquiler.Image = global::tp2.Properties.Resources.xwhite24;
			this.btnCancelarAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelarAlquiler.Location = new System.Drawing.Point(345, 7);
			this.btnCancelarAlquiler.Name = "btnCancelarAlquiler";
			this.btnCancelarAlquiler.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btnCancelarAlquiler.Size = new System.Drawing.Size(108, 47);
			this.btnCancelarAlquiler.TabIndex = 4;
			this.btnCancelarAlquiler.Text = "      Cancelar";
			this.btnCancelarAlquiler.UseVisualStyleBackColor = false;
			this.btnCancelarAlquiler.Click += new System.EventHandler(this.BtnCancelarAlquiler_Click);
			// 
			// pnlDetalles
			// 
			this.pnlDetalles.Controls.Add(this.lsbDetalles);
			this.pnlDetalles.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetalles.Location = new System.Drawing.Point(12, 12);
			this.pnlDetalles.Name = "pnlDetalles";
			this.pnlDetalles.Padding = new System.Windows.Forms.Padding(1, 9, 3, 12);
			this.pnlDetalles.Size = new System.Drawing.Size(533, 203);
			this.pnlDetalles.TabIndex = 12;
			// 
			// FDetalles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(844, 579);
			this.Controls.Add(this.gbAlquileres);
			this.Controls.Add(this.pnlDetalles);
			this.Controls.Add(this.tlpImágenes);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.MinimumSize = new System.Drawing.Size(860, 613);
			this.Name = "FDetalles";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Residencia";
			this.Load += new System.EventHandler(this.FDetalles_Load);
			this.tlpImágenes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
			this.gbAlquileres.ResumeLayout(false);
			this.tlpBotones.ResumeLayout(false);
			this.gbNroAlquiler.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).EndInit();
			this.pnlDetalles.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.TableLayoutPanel tlpImágenes;
		public System.Windows.Forms.PictureBox pbImagen1;
		public System.Windows.Forms.PictureBox pbImagen2;
		public System.Windows.Forms.ListBox lsbDetalles;
		private System.Windows.Forms.GroupBox gbAlquileres;
		public System.Windows.Forms.ListBox lsbAlquileres;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnAlquilar;
        public System.Windows.Forms.Button btnModificarAlquiler;
        public System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbNroAlquiler;
        public System.Windows.Forms.NumericUpDown nudNroAlquiler;
        public System.Windows.Forms.Button btnCancelarAlquiler;
		private System.Windows.Forms.Panel pnlDetalles;
	}
}