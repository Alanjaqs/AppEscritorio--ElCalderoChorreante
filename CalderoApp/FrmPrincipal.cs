using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using DominioCaldero;
using ServiceCaldero;


namespace CalderoApp
{
    public partial class frmPrincipal : Form
    {
        Productos seleccionado = new Productos();
        ProductoService service = new ProductoService();
        CategoriaService serviceCat = new CategoriaService();   

        List<Productos> listaProductos = new List<Productos>();
        

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarForm();
        }

        public void CargarForm()
        {
            try
            {
                dgvProductos.DataSource = service.Listar(1);

                // Lista para usar en filtros
                listaProductos = service.Listar(1);

                // ComboBox para filtros
                cmbFiltroCat.DataSource = serviceCat.ListarCat();
                cmbFiltroCat.ValueMember = "IdCat";
                cmbFiltroCat.DisplayMember = "NombreCat";

                // Ocultar columnas
                dgvProductos.Columns["Id"].Visible = false;
                dgvProductos.Columns["Imagen"].Visible = false;
                dgvProductos.Columns["ActInac"].Visible = false;

                pboxProd.ImageLocation = seleccionado.Imagen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.ShowDialog();
            CargarForm();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            seleccionado = (Productos)dgvProductos.CurrentRow.DataBoundItem;
            pboxProd.ImageLocation = seleccionado.Imagen;

        }

        private void btnEliminarDef_MouseClick(object sender, MouseEventArgs e)
        {
            //seleccionado = (Productos)dgvProductos.CurrentRow.DataBoundItem;
            if(dgvProductos.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Estás eliminando " + seleccionado.Nombre + " ¿Estás seguro/a?", "Eliminando..", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Eliminacion de la imagen si es local
                    if(!seleccionado.Imagen.ToUpper().Contains("HTTP"))
                    {
                        OpenFileDialog archivoPr = new OpenFileDialog();
                        archivoPr.FileName = seleccionado.Imagen;
                        File.Delete(ConfigurationManager.AppSettings["CalderoFotosApp"] + archivoPr.SafeFileName);
                    }
                    //

                    ProductoService service = new ProductoService();
                    service.EliminarProducto("delete from Productos where ProductoID = " + seleccionado.Id);
                    CargarForm();
                }
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado para eliminar");
                CargarForm();
            }
           
        }

        private void btnSinStock_Click (object sender, EventArgs e)
        {
            frmSinStock ventanaSinStock = new frmSinStock();
            ventanaSinStock.ShowDialog();
            CargarForm();
        }

        private void btnDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Estás dando de baja " + seleccionado.Nombre + " ¿Estás seguro/a?", "Dando de baja..", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    service.AgregarModificarProducto("update Productos set ActSN = 0 where ProductoID = " + seleccionado.Id);
                    MessageBox.Show("Producto dado de baja");
                    CargarForm();
                }
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado para dar de baja");
                CargarForm();
            }

        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                frmAgregar ventanaModificar = new frmAgregar(seleccionado);
                ventanaModificar.ShowDialog();
                CargarForm();
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado para modificar");
                CargarForm();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventanaCategorias = new frmCategorias();
            ventanaCategorias.ShowDialog();
            CargarForm();
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Productos> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro != "" && filtro.Length >= 3)
            {
                listaFiltrada = listaProductos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaProductos;
            }

         
            dgvProductos.DataSource = listaFiltrada;

            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["Imagen"].Visible = false;
            dgvProductos.Columns["ActInac"].Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Productos> listaFiltradaCat;
            string filtro = cmbFiltroCat.SelectedValue.ToString();

            listaFiltradaCat = listaProductos.FindAll(x => x.Categoria.IdCat.ToString() == filtro);

            dgvProductos.DataSource = listaFiltradaCat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = listaProductos;
        }
    }

}
