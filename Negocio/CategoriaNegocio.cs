using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> Lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT Id, NombreCategoria, Descripcion, Estado FROM Categoria WHERE Estado = 0");

                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id_cat = (int)datos.lector["Id"];
                    aux.NombreCategoria = (string)datos.lector["NombreCategoria"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.Estado = (bool)datos.lector["Estado"];

                    Lista.Add(aux);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public void AgregarCategoria(Categoria nuevo)
        {
            try
            {
                using (AccesoDatos Datos = new AccesoDatos())
                {

                    Datos.SetearQuery("INSERT INTO Categoria  (NombreCategoria, Descripcion, Estado) VALUES ( @Nombre, @Descripcion, @Estado ); SELECT SCOPE_IDENTITY();");


                    Datos.setearParametros("@Nombre", nuevo.NombreCategoria);
                    Datos.setearParametros("@Descripcion", nuevo.Descripcion);
                    Datos.setearParametros("@Estado", 0);
                    long Id = Convert.ToInt64(Datos.ejecutarScalar());

                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Modificar(Categoria nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("UPDATE Categoria SET NombreCategoria = @nombre, Descripcion = @Descripcion WHERE Id = @ID");

                Datos.setearParametros("@nombre", nuevo.NombreCategoria);
                Datos.setearParametros("@Descripcion", nuevo.Descripcion);
                Datos.setearParametros("@ID", nuevo.Id_cat);

                Datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public void EliminarCategoria(int IdCat)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("update Categoria set estado=1 where Id =@ID");
                datos.setearParametros("@ID", IdCat);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


    }
}
