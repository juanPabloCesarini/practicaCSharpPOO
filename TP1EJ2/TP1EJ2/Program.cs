using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EJ2
{
    class Cubo
    {
        private double lado, area, volumen;

        Cubo()
        {

        }

        public double Lado
        {
            set
            {
                lado = value;
            }
        }
        public double Area
        {
            set
            {
                area = value;
            }
        }

        public double Volumen
        {
            set
            {
                volumen = value;
            }
        }

        public double calcularVolumen(double lado)
        {
            volumen = lado * lado * lado;
            return volumen;
        }

        public double calcularArea(double lado)
        {
            area = lado * lado * 6;
            return area;
        }
        static void Main(string[] args)
        {
            Cubo miCubo = new Cubo();
            double v, a;
            Console.Write("Ingresar medida del lado: ");
            miCubo.lado = double.Parse(Console.ReadLine());
            v = miCubo.calcularVolumen(miCubo.lado);
            a = miCubo.calcularArea(miCubo.lado);
            Console.WriteLine("Area del cubo: {0}\nVolumen de cubo: {1}", a, v);
            Console.ReadKey();
            
        }
    }
}
