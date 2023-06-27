using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.CodeDom;

namespace Gestion_Alquiler_Canchas.ConeccionBD
{
    public class StoredProcuderes
    {
        ConexionBD conexion = new ConexionBD();
        SqlCommand comandoQuery = new SqlCommand();
        
        //APARTADO LOGIN

        public bool SP_ValidadLogin(string usuario, string contraseña)
        {

           
            using (SqlCommand command = new SqlCommand("ValidarLogin", conexion.abrirBd()))
            {
                try
                {
                    // Especificar que el comando es un procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros de entrada
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contraseña);

                    String mensaje =(string)command.ExecuteScalar();

                    MessageBox.Show(mensaje,"",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (mensaje == "Login exitoso")
                        return true;
                    else
                        return false;
                                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error con la base de datos: /n" + ex);
                     throw;
                }
                finally
                {
                    conexion.cerrarBD();
                }
                

            }

           

        }
        

        //APARTADO CLIENTES
        public void CargarTablasClientes_Activos(DataGridView data)
        {
            using (SqlCommand command = new SqlCommand("CargarTablaCliente_Activos", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    data.DataSource = tabla;

                    data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    data.Columns[1].HeaderText = "Tipo de Cliente";
                    data.Columns[5].MinimumWidth = 220;
                    data.Columns[3].MinimumWidth = 170;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public void BuscarClientePorCarnet(string carnet , DataGridView dataGrid)
        {
            using (SqlCommand command = new SqlCommand("BuscarClientePorCarnet", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                        command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@carnet", carnet);

                    resultado = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(resultado);
                    dataGrid.DataSource = table;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
              
            }
        }
        //sobrecarga
        public DataTable BuscarClientePorCarnet(string carnet)
        {
            using (SqlCommand command = new SqlCommand("BuscarClientePorCarnet", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@carnet", carnet);

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    return tabla;
                    
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                    return null;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public bool AgregarNuevoCliente(string nombre, string apellido, string carnet, string email, string telefono)
        {
            using (SqlCommand command = new SqlCommand("AgregarNuevoCliente", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType=CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nombre",nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@telefono", telefono);

                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "NUEVO USUARIO GUARDADO EXITOSAMENTE")
                        return true;
                    else
                        return false;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }            
            
        }
        public bool modificarCliente(string nombre, string apellido, string carnet, string email, string telefono, string buscar)
        {
            using (SqlCommand command = new SqlCommand("ModificarCliente", conexion.abrirBd()))
            {
                try {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@carnet", carnet);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@buscar", buscar);

                String mensaje = (string)command.ExecuteScalar();

                MessageBox.Show(mensaje);

                if (mensaje == "CLIENTE ACTUALIZADO CORRECTAMENTE")
                    return true;
                else
                    return false;


            }
                catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex);
                throw ex;
            }
            finally
            {
                conexion.cerrarBD();
            }

            }
        }
        public bool EliminarCliente (string carnet)
        {
            using (SqlCommand command = new SqlCommand("EliminarCliente", conexion.abrirBd()))
            {
                try
                {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("carnet", carnet);

                        String mensaje = (string)command.ExecuteScalar();

                        MessageBox.Show(mensaje);

                        if (mensaje == "CLIENTE ELIMINADO CORRECTAMENTE")
                            return true;
                        else
                            return false;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERROR VUELVA A INTERLO" + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
            
        }

        //APARTADO PREDIOS 

        public void CargarTablasCanchas_Activos(DataGridView data)
        {
            using (SqlCommand command = new SqlCommand("CargarTablaCanchas_Activos", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    data.DataSource = tabla;

                    data.Columns[3].HeaderText = "Precio Hora";
                    data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    data.Columns[2].MinimumWidth =200;
                    data.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public bool AgregarNuevoPredio(string nombre, string ubicacion, string precio, string descripcion)
        {
            using (SqlCommand command = new SqlCommand("InsertarCancha", conexion.abrirBd()))
            {
                try
                {
                
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Ubicacion", ubicacion);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Descripcion",descripcion);

                String mensaje = (string)command.ExecuteScalar();


                if (mensaje == "Acceso insertado correctamente")
                    return true;
                else
                    return false;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error" + ex);
                    return false;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public bool ModificarPredio(string id, string nombre, string ubicacion, decimal precio, string descripcion)
        {
            using (SqlCommand command = new SqlCommand("ModificarPredio", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Ubicacion", ubicacion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);


                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "PREDIO ACTUALIZADO CORRECTAMENTE")
                        return true;
                    else
                        return false;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }

            }
        }

        public DataTable BuscarPredioPorID(string id)
        {
            using (SqlCommand command = new SqlCommand("BuscarPredioPorID", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    return tabla;


                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                    return null;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }


        public bool EliminarPredio(string id)
        {
            using(SqlCommand command = new SqlCommand("EliminarPredio", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);

                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "PREDIO ELIMINADO CORRECTAMENTE")
                        return true;
                    else
                        return false;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        //APARTADO RESERVAS
        public void CargarTablasReservas_Activos(DataGridView data)
        {
            using (SqlCommand command = new SqlCommand("CargarTablaReservas_Activas", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    data.DataSource = tabla;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public void BuscarReservaCarnet(string carnet, DataGridView data)
        {
            using (SqlCommand command = new SqlCommand("BuscarReservaCarnet", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@carnet", carnet);

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    data.DataSource = tabla;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public class Cancha
        {
            public string Nombre { get; set; }
        }

        public void CargarComboBoxReservas(ComboBox comboBox)
        {
           using (SqlCommand command = new SqlCommand("ObtenerNombreCancha", conexion.abrirBd()))
            {
                SqlDataReader Resultados;
                try
                {
                    Resultados = command.ExecuteReader();
                    while (Resultados.Read())
                    {
                        
                        Cancha cancha = new Cancha();
                        cancha.Nombre = Resultados["Nombre"].ToString();
                        comboBox.Items.Add(cancha.Nombre);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }


        public class Horas
        {
            public string Hora { get; set; }
        }
        public void CargarComboBoxHoras(ComboBox comboBox)
        {
            using (SqlCommand command = new SqlCommand("ObtenerHorasReserva", conexion.abrirBd()))
            {
                SqlDataReader Resultados;
                try
                {
                    Resultados = command.ExecuteReader();
                    while (Resultados.Read())
                    {

                        Horas tiempo = new Horas();
                        tiempo.Hora = Resultados["Hora"].ToString();
                        comboBox.Items.Add(tiempo.Hora);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public bool NuevaReserva(string NumeroCarnet,String nombreCancha, 
            string fecha, string horaInicio, string horaFin, string observaciones)
        {
            using (SqlCommand command = new SqlCommand("GuardarReserva", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CarnetCliente", NumeroCarnet);
                    command.Parameters.AddWithValue("@CanchaNombre", nombreCancha);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@HoraInicio", horaInicio);
                    command.Parameters.AddWithValue("@HoraFin", horaFin);
                    command.Parameters.AddWithValue("@Observaciones", observaciones);

                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "RESERVA CREADA CORRECTAMENTE")
                        return true;
                    else
                        return false;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }

            }
        }

        public bool ConfirmarReserva(string id)
        {
            using (SqlCommand command = new SqlCommand("ConfirmarReserva", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);

                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "CLIENTE ELIMINADO CORRECTAMENTE")
                        return true;
                    else
                        return false;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("RESERVA CONFIRMADA CORRECTAMENTE" + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }

        }

        //PROCEDIMIENTO CREAR NUEVO USUARIO 
        public bool CrearNuevoUsuario (string usuario, string contrasena)
        {
            using (SqlCommand command = new SqlCommand("InsertarNuevoUsuario", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Usuario", usuario);
                    command.Parameters.AddWithValue("Contrasena", contrasena);
                    
                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "Acceso insertado correctamente")
                        return true;
                    else
                        return false;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public void VistaReporte(DataGridView data)
        {
            using(SqlCommand command = new SqlCommand("VistaReporte", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                command.CommandType = CommandType.StoredProcedure;

                resultado = command.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(resultado);
                data.DataSource = tabla;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error en la base de datos: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }
    }

}

