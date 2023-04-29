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
    public partial class frmPapelera : Form
    {
        
        public frmPapelera(List<Articulo> articulos)
        {
            InitializeComponent();
            articulosEliminados = articulos;
        }

        
        private List<Articulo> articulosEliminados;
        private Articulo articuloSeleccionado;
        private int inicio = 0;



        //Dgv no permite que se eliminen filas, a menos que uses la interface IBindingList
        //Si hay una fila seleccionada, sustrae el indice de la misma y el método elimina filas según su indice.
        //dgvNombre.Rows.RemoveAt(dgvNombre.Rows.IndexOf(dgvNombre.CurrentRow));


        //métodos
        private bool ListaVacia()
        {
            if (articulosEliminados.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cargar()
        {
            if (!ListaVacia())
            {
                if (inicio == 0)
                {
                    inicio = 1;
                    dgvArticulosEliminados.DataSource = articulosEliminados;
                    configDgv();
                }
            }
            else
            {
                dgvArticulosEliminados.DataSource = null;
                cargarImagen(pictureBox, "https://tse2.mm.bing.net/th?id=OIP.kCnaSFZ5lu75SwE_r5SksQHaHa&pid=Api&P=0");
                MessageBox.Show("No hay elementos en la papelera.", "Papelera Vacía...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void configDgv()
        {
            dgvArticulosEliminados.Columns["UrlImagen"].Visible = false;
            dgvArticulosEliminados.Columns["Nombre"].Width = 210;
            dgvArticulosEliminados.Columns["Descripcion"].Width = 260;
        }
        private bool dgvVacíoOrNulo(DataGridView nombre)
        {
            if (string.IsNullOrEmpty(dgvArticulosEliminados.Rows[0].Cells[0].Value?.ToString()))
            {
                return true;
            }
            return false;
        }
        private void eliminarOrRecuperar(Articulo articulo, DataGridView dgvNombre, bool eliminar = false)
        {
            if (!dgvVacíoOrNulo(dgvNombre))
            {

                if (eliminar)
                {
                    int id = articulo.Id;
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.eliminar(id);
                    articulosEliminados.Remove(articulo);
                    dgvReiniciar(dgvNombre);
                    MessageBox.Show("El articulo se ha eliminado.");
                }
                else
                {
                    
                    articulosEliminados.Remove(articulo);
                    dgvReiniciar(dgvNombre);
                    MessageBox.Show("Articulo recuperado.");
                }
                //cargar();
            }
        }

        private void dgvReiniciar(DataGridView nombre)
        {
            if (!ListaVacia())
            {
                nombre.DataSource = null;
                nombre.DataSource = articulosEliminados;
                configDgv();
            }
        }

        //eventos

        private void dgvArticulosEliminados_SelectionChanged(object sender, EventArgs e)
        {
            ////Verifica que el dgv tenga artículos y que efectivamente haya un articulo seleccionado.
            //if (dgvVacíoOrNulo(dgvArticulosEliminados))
            //{
            //    return;
            //}
            //else if (dgvArticulosEliminados.CurrentRow == null)
            //{
            //    MessageBox.Show("Por favor, selecciona un artículo antes de realizar una acción...");
            //    return;
            //}

            //    //Problema Index 1 sin valor... Solucionado con Reiniciar el dgv...
            //    articuloSeleccionado = (Articulo)dgvArticulosEliminados.CurrentRow.DataBoundItem;
            //    cargarImagen(pictureBox, articuloSeleccionado.UrlImagen);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarOrRecuperar(articuloSeleccionado, dgvArticulosEliminados,true);
            cargar();
        }       

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            eliminarOrRecuperar(articuloSeleccionado, dgvArticulosEliminados);
            cargar();
        }

        private void frmRecuperar_Load(object sender, EventArgs e)
        {
            cargar();
            cargarImagen(pictureBox, "https://st.depositphotos.com/1537427/1889/v/950/depositphotos_18898623-stock-illustration-recycle-bin-full-of-crumpled.jpg");
        }

        private void dgvArticulosEliminados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica que el dgv tenga artículos y que efectivamente haya un articulo seleccionado.
            if (dgvVacíoOrNulo(dgvArticulosEliminados))
            {
                return;
            }
            else if (dgvArticulosEliminados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un artículo antes de realizar una acción...");
                return;
            }
            //Problema Index 1 sin valor... Solucionado con Reiniciar el dgv...
            articuloSeleccionado = (Articulo)dgvArticulosEliminados.CurrentRow.DataBoundItem;
            cargarImagen(pictureBox, articuloSeleccionado.UrlImagen);
        }
    }
}
