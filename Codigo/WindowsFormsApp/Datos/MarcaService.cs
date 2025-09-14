using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MarcaService : BaseService
    {
        public List<Marca> lecturaMarcas()
        {
            List<Marca> lista = new List<Marca>();
            try
            {
                conectar();
                setStringCommand("Select Id,Descripcion From MARCAS");
                ExcecuteLector();

                while (lector.Read())
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

        public void agregarMarca(Marca nuevaMarca)
        {
            try
            {
                conectar();
                setStringCommand("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
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

        public bool ModificarMarca(int id, int id_Marca)
        {
            if (id_Marca > 0)
            {
                conectar();
                comando.Parameters.Clear();
                try
                {
                    if (verificarId(id))
                    {
                        comando.Parameters.AddWithValue("@IdMarca", id_Marca);
                        setStringCommand("Update Articulos set IdMarca=@IdMarca where id=@id");


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
    }
}
