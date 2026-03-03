using reproductor.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace reproductor.Modelos
{
    public class Cancion:Reproductor
    {
        public String Titulo { get; set; }
        public String Artista { get; set; }
        public String Album { get; set; }

        public void play()
        {
            Console.WriteLine("Reproduciendo la canción: " + Titulo + " de " + Artista +"ingrese el albun" +Album);
        }

        public void Stop()
        {
            Console.WriteLine("Deteniendo la canción: " + Titulo + " de " + Artista +"ingrese el albun" +Album);
        }
    }
}
