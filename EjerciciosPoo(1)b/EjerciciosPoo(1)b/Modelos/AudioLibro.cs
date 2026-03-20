using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPoo_1_b.Modelos
{
    internal class AudioLibro : MaterialBiblioteca
    {
        public double Duracion { get; set; }
        public string Narrador { get; set; }

        public AudioLibro(double duracion, string narrador, int id, string titulo, string autor,
                          int anioPublicacion, string categoria)
            : base(id, titulo, autor, anioPublicacion, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }
    }
}
