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
    public partial class ArrticuloIndividual : Form
    {

        private Articulo art;

        public ArrticuloIndividual(Articulo articulo)
        {
            art = articulo;
            InitializeComponent();
        }

        private void ArrticuloIndividual_Load(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.LightGray;
            panel.Width = flowPanelIndividual.Width;
            panel.Height = flowPanelIndividual.Height;
            ///
            Panel panelImage = new Panel();
            panelImage.Width = panel.Width;
            panelImage.Height = 230;
            panelImage.BackColor = Color.White;
            panelImage.Dock = DockStyle.Top;
            ////
            Panel panelTextNombre = new Panel();
            panelTextNombre.Width = panel.Width;
            panelTextNombre.Height = 35;
            panelTextNombre.Dock = DockStyle.Top;
            /////
            Label labelNombre = new Label();
            labelNombre.Text = art.Nombre;
            labelNombre.Dock = DockStyle.Fill;
            labelNombre.TextAlign = ContentAlignment.MiddleCenter;
            //////
            Panel panelTextDescripcion = new Panel();
            panelTextDescripcion.Width = panel.Width;
            panelTextDescripcion.Height = 60;
            panelTextDescripcion.Dock = DockStyle.Top;
            ///
            Label labelDescripcion = new Label();
            labelDescripcion.Text = art.Descripcion;
            labelDescripcion.Dock = DockStyle.Fill;
            labelDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            ////
            Panel panelMrcYCtg = new Panel();
            panelMrcYCtg.Width = panel.Width;
            panelMrcYCtg.Height = 30;
            panelMrcYCtg.Dock = DockStyle.Top;
            ////
            Label labelMrc = new Label();
            MarcaService marcaService = new MarcaService();
            Marca marca = marcaService.LecturaMarcaPorId((int)art.Id_Marca);
            labelMrc.Text += " | Marca: " + marca.DescripcionMarca;
            labelMrc.Dock = DockStyle.Fill;
            labelMrc.TextAlign = ContentAlignment.MiddleCenter;
           
            ///
            Panel panelPrecio = new Panel();
            panelPrecio.Width = panel.Width;
            panelPrecio.Dock = DockStyle.Top;
            ////
            Label labelPrecio = new Label();
            labelPrecio.Text = "Precio: $" + art.Precio.ToString("F2");
            labelPrecio.Dock = DockStyle.Fill;
            labelPrecio.TextAlign = ContentAlignment.TopCenter;
            labelPrecio.Padding = new Padding(0,10,0,0);
            ////
            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Width = panelImage.Width;
            pb.Height = panelImage.Height;
            ImagenService imagenService = new ImagenService();
            List<Imagen> Imagenes = imagenService.obtenerImagenesPorIdArticulo(art.Id);
            pb.ImageLocation = Imagenes[0].ImagenUrl;
            ////
            panelImage.Controls.Add(pb);
            panelPrecio.Controls.Add(labelPrecio);
            panelMrcYCtg.Controls.Add(labelMrc);
            panelTextDescripcion.Controls.Add(labelDescripcion);
            panelTextNombre.Controls.Add(labelNombre);
            panel.Controls.Add(panelPrecio);
            panel.Controls.Add(panelMrcYCtg);
            panel.Controls.Add(panelTextDescripcion);
            panel.Controls.Add(panelTextNombre);
            panel.Controls.Add(panelImage);
            flowPanelIndividual.Controls.Add(panel);
        }
    }
}
