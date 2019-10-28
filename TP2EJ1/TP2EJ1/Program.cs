using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ1
{
    class ClaseTrabajador
    {
        private string nombre;
        private string apellido;
        private string sector;
        private int edad;
        private double sueldo1, sueldo2, sueldoTotal;

        ClaseTrabajador()
        {

        }

        ClaseTrabajador(string nombre, string apellido, string sector, double sueldo1, double sueldo2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sector = sector;
            this.sueldo1 = sueldo1;
            this.sueldo2 = sueldo2;
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
        public string Sector
        {
            get
            {
                return sector;
            }
            set
            {
                switch (value)
                {
                    case "A":
                        Console.WriteLine("Administrativo");
                        break;
                    case "P":
                        Console.WriteLine("Producción");
                        break;
                    case "S":
                        Console.WriteLine("Secretaría");
                        break;
                    default:
                        Console.WriteLine("NO VALIDO");
                        break;
                }
            }
        }
        public double Sueldo1
        {
            get
            {
                return sueldo1;
            }
            set
            {
                sueldo1 = value;
            }
        }
        public double Sueldo2
        {
            get
            {
                return sueldo1;
            }
            set
            {
                sueldo1 = value;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
