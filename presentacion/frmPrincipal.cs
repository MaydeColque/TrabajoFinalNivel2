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
        
        private void Seleccionado()
        {
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Selecciona un artículo, por favor.");
            }
        }
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
            dgvEstilo();
        }
        private void dgvEstilo()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Width = 280;
            dgvArticulos.Columns["Categoria"].Width = 150;
            if (dgvArticulos.Columns["Precio"] is DataGridViewColumn columnaPrecios)
            {
                columnaPrecios.Width = 150;
                columnaPrecios.DefaultCellStyle.Format = "N3"; // "N4" muestra 4 decimales.
            }
            dgvArticulos.Columns["Marca"].Width = 150;
            dgvArticulos.Columns["Nombre"].Width = 220;
        }
        private void verDetalle()
        {
            frmDetalle ventanaDetalle = new frmDetalle(seleccionado);
            ventanaDetalle.ShowDialog();
        }
        private void dgvNewDataSource(DataGridView dgvName, List<Articulo> newlist)
        {
            dgvName.DataSource = null;
            dgvName.DataSource = newlist;
            dgvEstilo();
        }
        private void tooltipControl(Control controlNombre, ToolTip toolTipNombre, string txtActivo, string txtInactivo)
        {
            
            if (controlNombre.Enabled)
            {
                toolTipNombre.SetToolTip(controlNombre, txtActivo);
            }
            else
            {
                toolTipNombre.SetToolTip(controlNombre, txtInactivo);
            }
        }
        //eventos

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Config texto para tooltips
            toolTipPapelera.SetToolTip(btnPapelera, "Papelera");
            toolTipEliminar.SetToolTip(btnEliminar, "Eliminar");
            toolTipModificar.SetToolTip(btnModificar, "Modificar");
            toolTipVerDetalles.SetToolTip(btnVerDetalle, "Ver Artículo");
            toolTipQuitarCriterios.SetToolTip(btnQuitarCriterios, "Borrar Criterios");

            //Carga de la tabla
            cargarDgv();

            //Config de la tabla
            CategoriaNegocio categoria = new CategoriaNegocio();
            cBxCategoria.ValueMember = "Id";
            cBxCategoria.DisplayMember = "Descripcion";
            cBxCategoria.DataSource = categoria.listarCategorias();
            cBxCategoria.SelectedIndex = -1;

            MarcaNegocio marca = new MarcaNegocio();
            cBxMarca.ValueMember = "Id";
            cBxMarca.DisplayMember = "Descripcion";
            cBxMarca.DataSource = marca.listarMarcas();
            cBxMarca.SelectedIndex = -1;

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //Cuando se cierra la ventana de agregar, retorna null.
            if (dgvArticulos.CurrentRow == null)
            {
                return;
            }
            //seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Seleccionado();
            cargarImagen(pBxInfo, seleccionado.UrlImagen);
            lblCodigoInfo.Text = seleccionado.Codigo;
            lblCategoriaInfo.Text = seleccionado.Categoria.Descripcion;
            lblMarcaInfo.Text = seleccionado.Marca.Descripcion;
            string precio = $"{seleccionado.Precio}";
            lblPrecioInfo.Text = precio;
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaArticulosFiltrados = new List<Articulo>();
            string articulo = txtBuscar.Text;
            if (articulo != "" && articulo != "Buscar")
            {
                listaArticulosFiltrados = articulos.FindAll(art => art.Nombre.ToLower().Contains(articulo.ToLower()) || art.Categoria.Descripcion.ToLower().Contains(articulo.ToLower()) || art.Marca.Descripcion.ToLower().Contains(articulo.ToLower()) || art.Codigo.ToLower().Contains(articulo.ToLower()));
            }
            else
            {
                listaArticulosFiltrados = articulos;
            }

            dgvNewDataSource(dgvArticulos, listaArticulosFiltrados);
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "  Buscar")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                txtBuscar.Text = "  Buscar";
                dgvNewDataSource(dgvArticulos, articulos);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
            cargarDgv();
            
        }
        private void dgvArticulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            verDetalle();

        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //ArticuloNegocio eliminar = new ArticuloNegocio();
            string nombre = seleccionado.Nombre;
            DialogResult resultado = MessageBox.Show($"¿Deseas eliminar {nombre}? Nota: Podrás recuperar el elemento, haciendo clic en la Papelera. Pero se eliminarán definitivamente una vez que cierres la aplicación. ",$"Eliminando {nombre}...",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
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
            frmAgregar ventanaModificar = new frmAgregar(seleccionado);
            ventanaModificar.ShowDialog();
            cargarDgv();
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
            if (articulosEliminados != null && articulosEliminados.Count != 0)
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

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            verDetalle();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cBxCategoria.SelectedIndex != -1 || cBxMarca.SelectedIndex != -1)
            {
                string Marca = "";
                string Categoria = "";
                List<Articulo> listaFiltro = new List<Articulo>();

                if (cBxMarca.SelectedIndex != -1 && cBxCategoria.SelectedIndex != -1)
                {
                    Marca = cBxMarca.SelectedItem.ToString();
                    Categoria = cBxCategoria.SelectedItem.ToString();

                    listaFiltro = articulos.FindAll(art => art.Categoria.Descripcion.Contains(Categoria) && art.Marca.Descripcion.Contains(Marca));
                }
                else if(cBxCategoria.SelectedIndex != -1)
                {
                    Categoria = cBxCategoria.SelectedItem.ToString();

                    listaFiltro = articulos.FindAll(art => art.Categoria.Descripcion.Contains(Categoria));
                }
                else
                {
                    Marca = cBxMarca.SelectedItem.ToString();
                    listaFiltro = articulos.FindAll(art => art.Marca.Descripcion.Contains(Marca));
                }

                dgvNewDataSource(dgvArticulos, listaFiltro);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio para filtrar.");
            }
        }

        private void btnQuitarCriterios_Click(object sender, EventArgs e)
        {
            if (cBxCategoria.SelectedIndex != -1 || cBxMarca.SelectedIndex != -1)
            {
                cBxMarca.SelectedIndex = -1;
                cBxCategoria.SelectedIndex = -1;
                dgvNewDataSource(dgvArticulos, articulos);
            }
        }

        private void btnEliminarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "  Buscar";
            dgvNewDataSource(dgvArticulos, articulos);
        }

    }
}
