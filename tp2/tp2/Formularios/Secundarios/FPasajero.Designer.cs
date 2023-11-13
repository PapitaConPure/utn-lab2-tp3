
namespace tp2.Formularios.Secundarios
{
    partial class FPasajero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDniPasajero = new System.Windows.Forms.NumericUpDown();
            this.tbNombrePasajero = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDniPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dni:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(210, 94);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2023, 11, 12, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            this.dtpFechaNacimiento.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // nudDniPasajero
            // 
            this.nudDniPasajero.Location = new System.Drawing.Point(210, 54);
            this.nudDniPasajero.Name = "nudDniPasajero";
            this.nudDniPasajero.Size = new System.Drawing.Size(120, 20);
            this.nudDniPasajero.TabIndex = 4;
            // 
            // tbNombrePasajero
            // 
            this.tbNombrePasajero.Location = new System.Drawing.Point(210, 25);
            this.tbNombrePasajero.Name = "tbNombrePasajero";
            this.tbNombrePasajero.Size = new System.Drawing.Size(100, 20);
            this.tbNombrePasajero.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(210, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 234);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbNombrePasajero);
            this.Controls.Add(this.nudDniPasajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FPasajero";
            ((System.ComponentModel.ISupportInitialize)(this.nudDniPasajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown nudDniPasajero;
        public System.Windows.Forms.TextBox tbNombrePasajero;
        public System.Windows.Forms.Button btnAceptar;
    }
}