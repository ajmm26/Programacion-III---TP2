using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Dominio;

namespace WindowsFormsApp_Tarea1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxTipo.Items.Add("Marca");
            comboBoxTipo.Items.Add("Categoría");
            comboBoxTipo.SelectedIndex = 0;
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxTipo.SelectedItem.ToString();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
                return;
            }



            CategoriaService servicio = new CategoriaService();
            MarcaService service = new MarcaService();

            try
            {
                if (tipo == "Marca")
                {
                    Marca nuevaMarca = new Marca();
                    nuevaMarca.DescripcionMarca = nombre;
                    service.agregarMarca(nuevaMarca);
                }
                else if (tipo == "Categoría")
                {
                    Categoria nuevaCategoria = new Categoria();
                    nuevaCategoria.nombreCategoria = nombre;
                    servicio.agregarCategoria(nuevaCategoria);
                }

                MessageBox.Show($"{tipo} agregada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar " + tipo + ": " + ex.Message);
            }



        }
    }
}
