using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class ArticuloNegocio
    {
      
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, A.Precio, A.IdCategoria, A.IdMarca, A.Codigo, A.Nombre, A.Descripcion ,C.Descripcion AS DesCategoria, M.Descripcion AS DesMarca FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["DesCategoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["DesMarca"];
                    articulos.Add(aux);
                    
                }


                return articulos;
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

        public List<Articulo> buscarArticulo(Articulo busqueda)
        {
            List <Articulo> articulos = new List <Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, A.Precio, A.Codigo, A.Nombre, A.Descripcion, C.Descripcion AS DesCategoria, C.Id AS IdCategoria, M.Descripcion AS DesMarca, M.Id AS IdMarca FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    if(aux.Codigo == busqueda.Codigo || aux.Nombre == busqueda.Nombre)
                    {
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Codigo = (string)datos.Lector["Codigo"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        aux.Precio = (decimal)datos.Lector["Precio"];
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)datos.Lector["DesCategoria"];
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["DesMarca"];
                        articulos.Add((Articulo)aux);
                        
                    }

                }

                return articulos;
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

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.Comando.Parameters.AddWithValue("@Id", id);
                datos.EjecutarAccion();
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
        public void cargarArticulo(Articulo articuloNuevo)
        {
            AccesoDatos datos = new AccesoDatos(); // Instancia de la clase AccesoDatos

            try
            {
                
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                datos.ConvertirDatos(articuloNuevo);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                throw ex;
            }
            finally
            {
                // Asegurar que la conexión se cierre correctamente
                datos.CerrarConexion();
            }
        }
        public void Editar(Articulo articuloNuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE Articulos" +
                    " set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, " +
                    " IdCategoria = @IdCategoria, IdMarca = @IdMarca WHERE ID = @Id");

                datos.ConvertirDatos(articuloNuevo);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                throw ex;
            }
            finally
            {
                // Asegurar que la conexión se cierre correctamente
                datos.CerrarConexion();
            }
        }
    }

}

