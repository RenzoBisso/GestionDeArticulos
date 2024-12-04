using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }



        public override string ToString()
        {
            return $"CODIGO ARTICULO: {CodigoArticulo}\n" +
                   $"NOMBRE: {Nombre}\n" +
                   $"DESCRIPCION: {Descripcion}\n" +
                   $"MARCA: {Marca.DescripcionMarca}\n" +
                   $"CATEGORIA: {Categoria.DescripcionCategoria}\n" +
                   $"PRECIO: {Precio}";
        }

    }
}
