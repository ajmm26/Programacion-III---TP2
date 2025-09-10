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
    public partial class CatalogoWindows : Form
    {
        public CatalogoWindows()
        {
            InitializeComponent();
        }


      
        private void CatalogoWindows_Load(object sender, EventArgs e)
        {
                  CatalogoService catalogo = new CatalogoService();
            dataGridView1.DataSource = catalogo.lecturaArticulosGeneral();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaArticulo alta = new AltaArticulo(); 
            alta.ShowDialog();
            CatalogoService servicio = new CatalogoService();
            dataGridView1.DataSource = servicio.lecturaArticulosGeneral();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string codigoSeleccionado = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                CatalogoService servicio = new CatalogoService();
                List<Imagen> imagenes = servicio.lecturaImagenesPorCodigo(codigoSeleccionado);

                if(imagenes.Count > 0)
                pictureBoxArticulo.ImageLocation = imagenes[0].ImagenUrl;
                else
                    pictureBoxArticulo.Image = null;
            }
        }
    }
}
