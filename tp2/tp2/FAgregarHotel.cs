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
    public partial class FAgregarHotel : Form
    {
        public FAgregarHotel()
        {
            InitializeComponent();
            tbDireccionHotel.Enabled = true;
            nudNroPropiedad.Enabled = true;
            nudEstrellas.Enabled = true;
        }

        
    }
}
