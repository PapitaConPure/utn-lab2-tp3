
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
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
			this.SuspendLayout();
			// 
			// lbDetalles
			// 
			this.lbDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbDetalles.FormattingEnabled = true;
			this.lbDetalles.Location = new System.Drawing.Point(0, 0);
			this.lbDetalles.Name = "lbDetalles";
			this.lbDetalles.Size = new System.Drawing.Size(360, 250);
			this.lbDetalles.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.pbImagen1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbImagen2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 250);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 176);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// pbImagen1
			// 
			this.pbImagen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbImagen1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImagen1.Location = new System.Drawing.Point(3, 3);
			this.pbImagen1.Name = "pbImagen1";
			this.pbImagen1.Size = new System.Drawing.Size(174, 170);
			this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagen1.TabIndex = 0;
			this.pbImagen1.TabStop = false;
			// 
			// pbImagen2
			// 
			this.pbImagen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbImagen2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImagen2.Location = new System.Drawing.Point(183, 3);
			this.pbImagen2.Name = "pbImagen2";
			this.pbImagen2.Size = new System.Drawing.Size(174, 170);
			this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagen2.TabIndex = 0;
			this.pbImagen2.TabStop = false;
			// 
			// FDetalles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 426);
			this.Controls.Add(this.lbDetalles);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FDetalles";
			this.Text = "FDetalles";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbDetalles;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.PictureBox pbImagen1;
		public System.Windows.Forms.PictureBox pbImagen2;
	}
}