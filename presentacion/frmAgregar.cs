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

namespace presentacion
{
    public partial class frmAgregar : Form
    {
        private string codigo;
        private string nombre;
        private string precio;
        private string urlImagen;
        private string descripcion;
        private int categoria;
        private int marca;
        public frmAgregar()
        {
            InitializeComponent();
        }
        //Metodos
        private void inicializarElementos()
        {
            codigo = txtCodigo.Text;
            nombre = txtNombre.Text;
            precio = txtPrecio.Text;
            urlImagen = txtUrlImagen.Text;
            descripcion = txtDescripcion.Text;
            categoria = cBxCategoria.SelectedIndex;
            marca = cBxMarca.SelectedIndex;
        }
        private void restrablecerElementos()
        {
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtPrecio.Text = precio;
            txtPrecio.BackColor = txtCodigo.BackColor;
            lblFormatAlert.Visible = false;
            txtUrlImagen.Text = urlImagen;
            txtDescripcion.Text = descripcion;
            cBxCategoria.SelectedIndex = categoria;
            cBxMarca.SelectedIndex = marca;

        }

        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevoArticulo = new Articulo();
            //Manejo de EXCEPTION aquí, editar formato para el ingreso de número con .00
            try
            {
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);
            }
            catch (FormatException ex)
            {
                if (txtPrecio.Text is string)
                {
                    txtPrecio.BackColor = Color.LightCoral;
                    lblFormatAlert.Visible = true;
                    return;
                }
                else
                {
                    nuevoArticulo.Precio = formatoPrecio(txtPrecio.Text);
                }

            }

            if (txtCodigo.Text == "")
            {
                lblAlertCodigo.Visible = true;
                return;
            }
            else if (txtNombre.Text == "")
            {
                lblAlertNombre.Visible = true;
                return;
            }
            else if (txtUrlImagen.Text == "Url...")
            {
                lblUrlImagen.Text = "";
            }
            else if (cBxCategoria.SelectedItem == null)
            {
                lblAlertCategoriaNoSelec.Visible = true;
                return;
            }
            else if (cBxMarca.SelectedIndex < 0)
            {

                lblAlertMarcaNoSelec.Visible = true;
                return;
            }
            else
            {
                //Solo si las anteriores validaciones validaciones son falsas estas lineas se ejecutan.
                nuevoArticulo.Categoria = (Categoria)cBxCategoria.SelectedItem;
                nuevoArticulo.Marca = (Marca)cBxMarca.SelectedItem;
            }
            

            nuevoArticulo.Codigo = txtCodigo.Text;
            nuevoArticulo.Nombre = txtNombre.Text;
            nuevoArticulo.UrlImagen = txtUrlImagen.Text;
            nuevoArticulo.Descripcion = txtDescripcion.Text;
            negocio.agregar(nuevoArticulo);
            DialogResult resultado = MessageBox.Show("¿Deseas agregar más articulos?","Nuevo articulo guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == DialogResult.Yes)
            {
                restrablecerElementos();
            }
            else
            {
                Close();
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            
            cBxCategoria.DataSource = categoriaNegocio.listarCategorias();
            cBxCategoria.ValueMember = "Id";
            cBxCategoria.DisplayMember = "Descripcion";
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            cBxMarca.DataSource = marcaNegocio.listarMarcas();
            cBxMarca.ValueMember = "Id";
            cBxMarca.DisplayMember = "Descripcion";
            


            cBxCategoria.SelectedIndex = -1;
            cBxMarca.SelectedIndex = -1;
            inicializarElementos();
            cargarImagen(pictureBox, "");

        }
        
        private bool bandera = true;
        private void txtUrlImagen_Enter(object sender, EventArgs e)
        {
            if (bandera)
            {
                //Solo pone en blanco este campo una vez.
                bandera = false;
                txtUrlImagen.Text = "";
            }
            //Cambia el color de la fuente a Azul y lo subraya.
            txtUrlImagen.ForeColor = Color.DarkBlue;
            Font fuenteActual = txtUrlImagen.Font;
            Font fuenteSubrayado = new Font(fuenteActual.FontFamily,fuenteActual.Size, FontStyle.Underline);
            txtUrlImagen.Font = fuenteSubrayado;
            //cargarImagen(pictureBox,txtUrlImagen.Text);
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
    }
}
