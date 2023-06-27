using Gestion_Alquiler_Canchas.ConeccionBD;
using Gestion_Alquiler_Canchas.Forms.GESTION_PREDIOS;
using Microsoft.Win32;
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
    public partial class form_Predios : Form
    {
        string valorCelda = null;
        string valorCeldaNombre = null;

        public form_Predios()
        {
            InitializeComponent();
        }
        
        private void form_Predios_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void ActualizarTabla()
        {
            this.CargarTabla();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valorCelda = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            valorCeldaNombre = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void eliminarPredio()
        {
            StoredProcuderes eliminarPredio = new StoredProcuderes();
            if(valorCelda != null)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar el predio con id: " +  valorCelda +" - "+  valorCeldaNombre + "?",
                    "Eliminar PREDIO",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    eliminarPredio.EliminarPredio(valorCelda);
                    ActualizarTabla();
                    valorCelda = null; valorCeldaNombre = null;
                }
                
            }
            else
            {
                MessageBox.Show("Por favor selecione un Predio en la tabla", 
                    "",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            valorCelda = null; valorCeldaNombre = null;
        }

        public void CargarTabla()
        {
            StoredProcuderes storedProcuderes = new StoredProcuderes();
            storedProcuderes.CargarTablasCanchas_Activos(dataGridView1);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            form_menu pantalla = new form_menu();
            pantalla.Show();
        }

        private void ptbNuevoCliente_Click(object sender, EventArgs e)
        {
            form_agregarPredio pantalla = new form_agregarPredio();
            pantalla.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(pantalla_FormClosed);
            pantalla.ShowDialog();

        }
        private void pantalla_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarTabla();

        }

        private void ptbModificarCliente_Click(object sender, EventArgs e)
        {
            form_modificarPredios pantalla = new form_modificarPredios();
            pantalla.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(pantalla_FormClosed);
            pantalla.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ptbEliminarCliente_Click(object sender, EventArgs e)
        {
            eliminarPredio();
        }


    }
}
