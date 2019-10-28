using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3EJ1y2
{
    class Estudiantes
    {
        private string nombre;
        private string apellido;
        private long DNI;
        private int edad;

        Estudiantes()
        {

        }
        Estudiantes(string nombre, string apellido, long DNI, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
            this.edad = edad;
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value.ToLower();

            }

        }



        public string Apellido
        {
            get
            {

                return apellido;
            }
            set
            {

                apellido = value.ToUpper();
            }

        }

        public long Dni
        {
            get
            {
                return DNI;
            }
            set
            {
                DNI = value;
            }

        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
                while (value < 0 || value > 100)
                {
                    Console.Write("--ERROR-- Ingresar nuevamente la edad: ");
                    value = int.Parse(Console.ReadLine());
                }
                edad = value;
                // Console.ReadKey();
            }

        }


        public void cargarDatos()
        {
            Console.Write("Ingrese nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("DNI: ");
            DNI = long.Parse(Console.ReadLine());
            Console.Write("Edad: ");
            Edad = int.Parse(Console.ReadLine());
        }

        public void imprimirDatos()
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nDNI: {2}\nEdad: {3}", this.Nombre, this.Apellido, this.Dni, this.Edad);
        }
        static void Main(string[] args)
        {
            Estudiantes est1 = new Estudiantes();
            est1.cargarDatos();
            est1.imprimirDatos();
            Console.ReadKey();
        }

    }
}

