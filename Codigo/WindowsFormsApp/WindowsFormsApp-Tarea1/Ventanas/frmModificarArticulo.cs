using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Tarea1.Clases;

namespace WindowsFormsApp_Tarea1.Ventanas
{
    public partial class frmModificarArticulo : Form
    {
        public frmModificarArticulo()
        {
            InitializeComponent();
        }

        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            CatalogoService servicio = new CatalogoService();  
            //articulos
            List<Articulo> articulos = servicio.lecturaArticulosGeneral();
            cbArticuloElegido.DataSource = articulos;
            cbArticuloElegido.DisplayMember = "Nombre";  // Cambia "Nombre" por el nombre real de la propiedad (ej. "Descripcion")
            cbArticuloElegido.ValueMember = "Id";
            //categorias   
            List<Categoria> categorias = servicio.lecturaCategorias();
            cboCategoriaModificar.DataSource = categorias;
            cboCategoriaModificar.DisplayMember = "nombreCategoria";
            cboCategoriaModificar.ValueMember = "codigoCategoria";
            ///Marcas
            List<Marca> marcas = servicio.lecturaMarcas();
            cboMarcaModificar.DataSource = marcas;
            cboMarcaModificar.DisplayMember = "DescripcionMarca";
           cboMarcaModificar.ValueMember = "IdMarca";




        }

        private void ButtonModficar_Click(object sender, EventArgs e)
        {
            int id = (int)cbArticuloElegido.SelectedValue;
            string codigo = codigoModificado.Text;
            string nombre = nombreModificado.Text;
            string txtprecio = PrecioModificado.Text;
            decimal precio = verificarPrecio(txtprecio);
            string descripcion = DescripcionModificada.Text;
                Marca marca = (Marca)cboMarcaModificar.SelectedItem;
                 int id_Marca = (int)marca.IdMarca;
                Categoria categoria = (Categoria)cboCategoriaModificar.SelectedItem;
                int Id_Categotia = (int)categoria.codigoCategoria;
            try
            {
             
                CatalogoService servicio = new CatalogoService();
             bool resnombre=  servicio.ModificarNombre(id,nombre);
               bool rescodigo= servicio.ModificarCodigo(id,codigo);
               bool resDescripcion= servicio.ModificarDescripcion(id,descripcion);
                bool resMarca= servicio.ModificarMarca( id, id_Marca);
               bool resPrecio = servicio.ModificarPrecio( id, precio);
               bool resCategoria= servicio.ModificarCategoria(id, Id_Categotia);
               if(resnombre || rescodigo || resDescripcion  || resPrecio)
                {
                    MessageBox.Show("Articulo modificado con exito");
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
          
                this.Close();

            }
        }

        private decimal verificarPrecio(string precioText)
        {
            if (precioText != "" && !precioText.All(t => (t >= 'a' && t <= 'z') || (t >= 'A' && t <= 'Z')))
            {
                decimal precio = decimal.Parse(precioText);
                return precio;
            }
            else
            {
                return 0;
            }
        }

      

        private void precioModificado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (ej: backspace, suprimir, etc.)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permitir un único punto
            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                return;
            }

            // Si no cumple ninguna condición, se bloquea
            e.Handled = true;
        }

        private void buttonCancelarMD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
