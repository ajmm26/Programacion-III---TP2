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
    }
}
