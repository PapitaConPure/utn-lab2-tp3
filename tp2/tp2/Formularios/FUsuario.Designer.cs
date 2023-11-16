
namespace tp2
{
    partial class FUsuario
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
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.pnlBotonesAceptar = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tlpBotonesAlt = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotónCancelar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.gbContraseña = new System.Windows.Forms.GroupBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.tlpTipoUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.pnlBotonesAceptar.SuspendLayout();
            this.tlpBotonesAlt.SuspendLayout();
            this.pnlBotónCancelar.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.gbContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            this.tlpTipoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContraseña.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbContraseña.Location = new System.Drawing.Point(31, 17);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '•';
            this.tbContraseña.Size = new System.Drawing.Size(405, 20);
            this.tbContraseña.TabIndex = 0;
            this.tbContraseña.Click += new System.EventHandler(this.SeleccionarTextBox);
            this.tbContraseña.Enter += new System.EventHandler(this.SeleccionarTextBox);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbUsuario.Location = new System.Drawing.Point(31, 17);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(405, 20);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Click += new System.EventHandler(this.SeleccionarTextBox);
            this.tbUsuario.Enter += new System.EventHandler(this.SeleccionarTextBox);
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAdministrador.Location = new System.Drawing.Point(4, 5);
            this.rbAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(211, 40);
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbEmpleado.Checked = true;
            this.rbEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbEmpleado.Location = new System.Drawing.Point(223, 5);
            this.rbEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(212, 40);
            this.rbEmpleado.TabIndex = 1;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // pnlBotonesAceptar
            // 
            this.pnlBotonesAceptar.Controls.Add(this.btnAceptar);
            this.pnlBotonesAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotonesAceptar.Location = new System.Drawing.Point(3, 3);
            this.pnlBotonesAceptar.Name = "pnlBotonesAceptar";
            this.pnlBotonesAceptar.Size = new System.Drawing.Size(169, 36);
            this.pnlBotonesAceptar.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnAceptar.Location = new System.Drawing.Point(0, 0);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(169, 36);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // tlpBotonesAlt
            // 
            this.tlpBotonesAlt.ColumnCount = 3;
            this.tlpBotonesAlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBotonesAlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotonesAlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBotonesAlt.Controls.Add(this.pnlBotónCancelar, 2, 0);
            this.tlpBotonesAlt.Controls.Add(this.pnlBotonesAceptar, 0, 0);
            this.tlpBotonesAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBotonesAlt.Location = new System.Drawing.Point(12, 210);
            this.tlpBotonesAlt.Name = "tlpBotonesAlt";
            this.tlpBotonesAlt.RowCount = 1;
            this.tlpBotonesAlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesAlt.Size = new System.Drawing.Size(439, 42);
            this.tlpBotonesAlt.TabIndex = 4;
            this.tlpBotonesAlt.Visible = false;
            // 
            // pnlBotónCancelar
            // 
            this.pnlBotónCancelar.Controls.Add(this.btnCancelar);
            this.pnlBotónCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotónCancelar.Location = new System.Drawing.Point(265, 3);
            this.pnlBotónCancelar.Name = "pnlBotónCancelar";
            this.pnlBotónCancelar.Size = new System.Drawing.Size(171, 36);
            this.pnlBotónCancelar.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.tbUsuario);
            this.gbUsuario.Controls.Add(this.pbUsuario);
            this.gbUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.gbUsuario.Location = new System.Drawing.Point(12, 109);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(439, 48);
            this.gbUsuario.TabIndex = 1;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "USUARIO";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbUsuario.Image = global::tp2.Properties.Resources.useraccent24;
            this.pbUsuario.Location = new System.Drawing.Point(3, 17);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(28, 28);
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            // 
            // gbContraseña
            // 
            this.gbContraseña.Controls.Add(this.tbContraseña);
            this.gbContraseña.Controls.Add(this.pbContraseña);
            this.gbContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.gbContraseña.Location = new System.Drawing.Point(12, 157);
            this.gbContraseña.Name = "gbContraseña";
            this.gbContraseña.Size = new System.Drawing.Size(439, 48);
            this.gbContraseña.TabIndex = 2;
            this.gbContraseña.TabStop = false;
            this.gbContraseña.Text = "CONTRASEÑA";
            // 
            // pbContraseña
            // 
            this.pbContraseña.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbContraseña.Image = global::tp2.Properties.Resources.passaccent24;
            this.pbContraseña.Location = new System.Drawing.Point(3, 17);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(28, 28);
            this.pbContraseña.TabIndex = 1;
            this.pbContraseña.TabStop = false;
            // 
            // tlpTipoUsuario
            // 
            this.tlpTipoUsuario.ColumnCount = 2;
            this.tlpTipoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipoUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipoUsuario.Controls.Add(this.rbAdministrador, 0, 0);
            this.tlpTipoUsuario.Controls.Add(this.rbEmpleado, 1, 0);
            this.tlpTipoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTipoUsuario.Location = new System.Drawing.Point(12, 59);
            this.tlpTipoUsuario.Name = "tlpTipoUsuario";
            this.tlpTipoUsuario.RowCount = 1;
            this.tlpTipoUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTipoUsuario.Size = new System.Drawing.Size(439, 50);
            this.tlpTipoUsuario.TabIndex = 0;
            this.tlpTipoUsuario.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnIngresar.Location = new System.Drawing.Point(12, 168);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(439, 42);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTítulo.Font = new System.Drawing.Font("Segoe UI Black", 26F);
            this.lblTítulo.ForeColor = System.Drawing.Color.White;
            this.lblTítulo.Location = new System.Drawing.Point(12, 12);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(101, 47);
            this.lblTítulo.TabIndex = 5;
            this.lblTítulo.Text = "Hola";
            // 
            // FUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(463, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gbContraseña);
            this.Controls.Add(this.tlpBotonesAlt);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.tlpTipoUsuario);
            this.Controls.Add(this.lblTítulo);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FUsuario";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.FUsuario_Load);
            this.Shown += new System.EventHandler(this.FUsuario_Shown);
            this.pnlBotonesAceptar.ResumeLayout(false);
            this.tlpBotonesAlt.ResumeLayout(false);
            this.pnlBotónCancelar.ResumeLayout(false);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.gbContraseña.ResumeLayout(false);
            this.gbContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            this.tlpTipoUsuario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbContraseña;
        public System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.Panel pnlBotonesAceptar;
		private System.Windows.Forms.Panel pnlBotónCancelar;
		public System.Windows.Forms.TableLayoutPanel tlpTipoUsuario;
		private System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.TableLayoutPanel tlpBotonesAlt;
		public System.Windows.Forms.RadioButton rbAdministrador;
		public System.Windows.Forms.RadioButton rbEmpleado;
		public System.Windows.Forms.GroupBox gbUsuario;
		public System.Windows.Forms.GroupBox gbContraseña;
		public System.Windows.Forms.Button btnIngresar;
		public System.Windows.Forms.Button btnAceptar;
		public System.Windows.Forms.Label lblTítulo;
		private System.Windows.Forms.PictureBox pbUsuario;
		private System.Windows.Forms.PictureBox pbContraseña;
	}
}