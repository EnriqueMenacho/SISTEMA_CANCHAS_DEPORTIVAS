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
    public partial class form_reportes : Form
    {
        public form_reportes()
        {
            InitializeComponent();
        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cargarTabla()
        {
            StoredProcuderes cargarTabla = new StoredProcuderes();
            cargarTabla.VistaReporte(dgv_Reservas);
        }
        private void form_reportes_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
    }
}
