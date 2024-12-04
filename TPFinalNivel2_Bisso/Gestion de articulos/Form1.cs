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
            Articulo articuloDetalle=(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            formDetalle form = new formDetalle(articuloDetalle);
            form.ShowDialog();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conexion=new Conexion();
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            conexion.EliminarArticulo(articulo);
            Helper.Helper.CargarCatalogo(dgvArticulos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar form = new Agregar();
            form.ShowDialog();
            Helper.Helper.CargarCatalogo(dgvArticulos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Modificar form = new Modificar(articulo);
            form.ShowDialog(this);
            Helper.Helper.CargarCatalogo(dgvArticulos);
        }
    }
}
