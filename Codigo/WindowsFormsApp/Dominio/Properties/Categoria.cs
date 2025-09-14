using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        private int CodigoCategoria;
        private string NombreCategoria;

        public int codigoCategoria { get => CodigoCategoria; set => CodigoCategoria= value; }
        public string nombreCategoria { get => NombreCategoria; set =>  NombreCategoria= value; }
        public override string ToString() { return NombreCategoria; }
    }
}
