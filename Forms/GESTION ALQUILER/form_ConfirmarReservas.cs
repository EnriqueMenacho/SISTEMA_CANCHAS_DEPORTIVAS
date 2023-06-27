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

namespace Gestion_Alquiler_Canchas.Forms.GESTION_ALQUILER
{
    public partial class form_ConfirmarReservas : Form
    {
        string valorCelda, 
            canchaReserva, 
            nombreReserva,
            apellidoReserva,
            fechaReserva, 
            HoraInicio,
            Horafin = null;
        

        public form_ConfirmarReservas()
        {
            InitializeComponent();
        }

        private void form_ConfirmarReservas_Load(object sender, EventArgs e)
        {
            CargarTablaReservas_Activas();
        }

        public void CargarTablaReservas_Activas()
        {
            StoredProcuderes storedProcuderes = new StoredProcuderes();
            storedProcuderes.CargarTablasReservas_Activos(dgv_Reservas);
        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscarCi.Clear();
            this.CargarTablaReservas_Activas();
        }

        private void btnBuscarCi_Click(object sender, EventArgs e)
        {
            StoredProcuderes BuscarReservaCarnet = new StoredProcuderes();
            BuscarReservaCarnet.BuscarReservaCarnet(txtBuscarCi.Text, dgv_Reservas);
        }

        private void dgv_Reservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valorCelda = dgv_Reservas.Rows[e.RowIndex].Cells[0].Value.ToString();
            canchaReserva= dgv_Reservas.Rows[e.RowIndex].Cells[3].Value.ToString();
            nombreReserva = dgv_Reservas.Rows[e.RowIndex].Cells[1].Value.ToString();
            apellidoReserva = dgv_Reservas.Rows[e.RowIndex].Cells[2].Value.ToString();
            fechaReserva = dgv_Reservas.Rows[e.RowIndex].Cells[4].Value.ToString();
            HoraInicio = dgv_Reservas.Rows[e.RowIndex].Cells[5].Value.ToString();
            Horafin = dgv_Reservas.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            StoredProcuderes ConfirmarReserva = new StoredProcuderes();
            if (valorCelda != null)
            {
                if (MessageBox.Show("¿Esta seguro que desea CONFIRMAR la reserva \n " +
                    "N°: " + valorCelda + 
                    "\n CLIENTE: "+nombreReserva +" "+apellidoReserva+
                    "\n PREDIO: "+canchaReserva+
                    "\n FECHA: "+fechaReserva+
                    "\n HORA DE INICIO: "+ HoraInicio+
                    "\n HORA FINAL: "+ Horafin + "?",
                    
                    "CONFIRMAR RESERVA",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ConfirmarReserva.ConfirmarReserva(valorCelda);
                    CargarTablaReservas_Activas();
                    valorCelda = null;
                    canchaReserva = null;
                    nombreReserva = null;
                    apellidoReserva = null;
                    fechaReserva = null;
                    HoraInicio = null;
                    Horafin = null;
                }

            }
            else
            {
                MessageBox.Show("Por favor selecione una RESERVA en la tabla",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            valorCelda = null;
            canchaReserva = null;
            nombreReserva = null;
            apellidoReserva = null;
            fechaReserva = null;
            HoraInicio = null;
            Horafin = null;
        }
    }
}
