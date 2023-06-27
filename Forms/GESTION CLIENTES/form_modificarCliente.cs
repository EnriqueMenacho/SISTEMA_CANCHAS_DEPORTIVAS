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
    public partial class form_modificarCliente : Form
    {
        public form_modificarCliente()
        {
            InitializeComponent();
        }

        private void form_modificarCliente_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_MC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_MC_Click(object sender, EventArgs e)
        { 
            StoredProcuderes Buscar = new StoredProcuderes();
            DataTable datos = Buscar.BuscarClientePorCarnet(txtBuscarCliente_MC.Text);
            if(datos.Rows.Count > 0 )
            {
                txtNombre_MC.Text = datos.Rows[0][2].ToString();
                txtApellido_MC.Text = datos.Rows[0][3].ToString();
                txtCarnet_MC.Text = datos.Rows[0][4].ToString();
                txtEmail_MC.Text = datos.Rows[0][5].ToString();
                txtTelefono_MC.Text = datos.Rows[0][6].ToString();

                txtNombre_MC.Enabled = true;
                txtApellido_MC.Enabled = true;
                txtCarnet_MC.Enabled = true;
                txtEmail_MC.Enabled = true;
                txtTelefono_MC.Enabled = true;
                btnActualizar_MC.Enabled = true;  
            }
            else
            {
                MessageBox.Show("INTENTA NUEVAMENTE");
            }
 

        }

        private void btnActualizar_MC_Click(object sender, EventArgs e)
        {
            StoredProcuderes modificar = new StoredProcuderes();
            if(modificar.modificarCliente(txtNombre_MC.Text, txtApellido_MC.Text, txtCarnet_MC.Text, txtEmail_MC.Text, txtTelefono_MC.Text, txtBuscarCliente_MC.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("INTENTELO NUEVAMENTE");
            }

        }
    }
}
