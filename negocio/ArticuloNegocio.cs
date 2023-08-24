using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("select A.Id Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdCategoria, A.IdMarca from ARTICULOS A, CATEGORIAS C, MARCAS M where IdCategoria = C.Id AND IdMarca = M.Id");
                datos.ejecutarLector();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(articulo);
                }
                               
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Articulo> listarArticulos(List<Articulo> articulos)
        {
            List<Articulo> lista = new List<Articulo>();
            List<int> idlista = new List<int>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                foreach (Articulo articulo in articulos)
                {
                    idlista.Add(articulo.Id);
                }
                string consulta = "select A.Id Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdCategoria, A.IdMarca from ARTICULOS A, CATEGORIAS C, MARCAS M where IdCategoria = C.Id AND IdMarca = M.Id";
                string extension = "";
                foreach (int Id in idlista)
                {
                    extension += $" AND A.Id != {Id}";
                }
                consulta += extension;
                
                datos.setQuery(consulta);
                datos.ejecutarLector();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void agregar(Articulo nuevoArticulo) {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImgUrl, @Precio )");
                datos.setParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.setParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setParametro("@ImgUrl", nuevoArticulo.UrlImagen);
                datos.setParametro("@Precio", nuevoArticulo.Precio);
                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally { datos.cerrarConexion();}
        }
        public void modificar(Articulo articulo) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @UrlImagen, Precio = @precio where Id = @id");
                datos.setParametro("@codigo", articulo.Codigo);
                datos.setParametro("@nombre", articulo.Nombre);
                datos.setParametro("@descripcion", articulo.Descripcion);
                datos.setParametro("@idMarca", articulo.Marca.Id);
                datos.setParametro("@idCategoria", articulo.Categoria.Id);
                datos.setParametro("@UrlImagen", articulo.UrlImagen);
                datos.setParametro("@precio", articulo.Precio);
                datos.setParametro("@id", articulo.Id);
                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminar(int id) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery($"delete from ARTICULOS where Id = {id}");
                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { datos.cerrarConexion(); }

        }
        /*
        public List<Articulo> filtrar(int id, bool marca = false)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca AND IdCategoria = C.Id AND ";
                if (marca)
                {
                    consulta += "IdMarca = @idMarca";
                    datos.setQuery(consulta);
                    datos.setParametro("@idMarca", id);
                }
                else
                {
                    consulta += "IdCategoria = @idCategoria";
                    datos.setQuery(consulta);
                    datos.setParametro("@idCategoria", id);
                }
                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
        */
    }
}
