using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;

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
            CategoriaService servicio = new CategoriaService();
            MarcaService service = new MarcaService();

            List<Categoria> categorias = servicio.lecturaCategorias();

            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "nombreCategoria";     
            comboBoxCategoria.ValueMember = "codigoCategoria"; 

            List<Marca> marca = service.lecturaMarcas();

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
            
            
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtDescrpcion.Text))
                {
                    MessageBox.Show("Completá todos los campos obligatorios.");
                    return;
                }

                
                if (!float.TryParse(txtPrecio.Text, out float precio))
                {
                    MessageBox.Show("Ingresá un precio válido.");
                    return;
                }

                

                if (comboBoxMarca.SelectedItem == null || comboBoxCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná una marca y una categoría.");
                    return;
                }

                
                Articulo nuevo = new Articulo
                {
                    Codigo = txtcodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Descripcion = txtDescrpcion.Text.Trim(),
                    Marca = (Marca)comboBoxMarca.SelectedItem,
                    Categoria = (Categoria)comboBoxCategoria.SelectedItem
                };





                CatalogoService servicio = new CatalogoService();
                ImagenService service = new ImagenService();
                servicio.agregar(nuevo);


                string urlImagen = txtImagen.Text.Trim();
                string urlImagenVacia = "https://www.creaodontologia.com/wp-content/uploads/2025/03/placeholder-2.png";

                int idArticulo = servicio.obtenerIdArticuloPorCodigo(nuevo.Codigo);

                Imagen nuevaImagen = new Imagen();
                nuevaImagen.IdArticulo = idArticulo;
                nuevaImagen.ImagenUrl = string.IsNullOrWhiteSpace(urlImagen) ? urlImagenVacia : urlImagen;

                service.agregarImagen(nuevaImagen);




                MessageBox.Show("Articulo agregado correctamente.");
                Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar el articulo: " + ex.Message);
            }
        }

        

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            string url = txtImagen.Text.Trim();
            string urlImagenVacia = "https://www.creaodontologia.com/wp-content/uploads/2025/03/placeholder-2.png";

            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    pBoxVistaPrevia.Load(url);
                }
                catch
                {
                    pBoxVistaPrevia.Load(urlImagenVacia);
                    MessageBox.Show("No se pudo cargar la imagen desde la URL. Se muestra una imagen vacía.");
                }
            }
            else
            {
                pBoxVistaPrevia.Load(urlImagenVacia);
                MessageBox.Show("Ingresá una URL válida. Se muestra una imagen vacía.");
            }



        }
    }
}
