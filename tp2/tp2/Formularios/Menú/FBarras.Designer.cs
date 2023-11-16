
namespace tp2.Formularios.Secundarios
{
    partial class FBarras
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
			this.lbCantPasajeros = new System.Windows.Forms.Label();
			this.pnlBarras = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lbCantPasajeros
			// 
			this.lbCantPasajeros.AutoSize = true;
			this.lbCantPasajeros.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbCantPasajeros.Font = new System.Drawing.Font("Segoe UI Black", 24F);
			this.lbCantPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(123)))));
			this.lbCantPasajeros.Location = new System.Drawing.Point(0, 0);
			this.lbCantPasajeros.Name = "lbCantPasajeros";
			this.lbCantPasajeros.Size = new System.Drawing.Size(367, 45);
			this.lbCantPasajeros.TabIndex = 5;
			this.lbCantPasajeros.Text = "Cantidad de pasajeros";
			// 
			// pnlBarras
			// 
			this.pnlBarras.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBarras.Location = new System.Drawing.Point(0, 45);
			this.pnlBarras.Name = "pnlBarras";
			this.pnlBarras.Size = new System.Drawing.Size(800, 405);
			this.pnlBarras.TabIndex = 0;
			this.pnlBarras.SizeChanged += new System.EventHandler(this.PnlBarras_SizeChanged);
			this.pnlBarras.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBarras_Paint);
			// 
			// FBarras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlBarras);
			this.Controls.Add(this.lbCantPasajeros);
			this.MinimumSize = new System.Drawing.Size(380, 300);
			this.Name = "FBarras";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCantPasajeros;
		private System.Windows.Forms.Panel pnlBarras;
	}
}