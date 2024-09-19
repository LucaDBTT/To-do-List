using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class AccesoDatos : IDisposable
    {
        public SqlConnection Conexion;
        public SqlCommand Comando;
        public SqlDataReader Lector;

        public SqlDataReader lector
        {
            get { return Lector; }
        }

        public AccesoDatos()
        {

            Conexion = new SqlConnection("server=DESKTOP-LRPR1H0; database=Base_Comercio_2024; integrated security=true; Max Pool Size=100;");
            Comando = new SqlCommand();

        }

        public void setearParametros(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }

        public void SetearProcedimiento(string sp)
        {
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText = sp;
        }

        public void SetearQuery(string Query)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Query;
        }

        public void CerrarConexion()
        {
            if (Lector != null)
            {
                Lector.Close();
            }
            if (Conexion != null && Conexion.State != ConnectionState.Closed)
            {
                Conexion.Close();
            }
        }

        public void ejecutarAccion()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public object ejecutarScalar()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                return Comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }


        public void Dispose()
        {
            // Implementa la interfaz IDisposable para cerrar la conexión y liberar recursos
            CerrarConexion();
        }
        public void LimpiarParametros()
        {
            if (Comando != null)
            {
                Comando.Parameters.Clear();
            }
        }

        public void EjecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}

