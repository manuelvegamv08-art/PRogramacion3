using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPoo_1_b.Modelos
{
    public class Libro : MaterialBiblioteca
    {
        public int numeroDePagina;
        public string ISBN;

        public Libro(string isbn, int numeroDePagina, int id, string titulo, string autor, int anioPublicacion, string categoria)
            : base(id, titulo, autor, anioPublicacion, categoria)
        {
            this.ISBN = isbn;
            this.numeroDePagina = numeroDePagina;
        }
    }
}