using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominioCaldero;

namespace ServiceCaldero
{
    public class CategoriaService
    {
        public List<Categoria> ListarCat()
        {
            List<Categoria> listaCat = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select CategoriaID, NombreCat, ImagenCat from Categorias");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCat = (int)datos.Lector["CategoriaID"];
                    aux.NombreCat = (string)datos.Lector["NombreCat"];
                    aux.ImagenCat = (string)datos.Lector["ImagenCat"];

                    listaCat.Add(aux);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return listaCat;

        }

        public void AgregarModificarCategoria(string consulta)
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

        public void EliminarCategoria(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegurate de que no haya ningun producto con la categoria que queres eliminar");
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
