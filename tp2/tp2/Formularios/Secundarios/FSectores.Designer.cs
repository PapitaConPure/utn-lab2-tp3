
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
			this.lbHoteles = new System.Windows.Forms.Label();
			this.lbCasas = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pnlSectores = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lbHoteles
			// 
			this.lbHoteles.AutoSize = true;
			this.lbHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHoteles.Location = new System.Drawing.Point(128, 22);
			this.lbHoteles.Name = "lbHoteles";
			this.lbHoteles.Size = new System.Drawing.Size(78, 25);
			this.lbHoteles.TabIndex = 0;
			this.lbHoteles.Text = "Hoteles";
			// 
			// lbCasas
			// 
			this.lbCasas.AutoSize = true;
			this.lbCasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCasas.Location = new System.Drawing.Point(576, 22);
			this.lbCasas.MaximumSize = new System.Drawing.Size(200, 200);
			this.lbCasas.Name = "lbCasas";
			this.lbCasas.Size = new System.Drawing.Size(69, 25);
			this.lbCasas.TabIndex = 1;
			this.lbCasas.Text = "Casas";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
			this.pictureBox1.Location = new System.Drawing.Point(543, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(27, 25);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
			this.pictureBox2.Location = new System.Drawing.Point(96, 22);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(26, 25);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// pnlSectores
			// 
			this.pnlSectores.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSectores.Location = new System.Drawing.Point(0, 0);
			this.pnlSectores.Name = "pnlSectores";
			this.pnlSectores.Size = new System.Drawing.Size(800, 450);
			this.pnlSectores.TabIndex = 4;
			this.pnlSectores.BackColorChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
			this.pnlSectores.SizeChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
			this.pnlSectores.VisibleChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
			this.pnlSectores.Paint += new System.Windows.Forms.PaintEventHandler(this.FSectores_Paint);
			// 
			// FSectores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbCasas);
			this.Controls.Add(this.lbHoteles);
			this.Controls.Add(this.pnlSectores);
			this.Name = "FSectores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FSectores";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbHoteles;
        public System.Windows.Forms.Label lbCasas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel pnlSectores;
	}
}