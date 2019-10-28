using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3EJ3
{
    class Ventas
    {
        private string producto;
        private double punit;
        private int cantidad;

        Ventas()
        {

        }

        public string Producto
        {
            get
            {
                return producto;
            }
            set
            {
                producto = value;
            }
        }

        public double Punit
        {
            get
            {
                return punit;
            }
            set
            {
                punit = value;
            }
        }

        public int Cantidad
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

        public double Subtotal
        {
            get
            {
                return punit * cantidad;
            }
        }
        public double IVA
        {
            get
            {
                return Subtotal * 0.21;
            }
        }
        public double Total
        {
            get
            {
                return Subtotal + IVA;
            }
        }

        public void cargarDatos()
        {
            Console.Write("Ingrese Producto: ");
            this.Producto = Console.ReadLine();
            Console.Write("Precio Unit.: ");
            this.Punit = double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            this.cantidad = int.Parse(Console.ReadLine());
        }

        public void imprimir()
        {
            Console.WriteLine("\n---- LISTADO DE PRODUCTOS ----");
            Console.WriteLine("\nProducto: {0}\nPrecio unitario: {1}\nCantidad: {2}\nSubtotal: {3}\nIVA 21%: {4}\nTotal General: {5}", this.Producto, this.Punit, this.Cantidad, this.Subtotal, this.IVA, this.Total);
        }
        static void Main(string[] args)
        {
            Ventas ventas1 = new Ventas();
            ventas1.cargarDatos();
            ventas1.imprimir();
            Console.ReadKey();
        }
    }
}
