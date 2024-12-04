using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Windows.Forms;
using Base_de_datos;

namespace Helper
{
    public static class Helper
    {

        public static void MostrarImagen(string imagen, PictureBox pbxImagen)
        {

            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagen.Load("https://png.pngtree.com/png-clipart/20190705/original/pngtree-gallery-vector-icon-png-image_4279297.jpg");
                
            }
        }
        public static void CargarCatalogo(DataGridView dgvArticulos)
        {
            Conexion conexion = new Conexion();
            List<Articulo> lista = conexion.ListarArticulos();
            dgvArticulos.DataSource = lista;
            dgvArticulos.Columns.RemoveAt(5);
        }

    }
}
