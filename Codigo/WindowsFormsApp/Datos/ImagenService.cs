using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ImagenService : BaseService
    {

        public List<Imagen> obtenerImagenesPorIdArticulo(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            try
            {
                conectar();
                setStringCommand("SELECT * FROM Imagenes WHERE IdArticulo = @id");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", idArticulo);
                ExcecuteLector();

                while (lector.Read())
                {
                    Imagen img = new Imagen();
                    img.Id = (int)lector["Id"];
                    img.IdArticulo = (int)lector["IdArticulo"];
                    img.ImagenUrl = lector["ImagenUrl"].ToString();
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

        
        public List<Imagen> lecturaImagenes()
        {
            List<Imagen> lista = new List<Imagen>();
            try
            {
                conectar();
                setStringCommand("select Id,IdArticulo,ImagenUrl from IMAGENES");
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
        
        public void agregarImagen(Imagen nueva)
        {
            try
            {
                conectar();
                setStringCommand("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
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

        public void eliminarPorIdArticulo(int idArticulo)
        {
            try
            {
                conectar();
                setStringCommand("DELETE FROM Imagenes WHERE IdArticulo = @id");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", idArticulo);
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
