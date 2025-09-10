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
                setSringCommand("select Descripcion  from Categorias");
                ExcecuteLector();
                while (lector.Read())
                {
                    Categoria cat = new Categoria();
                   
                    
                    cat.codigoCategoria = (int)lector["id"];
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
    }
}
    
