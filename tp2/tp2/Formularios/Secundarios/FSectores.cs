using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp2.Formularios;
using AlquilerLib;

namespace tp2.Formularios.Secundarios
{
    public partial class FSectores : Form
    {
        Sistema unSistema;
        public FSectores()
        {
            InitializeComponent();
        }
        public FSectores(Sistema sis)
        {
            InitializeComponent();
            unSistema = sis;
            this.Text = "Cantidad de Reservas";
            lbHoteles.Text = "Hoteles: " + sis.CantHoteles;
            lbCasas.Text = "Casas: " + sis.CantCasas;
        }

        private void FSectores_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = (int)Math.Truncate(this.Width * 0.2);
            int y = (int)Math.Truncate(this.Height * 0.2);
            int h = (int)Math.Truncate(this.Height * 0.65);
            int w = (int)Math.Truncate(this.Width * 0.55);
            Rectangle rectangulo = new Rectangle(x, y, w, h);
            Brush azul = new SolidBrush(Color.DarkCyan);
            Brush rojo = new SolidBrush(Color.DarkRed);
            float total = unSistema.CantCasas + unSistema.CantHoteles;
            float angulo = unSistema.CantHoteles / total * 360;
            if (unSistema.CantHoteles == 0 && unSistema.CantCasas == 0)
                g.FillPie(new SolidBrush(Color.Gray), rectangulo, 0, 360);
            else
            {
                g.FillPie(azul, rectangulo, 0, angulo); //Hoteles
                g.FillPie(rojo, rectangulo, angulo, 360 - angulo); //Casas
            }
            
        } 
    }
}
