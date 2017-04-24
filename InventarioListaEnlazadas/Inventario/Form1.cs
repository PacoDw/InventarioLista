using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormMain : Form
    {
        InventarioControl inventario = new InventarioControl();
        public FormMain()
        {
            InitializeComponent();

            //Muesta el numeros de productos existentes
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON ADD
        private void bttonAdd_Click(object sender, EventArgs e)
        {
            //Se crea un objeto de la clase producto
            Producto product = new Producto();

            //Se establecen las caracteristicas del objeto
            product.setCodigo(Convert.ToInt32(txtCodigo.Text));
            product.setNombre(txtNombre.Text);
            product.setPrecio(float.Parse(txtPrecio.Text));
            product.setCantidad(Convert.ToInt32(txtCantidad.Text));

            //Se agrega el producto al inventario mediante un metodo que recibe como parametro un producto
            inventario.Agregar(product);
            
            //Se limpian las casillas
            txtCodigo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = String.Empty;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON DELETE
        private void bttonDelete_Click(object sender, EventArgs e)
        {
            //Se envia por parametro el codigo del producto que se desea borrar
            inventario.Borrar(Convert.ToInt32(txtCodigo.Text));

            //Se limpian las casillas
            txtCodigo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = String.Empty;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON iNSERTAR
        private void bttonInsertar_Click(object sender, EventArgs e)
        {
            //Se crea un objeto de la clase producto
            Producto product = new Producto();

            //Se establecen las caracteristicas del objeto producto
            product.setCodigo(Convert.ToInt32(txtCodigo.Text));
            product.setNombre(txtNombre.Text);
            product.setPrecio(float.Parse(txtPrecio.Text));
            product.setCantidad(Convert.ToInt32(txtCantidad.Text));

            //Se inserta el producto especificando como parametro en que posicion
            inventario.Insertar(product, Convert.ToByte(txtPosicion.Text));


            //Se limpian las casillas
            txtCodigo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = String.Empty;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON BUSCAR
        private void bttonBuscar_Click(object sender, EventArgs e)
        {
            //Se crea una variable pos que determina la posicion en la que esta el producto que sea desea encontrar
            Producto auxPro = inventario.Buscar(Convert.ToInt32(txtCodigo.Text));

            //Si fue encontrado el mismo metodo nos devolvera como true, ademas enviamos por parametro el codigo del producto que deseamos encontrar
            //, y por referencia pasamos la posicion
            if (auxPro != null)
            {
                //Se obtienen los valores del producto encontrado
                txtNombre.Text = auxPro.nombre;
                txtPrecio.Text = auxPro.precio.ToString();
                txtCantidad.Text = auxPro.cantidad.ToString();
            }
            else
            {
                //si no se encontro se muestra el siguiente mensaje
                MessageBox.Show("No se encontro ningún producto con el código.\nIntenta con otro código...", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Text = string.Empty;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON REPORTE
        private void bttonReporte_Click(object sender, EventArgs e)
        {
            txtReportes.Text = inventario.Reporte();
        }
    }
}
