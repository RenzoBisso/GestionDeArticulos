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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Articulo articulo = new Articulo();

            try
            {
                articulo.Nombre = txtBoxNombre.Text;
                articulo.UrlImagen = txtBoxUrlImagen.Text;
                articulo.CodigoArticulo = txtBoxCodigo.Text;
                articulo.Descripcion = txtBoxDescripcion.Text;

                bool esPrecioValido = Helper.Helper.VerificarTxtPrecio(txtBoxPrecio);
                if (!esPrecioValido)
                {
                    return;
                }
                articulo.Precio = decimal.Parse(txtBoxPrecio.Text);

                articulo.Categoria = (Categoria)cboBoxCategoria.SelectedItem;
                articulo.Marca = (Marca)cboBoxMarca.SelectedItem;

                conexion.AgregarArticulo(articulo);

                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
            }
            catch (Exception)
            {

            }
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            cboBoxCategoria.DataSource=conexion.ListarCategoria();
            cboBoxMarca.DataSource=conexion.ListarMarca();
        }

        private void txtBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            Helper.Helper.MostrarImagen(txtBoxUrlImagen.Text ,pbxArticulo);
        }
    }
}
