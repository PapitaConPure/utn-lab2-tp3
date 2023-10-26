
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
            this.SuspendLayout();
            // 
            // lbDetalles
            // 
            this.lbDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDetalles.FormattingEnabled = true;
            this.lbDetalles.Location = new System.Drawing.Point(0, 0);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.Size = new System.Drawing.Size(355, 491);
            this.lbDetalles.TabIndex = 0;
            // 
            // FDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 491);
            this.Controls.Add(this.lbDetalles);
            this.Name = "FDetalles";
            this.Text = "FDetalles";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbDetalles;
    }
}