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
    public partial class frmCategorias : Form
    {
        Categoria seleccionadoCat = new Categoria();
        CategoriaService serviceCat = new CategoriaService();


        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarFormCat();
        }

        public void CargarFormCat()
        {
            try
            {
                dgvCategorias.DataSource = serviceCat.ListarCat();
                dgvCategorias.Columns["IdCat"].Visible = false;
                dgvCategorias.Columns["ImagenCat"].Visible = false;
                lblCat.Text = seleccionadoCat.NombreCat;
                pboxCat.ImageLocation = seleccionadoCat.ImagenCat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            seleccionadoCat = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            lblCat.Text = seleccionadoCat.NombreCat;
            pboxCat.ImageLocation = seleccionadoCat.ImagenCat;

        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmAgregarCat ventanaAgregarCat = new frmAgregarCat();
            ventanaAgregarCat.ShowDialog();
            CargarFormCat();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Estás eliminando " + seleccionadoCat.NombreCat + " ¿Estás seguro/a?", "Eliminando..", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!seleccionadoCat.ImagenCat.ToUpper().Contains("HTTP"))
                    {
                        OpenFileDialog archivoCat = new OpenFileDialog();
                        archivoCat.FileName = seleccionadoCat.ImagenCat;
                        File.Delete(ConfigurationManager.AppSettings["CategoriasFotosWeb"] + archivoCat.SafeFileName);
                    }

                    serviceCat.EliminarCategoria("delete from Categorias where CategoriaID = " + seleccionadoCat.IdCat);
                    CargarFormCat();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna categoria seleccionada para eliminar");
                CargarFormCat();
            }
        }
    }
}
