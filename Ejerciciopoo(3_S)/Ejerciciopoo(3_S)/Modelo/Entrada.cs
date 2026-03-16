using System;
using Ejerciciopoo_3_S_.Enus;

namespace Ejerciciopoo_3_S_.Modelo
{
    public class Entrada : Plato
    {
        public Entrada(string nombre, double costo, int tiempo)
            : base(nombre, costo, tiempo)
        {
        }

        public override void Preparar()
        {
            this.Estado = EstadoOrden.Preparando;
            Console.WriteLine("Preparando la entrada: " + this.Nombre);
        }
    }
}