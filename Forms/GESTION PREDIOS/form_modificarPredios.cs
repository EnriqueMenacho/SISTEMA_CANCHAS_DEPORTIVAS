using Gestion_Alquiler_Canchas.ConeccionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.Forms.GESTION_PREDIOS
{
    public partial class form_modificarPredios : Form
    {
        public form_modificarPredios()
        {
            InitializeComponent();
        }

        public void modificarPredio()
        {
            decimal precio = decimal.Parse(txtPrecioH_NP.Text);
            StoredProcuderes modificar = new StoredProcuderes();
            if (modificar.ModificarPredio(
                txtBuscarPredio_MP.Text,
                txtNombre_NP.Text, 
                txtUbicacion_NP.Text, 
                precio, 
                txtDescripcion_NP.Text
                ))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("INTENTELO NUEVAMENTE");
                txtBuscarPredio_MP.Clear();
                txtNombre_NP.Clear();
                txtUbicacion_NP.Clear();
                txtPrecioH_NP.Clear();
                txtDescripcion_NP.Clear();
            }
        }

        private void btnCancelar_MC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_MC_Click(object sender, EventArgs e)
        {
            modificarPredio();
        }

        private void btnBuscarCliente_MC_Click(object sender, EventArgs e)
        {
            StoredProcuderes Buscar = new StoredProcuderes();
            DataTable datos = Buscar.BuscarPredioPorID(txtBuscarPredio_MP.Text);
            if (datos.Rows.Count > 0)
            {
                txtNombre_NP.Text = datos.Rows[0][1].ToString();
                txtUbicacion_NP.Text = datos.Rows[0][2].ToString();
                txtPrecioH_NP.Text = datos.Rows[0][3].ToString();
                txtDescripcion_NP.Text = datos.Rows[0][4].ToString();

                txtNombre_NP.Enabled = true;
                txtUbicacion_NP.Enabled = true;
                txtPrecioH_NP.Enabled = true;
                txtDescripcion_NP.Enabled = true;
                btnActualizar_MC.Enabled = true;
            }
            else
            {
                MessageBox.Show("INTENTA NUEVAMENTE");
            }
        }
    }
}
