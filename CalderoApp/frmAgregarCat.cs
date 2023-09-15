using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DominioCaldero;
using ServiceCaldero;


namespace CalderoApp
{
    public partial class frmAgregarCat : Form
    {
        CategoriaService service = new CategoriaService();
        OpenFileDialog archivo = null;
        bool imagen = false;
        public frmAgregarCat()
        {
            InitializeComponent();
        }

        private void chequearImagenCat(bool img)
        {
            if (img == true)
            {
                imagen = true;
            }
        }
        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCat_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            // Validacion para que no haya ningun textbox vacio
            if (txtAgregarNombreCat.Text != "" && txtAgregarImagenCat.Text != "")
            {
                try
                {
                    categoria.NombreCat = txtAgregarNombreCat.Text;
                    categoria.ImagenCat = txtAgregarImagenCat.Text;

                    // Guardar imagen localmente cuando se presiona el boton aceptar
                    if (archivo != null && !(txtAgregarImagenCat.Text.ToUpper().Contains("HTTP")) && !(File.Exists(ConfigurationManager.AppSettings["CategoriasFotosWeb"] + archivo.SafeFileName)))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["CategoriasFotosWeb"] + archivo.SafeFileName);
                        chequearImagenCat(true);

                    }
                    // Da el OK si nunca se intento agregar imagen local y se utilizo URL)
                    else if (archivo == null && txtAgregarImagenCat.Text.ToUpper().Contains("HTTP"))
                        chequearImagenCat(true);

                    if(imagen == true)
                    {
                        categoria.ImagenCat = ConfigurationManager.AppSettings["CategoriasFotosWeb"] + archivo.SafeFileName;
                        pboxImagenAgrCat.ImageLocation = categoria.ImagenCat;

                        service.AgregarModificarCategoria("insert into Categorias(NombreCat, ImagenCat) values ('" + categoria.NombreCat + "', '" + categoria.ImagenCat + "')");
                        MessageBox.Show("Categoria agregada exitosamente");
                        Close();
                    }
                    else if (imagen == false)
                    {
                        MessageBox.Show("Ya existe una categoria con esta imagen, por favor elija otra imagen");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                if(txtAgregarNombreCat.Text == "")
                   MessageBox.Show("Falta completar el nombre de la categoria");
                else if(txtAgregarImagenCat.Text == "")
                    MessageBox.Show("Falta agregar la imagen de la categoria");

            }
            
        }


        private void btnAgregarImagenCat_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtAgregarImagenCat.Text = archivo.FileName;
                pboxImagenAgrCat.ImageLocation = archivo.FileName;

            }
            else
            {
                archivo = null;
            }
        }

    }
}
