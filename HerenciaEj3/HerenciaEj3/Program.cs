using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEj3
{
    class Persona
    {
        protected string nombre, apellido;
        protected int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apenom
        {
            get { return string.Concat(this.nombre, "-", this.apellido); }
        }

        public int LargoAp
        {
            get { return apellido.Length; }
        }

        public string Info
        {
            get
            {
                string res;
                if (apellido.Length >= 10){
                    res= " apellido largo";
                }
                else
                {
                    res = " apellido corto";
                }
                return res;
            }
        }

        public virtual void imprimir()
        {
            Console.WriteLine(this.Nombre + " " +this.Apellido.ToUpper() + " " + this.Apenom + " " + this.LargoAp + " " + this.Info );
        }

        class Estudiante : Persona
        {
            protected int matricula;
            protected string aCursado;

            public Estudiante(string nombre, string apellido, int edad, int matricula, string aCursado) : base(nombre, apellido, edad)
            {
                this.matricula = matricula;
                this.aCursado = aCursado;
            }

            public int Matricula
            {
                get { return matricula; }
            }

            public string ACursado
            {
                get { return aCursado; }
            }
            public override void imprimir()
            {
                Console.WriteLine(this.Nombre + " " + this.Apellido.ToUpper() + " " + this.Apenom + " " + this.LargoAp + " " + this.Info + " " + this.Edad + " " + this.Matricula + " " + this.ACursado);
            }

        }
        static void Main(string[] args)
        {
            Persona pers = new Persona("juan","Cesarini",45);
            Estudiante est = new Estudiante("Pedro", "Picapiedra", 24, 2395, "3er año");
            pers.imprimir();
            est.imprimir();
            Console.ReadKey();
        }
    }
}
