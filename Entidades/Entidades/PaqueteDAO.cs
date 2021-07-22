using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PaqueteDAO()
        {
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.stringConexion); //Creado en Propiedades/Configuracion
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }

        //Agrega un paquete en la base de datos.
        public static bool Insertar(Paquete p)
        {
            bool resultado = false;

            PaqueteDAO.comando.CommandText = "INSERT INTO Paquetes values(@direccionEntrega, @trackingID)";
            PaqueteDAO.comando.Parameters.AddWithValue("@direccionEntrega", p.DireccionEntrega);
            PaqueteDAO.comando.Parameters.AddWithValue("@trackingID", p.TrackinID);

            try
            {
                if(PaqueteDAO.conexion.State != System.Data.ConnectionState.Open && PaqueteDAO.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    PaqueteDAO.conexion.Open();
                }

                //corrobora que se afecte una fila para confirmar si se agrego.
                if(PaqueteDAO.comando.ExecuteNonQuery() == 1)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                PaqueteDAO.conexion.Close();
                PaqueteDAO.comando.Parameters.Clear();
            }             
        }

    }
}
