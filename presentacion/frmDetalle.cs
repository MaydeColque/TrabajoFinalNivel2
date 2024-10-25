using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static presentacion.Helper;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articuloSeleccionado;
        public frmDetalle()
        {
            InitializeComponent();
        }
        public frmDetalle(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloSeleccionado = articuloSeleccionado;
        }
        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarImagen(pictureBoxArticulo, articuloSeleccionado.UrlImagen);

            string codigo = $"# {articuloSeleccionado.Codigo}";
            string precio = $"$ {articuloSeleccionado.Precio.ToString("0.00")}";

            Id.Text = $"{articuloSeleccionado.Id}";
            Codigo.Text = codigo;
            Marca.Text = articuloSeleccionado.Marca.Descripcion;
            Nombre.Text = articuloSeleccionado.Nombre;
            Descripcion.Text = articuloSeleccionado.Descripcion;
            Categoria.Text = articuloSeleccionado.Categoria.ToString();
            Precio.Text = precio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }    
}
