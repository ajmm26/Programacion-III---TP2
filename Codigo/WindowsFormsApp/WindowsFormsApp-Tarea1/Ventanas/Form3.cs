using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Tarea1.Ventanas
{
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

     
        private void buttonBuscarPDT_Click(object sender, EventArgs e)
        {
            string busqueda = txtNombreBox.Text;
            CatalogoService catalogoService = new CatalogoService();
            List<Articulo> articulos = catalogoService.BuscarArticulo(busqueda);

            dataGProductos.Rows.Clear();

           
            foreach (Articulo art in articulos)
            {

                int rowIndex = dataGProductos.Rows.Add(art.Nombre, art.Descripcion, art.Precio);
               
                dataGProductos.Rows[rowIndex].Tag = art;

            }
        }

     

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            dataGProductos.ColumnCount = 3;
            dataGProductos.Columns[0].Name = "Nombre";
            dataGProductos.Columns[1].Name = "Descripción";
            dataGProductos.Columns[2].Name = "Precio";
        }

        private void dataGProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGProductos.Rows[e.RowIndex];

            Articulo artSeleccionado = fila.Tag as Articulo;

            if (artSeleccionado != null)
            {
                ArrticuloIndividual arrticuloIndividual = new ArrticuloIndividual(artSeleccionado);
                arrticuloIndividual.StartPosition = FormStartPosition.CenterParent;
                arrticuloIndividual.ShowDialog();
            }
        }
    }
}
