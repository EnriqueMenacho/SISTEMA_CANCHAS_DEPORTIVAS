using Gestion_Alquiler_Canchas.ConeccionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.Forms
{
    public partial class form_nuevaReserva : Form
    {
        private TimeSpan tiempo = TimeSpan.FromMinutes(30);
        public form_nuevaReserva()
        {
            InitializeComponent();
        }

        private void form_nuevaReserva_Load(object sender, EventArgs e)
        {
            CargarComboBox();

            txt_horas.Text = "00:30";
        }

        private void CargarComboBox()
        {
            StoredProcuderes storedProcuderes = new StoredProcuderes();
            storedProcuderes.CargarComboBoxReservas(cb_ElegirCancha);
            storedProcuderes.CargarComboBoxHoras(cb_HoraInicio);
        }

        private void SumarHorasBoton()
        {
            tiempo += TimeSpan.FromMinutes(30);
            TimeSpan tiempoActual = TimeSpan.Parse(txt_horas.Text);
            tiempoActual += tiempo;
            txt_horas.Text = tiempo.ToString(@"hh\:mm");
        }

        private void RestarHorasBoton()
        {
            if (txt_horas.Text != "00:30")
            {
                tiempo -= TimeSpan.FromMinutes(30);
                TimeSpan tiempoActual = TimeSpan.Parse(txt_horas.Text);
                tiempoActual += tiempo;
                txt_horas.Text = tiempo.ToString(@"hh\:mm");
            }
        }

        private void HoraFinal()
        {
            if (cb_HoraInicio.Text != "")
            {
                string horaInicio = cb_HoraInicio.Text;
                string SumaHoras = txt_horas.Text;

                TimeSpan tiempoInicio = TimeSpan.ParseExact(horaInicio, "hh\\:mm\\:ss", null);
                TimeSpan tiempoHoras = TimeSpan.ParseExact(SumaHoras, "hh\\:mm", null);

                TimeSpan Resultado = tiempoInicio + tiempoHoras;
                txt_horaFinal.Text = Resultado.ToString(@"hh\:mm\:ss");
            }

        }

        private void NuevaReserva()
        {
            //formato de fecha
            DateTime ElegirFecha = Cal_FechaParaAlquilar.SelectionRange.Start;
            TimeSpan horaInicio = TimeSpan.ParseExact(cb_HoraInicio.Text, "hh\\:mm\\:ss", null);

            //variables para Procedimiento

            
            string NumeroCarnet = txtNombre_NC.Text;
            string NombreCancha = cb_ElegirCancha.Text;
            string Fecha= ElegirFecha.ToString("yyyy-MM-dd");
            string HoraInicio = horaInicio.ToString(@"hh\:mm\:ss");
            string HoraFin = txt_horaFinal.Text;
            string Observaciones = txt_Observaciones.Text;

            StoredProcuderes NuevaReserva = new StoredProcuderes();
            if (NuevaReserva.NuevaReserva(NumeroCarnet, NombreCancha, Fecha, HoraInicio, HoraFin, Observaciones))
            {
                this.Close();
            }
            
            
        }
        private void btnGuardar_NC_Click(object sender, EventArgs e)
        {
            NuevaReserva();
        }


        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_ElegirCancha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_ElegirCancha_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_SumarHoras_Click(object sender, EventArgs e)
        {
            SumarHorasBoton();

            HoraFinal();
        }

        private void btn_RestarHoras_Click(object sender, EventArgs e)
        {
            RestarHorasBoton();
            HoraFinal();
        }

        private void cb_HoraInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoraFinal();
        }
    }
}
