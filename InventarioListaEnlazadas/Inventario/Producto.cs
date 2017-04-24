using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE CON SU RESPECTIVO GET
        private int _codigo;
        public int codigo { get { return _codigo; } }

        private string _nombre;
        public string nombre { get { return _nombre; } }

        private float _precio;
        public float precio { get { return _precio; } }

        private int _cantiddad;
        public int cantidad { get { return _cantiddad; } }

        private Producto _siguiente;
        public Producto siguiente { get { return _siguiente; } set { _siguiente = value; } }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE PRODUCTO
        public Producto()
        {
            _codigo = 0;
            _nombre = string.Empty;
            _precio = 0.0F;
            _cantiddad = 0;
            _siguiente = null;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO SETCODIGO
        public void setCodigo(int codigo)
        {
            this._codigo = codigo;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO SETNOMBRE
        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO SETPRECIO
        public void setPrecio(float precio)
        {
            this._precio = precio;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO SETCANTIDAD
        public void setCantidad(int cantidad)
        {
            this._cantiddad = cantidad;
        }

        public override string ToString()
        {
            string info = "Código:    " + this.codigo + Environment.NewLine +
                        "Nombre:    " + this.nombre + Environment.NewLine +
                        "Precio:    " + this.precio + Environment.NewLine +
                        "Cantidad:  " + this.cantidad + Environment.NewLine +
                        " ----------------------------------------------" + Environment.NewLine + Environment.NewLine;
            return info;
        }
    }
}
