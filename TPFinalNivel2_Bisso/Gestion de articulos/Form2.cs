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
    public partial class formDetalle : Form
    {
        private Articulo articuloDetalle;

        public formDetalle(Articulo articulo)
        {
            InitializeComponent();
            articuloDetalle = articulo;
        }


        private void formDetalle_Shown(object sender, EventArgs e)
        {
            lblDetalle.Text = articuloDetalle.ToString();
            Helper.Helper.MostrarImagen(articuloDetalle.UrlImagen, pbxProductosDetalles);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
