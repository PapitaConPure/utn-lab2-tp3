
namespace tp2.Formularios.Secundarios
{
    partial class FSectores
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
			this.pnlSectores = new System.Windows.Forms.Panel();
			this.lbPropReser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pnlSectores
			// 
			this.pnlSectores.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSectores.Location = new System.Drawing.Point(0, 45);
			this.pnlSectores.Name = "pnlSectores";
			this.pnlSectores.Size = new System.Drawing.Size(800, 405);
			this.pnlSectores.TabIndex = 4;
			this.pnlSectores.BackColorChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
			this.pnlSectores.SizeChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
			this.pnlSectores.VisibleChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
			this.pnlSectores.Paint += new System.Windows.Forms.PaintEventHandler(this.FSectores_Paint);
			// 
			// lbPropReser
			// 
			this.lbPropReser.AutoSize = true;
			this.lbPropReser.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbPropReser.Font = new System.Drawing.Font("Segoe UI Black", 24F);
			this.lbPropReser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
			this.lbPropReser.Location = new System.Drawing.Point(0, 0);
			this.lbPropReser.Name = "lbPropReser";
			this.lbPropReser.Size = new System.Drawing.Size(393, 45);
			this.lbPropReser.TabIndex = 8;
			this.lbPropReser.Text = "Propiedades Alquiladas";
			// 
			// FSectores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlSectores);
			this.Controls.Add(this.lbPropReser);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(410, 360);
			this.Name = "FSectores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlSectores;
		private System.Windows.Forms.Label lbPropReser;
	}
}