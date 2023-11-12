namespace tp2.Formularios
{
    partial class AcercaDe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 2);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(855, 411);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(4, 5);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new System.Drawing.Size(425, 401);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(441, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 26);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(410, 26);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "Id del producto: 1010";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new System.Drawing.Point(441, 41);
			this.labelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.labelVersion.MaximumSize = new System.Drawing.Size(0, 26);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(410, 26);
			this.labelVersion.TabIndex = 0;
			this.labelVersion.Text = "Versión: 1.0.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
			this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
			this.textBoxDescription.Location = new System.Drawing.Point(441, 169);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(8, 5, 4, 5);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new System.Drawing.Size(410, 195);
			this.textBoxDescription.TabIndex = 23;
			this.textBoxDescription.TabStop = false;
			this.textBoxDescription.Text = "Contiene software de seguridad con licencia RSA Data Security Inc.\r\n\r\nFecha de en" +
    "trega: 16/11/2023\r\n\r\nCátedra: Laboratorio de Computación II\r\n\r\nDesarrolladores:\r" +
    "\nFranky\r\nKorea\r\nPapita";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 2;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.okButton.Location = new System.Drawing.Point(727, 374);
			this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(124, 32);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&Cerrar";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// labelCopyright
			// 
			this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new System.Drawing.Point(441, 123);
			this.labelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 26);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(410, 26);
			this.labelCopyright.TabIndex = 21;
			this.labelCopyright.Text = "© 2023 Royal Alquiler. Todos los derechos reservados.";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCompanyName.Location = new System.Drawing.Point(441, 82);
			this.labelCompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
			this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 26);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(410, 26);
			this.labelCompanyName.TabIndex = 22;
			this.labelCompanyName.Text = "Por: Royal Alquiler";
			this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AcercaDe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(879, 435);
			this.Controls.Add(this.tableLayoutPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AcercaDe";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acerca de...";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
    }
}