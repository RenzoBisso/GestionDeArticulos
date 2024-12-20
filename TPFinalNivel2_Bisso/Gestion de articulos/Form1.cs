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
using Helper;
using System.Collections;

namespace Gestion_de_articulos
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }


        private void Catalogo_Load(object sender, EventArgs e)
        {
            Helper.Helper.CargarCatalogo(dgvArticulos);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Helper.Helper.MostrarImagen(articulo.UrlImagen, pbxProductos);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No hay un artículo seleccionado para ver detalle.");
                    return;
                }


                    Conexion conexion = new Conexion();
                    Articulo articuloDetalle = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    formDetalle form = new formDetalle(articuloDetalle);
                    form.ShowDialog();

                if (articuloDetalle == null)
                    {
                        MessageBox.Show("No se pudo obtener el artículo seleccionado.");
                        return;
                    }

                    Helper.Helper.CargarCatalogo(dgvArticulos);
                
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en lugar de relanzar la excepción
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No hay un artículo seleccionado para eliminar.");
                    return;
                }

                if (MessageBox.Show("¿Estás seguro de eliminarlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();
                    Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    if (articulo == null)
                    {
                        MessageBox.Show("No se pudo obtener el artículo seleccionado.");
                        return;
                    }

                    conexion.EliminarArticulo(articulo);
                    Helper.Helper.CargarCatalogo(dgvArticulos);
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en lugar de relanzar la excepción
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar form = new Agregar();
            form.ShowDialog();
            Helper.Helper.CargarCatalogo(dgvArticulos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No hay un artículo seleccionado para ver detalle.");
                    return;
                }



                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Modificar form = new Modificar(articulo);
                form.ShowDialog(this);
                Helper.Helper.CargarCatalogo(dgvArticulos);

                if (articulo == null)
                {
                    MessageBox.Show("No se pudo obtener el artículo seleccionado.");
                    return;
                }

                Helper.Helper.CargarCatalogo(dgvArticulos);

            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en lugar de relanzar la excepción
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBoxCriterio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            string filtro = string.Empty;

            if (rbtnFiltrarPorCategoria.Checked)
                filtro = rbtnFiltrarPorCategoria.Text; // Obtiene el texto del RadioButton seleccionado
            else if (rbtnFiltrarPorCodigo.Checked)
                filtro = rbtnFiltrarPorCodigo.Text;
            else if (rbtnFiltrarPorMarca.Checked)
                filtro = rbtnFiltrarPorMarca.Text;
            else if (rbtnFiltrarPorNombre.Checked)
                filtro = rbtnFiltrarPorNombre.Text;

            if (!string.IsNullOrEmpty(filtro))
            {
                List<Articulo> lista = conexion.ListarArticulos(filtro, txtBoxCriterio.Text.ToString());
                Helper.Helper.CargarCatalogo(dgvArticulos, lista);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un filtro de búsqueda.");
            }
            txtBoxCriterio.Text = string.Empty;
        }

    }
}
