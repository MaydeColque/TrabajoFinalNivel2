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
        
        //Valores capturados.
        private Articulo seleccionado;
        private List<Articulo> articulosEliminados;
        private List<Articulo> articulos;


        //métodos       
        private void cargarDgv()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (articulosEliminados == null || articulosEliminados.Count == 0)
            {
                articulos = negocio.listarArticulos();
                dgvArticulos.DataSource = articulos;
                btnPapelera.Enabled = false;
            }
            else
            {
                btnPapelera.Enabled = true;
                dgvArticulos.DataSource = negocio.listarArticulos(articulosEliminados);
            }
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Width = 280;
            dgvArticulos.Columns["Categoria"].Width = 150;
            dgvArticulos.Columns["Precio"].Width = 150;
            dgvArticulos.Columns["Marca"].Width = 150;
            dgvArticulos.Columns["Nombre"].Width = 220;

            //dataGridViewPrueba.DataSource = articulos;
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
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;


            //Carga Info. en las labels de la sección "más detalles" del artículo.
            cargarImagen(pictureBoxArticulo, seleccionado.UrlImagen);
            //Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            string codigo = $"# {seleccionado.Codigo}";
            string precio = $"$ {seleccionado.Precio.ToString("0.00")}";

            Id.Text = $"{seleccionado.Id}";
            Codigo.Text = codigo;
            Marca.Text = seleccionado.Marca.Descripcion;
            Nombre.Text = seleccionado.Nombre;
            Descripcion.Text = seleccionado.Descripcion;
            Categoria.Text = seleccionado.Categoria.ToString();
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

        private void dgvArticulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalle ventana = new frmDetalle(seleccionado);
            ventana.ShowDialog();

        }

        private void frmPrincipal_SizeChanged(object sender, EventArgs e)
        {
            int minWidth = MinimumSize.Width;
            int actualWidth = Size.Width;

            if (actualWidth > minWidth)
            {
                btnAgregar.Location = new Point(25, 705);
                btnFiltrar.Location = new Point(98, 810);
                btnPapelera.Location = new Point(168, 705);
                panelDetalleArticulo.Visible = true;
            }
            else
            {
                btnAgregar.Location = new Point(25, 635);
                btnFiltrar.Location = new Point(98, 560);
                btnPapelera.Location = new Point(168, 635);
                panelDetalleArticulo.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //ArticuloNegocio eliminar = new ArticuloNegocio();
            string nombre = seleccionado.Nombre;
            DialogResult resultado = MessageBox.Show($"¿Deseas eliminar {nombre}? Nota: Podrás recuperar el elemento, haciendo clic en el botón Recuperar. Pero se eliminarán definitivamente una vez que cierres la aplicación. ",$"Eliminando {nombre}...",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                if (articulosEliminados != null)
                {
                    articulosEliminados.Add(seleccionado);
                }
                else
                {
                    articulosEliminados = new List<Articulo>();
                    articulosEliminados.Add(seleccionado);
                }

                cargarDgv();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            if (articulosEliminados != null)
            {
                frmPapelera ventanaRecuperar = new frmPapelera(articulosEliminados);
                ventanaRecuperar.ShowDialog();
            }
            else
            {
                MessageBox.Show("La lista de elementos eliminados está vacía.");
            }
            cargarDgv();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (articulosEliminados != null && articulosEliminados.Count == 0)
            {
                DialogResult resultado = MessageBox.Show("Se detectaron artículos en la papelera ¿Deseas continuar con el cierre de la aplicación? Alerta: Recuerda que se eliminarán definitivamente.", "Confirmación cierre de la Aplicación...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    e.Cancel= true;
                }
                else
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    foreach (Articulo articulo in articulosEliminados)
                    {
                        negocio.eliminar(articulo.Id);
                    }
                }
            }
        }

    }
}
