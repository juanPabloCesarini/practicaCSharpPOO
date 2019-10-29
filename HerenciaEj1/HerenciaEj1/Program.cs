using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEj1
{
    class Operacion
    {
        protected double nro1, nro2, res;

        public double Nro1
        {
            get { return nro1; }
            set { nro1 = value; }
        }

        public double Nro2
        {
            get { return nro2; }
            set { nro2 = value; }
        }
        public double Res
        {
            get { return res; }
            set { res = value; }
        }


        class Suma : Operacion
        {
            public void operar()
            {
                Res = Nro1 + Nro2;
            }

            public void imprimir()
            {
                Console.WriteLine("La suma de: {0} + {1} = {2}", this.Nro1, this.Nro2, this.Res);
            }
        }

        class Resta : Operacion
        {
            public void operar()
            {
                Res = Nro1 - Nro2;
            }

            public void imprimir()
            {
                Console.WriteLine("La suma de: {0} - {1} = {2}", this.Nro1, this.Nro2, this.Res);
            }
        }
        class Producto : Operacion
        {
            public void operar()
            {
                Res = Nro1 * Nro2;
            }

            public void imprimir()
            {
                Console.WriteLine("La suma de: {0} * {1} = {2}", this.Nro1, this.Nro2, this.Res);
            }
        }
        static void Main(string[] args)
        {
            Suma s1 = new Suma();
            Resta r1 = new Resta();
            Producto p1 = new Producto();
            s1.Nro1 = 10;
            s1.Nro2 = 10;
            s1.operar();
            s1.imprimir();

            r1.Nro1 = 10;
            r1.Nro2 = 10;
            r1.operar();
            r1.imprimir();

            p1.Nro1 = 10;
            p1.Nro2 = 10;
            p1.operar();
            p1.imprimir();
            Console.ReadKey();

        }

    }
}

