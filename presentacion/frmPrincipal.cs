using modelo;
using negocio;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //métodos
        
        private void cargarDgv()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listarArticulos();
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Width = 190;
            dgvArticulos.Columns["Categoria"].Width = 120;
            dgvArticulos.Columns["Precio"].Width = 148;
            dgvArticulos.Columns["Nombre"].Width = 165;
        }

        //eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //panelDgvArticulos.Location = new Point(140, 70);
            //DataGridView dgvArticulos = this.dgvArticulos;
            //dgvArticulos.Location = new Point(140, 70);
            //this.Size = new Size(1040,451);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //Cuando se cierra la ventana de agregar, retorna null.
            if (dgvArticulos.CurrentRow == null)
            {
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(pictureBoxArticulo, seleccionado.UrlImagen);

            //Carga Info. en las labels de más detalles del artículo.
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            string codigo = $"# {artSeleccionado.Codigo}";
            string precio = $"$ {artSeleccionado.Precio.ToString("0.00")}";

            Id.Text = $"{artSeleccionado.Id}";
            Codigo.Text = codigo;
            Marca.Text = artSeleccionado.Marca.Descripcion;
            Nombre.Text = artSeleccionado.Nombre;
            Descripcion.Text = artSeleccionado.Descripcion;
            Categoria.Text = artSeleccionado.Categoria.ToString();
            Precio.Text = precio;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
            cargarDgv();
            
        }
    }
}
