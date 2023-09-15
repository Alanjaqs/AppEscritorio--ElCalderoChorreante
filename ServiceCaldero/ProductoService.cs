using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominioCaldero;

namespace ServiceCaldero
{
    public class ProductoService
    {
        public List<Productos> Listar(int alta)
        {
            List<Productos> lista = new List<Productos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select p.ProductoID, p.NombreProd, p.Descripcion, p.CategoriaProd, c.NombreCat as Categoria, p.ImagenProd, p.Precio, p.Stock from Productos p, Categorias c where p.CategoriaProd = c.CategoriaID AND ActSN = " + alta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();
                    aux.Id = (int)datos.Lector["ProductoID"];
                    aux.Nombre = (string)datos.Lector["NombreProd"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCat = (int)datos.Lector["CategoriaProd"];
                    aux.Categoria.NombreCat = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenProd"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
            return lista;

        }

        public List<Productos> ListarConFiltro(int catID)
        {
            List<Productos> lista = new List<Productos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select p.ProductoID, p.NombreProd, p.Descripcion, p.CategoriaProd, c.NombreCat as Categoria, p.ImagenProd, p.Precio, p.Stock from Productos p, Categorias c WHERE p.CategoriaProd = c.CategoriaID AND ActSN = 1 AND p.CategoriaProd = " + catID);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();
                    aux.Id = (int)datos.Lector["ProductoID"];
                    aux.Nombre = (string)datos.Lector["NombreProd"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCat = (int)datos.Lector["CategoriaProd"];
                    aux.Categoria.NombreCat = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenProd"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
            return lista;

        }

        public List<Productos> ListarConDetalle(int prodID)
        {
            List<Productos> lista = new List<Productos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select p.ProductoID, p.NombreProd, p.Descripcion, p.CategoriaProd, c.NombreCat as Categoria, p.ImagenProd, p.Precio, p.Stock from Productos p, Categorias c WHERE p.CategoriaProd = c.CategoriaID AND ActSN = 1 AND p.ProductoID = " + prodID);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();
                    aux.Id = (int)datos.Lector["ProductoID"];
                    aux.Nombre = (string)datos.Lector["NombreProd"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCat = (int)datos.Lector["CategoriaProd"];
                    aux.Categoria.NombreCat = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenProd"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
            return lista;

        }



        public void AgregarModificarProducto(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public void EliminarProducto(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }
}
