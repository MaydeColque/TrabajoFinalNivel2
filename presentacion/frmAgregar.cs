using modelo;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using static presentacion.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace presentacion
{
    public partial class frmAgregar : Form
    {
        private bool banderaTxtUrlImagenEnter = true;
        private Articulo articulo = null;
        private bool camposCompletados = false;
        //private OpenFileDialog archivo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articuloModificar)
        {
            InitializeComponent();
            articulo = articuloModificar;
            this.Text = "Modificar datos del Artículo";
        }
        //Metodos
        
        private void restablecerElementos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtPrecio.BackColor = txtDescripcion.BackColor;
            txtUrlImagen.Text = "Url...";
            estiloUrl();
            txtDescripcion.Text = "";
            cBxCategoria.SelectedIndex = -1;
            cBxMarca.SelectedIndex = -1;
            lblFormatAlert.Visible = false;
            lblAlertCategoriaNoSelec.Visible = false;
            lblAlertMarcaNoSelec.Visible = false;
            lblAlertNombre.Visible = false;
            lblAlertCodigo.Visible = false;
        }
        private void estiloUrl()
        {
            //Cambia el color de la fuente a Azul y lo subraya de la label txtUrlImagen.
            txtUrlImagen.ForeColor = Color.DarkBlue;
            Font fuenteActual = txtUrlImagen.Font;
            Font fuenteSubrayado = new Font(fuenteActual.FontFamily, fuenteActual.Size, FontStyle.Underline);
            txtUrlImagen.Font = fuenteSubrayado;
        }
        private void verificarCampos()
        {
            //Verifica que los campos obligatorios estén completados...
            if (txtCodigo.Text == "")
            {
                lblAlertCodigo.Visible = true;
            }
            else if (txtPrecio.Text == "" || esTexto(txtPrecio.Text))
            {
                alertaTexto();
            }
            else if (txtNombre.Text == "")
            {
                lblAlertNombre.Visible = true;
            }
            else if (txtUrlImagen.Text == "Url...")
            {
                lblUrlImagen.Text = "";
            }
            else if (cBxCategoria.SelectedItem == null)
            {
                lblAlertCategoriaNoSelec.Visible = true;
            }
            else if (cBxMarca.SelectedItem == null)
            {

                lblAlertMarcaNoSelec.Visible = true;
            }
            else
            {
                camposCompletados = true;
            }
        }
        private bool esTexto(string cadena)
        {
            //Revisa si hay algún ítem que sea texto. Permite el ingreso del punto.
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter) && caracter != '.')
                {
                    return true;
                }
            }
            return false;
        }
        private void alertaTexto()
        {
            // Muestra el alert: si esta vacío notifica que se debe poner un precio sino avisa que solo se permiten números.
            txtPrecio.BackColor = Color.LightCoral;
            lblFormatAlert.Visible = true;
            if (txtPrecio.Text == "")
            {
                lblFormatAlert.Text = "Ingrese un precio";
            }
            else
            {
                lblFormatAlert.Text = "Solo números...";
            }
        }

        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if (articulo == null)
            {
                articulo = new Articulo();
            }
            verificarCampos();
            if (camposCompletados)
            {
                //Solo si se han completado los campos obligatorios, los datos del articulo se guardan y se agrega.
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cBxCategoria.SelectedItem;
                articulo.Marca = (Marca)cBxMarca.SelectedItem;

                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);
                    DialogResult resultado = MessageBox.Show("¿Deseas agregar más artículos?", "Nuevo Artículo Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        restablecerElementos();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo Modificado.", "Modificación Exitosa.");
                    Close();
                }
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                cBxCategoria.DataSource = categoriaNegocio.listarCategorias();
                cBxCategoria.ValueMember = "Id";
                cBxCategoria.DisplayMember = "Descripcion";
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cBxMarca.DataSource = marcaNegocio.listarMarcas();
                cBxMarca.ValueMember = "Id";
                cBxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {

                    txtNombre.Text = articulo.Nombre;
                    txtCodigo.Text = articulo.Codigo;
                    txtPrecio.Text = $"{articulo.Precio}";
                    txtUrlImagen.Text = articulo.UrlImagen;
                    estiloUrl();
                    txtDescripcion.Text = articulo.Descripcion;
                    cBxCategoria.SelectedItem = articulo.Categoria.Id;
                    cBxMarca.SelectedItem = articulo.Marca.Id;
                }
                else
                {
                    cBxCategoria.SelectedIndex = -1;
                    cBxMarca.SelectedIndex = -1;
                    cargarImagen(pictureBox, "");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        private void txtUrlImagen_Enter(object sender, EventArgs e)
        {
            if (banderaTxtUrlImagenEnter)
            {
                //Solo pone en blanco este campo una vez.
                banderaTxtUrlImagenEnter = false;
                txtUrlImagen.Text = "";
            }
            //Cambia el color de la fuente a Azul y lo subraya.
            estiloUrl();
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {

            cargarImagen(pictureBox, txtUrlImagen.Text);
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "png|*.png |jpg|*.jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(pictureBox, archivo.FileName);
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            //Manejo de FORMATEXCEPTION, edita el formato para el ingreso de número con .00
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                //Solo guarda el precio si tiene este formato 000.00 o si es un número.
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                txtPrecio.BackColor = Color.LightGreen;
                lblFormatAlert.Visible = false;
            }
            catch (FormatException)
            {
                alertaTexto();
            }
        }
    }
}
