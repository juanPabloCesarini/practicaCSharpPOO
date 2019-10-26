using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1EJ3
{
    class Cuadrado
    {
        private double lado;

        Cuadrado()
        {

        }
        public double Lado
        {
            get
            {
                return lado;
            }
            set
            {
                lado = value;
            }
        }
        public double inicializar()
        {
            Console.Write("Ingresar medida del lado: ");
            lado = double.Parse(Console.ReadLine());
            return lado;
        }
        public void calcularPerimetro(double lado)
        {
            double perimetro = lado * 4;
            Console.WriteLine("El perímetro del cuadrado es: {0} cms.", perimetro);
        }
        public void calcularSuperficie(double lado)
        {
            double sup = lado * lado;
            Console.WriteLine("La superficie del cuadrado es: {0} cms.", sup);
        }
        static void Main(string[] args)
        {
            Cuadrado miCuadrado = new Cuadrado();
            miCuadrado.Lado = miCuadrado.inicializar();
            miCuadrado.calcularPerimetro(miCuadrado.Lado);
            miCuadrado.calcularSuperficie(miCuadrado.Lado);
            Console.ReadKey();
        }
    }
}
