using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;
namespace WindowsFormsApp_Tarea1.Clases
{
    class CatalogoService
    {

        private SqlConnection conexion;

        private SqlCommand comando;

        private SqlDataReader lector;


        public CatalogoService()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }


        private void conectar()
        {
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            conexion.Open();
        }

        private void desconectar()
        {
            conexion.Close();
        }

        private void setSringCommand(string stsqlcommand)
        {
            comando.CommandText = stsqlcommand;
        }

        private void ExcecuteLector()
        {
            lector = comando.ExecuteReader();

        }

        public List<Articulo> lecturaArticulosGeneral()
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                conectar();
                setSringCommand("select Codigo, Nombre, Precio, Descripcion from ARTICULOS");
                ExcecuteLector();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Codigo = (string)lector["Codigo"];
                    art.Nombre = (string)lector["Nombre"];
                    art.Precio = (float)Convert.ToDecimal(lector["Precio"]);
                    art.Descripcion = (string)lector["Descripcion"];
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

        public List<Categoria> lecturaCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                conectar();
                setSringCommand("select Id,Descripcion  from Categorias");
                ExcecuteLector();
                while (lector.Read())
                {
                    Categoria cat = new Categoria();
                   
                    
                    cat.codigoCategoria = (int)lector["Id"];
                    cat.nombreCategoria = (string)lector["Descripcion"];
                    lista.Add(cat);
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

        public List<Marca> lecturaMarcas()
        {
            List<Marca> lista=new List<Marca>();
            try
            {
                conectar();
                setSringCommand("Select Id,Descripcion From MARCAS");
                ExcecuteLector();

                while(lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IdMarca = (int)lector["Id"];
                    aux.DescripcionMarca = (string)lector["Descripcion"];
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
                desconectar(); 
            }
        }

        public List<Imagen> lecturaImagenes()
        {
            List<Imagen> lista =new List<Imagen>();
            try
            {
                conectar();
                setSringCommand("select Id,IdArticulo,ImagenUrl from IMAGENES");
                ExcecuteLector();

                while (lector.Read())
                {
                    Imagen img = new Imagen();
                    img.Id = (int)lector["Id"];
                    img.IdArticulo = (int)lector["IdArticulo"];
                    img.ImagenUrl = (string)lector["ImagenUrl"];
                    lista.Add(img);
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


        public List<Imagen> lecturaImagenesPorCodigo(string codigo)
        {
            List<Imagen> lista = new List<Imagen>();
            try
            {
                conectar();
                setSringCommand("SELECT ImagenUrl from IMAGENES WHERE IdArticulo = (SELECT Id FROM ARTICULOS WHERE Codigo = @codigo)");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", codigo);
                ExcecuteLector();

                while (lector.Read())
                {
                    Imagen img = new Imagen();
                    img.ImagenUrl = (string)lector["ImagenUrl"];
                    lista.Add(img);
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
                setSringCommand("INSERT INTO ARTICULOS (Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Precio, @Descripcion, @IdMarca, @IdCategoria)");
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

        internal void agregarMarca(Marca nuevaMarca)
        {
            try
            {
                conectar();
                setSringCommand("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Descripcion", nuevaMarca.DescripcionMarca);
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

        internal void agregarCategoria(Categoria nuevaCategoria)
        {
            try
            {
                conectar();
                setSringCommand("INSERT INTO CATEGORIAS (Descripcion) VALUES (@Descripcion)");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Descripcion", nuevaCategoria.nombreCategoria);
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

        public int obtenerIdArticuloPorCodigo(string codigo)
        {
            try
            {
                conectar();
                setSringCommand("SELECT Id FROM ARTICULOS WHERE Codigo = @Codigo");
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

        public void agregarImagen(Imagen nueva)
        {
            try
            {
                conectar();
                setSringCommand("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdArticulo", nueva.IdArticulo);
                comando.Parameters.AddWithValue("@ImagenUrl", nueva.ImagenUrl);
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




    }
}
    
