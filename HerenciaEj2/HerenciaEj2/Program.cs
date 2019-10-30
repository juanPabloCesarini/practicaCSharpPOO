using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEj2
{
    class Publicacion
    {
        protected string titulo;
        protected string autor;
        protected double precio;

        Publicacion(string titulo, string autor, double precio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.precio = precio;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        class Libro : Publicacion
        {
            protected int nroPag;

            public Libro(string titulo, string autor, double precio, int nroPag) : base(titulo, autor, precio)
            {
                this.nroPag = nroPag;
            }

            public int NroPag
            {
                get { return nroPag; }
                set { nroPag = value; }
            }

            public void informar()
            {
                Console.WriteLine("Título: {0}\nAutor: {1}\nPrecio: $ {2}\nPáginas: {3}", this.Titulo, this.Autor, this.Precio, this.NroPag);
            }
        }
        class CD : Publicacion
        {
            protected double tiempo;

            public CD(string titulo, string autor, double precio, double tiempo) : base(titulo, autor, precio)
            {
                this.tiempo = tiempo;
            }

            public double Tiempo
            {
                get { return tiempo; }
                set { tiempo = value; }
            }

            public void informar()
            {
                Console.WriteLine("Título: {0}\nAutor: {1}\nPrecio: $ {2}\nTiempo de reproducción: {3}", this.Titulo, this.Autor, this.Precio, this.Tiempo);
            }
        }
        
        static void Main(string[] args)
        {
            Libro lib = new Libro("Cien años de soledad","Garcia Marquez",1050,200);
            CD compact = new CD("True Blue","Madonna",150,58);
            Console.WriteLine("Libro:");
            lib.informar();
            Console.WriteLine("\nCD: ");
            compact.informar();
            Console.ReadKey();
        }
    }

}
