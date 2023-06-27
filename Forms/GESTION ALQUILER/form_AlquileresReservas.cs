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
    public partial class form_AlquileresReservas : Form
    {
        public form_AlquileresReservas()
        {
            InitializeComponent();
        }

        private void form_AlquileresReservas_Load(object sender, EventArgs e)
        {
            CargarTablaReservas_Activas();
        }

        public void CargarTablaReservas_Activas()
        {
            StoredProcuderes storedProcuderes = new StoredProcuderes();
            storedProcuderes.CargarTablasReservas_Activos(dgv_Reservas);
        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            form_menu pantalla = new form_menu();
            pantalla.Show();
        }

        private void pnl_NuevaReserva_Click(object sender, EventArgs e)
        {
            form_nuevaReserva pantalla = new form_nuevaReserva();
            pantalla.FormClosed += new
                System.Windows.Forms.FormClosedEventHandler(form_AlquileresReservas_FormClosed);
            pantalla.ShowDialog();
        }

        private void form_AlquileresReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarTablaReservas_Activas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscarCi.Clear();
            this.CargarTablaReservas_Activas();
        }

        private void btnBuscarCi_Click(object sender, EventArgs e)
        {
            StoredProcuderes BuscarReservaCarnet = new StoredProcuderes();
            BuscarReservaCarnet.BuscarReservaCarnet(txtBuscarCi.Text,dgv_Reservas);
        }

        private void dgv_Reservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
