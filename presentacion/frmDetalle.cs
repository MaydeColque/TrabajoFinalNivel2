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
            this.articuloSeleccionado= articuloSeleccionado;
        }
        private void frmDetalle_Load(object sender, EventArgs e)
        {
            //Cuando se cierra la ventana de agregar, retorna null.

            //if (dgvArticulos.CurrentRow == null)
            //{
            //    return;
            //}
            
            // Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(pictureBoxArticulo, articuloSeleccionado.UrlImagen);

            //Carga Info. en las labels de más detalles del artículo.
            //Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
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
    }
}
