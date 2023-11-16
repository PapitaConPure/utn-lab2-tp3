namespace ProyectoSplash
{
    partial class FSplash
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSplash));
			this.tmReloj = new System.Windows.Forms.Timer(this.components);
			this.barra = new ProyectoSplash.BarraBonita();
			this.SuspendLayout();
			// 
			// tmReloj
			// 
			this.tmReloj.Tick += new System.EventHandler(this.TmReloj_Tick);
			// 
			// barra
			// 
			this.barra.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barra.Location = new System.Drawing.Point(10, 460);
			this.barra.Maximum = 1000;
			this.barra.Name = "barra";
			this.barra.Size = new System.Drawing.Size(281, 7);
			this.barra.TabIndex = 0;
			// 
			// FSplash
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(301, 477);
			this.Controls.Add(this.barra);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FSplash";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmReloj;
        private BarraBonita barra;
    }
}