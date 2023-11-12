
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(109, 81);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(112, 130);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(61, 13);
            this.lbContraseña.TabIndex = 1;
            this.lbContraseña.Text = "Contraseña";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(249, 123);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '•';
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 2;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(249, 81);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(190, 199);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnAceptar.Location = new System.Drawing.Point(77, 199);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(324, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(199, 33);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbAdministrador.TabIndex = 6;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            this.rbAdministrador.Visible = false;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Checked = true;
            this.rbEmpleado.Location = new System.Drawing.Point(311, 35);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rbEmpleado.TabIndex = 7;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            this.rbEmpleado.Visible = false;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Location = new System.Drawing.Point(108, 35);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(31, 13);
            this.lbTipoUsuario.TabIndex = 8;
            this.lbTipoUsuario.Text = "Tipo:";
            this.lbTipoUsuario.Visible = false;
            // 
            // FUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 253);
            this.Controls.Add(this.lbTipoUsuario);
            this.Controls.Add(this.rbEmpleado);
            this.Controls.Add(this.rbAdministrador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Name = "FUsuario";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        public System.Windows.Forms.TextBox tbContraseña;
        public System.Windows.Forms.TextBox tbUsuario;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.RadioButton rbAdministrador;
        public System.Windows.Forms.RadioButton rbEmpleado;
        public System.Windows.Forms.Label lbTipoUsuario;
    }
}