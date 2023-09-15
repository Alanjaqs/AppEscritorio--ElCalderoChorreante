using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class frmAgregar : Form
    {
        private bool imagen = false;
        private Productos seleccionado = null;

        OpenFileDialog archivo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR SOBRECARGADO
        public frmAgregar(Productos producto)
        {
            InitializeComponent();
            seleccionado = producto;
            //btnAgregarProd.Text = "Modificar";
        }

        // LOAD DEL FORM
        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CategoriaService serviceCat = new CategoriaService();
            try
            {
                cmbAgregarCat.DataSource = serviceCat.ListarCat();
                cmbAgregarCat.ValueMember = "IdCat";
                cmbAgregarCat.DisplayMember = "NombreCat";
                //if(btnAgregarProd.Text == "Modificar")
                if (seleccionado != null)
                {
                    txtNombreProd.Text = seleccionado.Nombre;
                    txtDescripcionProd.Text = seleccionado.Descripcion;
                    txtImagenProd.Text = seleccionado.Imagen;
                    pboxAgregarProd.ImageLocation = txtImagenProd.Text;
                    cmbAgregarCat.SelectedValue = seleccionado.Categoria.IdCat;
                    txtPrecioProd.Text = seleccionado.Precio.ToString();
                    txtStockProd.Text = seleccionado.Stock.ToString();
                    chbAlta.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
              
        }

        // BOTON CANCELAR
        private void btnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        // VALIDACION PARA TEXTBOX SOLO NUMEROS
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                    return false;
            }
            return true;
        }

        // Metodo artesanal para chequear luego que una imagen existe o no en la carpeta de imagenes copiadas
        private void chequearImagen(bool img)
        {
            if (img == true)
            {
                imagen = true;
            }  
        }

        private void btnAceptarProd_MouseClick(object sender, MouseEventArgs e)
        {
            ProductoService serviceProd = new ProductoService();
            Productos producto = new Productos();

            // Agregar producto
            if (seleccionado == null)
            {
                // Validacion para que no haya ningun textbox vacio
                if(txtNombreProd.Text != "" && txtDescripcionProd.Text != "" && txtImagenProd.Text != "" && txtPrecioProd.Text != "" && txtStockProd.Text != "")
                {
                    // Validacion para que haya solo numeros en los textbox correspondientes
                    if (soloNumeros(txtPrecioProd.Text) && soloNumeros(txtStockProd.Text))
                    {
                        producto.Nombre = txtNombreProd.Text;
                        producto.Descripcion = txtDescripcionProd.Text;
                        producto.Imagen = txtImagenProd.Text;
                        producto.Categoria = (Categoria)cmbAgregarCat.SelectedItem;
                        producto.Precio = int.Parse(txtPrecioProd.Text);
                        producto.Stock = int.Parse(txtStockProd.Text);
                        producto.ActInac = chbAlta.Checked;

                        
                        // Guardar imagen localmente cuando se presiona el boton aceptar
                        if (archivo != null && !(txtImagenProd.Text.ToUpper().Contains("HTTP")) && !(File.Exists(ConfigurationManager.AppSettings["CalderoFotosWeb"] + archivo.SafeFileName)))
                        {
                            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["CalderoFotosWeb"] + archivo.SafeFileName);
                            chequearImagen(true);

                        }
                        else if(archivo == null && txtImagenProd.Text.ToUpper().Contains("HTTP"))
                            chequearImagen(true);

                        if (imagen == true)
                        {
                            producto.Imagen = ConfigurationManager.AppSettings["CalderoFotosWeb"] + archivo.SafeFileName;
                            // Dar de alta o no segun el checkbox
                            if (!producto.ActInac || producto.Stock <= 0)
                            {
                                serviceProd.AgregarModificarProducto("insert into Productos(NombreProd, Descripcion, ImagenProd, Precio, CategoriaProd, Stock, ActSN) values ( '" + producto.Nombre + "', '" + producto.Descripcion + "', '" + producto.Imagen + "', " + producto.Precio + ", " + producto.Categoria.IdCat + ", " + producto.Stock + ", 0)"); ;
                                if (producto.Stock <= 0)
                                    MessageBox.Show("Stock en 0, producto dado de baja");

                                else
                                    MessageBox.Show("Agregado exitosamente");

                                producto.ActInac = false;
                            }
                            else
                            {
                                serviceProd.AgregarModificarProducto("insert into Productos(NombreProd, Descripcion, ImagenProd, Precio, CategoriaProd, Stock, ActSN) values ( '" + producto.Nombre + "', '" + producto.Descripcion + "', '" + producto.Imagen + "', " + producto.Precio + ", " + producto.Categoria.IdCat + ", " + producto.Stock + ", 1)");
                                producto.ActInac = true;
                                MessageBox.Show("Agregado exitosamente"); ;
                            }
                            Close();
                        }
                        else if(imagen == false)
                        {
                            MessageBox.Show("Ya existe un producto con esta imagen, por favor elija otra imagen");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Completar el precio y el stock con numeros");
                    }

                
                }
                else
                {                 
                    // Validaciones mas especificas para los textbox vacios
                    if(txtNombreProd.Text == "")
                    {
                        MessageBox.Show("Falta completar el nombre");
                    }
                    else if(txtDescripcionProd.Text == "")
                    {
                        MessageBox.Show("Falta completar la descripcion");
                    }
                    else if(txtImagenProd.Text == "")
                    {
                        MessageBox.Show("Falta agregar la imagen");
                    }
                    else if (txtPrecioProd.Text == "")
                    {
                        MessageBox.Show("Falta agregar el precio");
                    }
                    else if (txtStockProd.Text == "")
                    {
                        MessageBox.Show("Falta agregar el stock");
                    }
                    
                }
           
            }
            // Modificar producto
            else
            {
                if (txtNombreProd.Text != "" && txtDescripcionProd.Text != "" && txtImagenProd.Text != "" && txtPrecioProd.Text != "" && txtStockProd.Text != "")
                {
                    if (soloNumeros(txtPrecioProd.Text) && soloNumeros(txtStockProd.Text))
                    {
                        producto.Nombre = txtNombreProd.Text;
                        producto.Descripcion = txtDescripcionProd.Text;
                        producto.Imagen = txtImagenProd.Text;
                        producto.Categoria = (Categoria)cmbAgregarCat.SelectedItem;
                        producto.Precio = int.Parse(txtPrecioProd.Text);
                        producto.Stock = int.Parse(txtStockProd.Text);

                        if (archivo != null && !(txtImagenProd.Text.ToUpper().Contains("HTTP")) && !(File.Exists(ConfigurationManager.AppSettings["CalderoFotosWeb"] + archivo.SafeFileName)))
                        {
                            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["CalderoFotosWeb"] + archivo.SafeFileName);
                            chequearImagen(true);

                        }
                        else if (archivo == null && txtImagenProd.Text.ToUpper().Contains("HTTP"))
                            chequearImagen(true);


                        if (imagen == true || archivo == null)
                        {
                            try
                            {
                                
                                if (archivo != null)
                                {
                                    producto.Imagen = ConfigurationManager.AppSettings["CalderoFotosWeb"] + archivo.SafeFileName;
                                }
                                else
                                {
                                    archivo = null;
                                }
                                
                                if (producto.Stock <= 0)
                                {
                                    serviceProd.AgregarModificarProducto("update Productos set NombreProd = '" + producto.Nombre + "',Descripcion = '" + producto.Descripcion + "',ImagenProd = '" + producto.Imagen + "',CategoriaProd = '" + producto.Categoria.IdCat + "',Precio = '" + producto.Precio + "',Stock = '" + producto.Stock + "',ActSN = 0 where ProductoId = " + seleccionado.Id);
                                    MessageBox.Show("Stock en 0, producto dado de baja");
                                    Close();
                                }
                                else
                                {
                                    serviceProd.AgregarModificarProducto("update Productos set NombreProd = '" + producto.Nombre + "',Descripcion = '" + producto.Descripcion + "',ImagenProd = '" + producto.Imagen + "',CategoriaProd = '" + producto.Categoria.IdCat + "',Precio = '" + producto.Precio + "',Stock = '" + producto.Stock + "' where ProductoId = " + seleccionado.Id);
                                    MessageBox.Show("Modificado exitosamente");
                                    Close();
                                }
                            }
                            catch (Exception ex)
                            { MessageBox.Show(ex.ToString()); }
                        }
                        else if (imagen == false && archivo != null )
                        {
                            MessageBox.Show("Ya existe un producto con esta imagen, por favor elija otra imagen");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Completar el precio y el stock con numeros");
                    }
                 

                }
                else
                {
                    if (txtNombreProd.Text == "")
                    {
                        MessageBox.Show("Falta completar el nombre");
                    }
                    else if (txtDescripcionProd.Text == "")
                    {
                        MessageBox.Show("Falta completar la descripcion");
                    }
                    else if (txtImagenProd.Text == "")
                    {
                        MessageBox.Show("Falta agregar la imagen");
                    }
                    else if (txtPrecioProd.Text == "")
                    {
                        MessageBox.Show("Falta agregar el precio");
                    }
                    else if (txtStockProd.Text == "")
                    {
                        MessageBox.Show("Falta agregar el stock");
                    }
                }              
            }      
        }

        private void btnAgregarImagenLocal_Click(object sender, EventArgs e)
        {
            try
            {
                archivo = new OpenFileDialog();
                archivo.Filter = "jpg|*.jpg|png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtImagenProd.Text = archivo.FileName;
                    pboxAgregarProd.ImageLocation = archivo.FileName;

                }
                else
                {
                    archivo = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtImagenProd_Leave(object sender, EventArgs e)
        {
            pboxAgregarProd.ImageLocation = txtImagenProd.Text;
        }
    }
    
}
