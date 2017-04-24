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
        private Producto[] _vecProduct = new Producto[15]; //Definimos un vector que almacenara 15 productos
        public Producto[] vecProduct { get { return _vecProduct; } } //Establecemos un get del almacen

        private byte _contador;                            //creamos un contador que ira incrementando cada vez que se agrege un producto
        public byte contador { get { return _contador; } } //Creamos un get para el contador

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE INVENTARIOCONTROL
        public InventarioControl()
        {
            this._contador = 0;  //se inicializa el contador en cero
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR 
        public void Agregar(Producto product)
        {
            _vecProduct[_contador] = product;   //se agrega un producto
            _contador++;                        //y se incrementa el contador
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BUSCAR
        public Producto Buscar(int codigo)
        {
            //Definimos una variable bool para definir si se encontro un producto
            Producto auxPro = null;

            //se crea un bucle para recorrer el vector he identificar si se encuentra el producto
            for (byte i = 0; i < _contador; i++)
                if (codigo == _vecProduct[i].codigo)
                    auxPro = _vecProduct[i];                //si se encuentra aux pro es igual a producto acutal

            return auxPro;  //se retorna torna la referencia del producto actual
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BORRAR 
        public void Borrar(int codigo)
        {
            Producto aux;

            //Se crea un bucle para identificar el produto y elminarlo (null)
            for (byte i = 0; i < _contador; i++)
                if (codigo == _vecProduct[i].codigo)
                    _vecProduct[i] = null;

            //En este otro for se determina el producto null y se envia a la ultima posicion recorriendolo,
            // despues de hacer esto le restamos uno al contador para que ya no lo tome en cuenta
            for (byte i = 1; i < _contador; i++)
                if (_vecProduct[i - 1] == null)
                {
                    aux = _vecProduct[i];
                    _vecProduct[i] = _vecProduct[i - 1];
                    _vecProduct[i - 1] = aux;
                }
            _contador--;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO BUSCAR
        public void Insertar(Producto newProduct, byte posicion)
        {
            //Se crea un auxiliar
            Producto aux = null;

            if (contador < vecProduct.Length)
                _contador++;

            //Se hace un bucle empezando por la posicion hasta el contador que define los elementos que tiene
            for (byte i = (posicion-=1); i < contador; i++)
            {
                aux = vecProduct[i];           //se guarda el producto de la posicion actual
                vecProduct[i] = newProduct;    //se establece el producto de la posicion anterior en la posicion actual
                newProduct = aux;                     //se copia el producto actual
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO REPORTE
        public string Reporte()
        {
            //se crea una variable string
            string reporte = string.Empty;

            //Se hace un bucle para ir recorriendo el vector de los productos he ir guardando las caracteristicas
            //de cada producto por el que pase en la variable string reporte
            for(byte i = 0, k = 1; i < _contador; i++, k++)
            {
                reporte += "[" + k + "] ----------------------------------------------" + Environment.NewLine +
                        "Código:    " + vecProduct[i].codigo + Environment.NewLine +
                        "Nombre:    " + vecProduct[i].nombre + Environment.NewLine +
                        "Precio:    " + vecProduct[i].precio + Environment.NewLine +
                        "Cantidad:  " + vecProduct[i].cantidad + Environment.NewLine + Environment.NewLine;
            }
            return reporte; // se retorna el reporte con las caracteristicas de todos los productos
        }

    }
}
