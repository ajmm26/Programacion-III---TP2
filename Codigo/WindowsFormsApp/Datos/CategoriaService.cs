
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class CategoriaService : BaseService
    {
        public List<Categoria> lecturaCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                conectar();
                setStringCommand("select Id,Descripcion  from Categorias");
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

        public void agregarCategoria(Categoria nuevaCategoria)
        {
            try
            {
                conectar();
                setStringCommand("INSERT INTO CATEGORIAS (Descripcion) VALUES (@Descripcion)");
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

        public bool ModificarCategoria(int id, int id_Categoria)
        {
            if (id_Categoria > 0)
            {
                try
                {
                    conectar();
                    comando.Parameters.Clear();
                    if (verificarId(id))
                    {
                        comando.Parameters.AddWithValue("@IdCategoria", id_Categoria);
                        setStringCommand("Update Articulos set IdCategoria=@IdCategoria where id=@id");
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

        public bool modificarCategoriaTabla(int idCategoria, string nombre)
        {
            if (nombre != " ")
            {
                try
                {
                    conectar();
                    comando.Parameters.Clear();
                    if (verificarId(idCategoria))
                    {
                        comando.Parameters.AddWithValue("@descripcion", nombre);
                        setStringCommand("Update Categorias set Descripcion=@descripcion where id=@Id");
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

        public Categoria LecturaCategoriaPorId(int id)
        {
            try
            {
                conectar();
                comando.Parameters.Clear();
                if (verificarId(id))
                {
                    setStringCommand("Select Id, Descripcion From Categorias where id=@Id");
                    ExcecuteLector();
                    if (lector.Read())
                    {
                        Categoria aux = new Categoria();
                        aux.codigoCategoria = (int)lector["Id"];
                        aux.nombreCategoria = (string)lector["Descripcion"];
                        return aux;
                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                desconectar();
            }
            return null;
        }


    }
}
