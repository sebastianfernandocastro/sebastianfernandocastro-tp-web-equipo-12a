using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class NegocioMarca
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from Marcas");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;

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
        public List<Marca> buscar(Marca marca)
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM Marcas where Id = @Id");
                datos.Comando.Parameters.AddWithValue("Id", marca.Id);
                datos.EjecutarLectura();
                datos.Lector.Read();
                marca.Id = (int)datos.Lector["Id"];
                marca.Descripcion = (string)datos.Lector["Descripcion"];
                marcas.Add(marca);
                return marcas;
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

        public void agregar(string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO MARCAS(Descripcion) VALUES(@Descripcion)");
                datos.Comando.Parameters.AddWithValue("@Descripcion", descripcion);
                datos.EjecutarLectura();
                datos.Lector.Read();
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

        public void borrar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM MARCAS WHERE ID = @Id");
                datos.Comando.Parameters.AddWithValue("@Id", id);
                datos.EjecutarLectura();

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
  
        public bool checkBorrar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) AS cantidad FROM ARTICULOS WHERE IdMarca = @Id");
                datos.Comando.Parameters.AddWithValue("@Id", id);
                datos.EjecutarLectura();

                datos.Lector.Read();

                if ((int)datos.Lector["cantidad"]>0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                    
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
    }
}
