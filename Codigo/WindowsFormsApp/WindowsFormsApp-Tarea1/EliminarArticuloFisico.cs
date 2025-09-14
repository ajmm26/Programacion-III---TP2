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
    public partial class EliminarArticuloFisico : Form
    {
        public EliminarArticuloFisico()
        {
            InitializeComponent();
        }

        private void EliminarArticuloFisico_Load(object sender, EventArgs e)
        {
            CatalogoService servicio = new CatalogoService();
            dgvArticulos.DataSource = servicio.lecturaArticulosGeneral();
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.MultiSelect = false;

            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                int id = (int)dgvArticulos.SelectedRows[0].Cells["Id"].Value;

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que querés eliminar este artículo?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    ImagenService imagenService = new ImagenService();
                    CatalogoService catalogoService = new CatalogoService();

                    imagenService.eliminarPorIdArticulo(id); 
                    catalogoService.eliminar(id);             

                    MessageBox.Show("Artículo eliminado correctamente.");

                    
                    dgvArticulos.DataSource = catalogoService.lecturaArticulosGeneral();
                }
            }
            else
            {
                MessageBox.Show("Seleccioná una fila para eliminar.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
