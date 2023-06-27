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
    public partial class form_clientes : Form
    {
        public string getBuscarPorCarnet()
        {
            return txtBuscarCi.Text;
        }

        public form_clientes()
        {
            InitializeComponent();
        }
        public void CargarTabla()
        {
            StoredProcuderes storedProcuderes = new StoredProcuderes();
            storedProcuderes.CargarTablasClientes_Activos(dataGridView1);
        }
        
        public void actualizar_data()
        {
            txtBuscarCi.Clear();
            this.CargarTabla();

        }

        private void form_clientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            form_menu pantalla = new form_menu();
            pantalla.Show();
        }

        private void btnBuscarCi_Click(object sender, EventArgs e)
        {
            StoredProcuderes Buscar = new StoredProcuderes();
            Buscar.BuscarClientePorCarnet(txtBuscarCi.Text, dataGridView1);

        }

        private void ptbNuevoCliente_Click(object sender, EventArgs e)
        {
            form_nuevoCliente pantalla = new form_nuevoCliente();
            pantalla.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(pantalla_FormClosed);
            pantalla.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
         this.actualizar_data();
        }

        private void ptbModificarCliente_Click(object sender, EventArgs e)
        {
                form_modificarCliente pantalla = new form_modificarCliente();
                pantalla.FormClosed += new
                System.Windows.Forms.FormClosedEventHandler(pantalla_FormClosed);
                pantalla.ShowDialog();
                       
        }
        private void pantalla_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarTabla();

        }

        private void ptbEliminarCliente_Click(object sender, EventArgs e)
        {
            if(txtBuscarCi.Text != "")
            {
                StoredProcuderes eliminar = new StoredProcuderes();
                eliminar.EliminarCliente(txtBuscarCi.Text);
                txtBuscarCi.Clear();
                CargarTabla();
            }
            else
            {
                MessageBox.Show("POR FAVOR PRIMERO BUSQUE EL CLIENTE");
            }
        }
    }
}
