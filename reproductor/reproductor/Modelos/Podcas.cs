using reproductor.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductor.Modelos
{
    public class Podcas: Reproductor
    {
        public String Titulo { get; set; }
            public String Creador { get; set; }
            public String Episodio { get; set; }

        public void play() 
        { 
            Console.WriteLine("Reproduciendo el podcast: " + Titulo + " de " + Creador);

        }

        public void Stop()
        {
            Console.WriteLine("Deteniendo el podcast: " + Titulo + " de " + Creador);
        }


    }
}
