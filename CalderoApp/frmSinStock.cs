using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominioCaldero;
using ServiceCaldero;

namespace CalderoApp
{
    public partial class frmSinStock : Form
    {
        Productos seleccionado = new Productos();
        ProductoService service = new ProductoService();
        public frmSinStock()
        {
            InitializeComponent();
        }

        public void CargarFormSinStock()
        {

            dgvSinStock.DataSource = service.Listar(0);

            dgvSinStock.Columns["Id"].Visible = false;
            dgvSinStock.Columns["Imagen"].Visible = false;
            dgvSinStock.Columns["ActInac"].Visible = false;
            dgvSinStock.Columns["Stock"].Visible = false;
        }

        private void frmSinStock_Load(object sender, EventArgs e)
        {
            CargarFormSinStock();
        }

        private void btnCancelarSinStock_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnDarAlta_MouseClick(object sender, MouseEventArgs e)
        {
            if(dgvSinStock.CurrentRow != null)
            {
                service.AgregarModificarProducto("update Productos set ActSN = 1 where ProductoID = " + seleccionado.Id);
                MessageBox.Show("Producto dado de alta");
                CargarFormSinStock();
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado");
                CargarFormSinStock();
            }
        }

        private void dgvSinStock_SelectionChanged(object sender, EventArgs e)
        {
            seleccionado = (Productos)dgvSinStock.CurrentRow.DataBoundItem;
        }
    }
}
