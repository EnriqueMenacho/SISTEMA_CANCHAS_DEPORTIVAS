using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.ConeccionBD
{
    public class ConexionBD
    {
        //1.- cadena de conexión
        string cadena = "Data Source=PC-KIKE;Initial Catalog=Alquiler_Canchas;Integrated Security=True;";

        public static SqlConnection conectarBd = new SqlConnection();

        public ConexionBD()
        {
            conectarBd.ConnectionString = cadena;
        }

        public SqlConnection abrirBd()
        {
            if (conectarBd.State == ConnectionState.Closed)
            {
                conectarBd.Open();
            }
            
            return conectarBd;
        }
        public SqlConnection cerrarBD()
        {
            if (conectarBd.State == ConnectionState.Open)
            {
                conectarBd.Close();
            }
            return conectarBd;


        }
    }
}
