using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPoo_1_b.Modelos
{
    internal class Revista : MaterialBiblioteca
    {
        public int NumeroEdicion { get; set; }
        public string Periodicidad { get; set; }

        public Revista(int numeroEdicion, string periodicidad, int id, string titulo, string autor,
                       int anioPublicacion, string categoria)
            : base(id, titulo, autor, anioPublicacion, categoria)
        {
            NumeroEdicion = numeroEdicion;
            Periodicidad = periodicidad;
        }
    }
}
