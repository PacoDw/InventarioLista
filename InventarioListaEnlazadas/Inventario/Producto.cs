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

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE PRODUCTO
        public Producto()
        {
            _codigo = 0;
            _nombre = string.Empty;
            _precio = 0.0F;
            _cantiddad = 0;
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
    }
}
