using Gestion_Alquiler_Canchas.ConeccionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.Forms.GESTION_PREDIOS
{
    public partial class form_agregarPredio : Form
    {
        public form_agregarPredio()
        {
            InitializeComponent();
        }

        public void AgregarPredio()
        {
            double precio = Convert.ToDouble(txtPrecioH_NP.Text);
           StoredProcuderes agregarCancha = new StoredProcuderes();
            if (agregarCancha.AgregarNuevoPredio(
                txtNombre_NP.Text,
                txtUbicacion_NP.Text,
                txtPrecioH_NP.Text,
                txtDescripcion_NP.Text
                ))
            {
                MessageBox.Show("Se ha agregado la nueva Cancha Correctamente");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Por favor revisa los datos e intenta nuevamente");
            }

        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_NC_Click(object sender, EventArgs e)
        {
            AgregarPredio();
        }
    }
}
