
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
			this.btncm = new System.Windows.Forms.Button();
			this.btnbm = new System.Windows.Forms.Button();
			this.btnam = new System.Windows.Forms.Button();
			this.btncp = new System.Windows.Forms.Button();
			this.btnbp = new System.Windows.Forms.Button();
			this.btnap = new System.Windows.Forms.Button();
			this.lbPropReser = new System.Windows.Forms.Label();
			this.pnlSectores.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSectores
			// 
			this.pnlSectores.Controls.Add(this.btncm);
			this.pnlSectores.Controls.Add(this.btnbm);
			this.pnlSectores.Controls.Add(this.btnam);
			this.pnlSectores.Controls.Add(this.btncp);
			this.pnlSectores.Controls.Add(this.btnbp);
			this.pnlSectores.Controls.Add(this.btnap);
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
			// btncm
			// 
			this.btncm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btncm.Location = new System.Drawing.Point(765, 370);
			this.btncm.Name = "btncm";
			this.btncm.Size = new System.Drawing.Size(23, 23);
			this.btncm.TabIndex = 1;
			this.btncm.Text = "-";
			this.btncm.UseVisualStyleBackColor = true;
			this.btncm.Visible = false;
			this.btncm.Click += new System.EventHandler(this.Btncm_Click);
			// 
			// btnbm
			// 
			this.btnbm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnbm.Location = new System.Drawing.Point(765, 341);
			this.btnbm.Name = "btnbm";
			this.btnbm.Size = new System.Drawing.Size(23, 23);
			this.btnbm.TabIndex = 1;
			this.btnbm.Text = "-";
			this.btnbm.UseVisualStyleBackColor = true;
			this.btnbm.Visible = false;
			this.btnbm.Click += new System.EventHandler(this.Btnbm_Click);
			// 
			// btnam
			// 
			this.btnam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnam.Location = new System.Drawing.Point(765, 312);
			this.btnam.Name = "btnam";
			this.btnam.Size = new System.Drawing.Size(23, 23);
			this.btnam.TabIndex = 1;
			this.btnam.Text = "-";
			this.btnam.UseVisualStyleBackColor = true;
			this.btnam.Visible = false;
			this.btnam.Click += new System.EventHandler(this.Btnam_Click);
			// 
			// btncp
			// 
			this.btncp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btncp.Location = new System.Drawing.Point(736, 370);
			this.btncp.Name = "btncp";
			this.btncp.Size = new System.Drawing.Size(23, 23);
			this.btncp.TabIndex = 0;
			this.btncp.Text = "+";
			this.btncp.UseVisualStyleBackColor = true;
			this.btncp.Visible = false;
			this.btncp.Click += new System.EventHandler(this.Btncp_Click);
			// 
			// btnbp
			// 
			this.btnbp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnbp.Location = new System.Drawing.Point(736, 341);
			this.btnbp.Name = "btnbp";
			this.btnbp.Size = new System.Drawing.Size(23, 23);
			this.btnbp.TabIndex = 0;
			this.btnbp.Text = "+";
			this.btnbp.UseVisualStyleBackColor = true;
			this.btnbp.Visible = false;
			this.btnbp.Click += new System.EventHandler(this.Btnbp_Click);
			// 
			// btnap
			// 
			this.btnap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnap.Location = new System.Drawing.Point(736, 312);
			this.btnap.Name = "btnap";
			this.btnap.Size = new System.Drawing.Size(23, 23);
			this.btnap.TabIndex = 0;
			this.btnap.Text = "+";
			this.btnap.UseVisualStyleBackColor = true;
			this.btnap.Visible = false;
			this.btnap.Click += new System.EventHandler(this.Btnap_Click);
			// 
			// lbPropReser
			// 
			this.lbPropReser.AutoSize = true;
			this.lbPropReser.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbPropReser.Font = new System.Drawing.Font("Segoe UI Black", 24F);
			this.lbPropReser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
			this.lbPropReser.Location = new System.Drawing.Point(0, 0);
			this.lbPropReser.Name = "lbPropReser";
			this.lbPropReser.Size = new System.Drawing.Size(379, 45);
			this.lbPropReser.TabIndex = 8;
			this.lbPropReser.Text = "Residencias Alquiladas";
			// 
			// FSectores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlSectores);
			this.Controls.Add(this.lbPropReser);
			this.MinimumSize = new System.Drawing.Size(410, 360);
			this.Name = "FSectores";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pnlSectores.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlSectores;
		private System.Windows.Forms.Label lbPropReser;
		private System.Windows.Forms.Button btncp;
		private System.Windows.Forms.Button btnbp;
		private System.Windows.Forms.Button btnap;
		private System.Windows.Forms.Button btncm;
		private System.Windows.Forms.Button btnbm;
		private System.Windows.Forms.Button btnam;
	}
}