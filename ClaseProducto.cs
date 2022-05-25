using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    class ClaseProducto
    {
        string nombre;
        double precio;
        double cantidad;

        public ClaseProducto(string nombre, double precio, double cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public ClaseProducto()
        {
            this.nombre = "";
            this.precio = 0;
            this.cantidad = 0;
        }

        public string pNombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public double pPrecio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public double pCantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double calcularImporte(double porcentaje)
        {
            return precio * cantidad + (precio * cantidad * porcentaje / 100);
        }
    }
}
