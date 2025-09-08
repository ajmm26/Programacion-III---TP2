using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Tarea1.Clases
{
    internal class ClassArticulo
    {

        private int Codigo;
        private string Nombre;
        private float Precio;
        private string Descripcion;

        public int codigo { get => Codigo; set => Codigo = value; } 

        public string nombre { get => Nombre; set => Nombre = value; }  

        public float precio { get => Precio; set => Precio = value; }

        public string descripcion { get => Descripcion; set => Descripcion = value; }

    }
}
