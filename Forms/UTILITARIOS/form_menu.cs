using Gestion_Alquiler_Canchas.Forms.GESTION_ALQUILER;
using Gestion_Alquiler_Canchas.Forms.UTILITARIOS;
using GYM_ADS;
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
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }
        public void MostrarFormulario(Form formulario) 
        {
            formulario.Show();
            this.Hide();
        }

        public void CerrarSesion()
        {
            if(
                MessageBox.Show("¿Esta seguro que desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK
                )
            {
                List<Form> ventanasACerrar = new List<Form>();

                // Agregar las ventanas a la lista
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name != "form_login") // Evitar cerrar la ventana de inicio de sesión
                        ventanasACerrar.Add(form);
                }

                // Cerrar las ventanas almacenadas en la lista
                foreach (Form form in ventanasACerrar)
                {
                    form.Close();
                }

                form_login login = new form_login();  
                login.Show();
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void pictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

            form_clientes pantalla1 = new form_clientes();
            MostrarFormulario(pantalla1);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            form_AlquileresReservas pantalla2 = new form_AlquileresReservas();
            MostrarFormulario(pantalla2);
        } 
        private void lblCliente_Click(object sender, EventArgs e)
        {
            form_Predios pantalla2 = new form_Predios();
            MostrarFormulario(pantalla2);
        }
         private void pnPredios_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pnPredios_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ptb_NuevoUsusario_MouseHover(object sender, EventArgs e)
        {
            ptb_NuevoUsusario.Size = new Size(150, 160);
        }

        private void ptb_NuevoUsusario_MouseLeave(object sender, EventArgs e)
        {
            ptb_NuevoUsusario.Size = new Size(142, 142);
        }

        private void ptb_NuevoUsusario_Click(object sender, EventArgs e)
        {
            form_nuevoUsuario pantalla = new form_nuevoUsuario();
            pantalla.Show();
        }

        private void ptb_Reportes_MouseHover(object sender, EventArgs e)
        {
            ptb_Reportes.Size = new Size(150, 160);
        }

        private void ptb_Reportes_MouseLeave(object sender, EventArgs e)
        {
            ptb_Reportes.Size = new Size(142, 142);
        }

        private void ptb_Reportes_Click(object sender, EventArgs e)
        {
            form_reportes pantalla = new form_reportes();
            pantalla.Show();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();

        }

        private void ptbConfirmarReserva_MouseHover(object sender, EventArgs e)
        {
            ptbConfirmarReserva.Size = new Size(150, 160);
        }

        private void ptbConfirmarReserva_MouseLeave(object sender, EventArgs e)
        {
            ptbConfirmarReserva.Size = new Size(142, 142);
        }

        private void ptbConfirmarReserva_Click(object sender, EventArgs e)
        {
            form_ConfirmarReservas pantalla = new form_ConfirmarReservas();
            pantalla.Show();
        }
    }
}
