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
    public partial class FBarras : Form
    {
        Sistema unSistema;
        int c2, c3, c4, c5, c6;
        public FBarras()
        {
            InitializeComponent();
        }
        public FBarras(Sistema sis)
        {
            InitializeComponent();
            unSistema = sis;
            this.Text = "Cantidad de pasajeros";
            foreach(Residencia r in unSistema.Residencias)
            {
                foreach(Alquiler a in r.Alquileres)
                {
                    switch (a.Cliente.CantPasajeros)
                    {
                        case 1:
                            unSistema.CantDos++;
                            break;
                        case 2:
                            unSistema.CantDos++;
                            break;
                        case 3:
                            unSistema.CantTres++;
                            break;
                        case 4:
                            unSistema.CantCuatro++;
                            break;
                        case 5:
                            unSistema.CantCinco++;
                            break;
                        case 6:
                            unSistema.CantSeis++;
                            break;
                        default:
                            unSistema.CantSeis++;
                            break;
                    }
                }
            }
            c2 = unSistema.CantDos;
            c3 = unSistema.CantTres++;
            c4 = unSistema.CantCuatro++;
            c5 = unSistema.CantCinco++;
            c6 = unSistema.CantSeis++;
        }
        
        //Arreglar
        private void FBarras_Paint(object sender, PaintEventArgs e)
        {
            Brush d = new SolidBrush(Color.Black);
            Brush t = new SolidBrush(Color.Green);
            Brush cu = new SolidBrush(Color.Yellow);
            Brush ci = new SolidBrush(Color.Blue);
            Brush s = new SolidBrush(Color.Red);

            int x = (int)Math.Truncate(this.Width * 0.25);
            int y = (int)Math.Truncate(this.Height * 0.1);
            int w = this.Width / 7;
            int h = (int)Math.Truncate(this.Height * 0.25);
            Rectangle dos = new Rectangle(x, y, 15, h);
            e.Graphics.FillRectangle(d,dos);
            h -= 20;
            Rectangle tres = new Rectangle(x += w, h, 15, y);
            e.Graphics.FillRectangle(t, tres);
            h -= 20;
            Rectangle cuatro = new Rectangle(x +=w, h, 15, y);
            e.Graphics.FillRectangle(cu, cuatro);
            h -= 20;
            Rectangle cinco = new Rectangle(x += w, h, 15, y);
            e.Graphics.FillRectangle(ci, cinco);
            h -= 20;
            Rectangle seis = new Rectangle(x += w, h, 15, y);
            e.Graphics.FillRectangle(s, seis);
        }
    }
}
