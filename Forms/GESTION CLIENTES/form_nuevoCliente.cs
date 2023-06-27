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

namespace Gestion_Alquiler_Canchas.Forms
{
    public partial class form_nuevoCliente : Form
    {
        public form_nuevoCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_NC_Click(object sender, EventArgs e)
        {
            StoredProcuderes NuevoCliene = new StoredProcuderes();
            if (NuevoCliene.AgregarNuevoCliente(txtNombre_NC.Text, txtApellido_NC.Text, txtCarnet_NC.Text, txtEmail_NC.Text, txtTelefono_NC.Text))
            {
                this.Close();               
            }
            else
            {
                txtNombre_NC.Clear();
                txtApellido_NC.Clear();
                txtCarnet_NC.Clear();
                txtEmail_NC.Clear();
                txtTelefono_NC.Clear();
            }
        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
