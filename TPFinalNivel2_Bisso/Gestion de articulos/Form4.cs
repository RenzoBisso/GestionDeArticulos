using Base_de_datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_articulos
{
    public partial class Modificar : Form
    {
        private Articulo articulo;
        public Modificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            
            cboBoxCategoria.DataSource = conexion.ListarCategoria();
            cboBoxCategoria.ValueMember = "IdCategoria";
            cboBoxCategoria.DisplayMember = "DescripcionCategoria";
            cboBoxMarca.DataSource = conexion.ListarMarca();
            cboBoxMarca.ValueMember = "IdMarca";
            cboBoxMarca.DisplayMember = "DescripcionMarca";

            lblIdValor.Text=articulo.Id.ToString();
            txtBoxCodigo.Text=articulo.CodigoArticulo.ToString();
            txtBoxDescripcion.Text=articulo.Descripcion.ToString();
            txtBoxNombre.Text=articulo.Nombre.ToString();
            txtBoxPrecio.Text=articulo.Precio.ToString();
            txtBoxUrlImagen.Text=articulo.UrlImagen.ToString();
            cboBoxCategoria.SelectedValue=articulo.Categoria.IdCategoria;
            cboBoxMarca.SelectedValue=articulo.Marca.IdMarca;
            Helper.Helper.MostrarImagen(articulo.UrlImagen, pbxArticulo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Articulo articulo = new Articulo();
            Marca marca = new Marca();
            Categoria categoria = new Categoria();
            try
            {
                articulo.Id = int.Parse(lblIdValor.Text);
                articulo.CodigoArticulo = txtBoxCodigo.Text;
                articulo.Descripcion = txtBoxDescripcion.Text;
                articulo.Nombre = txtBoxNombre.Text;
                articulo.Categoria = (Categoria)cboBoxCategoria.SelectedItem;
                articulo.Marca = (Marca)cboBoxMarca.SelectedItem;
                articulo.UrlImagen = txtBoxUrlImagen.Text;
                bool esPrecioValido = Helper.Helper.VerificarTxtPrecio(txtBoxPrecio);
                if (!esPrecioValido)
                {
                    return;
                }
                conexion.AgregarArticulo(articulo);

                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
            }
            catch (Exception)
            {

                throw;
            }
           
            
            articulo.Precio=decimal.Parse(txtBoxPrecio.Text);
            

            conexion.ModificarArticulo(articulo);
            Close();
        }

        private void txtBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            Helper.Helper.MostrarImagen(articulo.UrlImagen, pbxArticulo);
        }
    }
}
