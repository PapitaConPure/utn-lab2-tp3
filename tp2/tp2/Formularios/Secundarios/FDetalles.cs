using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerLib;
namespace tp2
{
    public partial class FDetalles : Form
    {
        Sistema sistema;
        Residencia residencia;
        public FDetalles()
        {
            InitializeComponent();
        }
        public FDetalles(Sistema sist, Residencia res)
        {
            InitializeComponent();
            sistema = sist;
            residencia = res;
        }

        private void btnCancelarAlquiler_Click(object sender, EventArgs e)
        {
            string[] renglon = lbDetalles.SelectedItem.ToString().Split(' ');
            Alquiler alq = residencia.VerAlquiler(Convert.ToInt32(renglon[3]));
            if (sistema.CancelarAlquiler(alq.Residencia.Número, alq.Número))
            {
                MessageBox.Show("El alquiler ha sido cancelado");
            }
            else
            {
                MessageBox.Show("El alquiler no se ha podido cancelar");
            }
            this.Close();
        }

        private void btnModificarAlquiler_Click(object sender, EventArgs e)
        {

            Alquiler alq = residencia.VerAlquiler(Convert.ToInt32(nudNROAlquiler.Value));
            FAlquiler nuevo = new FAlquiler(this.sistema,residencia);
            nuevo.gbPropietario.Enabled = false;
            nuevo.nudCantPasajeros.Value = alq.Cliente.CantPasajeros;
            nuevo.nudDNI.Value = alq.Cliente.Dni;
            nuevo.nudTel.Value = alq.Cliente.Teléfono;
            nuevo.tbApellido.Text = alq.Cliente.Apellido;
            nuevo.tbNombre.Text = alq.Cliente.Nombre;
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                sistema.ModificarAlquiler(residencia.Número,alq.Número,nuevo.Calendario.DíaSeleccionado,
                                            nuevo.Calendario.DíaSeleccionado.AddDays(Convert.ToInt32(nuevo.nudCantDias.Value)));
                MessageBox.Show($"Alquiler modificado");
            }
            else
                MessageBox.Show("No se ha podido modificar el alquier");
            nuevo.gbPropietario.Enabled = true;
            nuevo.Dispose();
        }
    }
}
