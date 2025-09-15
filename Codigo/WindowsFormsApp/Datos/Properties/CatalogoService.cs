using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;
using Dominio;


namespace Datos
{
     public class CatalogoService : BaseService
    {

        
        public List<Articulo> lecturaArticulosGeneral()
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                conectar();
                setStringCommand("select Id,Codigo, Nombre, Precio, Descripcion,IdMarca,IdCategoria from ARTICULOS");
                ExcecuteLector();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)lector["Id"];
                    art.Codigo = (string)lector["Codigo"];
                    art.Nombre = (string)lector["Nombre"];
                    art.Precio = (float)Convert.ToDecimal(lector["Precio"]);
                    art.Descripcion = (string)lector["Descripcion"];
                    art.Id_Marca= (int)lector["idMarca"];
                    art.Id_Categoria = (int)lector["idCategoria"];

                    ImagenService imagenService = new ImagenService();
                    art.Imagenes = imagenService.obtenerImagenesPorIdArticulo(art.Id);


                    lista.Add(art);
                }

                return lista;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }


        }

        public void agregar(Articulo nuevo)
        {
            try
            {
                conectar();
                setStringCommand("INSERT INTO ARTICULOS (Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Precio, @Descripcion, @IdMarca, @IdCategoria)");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", nuevo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Precio", nuevo.Precio);
                comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", nuevo.Marca.IdMarca);
                comando.Parameters.AddWithValue("@IdCategoria", nuevo.Categoria.codigoCategoria);


                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }

        }

        public bool ModificarCodigo(int id, string codigo)
        {
            if (codigo != "")
            {
                try
                {
                    conectar();
                    comando.Parameters.Clear();
                    if (verificarId(id))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        setStringCommand("Update Articulos set Codigo=@codigo where id=@id");
                        comando.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex) { throw ex; }
                finally { desconectar(); }
            }
            return false;
        }
        public bool ModificarNombre(int id, string nombre)
        {
            if (nombre != "")
            {
                try
                {

                    conectar();
                    comando.Parameters.Clear();
                    if (verificarId(id))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        setStringCommand("Update Articulos set Nombre=@nombre where id=@id");

                        comando.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    desconectar();
                }
            }
            return false;
        }

        public bool ModificarDescripcion(int id, string Descripcion)
        {
            if (Descripcion != "")
            {
                try
                {
                    conectar();
                    comando.Parameters.Clear();

                    if (verificarId(id))
                    {
                        comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                        setStringCommand("Update Articulos set Descripcion=@Descripcion where id=@id");

                        comando.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex) { throw ex; }
                finally { desconectar(); }
            }
            return false;
        }

       





        public bool ModificarPrecio(int id, decimal precio)
        {

            if (precio > 0)
            {
                try
                {
                    conectar();
                    comando.Parameters.Clear();

                    if (verificarId(id))
                    {
                        comando.Parameters.AddWithValue("@precio", precio);
                        setStringCommand("Update Articulos set precio=@precio where id=@id");

                        comando.ExecuteNonQuery();
                    }
                    return true;

                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {

                    desconectar();
                }
            }
            return false;
        }






        public int obtenerIdArticuloPorCodigo(string codigo)
        {
            try
            {
                conectar();
                setStringCommand("SELECT Id FROM ARTICULOS WHERE Codigo = @Codigo");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", codigo);
                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                conectar();
                setStringCommand("DELETE FROM Articulos WHERE Id = @id");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public List<Articulo> BuscarArticulo(string nombre)
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                conectar();

                setStringCommand("SELECT Id, Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria " +
                                 "FROM ARTICULOS " +
                                 "WHERE LOWER(Nombre) LIKE '%' + LOWER(@nombre) + '%'");

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", nombre);

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)lector["Id"];
                    art.Codigo = (string)lector["Codigo"];
                    art.Nombre = (string)lector["Nombre"];
                    art.Precio = Convert.ToSingle(lector["Precio"]);  // mejor que cast directo
                    art.Descripcion = (string)lector["Descripcion"];
                    art.Id_Marca = (int)lector["IdMarca"];
                    art.Id_Categoria = (int)lector["IdCategoria"];

                    lista.Add(art);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }

            return lista;
        }
    }
}
    
