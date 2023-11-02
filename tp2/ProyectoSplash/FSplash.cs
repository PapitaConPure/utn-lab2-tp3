using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSplash
{
    public partial class FSplash : Form
    {
        private double segundos;
        private double avance;

        public FSplash(double segundos, int fps)
        {
            this.InitializeComponent();

            this.Opacity = 0;
            this.segundos = segundos;
            this.avance = 0;
            this.tmReloj.Interval = Math.Max(5, (int)Math.Round(1000d / fps));
            this.tmReloj.Enabled = true;
            this.tmReloj.Start();
            this.barra.Style = ProgressBarStyle.Blocks;
            //Mantener relación de aspecto
            this.Width = (int)Math.Round(this.Height * 1d * this.BackgroundImage.Width / this.BackgroundImage.Height);
        }

        private void tmReloj_Tick(object sender, EventArgs e)
        {
            this.avance += this.tmReloj.Interval / (1000 * this.segundos);
            if (avance <= 0.75)
            {
                double cargaBarra = 1 - Math.Pow(1 - this.avance / 0.75, 2);
                this.barra.Value = Math.Min((int)(cargaBarra * this.barra.Maximum), this.barra.Maximum);
            }
            else
                this.barra.Value = this.barra.Maximum;

            if (this.avance >= 1)
            {
                this.Opacity = 0;
                this.tmReloj.Stop();
                this.DialogResult = DialogResult.OK;
            }
            else if (this.avance < 0.25)
                this.Opacity = 1 - Math.Pow(1 - avance / 0.25, 2);
            else if (this.avance > 0.75)
                this.Opacity = 1 - Math.Pow((avance - 0.75) / 0.25, 2);
        }

        private void FSplash_Load(object sender, EventArgs e)
        {

        }

        private void FSplash_Load_1(object sender, EventArgs e)
        {

        }
    }
}
