using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ejercicios
{

    namespace ConsoleApp1.Ejercicios
    {
        class Libro
        {
            public string Titulo { get; set; }
            public string Estado { get; set; }  // "Disponible" o "Prestado"

            public Libro(string titulo)
            {
                Titulo = titulo;
                Estado = "Disponible"; // por defecto inicia disponible
            }

            public void Prestar()
            {
                if (Estado == "Disponible")
                {
                    Estado = "Prestado";
                    Console.WriteLine("El libro '" + Titulo + "' ha sido prestado.");
                }
                else
                {
                    Console.WriteLine("El libro '" + Titulo + "' no está disponible.");
                }
            }
        }

        
    }
}
