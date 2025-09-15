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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        { 

            cbEleccionAtributo.Items.Add("Marca");
            cbEleccionAtributo.Items.Add("Categoria");
            cbEleccionAtributo.SelectedIndex = 0; 


        }

        private void cbEleccionAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEleccionAtributo.SelectedIndex == 0)
            {
                MarcaService marcaService = new MarcaService();
                List<Marca> marcas = marcaService.lecturaMarcas();

                cbEleccionItem.DataSource = marcas;
                cbEleccionItem.DisplayMember = "DescripcionMarca";
                cbEleccionAtributo.ValueMember = "IdMarca";


            }

            if (cbEleccionAtributo.SelectedIndex == 1)
            {
                CategoriaService categoriaService = new CategoriaService();
                List<Categoria> categorias = categoriaService.lecturaCategorias();

                cbEleccionItem.DataSource = categorias;
                cbEleccionItem.DisplayMember = "nombreCategoria";
                cbEleccionAtributo.ValueMember = "codigoCategoria";
            }
        }

        private void buttonModificarMC_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoNombre = textNombreModificado.Text;
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("El nombre no puede estar vacio");
                }
                if (cbEleccionAtributo.SelectedIndex == 1)
                {
                   Categoria categoria=(Categoria)cbEleccionItem.SelectedItem;
                   int id_categoria = categoria.codigoCategoria;
                    CategoriaService service = new CategoriaService();
                      bool resCateogria = service.modificarCategoriaTabla(id_categoria, nuevoNombre);
                      if (resCateogria)
                      {
                          MessageBox.Show("Categoria modificada con exito");
                      }

               
                }

                if(cbEleccionAtributo.SelectedIndex == 0)
                    {
                        Marca marca = (Marca)cbEleccionItem.SelectedItem;
                        int id_marca = marca.IdMarca;
                        MarcaService serviceMaarca = new MarcaService();
                        bool resMarca= serviceMaarca.modificarMarcaTabla(id_marca,nuevoNombre);
                if (resMarca)
                {
                    MessageBox.Show("Categoria modificada con exito");
                }
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
