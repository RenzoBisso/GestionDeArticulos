﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Modelos;
using System.Data.SqlTypes;
using System.Globalization;



namespace Base_de_datos
{
    public class Conexion
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public Conexion()
        {
            conexion =new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void setQuery(string consulta)
        {
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText=consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector=comando.ExecuteReader();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }


        public List<Marca> ListarMarca()
        {
            List<Marca> lista = new List<Marca>();
            Conexion conexion = new Conexion();
            conexion.setQuery("select Id, Descripcion from MARCAS;");
            conexion.ejecutarLectura();
            while (conexion.Lector.Read())
            {
                Marca marca = new Marca();
                marca.IdMarca = (int)conexion.Lector["Id"];
                marca.DescripcionMarca = (string)conexion.Lector["Descripcion"];
                lista.Add(marca);
            }
            conexion.cerrarConexion();
            return lista;
        }

        public List<Categoria> ListarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            Conexion conexion = new Conexion();
            conexion.setQuery("select Id, Descripcion from CATEGORIAS;");
            conexion.ejecutarLectura();
            while (conexion.Lector.Read())
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria = (int)conexion.Lector["Id"];
                categoria.DescripcionCategoria = (string)conexion.Lector["Descripcion"];
                lista.Add(categoria);
            }
            conexion.cerrarConexion();
            return lista;
        }
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            Conexion conexion = new Conexion();
            conexion.setQuery("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion AS ArticuloDescripcion, A.ImagenUrl, A.Precio, C.Descripcion AS CategoriaDescripcion, M.Descripcion AS MarcaDescripcion, A.IdMarca, A.IdCategoria FROM ARTICULOS AS A INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id INNER JOIN MARCAS AS M ON A.IdMarca = M.Id;");
            conexion.ejecutarLectura();

            while (conexion.Lector.Read())
            {
                Articulo articulo = new Articulo();
                articulo.Marca = new Marca();
                articulo.Id = (int)conexion.Lector["Id"];
                if (!(conexion.Lector["IdMarca"] is DBNull))
                    articulo.Marca.IdMarca = (int)conexion.Lector["IdMarca"];
                if (!(conexion.Lector["MarcaDescripcion"] is DBNull))
                    articulo.Marca.DescripcionMarca = (string)conexion.Lector["MarcaDescripcion"];
                articulo.Categoria = new Categoria();
                if (!(conexion.Lector["IdCategoria"] is DBNull))
                    articulo.Categoria.IdCategoria = (int)conexion.Lector["IdCategoria"];
                if (!(conexion.Lector["CategoriaDescripcion"] is DBNull))
                    articulo.Categoria.DescripcionCategoria = (string)conexion.Lector["CategoriaDescripcion"];
                if (!(conexion.Lector["Nombre"] is DBNull))
                    articulo.Nombre = (string)conexion.Lector["Nombre"];
                if (!(conexion.Lector["Codigo"] is DBNull))
                    articulo.CodigoArticulo = (string)conexion.Lector["Codigo"];
                if (!(conexion.Lector["ArticuloDescripcion"] is DBNull))
                    articulo.Descripcion = (string)conexion.Lector["ArticuloDescripcion"];
                if (!(conexion.Lector["ImagenUrl"] is DBNull))
                    articulo.UrlImagen = (string)conexion.Lector["ImagenUrl"];
                if (!(conexion.Lector["Precio"] is DBNull))
                    articulo.Precio = (decimal)conexion.Lector["Precio"];
                
                lista.Add(articulo);
                }

                conexion.cerrarConexion();
            return lista;
        }

        public List<Articulo> ListarArticulos(string columna,string criterio)
        {
            List<Articulo>lista=new List<Articulo>();
            Conexion conexion = new Conexion();
            // Define las columnas válidas y sus correspondientes alias
            string aliasTabla = string.Empty;
            string columnaFiltro = string.Empty;

            // Asignar el alias y la columna a filtrar según la opción elegida
            if (columna == "Categoria")
            {
                aliasTabla = "C";
                columnaFiltro = "C.Descripcion";  // Columna para filtrar por categoría
            }
            else if (columna == "Marca")
            {
                aliasTabla = "M";
                columnaFiltro = "M.Descripcion";  // Columna para filtrar por marca
            }
            else if (columna == "Codigo")
            {
                aliasTabla = "A";
                columnaFiltro = "A.Codigo";  // Columna para filtrar por código
            }
            else if (columna == "Nombre")
            {
                aliasTabla = "A";
                columnaFiltro = "A.Nombre";  // Columna para filtrar por nombre
            }

            conexion.setQuery($"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion AS ArticuloDescripcion, A.ImagenUrl, A.Precio, " +
                   $"C.Descripcion AS CategoriaDescripcion, M.Descripcion AS MarcaDescripcion, A.IdMarca, A.IdCategoria " +
                   $"FROM ARTICULOS AS A " +
                   $"INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id " +
                   $"INNER JOIN MARCAS AS M ON A.IdMarca = M.Id " +
                   $"WHERE {columnaFiltro} LIKE @criterio;");

            conexion.setParametro("@criterio", "%" + criterio + "%");
            conexion.ejecutarLectura();

            while (conexion.Lector.Read())
            {

                Articulo articulo = new Articulo();
                articulo.Marca=new Marca();
        
                articulo.Id = (int)conexion.Lector["Id"];
                if (!(conexion.Lector["IdMarca"] is DBNull))
                    articulo.Marca.IdMarca = (int)conexion.Lector["IdMarca"];
                if (!(conexion.Lector["MarcaDescripcion"] is DBNull))
                    articulo.Marca.DescripcionMarca = (string)conexion.Lector["MarcaDescripcion"];
                articulo.Categoria = new Categoria();
                if (!(conexion.Lector["IdCategoria"] is DBNull))
                    articulo.Categoria.IdCategoria = (int)conexion.Lector["IdCategoria"];
                if (!(conexion.Lector["CategoriaDescripcion"] is DBNull))
                    articulo.Categoria.DescripcionCategoria = (string)conexion.Lector["CategoriaDescripcion"];
                if (!(conexion.Lector["Nombre"] is DBNull))
                    articulo.Nombre = (string)conexion.Lector["Nombre"];
                if (!(conexion.Lector["Codigo"] is DBNull))
                    articulo.CodigoArticulo = (string)conexion.Lector["Codigo"];
                if (!(conexion.Lector["ArticuloDescripcion"] is DBNull))
                    articulo.Descripcion = (string)conexion.Lector["ArticuloDescripcion"];
                if (!(conexion.Lector["ImagenUrl"] is DBNull))
                    articulo.UrlImagen = (string)conexion.Lector["ImagenUrl"];
                if (!(conexion.Lector["Precio"] is DBNull))
                    articulo.Precio = (decimal)conexion.Lector["Precio"];

                lista.Add(articulo);
            }
            conexion.cerrarConexion();
            return lista;
        }



        public void setParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void EliminarArticulo(Articulo articulo)
        {
            Conexion conexion = new Conexion();
            conexion.setQuery($"delete from ARTICULOS where Id='{articulo.Id}';");
            conexion.ejecutarLectura();
            conexion.cerrarConexion();
        }

        public void AgregarArticulo(Articulo articulo)
        {
            Conexion conexion = new Conexion();
            conexion.setQuery($"INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) " +
                  $"VALUES ('{articulo.CodigoArticulo}', '{articulo.Nombre}', '{articulo.Descripcion}', " +
                  $"{articulo.Marca.IdMarca}, {articulo.Categoria.IdCategoria}, '{articulo.UrlImagen}', {articulo.Precio});");

            conexion.ejecutarLectura();
            conexion.cerrarConexion();
        }

        public void ModificarArticulo(Articulo articulo)
        {
            Conexion conexion = new Conexion();
            conexion.setQuery(
                @"UPDATE ARTICULOS 
          SET Codigo = @codigo, 
              Nombre = @nombre, 
              Descripcion = @desc, 
              IdMarca = @marca, 
              IdCategoria = @categoria, 
              ImagenUrl = @urlImagen, 
              Precio = @precio  
          WHERE Id = @id;"
            );

            // Asignar parámetros
            conexion.setParametro("@codigo", articulo.CodigoArticulo);
            conexion.setParametro("@nombre", articulo.Nombre);
            conexion.setParametro("@desc", articulo.Descripcion);
            conexion.setParametro("@marca", articulo.Marca.IdMarca);
            conexion.setParametro("@categoria", articulo.Categoria.IdCategoria);
            conexion.setParametro("@urlImagen", articulo.UrlImagen);
            conexion.setParametro("@precio", articulo.Precio);
            conexion.setParametro("@id", articulo.Id);

            // Ejecutar la consulta
            conexion.ejecutarLectura();
            conexion.cerrarConexion();
        }

    }
}
