using System;

namespace TP1EJ1
{
    class Estudiante
    {
        private string nombre;
        private string apellido;
        private int legajo;

        Estudiante()
        {

        }
        Estudiante(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Su nombre es " + this.Nombre + " y su apellido " + this.Apellido + " y su legajo es: " + this.Legajo);
        }
        static void Main(string[] args)
        {
            Estudiante Est1 = new Estudiante("Juan", "Gonzalez", 1586);
            Estudiante Est2 = new Estudiante("Pablo", "Marmol", 8453);

            Est1.imprimir();
            Est2.imprimir();
            Console.ReadKey();
        }
    }
}
