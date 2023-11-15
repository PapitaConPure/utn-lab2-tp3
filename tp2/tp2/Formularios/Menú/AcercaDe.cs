using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesForms;

namespace tp2.Formularios
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            this.InitializeComponent();
			new ArrastradorVentana(this);
        }
    }
}
