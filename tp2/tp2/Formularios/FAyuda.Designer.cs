
namespace tp2.Formularios {
	partial class FAyuda {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.btnInicio, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAnterior, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSiguiente, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCerrar, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 46);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInicio.FlatAppearance.BorderSize = 0;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
			this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnInicio.Location = new System.Drawing.Point(4, 5);
			this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(228, 36);
			this.btnInicio.TabIndex = 0;
			this.btnInicio.Text = "▲";
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAnterior.FlatAppearance.BorderSize = 0;
			this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
			this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnAnterior.Location = new System.Drawing.Point(240, 5);
			this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(228, 36);
			this.btnAnterior.TabIndex = 0;
			this.btnAnterior.Text = "◀";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSiguiente.FlatAppearance.BorderSize = 0;
			this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
			this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnSiguiente.Location = new System.Drawing.Point(476, 5);
			this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(228, 36);
			this.btnSiguiente.TabIndex = 0;
			this.btnSiguiente.Text = "▶";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCerrar.FlatAppearance.BorderSize = 0;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Location = new System.Drawing.Point(712, 5);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(228, 36);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			// 
			// webView
			// 
			this.webView.AllowExternalDrop = true;
			this.webView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
			this.webView.CreationProperties = null;
			this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webView.Location = new System.Drawing.Point(0, 46);
			this.webView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.webView.Name = "webView";
			this.webView.Size = new System.Drawing.Size(944, 475);
			this.webView.TabIndex = 0;
			this.webView.ZoomFactor = 1D;
			// 
			// FAyuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(944, 521);
			this.ControlBox = false;
			this.Controls.Add(this.webView);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FAyuda";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ayuda";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView;
		private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnCerrar;
	}
}