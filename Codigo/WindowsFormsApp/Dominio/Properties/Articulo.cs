using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {

        private string codigo;
        private string nombre;
        private float precio;
        private string descripcion;
        private int id;
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();




        public int Id { get => id; set => id = value; }
        
        public string Codigo { get => codigo; set => codigo = value; } 

        public string Nombre { get => nombre; set => nombre = value; }  

        public float Precio { get => precio; set => precio = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
