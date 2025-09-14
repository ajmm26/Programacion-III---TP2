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
using WindowsFormsApp_Tarea1.Ventanas;

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
            FlowLayoutPanel panel_Catalogo = PanelCatalogo;
            panel_Catalogo.AutoScroll = true;
            List<Articulo> lista = listaArticulos();
            List<Imagen> listaImagenes = ObtenerUrlImagenes();
            int index = 0;
            foreach (Articulo art in lista)
            {
                ////paneles contenedores
              
                ///General
                Panel panel = panelContenedor();
                ///contendor de imagenes
               Panel panelImage = getpanelImage(panel_Catalogo);
                ///contendor de textos
                // Panel de texto
                Panel panelText = getpanelText();
                ////contenedor de imagenes
               PictureBox pictureBox = getPictureBox( listaImagenes,index,panelImage);
                ////label nombre
                Label labelNombre = getlabel();
                labelNombre.Text = art.Nombre;
                labelNombre.Dock = DockStyle.Top;
                labelNombre.TextAlign = ContentAlignment.TopCenter;
                ///label precioValor
                Label labelPrecioValor = getlabel();
                labelPrecioValor.Text = "$ " + art.Precio.ToString("F2");
                labelPrecioValor.Dock = DockStyle.Fill;
                labelPrecioValor.TextAlign = ContentAlignment.BottomCenter;
                ////
                Label labelDescripcion = getlabel();   
                labelDescripcion.Text = art.Descripcion;
                labelDescripcion.Dock = DockStyle.Top;
                labelDescripcion.TextAlign = ContentAlignment.MiddleCenter;
                labelDescripcion.Height = 40;
                labelDescripcion.Padding = new Padding(0,5,0,0);
                // margen interno
                labelNombre.Padding = new Padding(0, 6,0,0);
                 

                panelText.Controls.Add(labelDescripcion);
                panelImage.Controls.Add(pictureBox);   
                panelText.Controls.Add(labelNombre);
                panelText.Controls.Add(labelPrecioValor);
                // Agrego al panel principal
                panel_Catalogo.Controls.Add(panel);
                panel.Controls.Add(panelImage);
                panel.Controls.Add(panelText);

                index++;
            }


        }



        private Label getlabel()
        {
            Label label = new Label();
            label.Font = new Font("Arial", 9, FontStyle.Regular);
            return label;

        }
       

        private PictureBox getPictureBox(List<Imagen> listaImagenes,int index,Panel panelImage)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;    // se estira dentro del panelImage
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // la imagen se adapta al tamaño del PictureBox
            pictureBox.Width = 140;
            pictureBox.Height = 150;
            pictureBox.ImageLocation = listaImagenes[index].ImagenUrl;
            pictureBox.Location = new Point(
            (panelImage.Width - panelImage.Width) / 2,  // posición X
             (panelImage.Height - panelImage.Height) / 2  // posición Y
                                     );
            return pictureBox;
        }

       private Panel getpanelText()
        {
            Panel panelText = new Panel();
            panelText.Dock = DockStyle.Bottom;   // 👈 clave
            panelText.Height = 100;
            panelText.BackColor = Color.LightGray;
           return panelText;
        }

        private Panel panelContenedor() {

            Panel panel = new Panel();
            panel.Width = 160;
            panel.Height = 250;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.LightGray;
            panel.Margin = new Padding(30);
          
            panel.BorderStyle = BorderStyle.Fixed3D;
            return panel;
        }

        private Panel getpanelImage(FlowLayoutPanel panel_Catalogo)
        {
            Panel panelImage = new Panel();
            panelImage.Width = 140;
            panelImage.Height = 150;
            panelImage.BackColor = Color.White;
            panelImage.Dock = DockStyle.Top;
            return panelImage;
        }


        private List<Articulo> listaArticulos()
        {
            CatalogoService servicio = new CatalogoService();
            return servicio.lecturaArticulosGeneral();
        }

        private List<Imagen> ObtenerUrlImagenes()
        {
            CatalogoService servicio = new CatalogoService();
           return servicio.lecturaImagenes();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaArticulo alta = new AltaArticulo(); 
            alta.ShowDialog();
           /* CatalogoService servicio = new CatalogoService();
            dataGridView1.DataSource = servicio.lecturaArticulosGeneral();*/
        }

        private void articuloToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form form = new frmModificarArticulo();
            form.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 altaMarca = new Form4();
            altaMarca.StartPosition = FormStartPosition.CenterScreen;
            altaMarca.ShowDialog();
        }
    }
}
