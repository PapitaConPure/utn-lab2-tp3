
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
            this.pnlTest = new System.Windows.Forms.Panel();
            this.tlpControlPropiedadesTest = new System.Windows.Forms.TableLayoutPanel();
            this.lblHotel = new System.Windows.Forms.Label();
            this.btnAgregarCasa = new System.Windows.Forms.Button();
            this.lblCasaFinde = new System.Windows.Forms.Label();
            this.btnQuitarHotel = new System.Windows.Forms.Button();
            this.lblCasa = new System.Windows.Forms.Label();
            this.btnAgregarCasaFinde = new System.Windows.Forms.Button();
            this.btnQuitarCasaFinde = new System.Windows.Forms.Button();
            this.btnAgregarHotel = new System.Windows.Forms.Button();
            this.btnQuitarCasa = new System.Windows.Forms.Button();
            this.lbPropReser = new System.Windows.Forms.Label();
            this.pnlSectores.SuspendLayout();
            this.pnlTest.SuspendLayout();
            this.tlpControlPropiedadesTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSectores
            // 
            this.pnlSectores.Controls.Add(this.pnlTest);
            this.pnlSectores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSectores.Location = new System.Drawing.Point(0, 45);
            this.pnlSectores.Name = "pnlSectores";
            this.pnlSectores.Size = new System.Drawing.Size(800, 405);
            this.pnlSectores.TabIndex = 0;
            this.pnlSectores.BackColorChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
            this.pnlSectores.SizeChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
            this.pnlSectores.VisibleChanged += new System.EventHandler(this.PnlSectores_SizeChanged);
            this.pnlSectores.Paint += new System.Windows.Forms.PaintEventHandler(this.FSectores_Paint);
            // 
            // pnlTest
            // 
            this.pnlTest.AutoSize = true;
            this.pnlTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTest.Controls.Add(this.tlpControlPropiedadesTest);
            this.pnlTest.Location = new System.Drawing.Point(599, 266);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTest.Size = new System.Drawing.Size(189, 127);
            this.pnlTest.TabIndex = 1;
            this.pnlTest.Visible = false;
            // 
            // tlpControlPropiedadesTest
            // 
            this.tlpControlPropiedadesTest.AutoSize = true;
            this.tlpControlPropiedadesTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpControlPropiedadesTest.ColumnCount = 3;
            this.tlpControlPropiedadesTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlPropiedadesTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControlPropiedadesTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControlPropiedadesTest.Controls.Add(this.lblHotel, 0, 2);
            this.tlpControlPropiedadesTest.Controls.Add(this.btnAgregarCasa, 1, 0);
            this.tlpControlPropiedadesTest.Controls.Add(this.lblCasaFinde, 0, 1);
            this.tlpControlPropiedadesTest.Controls.Add(this.btnQuitarHotel, 2, 2);
            this.tlpControlPropiedadesTest.Controls.Add(this.lblCasa, 0, 0);
            this.tlpControlPropiedadesTest.Controls.Add(this.btnAgregarCasaFinde, 1, 1);
            this.tlpControlPropiedadesTest.Controls.Add(this.btnQuitarCasaFinde, 2, 1);
            this.tlpControlPropiedadesTest.Controls.Add(this.btnAgregarHotel, 1, 2);
            this.tlpControlPropiedadesTest.Controls.Add(this.btnQuitarCasa, 2, 0);
            this.tlpControlPropiedadesTest.Location = new System.Drawing.Point(26, 13);
            this.tlpControlPropiedadesTest.Name = "tlpControlPropiedadesTest";
            this.tlpControlPropiedadesTest.RowCount = 3;
            this.tlpControlPropiedadesTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControlPropiedadesTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControlPropiedadesTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControlPropiedadesTest.Size = new System.Drawing.Size(148, 99);
            this.tlpControlPropiedadesTest.TabIndex = 0;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHotel.Location = new System.Drawing.Point(3, 73);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 6);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(46, 20);
            this.lblHotel.TabIndex = 0;
            this.lblHotel.Text = "Hotel";
            // 
            // btnAgregarCasa
            // 
            this.btnAgregarCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(185)))), ((int)(((byte)(86)))));
            this.btnAgregarCasa.FlatAppearance.BorderSize = 0;
            this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAgregarCasa.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCasa.Location = new System.Drawing.Point(85, 3);
            this.btnAgregarCasa.Name = "btnAgregarCasa";
            this.btnAgregarCasa.Size = new System.Drawing.Size(27, 27);
            this.btnAgregarCasa.TabIndex = 0;
            this.btnAgregarCasa.Text = "+";
            this.btnAgregarCasa.UseVisualStyleBackColor = false;
            this.btnAgregarCasa.Click += new System.EventHandler(this.Btnap_Click);
            // 
            // lblCasaFinde
            // 
            this.lblCasaFinde.AutoSize = true;
            this.lblCasaFinde.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCasaFinde.Location = new System.Drawing.Point(3, 40);
            this.lblCasaFinde.Margin = new System.Windows.Forms.Padding(3, 7, 3, 6);
            this.lblCasaFinde.Name = "lblCasaFinde";
            this.lblCasaFinde.Size = new System.Drawing.Size(76, 20);
            this.lblCasaFinde.TabIndex = 0;
            this.lblCasaFinde.Text = "CasaFinde";
            // 
            // btnQuitarHotel
            // 
            this.btnQuitarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnQuitarHotel.FlatAppearance.BorderSize = 0;
            this.btnQuitarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarHotel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnQuitarHotel.ForeColor = System.Drawing.Color.White;
            this.btnQuitarHotel.Location = new System.Drawing.Point(118, 69);
            this.btnQuitarHotel.Name = "btnQuitarHotel";
            this.btnQuitarHotel.Size = new System.Drawing.Size(27, 27);
            this.btnQuitarHotel.TabIndex = 1;
            this.btnQuitarHotel.Text = "-";
            this.btnQuitarHotel.UseVisualStyleBackColor = false;
            this.btnQuitarHotel.Click += new System.EventHandler(this.Btncm_Click);
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCasa.Location = new System.Drawing.Point(3, 7);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(3, 7, 3, 6);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(40, 20);
            this.lblCasa.TabIndex = 0;
            this.lblCasa.Text = "Casa";
            // 
            // btnAgregarCasaFinde
            // 
            this.btnAgregarCasaFinde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(185)))), ((int)(((byte)(86)))));
            this.btnAgregarCasaFinde.FlatAppearance.BorderSize = 0;
            this.btnAgregarCasaFinde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCasaFinde.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAgregarCasaFinde.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCasaFinde.Location = new System.Drawing.Point(85, 36);
            this.btnAgregarCasaFinde.Name = "btnAgregarCasaFinde";
            this.btnAgregarCasaFinde.Size = new System.Drawing.Size(27, 27);
            this.btnAgregarCasaFinde.TabIndex = 0;
            this.btnAgregarCasaFinde.Text = "+";
            this.btnAgregarCasaFinde.UseVisualStyleBackColor = false;
            this.btnAgregarCasaFinde.Click += new System.EventHandler(this.Btnbp_Click);
            // 
            // btnQuitarCasaFinde
            // 
            this.btnQuitarCasaFinde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnQuitarCasaFinde.FlatAppearance.BorderSize = 0;
            this.btnQuitarCasaFinde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCasaFinde.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnQuitarCasaFinde.ForeColor = System.Drawing.Color.White;
            this.btnQuitarCasaFinde.Location = new System.Drawing.Point(118, 36);
            this.btnQuitarCasaFinde.Name = "btnQuitarCasaFinde";
            this.btnQuitarCasaFinde.Size = new System.Drawing.Size(27, 27);
            this.btnQuitarCasaFinde.TabIndex = 1;
            this.btnQuitarCasaFinde.Text = "-";
            this.btnQuitarCasaFinde.UseVisualStyleBackColor = false;
            this.btnQuitarCasaFinde.Click += new System.EventHandler(this.Btnbm_Click);
            // 
            // btnAgregarHotel
            // 
            this.btnAgregarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(185)))), ((int)(((byte)(86)))));
            this.btnAgregarHotel.FlatAppearance.BorderSize = 0;
            this.btnAgregarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHotel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAgregarHotel.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHotel.Location = new System.Drawing.Point(85, 69);
            this.btnAgregarHotel.Name = "btnAgregarHotel";
            this.btnAgregarHotel.Size = new System.Drawing.Size(27, 27);
            this.btnAgregarHotel.TabIndex = 0;
            this.btnAgregarHotel.Text = "+";
            this.btnAgregarHotel.UseVisualStyleBackColor = false;
            this.btnAgregarHotel.Click += new System.EventHandler(this.Btncp_Click);
            // 
            // btnQuitarCasa
            // 
            this.btnQuitarCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnQuitarCasa.FlatAppearance.BorderSize = 0;
            this.btnQuitarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnQuitarCasa.ForeColor = System.Drawing.Color.White;
            this.btnQuitarCasa.Location = new System.Drawing.Point(118, 3);
            this.btnQuitarCasa.Name = "btnQuitarCasa";
            this.btnQuitarCasa.Size = new System.Drawing.Size(27, 27);
            this.btnQuitarCasa.TabIndex = 1;
            this.btnQuitarCasa.Text = "-";
            this.btnQuitarCasa.UseVisualStyleBackColor = false;
            this.btnQuitarCasa.Click += new System.EventHandler(this.Btnam_Click);
            // 
            // lbPropReser
            // 
            this.lbPropReser.AutoSize = true;
            this.lbPropReser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPropReser.Font = new System.Drawing.Font("Segoe UI Black", 24F);
            this.lbPropReser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(123)))));
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSectores);
            this.Controls.Add(this.lbPropReser);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.MinimumSize = new System.Drawing.Size(410, 360);
            this.Name = "FSectores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSectores.ResumeLayout(false);
            this.pnlSectores.PerformLayout();
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            this.tlpControlPropiedadesTest.ResumeLayout(false);
            this.tlpControlPropiedadesTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlSectores;
		private System.Windows.Forms.Label lbPropReser;
		private System.Windows.Forms.Button btnAgregarHotel;
		private System.Windows.Forms.Button btnAgregarCasaFinde;
		private System.Windows.Forms.Button btnAgregarCasa;
		private System.Windows.Forms.Button btnQuitarHotel;
		private System.Windows.Forms.Button btnQuitarCasaFinde;
		private System.Windows.Forms.Button btnQuitarCasa;
		private System.Windows.Forms.Label lblCasa;
		private System.Windows.Forms.TableLayoutPanel tlpControlPropiedadesTest;
		private System.Windows.Forms.Label lblHotel;
		private System.Windows.Forms.Label lblCasaFinde;
		private System.Windows.Forms.Panel pnlTest;
	}
}