using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2
{
    public partial class FAgregarCasa : Form
    {
        public FAgregarCasa()
        {
            InitializeComponent();
        }

        private void rbCasa_CheckedChanged(object sender, EventArgs e)
        {
            nudMinDias.Enabled = true;
        }

        private void rbCasaFinde_CheckedChanged(object sender, EventArgs e)
        {
            nudMinDias.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
