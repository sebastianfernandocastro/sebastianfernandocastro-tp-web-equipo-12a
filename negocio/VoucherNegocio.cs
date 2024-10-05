using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> listar()
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select CodigoVoucher, IdCliente, FechaCanje, IdArituclo from Vouchers");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.codigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    aux.idCliente = (int)datos.Lector["IdCliente"];
                    aux.fechaCanje = (DateTime)datos.Lector["FechaCanje"];
                    aux.idArticulo = (int)datos.Lector["IdArticulo"];
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
        public bool usado(string voucher)
        {
            int a = 0;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IdCliente FROM Vouchers where CodigoVoucher = @CodigoVoucher");
                datos.Comando.Parameters.AddWithValue("@CodigoVoucher", voucher);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    try
                    {
                        a = datos.Lector.GetInt32(0);
                    }
                    catch (Exception ex)
                    {

                        a = 0;
                    }
                    
                }
                if(a>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


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

        public bool buscar(string voucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT CodigoVoucher FROM Vouchers where CodigoVoucher = @CodigoVoucher");
                datos.Comando.Parameters.AddWithValue("@CodigoVoucher", voucher);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

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

        public void Editar(Voucher voucher)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE Vouchers SET IdCliente = @idCliente, FechaCanje = @fechaCanje, IdArticulo = @idArticulo WHERE CodigoVoucher = @codigoVoucher");

                datos.Comando.Parameters.AddWithValue("@idCliente", voucher.idCliente);
                datos.Comando.Parameters.AddWithValue("@fechaCanje", voucher.fechaCanje);
                datos.Comando.Parameters.AddWithValue("@idArticulo", voucher.idArticulo);
                datos.Comando.Parameters.AddWithValue("@codigoVoucher", voucher.codigoVoucher);

                datos.EjecutarAccion();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        //public void agregar(string descripcion)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("INSERT INTO VoucherS(Descripcion) VALUES(@Descripcion)");
        //        datos.Comando.Parameters.AddWithValue("@Descripcion", descripcion);
        //        datos.EjecutarLectura();
        //        datos.Lector.Read();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.CerrarConexion();
        //    }
        //}

        //public void borrar(int id)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("DELETE FROM VoucherS WHERE ID = @Id");
        //        datos.Comando.Parameters.AddWithValue("@Id", id);
        //        datos.EjecutarLectura();

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.CerrarConexion();
        //    }
        //}

        //public bool checkBorrar(int id)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("SELECT COUNT(*) AS cantidad FROM ARTICULOS WHERE IdVoucher = @Id");
        //        datos.Comando.Parameters.AddWithValue("@Id", id);
        //        datos.EjecutarLectura();

        //        datos.Lector.Read();

        //        if ((int)datos.Lector["cantidad"] > 0)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        datos.CerrarConexion();
        //    }

        //}
    }
}