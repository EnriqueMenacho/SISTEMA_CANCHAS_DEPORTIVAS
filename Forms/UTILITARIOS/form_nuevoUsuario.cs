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

namespace Gestion_Alquiler_Canchas.Forms.UTILITARIOS
{
    public partial class form_nuevoUsuario : Form
    {
        public form_nuevoUsuario()
        {
            InitializeComponent();
        }

        public void crearnuevoUsuario(string usuario, string contrasena)
        {
            StoredProcuderes NuevoUsuario = new StoredProcuderes(); 
            NuevoUsuario.CrearNuevoUsuario(usuario, contrasena);
        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_NC_Click(object sender, EventArgs e)
        {

            if(txtNuevaContrasena_NC.Text == txtRepetirContrasena_NC.Text){
                crearnuevoUsuario(txtNuevoUsuario_NC.Text, txtNuevaContrasena_NC.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN");
                txtRepetirContrasena_NC.Clear();
            }
        }
    }
}
