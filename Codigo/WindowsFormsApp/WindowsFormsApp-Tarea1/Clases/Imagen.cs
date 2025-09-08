using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Tarea1
{
    internal class Imagen
    {
        private int CodigoImagen;
        private string Url;
        private int ArticuloCodigo;

        public int codigoImagen { get => CodigoImagen; set => CodigoImagen = value; }
        public string url { get => Url; set => Url = value; }
        public int articuloCodigo { get => ArticuloCodigo; set => ArticuloCodigo = value; }

    }
}
