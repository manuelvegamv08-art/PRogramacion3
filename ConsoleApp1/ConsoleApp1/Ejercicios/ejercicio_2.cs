using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//App de Streaming de Música: Crea una interfaz IReproductor con métodos Play() 
//    y Stop(). Implementa esta interfaz en clases como Cancion
//    y Podcast. El usuario debe poder "darle play" a cualquiera de los dos.

namespace ConsoleApp1.Ejercicios
{
    interface IReproductor
    {
        void Play();
        void Stop();
    }

    class Cancion : IReproductor
    {
        public string Titulo { get; set; }

        public Cancion(string titulo)
        {
            Titulo = titulo;
        }

        public void Play()
        {
            Console.WriteLine("Reproduciendo canción: " + Titulo);
        }

        public void Stop()
        {
            Console.WriteLine("Canción detenida: " + Titulo);
        }
    }

    class Podcast : IReproductor
    {
        public string Nombre { get; set; }

        public Podcast(string nombre)
        {
            Nombre = nombre;
        }

        public void Play()
        {
            Console.WriteLine("Reproduciendo podcast: " + Nombre);
        }

        public void Stop()
        {
            Console.WriteLine("Podcast detenido: " + Nombre);
        }
    }

    
}
