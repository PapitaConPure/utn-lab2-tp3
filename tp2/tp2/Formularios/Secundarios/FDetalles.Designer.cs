
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.lsbDetalles = new System.Windows.Forms.ListBox();
            this.gbAlquileres = new System.Windows.Forms.GroupBox();
            this.lsbAlquileres = new System.Windows.Forms.ListBox();
            this.gbNroAlquiler = new System.Windows.Forms.GroupBox();
            this.nudNroAlquiler = new System.Windows.Forms.NumericUpDown();
            this.btnCancelarAlquiler = new System.Windows.Forms.Button();
            this.btnModificarAlquiler = new System.Windows.Forms.Button();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.pbImagen2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDetalles.SuspendLayout();
            this.gbAlquileres.SuspendLayout();
            this.gbNroAlquiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbImagen1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbImagen2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 417);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 184);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.lsbDetalles);
            this.gbDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetalles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gbDetalles.Location = new System.Drawing.Point(0, 0);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(561, 155);
            this.gbDetalles.TabIndex = 10;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles";
            // 
            // lsbDetalles
            // 
            this.lsbDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbDetalles.FormattingEnabled = true;
            this.lsbDetalles.IntegralHeight = false;
            this.lsbDetalles.ItemHeight = 20;
            this.lsbDetalles.Location = new System.Drawing.Point(3, 23);
            this.lsbDetalles.Name = "lsbDetalles";
            this.lsbDetalles.ScrollAlwaysVisible = true;
            this.lsbDetalles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbDetalles.Size = new System.Drawing.Size(555, 129);
            this.lsbDetalles.TabIndex = 0;
            // 
            // gbAlquileres
            // 
            this.gbAlquileres.Controls.Add(this.lsbAlquileres);
            this.gbAlquileres.Controls.Add(this.tableLayoutPanel3);
            this.gbAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlquileres.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gbAlquileres.Location = new System.Drawing.Point(0, 155);
            this.gbAlquileres.Name = "gbAlquileres";
            this.gbAlquileres.Size = new System.Drawing.Size(561, 262);
            this.gbAlquileres.TabIndex = 11;
            this.gbAlquileres.TabStop = false;
            this.gbAlquileres.Text = "Alquileres";
            // 
            // lsbAlquileres
            // 
            this.lsbAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbAlquileres.FormattingEnabled = true;
            this.lsbAlquileres.IntegralHeight = false;
            this.lsbAlquileres.ItemHeight = 20;
            this.lsbAlquileres.Location = new System.Drawing.Point(3, 23);
            this.lsbAlquileres.Name = "lsbAlquileres";
            this.lsbAlquileres.ScrollAlwaysVisible = true;
            this.lsbAlquileres.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbAlquileres.Size = new System.Drawing.Size(555, 179);
            this.lsbAlquileres.TabIndex = 0;
            // 
            // gbNroAlquiler
            // 
            this.gbNroAlquiler.Controls.Add(this.nudNroAlquiler);
            this.gbNroAlquiler.Location = new System.Drawing.Point(492, 3);
            this.gbNroAlquiler.Name = "gbNroAlquiler";
            this.gbNroAlquiler.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gbNroAlquiler.Size = new System.Drawing.Size(55, 51);
            this.gbNroAlquiler.TabIndex = 3;
            this.gbNroAlquiler.TabStop = false;
            this.gbNroAlquiler.Text = "Nro.";
            // 
            // nudNroAlquiler
            // 
            this.nudNroAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNroAlquiler.Location = new System.Drawing.Point(3, 20);
            this.nudNroAlquiler.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.nudNroAlquiler.Name = "nudNroAlquiler";
            this.nudNroAlquiler.Size = new System.Drawing.Size(49, 27);
            this.nudNroAlquiler.TabIndex = 0;
            // 
            // btnCancelarAlquiler
            // 
            this.btnCancelarAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.btnCancelarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnCancelarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlquiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnCancelarAlquiler.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAlquiler.Location = new System.Drawing.Point(241, 3);
            this.btnCancelarAlquiler.Name = "btnCancelarAlquiler";
            this.btnCancelarAlquiler.Size = new System.Drawing.Size(120, 51);
            this.btnCancelarAlquiler.TabIndex = 2;
            this.btnCancelarAlquiler.Text = "Cancelar";
            this.btnCancelarAlquiler.UseVisualStyleBackColor = false;
            this.btnCancelarAlquiler.Click += new System.EventHandler(this.BtnCancelarAlquiler_Click);
            // 
            // btnModificarAlquiler
            // 
            this.btnModificarAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnModificarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnModificarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlquiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnModificarAlquiler.Location = new System.Drawing.Point(117, 3);
            this.btnModificarAlquiler.Name = "btnModificarAlquiler";
            this.btnModificarAlquiler.Size = new System.Drawing.Size(118, 51);
            this.btnModificarAlquiler.TabIndex = 1;
            this.btnModificarAlquiler.Text = "Modificar";
            this.btnModificarAlquiler.UseVisualStyleBackColor = false;
            this.btnModificarAlquiler.Click += new System.EventHandler(this.BtnModificarAlquiler_Click);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnAlquilar.FlatAppearance.BorderSize = 0;
            this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAlquilar.Location = new System.Drawing.Point(3, 3);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(108, 51);
            this.btnAlquilar.TabIndex = 0;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.BtnAlquilar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.33515F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.05994F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.6049F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel3.Controls.Add(this.btnAlquilar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnModificarAlquiler, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnImprimir, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbNroAlquiler, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelarAlquiler, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(555, 57);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(367, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 51);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pbImagen1
            // 
            this.pbImagen1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbImagen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbImagen1.Location = new System.Drawing.Point(3, 7);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(274, 174);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen1.TabIndex = 0;
            this.pbImagen1.TabStop = false;
            // 
            // pbImagen2
            // 
            this.pbImagen2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbImagen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen2.Location = new System.Drawing.Point(283, 7);
            this.pbImagen2.Name = "pbImagen2";
            this.pbImagen2.Size = new System.Drawing.Size(275, 174);
            this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen2.TabIndex = 0;
            this.pbImagen2.TabStop = false;
            // 
            // FDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 601);
            this.Controls.Add(this.gbAlquileres);
            this.Controls.Add(this.gbDetalles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.MinimumSize = new System.Drawing.Size(360, 440);
            this.Name = "FDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Residencia";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDetalles.ResumeLayout(false);
            this.gbAlquileres.ResumeLayout(false);
            this.gbNroAlquiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.PictureBox pbImagen1;
		public System.Windows.Forms.PictureBox pbImagen2;
		private System.Windows.Forms.GroupBox gbDetalles;
		public System.Windows.Forms.ListBox lsbDetalles;
		private System.Windows.Forms.GroupBox gbAlquileres;
		public System.Windows.Forms.ListBox lsbAlquileres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAlquilar;
        public System.Windows.Forms.Button btnModificarAlquiler;
        public System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbNroAlquiler;
        public System.Windows.Forms.NumericUpDown nudNroAlquiler;
        public System.Windows.Forms.Button btnCancelarAlquiler;
    }
}