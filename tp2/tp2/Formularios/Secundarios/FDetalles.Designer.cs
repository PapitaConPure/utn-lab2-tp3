
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
            this.lbDetalles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.pbImagen2 = new System.Windows.Forms.PictureBox();
            this.btnCancelarAlquiler = new System.Windows.Forms.Button();
            this.btnModificarAlquiler = new System.Windows.Forms.Button();
            this.nudNROAlquiler = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNROAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDetalles
            // 
            this.lbDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDetalles.FormattingEnabled = true;
            this.lbDetalles.Location = new System.Drawing.Point(0, 0);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.Size = new System.Drawing.Size(445, 362);
            this.lbDetalles.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 362);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 184);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pbImagen1
            // 
            this.pbImagen1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbImagen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbImagen1.Location = new System.Drawing.Point(3, 7);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(216, 174);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen1.TabIndex = 0;
            this.pbImagen1.TabStop = false;
            // 
            // pbImagen2
            // 
            this.pbImagen2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbImagen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen2.Location = new System.Drawing.Point(225, 7);
            this.pbImagen2.Name = "pbImagen2";
            this.pbImagen2.Size = new System.Drawing.Size(217, 174);
            this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen2.TabIndex = 0;
            this.pbImagen2.TabStop = false;
            // 
            // btnCancelarAlquiler
            // 
            this.btnCancelarAlquiler.Location = new System.Drawing.Point(42, 333);
            this.btnCancelarAlquiler.Name = "btnCancelarAlquiler";
            this.btnCancelarAlquiler.Size = new System.Drawing.Size(105, 23);
            this.btnCancelarAlquiler.TabIndex = 2;
            this.btnCancelarAlquiler.Text = "Cancelar Alquiler";
            this.btnCancelarAlquiler.UseVisualStyleBackColor = true;
            this.btnCancelarAlquiler.Visible = false;
            this.btnCancelarAlquiler.Click += new System.EventHandler(this.btnCancelarAlquiler_Click);
            // 
            // btnModificarAlquiler
            // 
            this.btnModificarAlquiler.Location = new System.Drawing.Point(282, 333);
            this.btnModificarAlquiler.Name = "btnModificarAlquiler";
            this.btnModificarAlquiler.Size = new System.Drawing.Size(100, 23);
            this.btnModificarAlquiler.TabIndex = 3;
            this.btnModificarAlquiler.Text = "Modificar Alquiler";
            this.btnModificarAlquiler.UseVisualStyleBackColor = true;
            this.btnModificarAlquiler.Visible = false;
            this.btnModificarAlquiler.Click += new System.EventHandler(this.btnModificarAlquiler_Click);
            // 
            // nudNROAlquiler
            // 
            this.nudNROAlquiler.Location = new System.Drawing.Point(153, 283);
            this.nudNROAlquiler.Name = "nudNROAlquiler";
            this.nudNROAlquiler.Size = new System.Drawing.Size(120, 20);
            this.nudNROAlquiler.TabIndex = 4;
            // 
            // FDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 546);
            this.Controls.Add(this.nudNROAlquiler);
            this.Controls.Add(this.btnModificarAlquiler);
            this.Controls.Add(this.btnCancelarAlquiler);
            this.Controls.Add(this.lbDetalles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(280, 420);
            this.Name = "FDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles de Residencia";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNROAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbDetalles;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.PictureBox pbImagen1;
		public System.Windows.Forms.PictureBox pbImagen2;
        public System.Windows.Forms.Button btnModificarAlquiler;
        public System.Windows.Forms.Button btnCancelarAlquiler;
        public System.Windows.Forms.NumericUpDown nudNROAlquiler;
    }
}