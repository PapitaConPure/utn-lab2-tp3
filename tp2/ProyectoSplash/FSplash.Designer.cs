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
            this.tmReloj.Tick += new System.EventHandler(this.tmReloj_Tick);
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(-4, 374);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(513, 23);
            this.barra.TabIndex = 0;
            // 
            // FSplash
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 398);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSplash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FSplash_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmReloj;
        private BarraBonita barra;
    }
}