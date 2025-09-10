using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Tarea1.Clases;

namespace WindowsFormsApp_Tarea1
{
    public partial class AltaArticulo : Form
    {
        public AltaArticulo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CatalogoService servicio = new CatalogoService();

            List<Categoria> categorias = servicio.lecturaCategorias();

            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "nombreCategoria";     
            comboBoxCategoria.ValueMember = "codigoCategoria"; 

            List<Marca> marca = servicio.lecturaMarcas();

            comboBoxMarca.DataSource = marca;
            comboBoxMarca.DisplayMember = "DescripcionMarca";
            comboBoxMarca.ValueMember = "IdMarca";



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            
            try
            {
                nuevo.Codigo = txtcodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Precio = float.Parse(txtPrecio.Text);
                nuevo.Descripcion = txtDescrpcion.Text;
                //nuevo.Marca = (Marca)comboBoxMarca.SelectedItem;
                //nuevo.Categoria = (Categoria)comboBoxCategoria.SelectedItem; 
                
                CatalogoService servicio = new CatalogoService();
                servicio.agregar(nuevo);
                MessageBox.Show("Articulo agregado correctamente.");
                Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar el articulo: " + ex.Message);
            }
        }
    }
}
