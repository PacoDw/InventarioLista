using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class InventarioControl
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        private Producto productInicio; 
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE INVENTARIOCONTROL
        public InventarioControl()
        {
            this.productInicio = null;  //se inicializa el contador en cero
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR 
        public void Agregar(Producto newProduct)
        {
            if (productInicio == null)
                productInicio = newProduct;
            else
            {
                Producto temp = productInicio;
                while (temp.siguiente != null)
                    temp = temp.siguiente;

                temp.siguiente = newProduct;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BUSCAR
        public Producto Buscar(int codigo)
        {
            //Definimos una variable bool para definir si se encontro un producto
            Producto temp = null;

            if (productInicio != null)
            {
                 temp = productInicio;
                while(temp != null)
                {
                    if (temp.codigo == codigo)
                        break;
                    temp = temp.siguiente;
                }
            }
            //si se encuentra aux pro es igual a producto acutal
            return temp;  //se retorna torna la referencia del producto actual
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BORRAR 
        public void Borrar(int codigo)
        {
            Producto temp = null;
            bool encontrado = false;

            if(productInicio != null)
            {
                temp = productInicio;

                if(temp.codigo == codigo)
                {
                    productInicio = temp.siguiente;
                    temp = null;
                }
                else
                {
                    while (encontrado != true)
                    {
                        if (temp.siguiente.codigo == codigo)
                        {
                            temp.siguiente = temp.siguiente.siguiente;
                            encontrado = true;
                        }
                        temp = temp.siguiente;
                    }
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BUSCAR
        //public void Insertar(Producto newProduct, byte posicion)
        //{
        //    //Se crea un auxiliar
        //    Producto aux = null;

        //    if (contador < vecProduct.Length)
        //        _contador++;

        //    //Se hace un bucle empezando por la posicion hasta el contador que define los elementos que tiene
        //    for (byte i = (posicion-=1); i < contador; i++)
        //    {
        //        aux = vecProduct[i];           //se guarda el producto de la posicion actual
        //        vecProduct[i] = newProduct;    //se establece el producto de la posicion anterior en la posicion actual
        //        newProduct = aux;                     //se copia el producto actual
        //    }
        //}

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO REPORTE
        public string Reporte()
        {
            //se crea una variable string
            string reporte = string.Empty;

            Producto temp = productInicio;

            while(temp != null)
            {
                reporte += temp.ToString();
                temp = temp.siguiente;
            }
            return reporte; // se retorna el reporte con las caracteristicas de todos los productos
        }

    }
}
