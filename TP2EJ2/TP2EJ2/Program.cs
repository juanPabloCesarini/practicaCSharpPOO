using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ2
{
    class ClaseAlumno
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int cuota;
        private int edad;

        ClaseAlumno()
        {

        }

        ClaseAlumno(int edad, string nombre, string apellido, string legajo, int cuota)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.cuota = cuota;
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

            }
        }
        public string Nombre
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
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }
        public int Cuota
        {
            get
            {
                return cuota;
            }
            set
            {
                cuota = value;
            }
        }

        public string mostrarEdad(int edad)
        {
            string legal;
            if (edad >= 18)
            {
                legal = "Mayor de edad";
            }
            else
            {
                legal = "Menor de edad";
            }
            return legal;
        }
        public string mostrarCuota(int cuota)
        {
            string laCuota;
            if (cuota >0 && cuota < 5000)
            {
                laCuota = "Cuota accesible";
            }
            else
            {
                if (cuota >=5000 && cuota < 10000)
                {
                    laCuota = "Cuota Cara";
                }
                else
                {
                    laCuota = "Cuota muy Cara";
                }
            }
            return laCuota;
        }
        public void imprimir()
        {
            Console.WriteLine("El alumno se llama " + this.Nombre + " y su apellido es " + this.Apellido + " y su edad es: " + this.Edad + "\nPor lo tanto es " + mostrarEdad(this.Edad) + " y la cuota que paga es: " + mostrarCuota(this.Cuota));
        }

        static void Main(string[] args)
        {
            ClaseAlumno alu1 = new ClaseAlumno();
            ClaseAlumno alu2 = new ClaseAlumno(33, "Pedro", "Lopez", "4589", 12650);
            Console.Write("Nombre: ");
            alu1.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            alu1.Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            alu1.Edad = int.Parse(Console.ReadLine());
            Console.Write("Legajo: ");
            alu1.Legajo = Console.ReadLine();
            Console.Write("Cuota: ");
            alu1.Cuota = int.Parse(Console.ReadLine());

            alu1.imprimir();
            Console.WriteLine("\n-------------------\n");
            alu2.imprimir();
            Console.ReadKey();
        }
    }
}
