using Ejerciciopoo_3_S_.Enus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciopoo_3_S_.Modelo
{
    public class PlatoPrincipal : Plato
    {
        public PlatoPrincipal(string nombre, double costo, int tiempo)
            : base(nombre, costo, tiempo)
        {
        }

        public override void Preparar()
        {
            this.Estado = EstadoOrden.Preparando;
            Console.WriteLine("Preparando el plato principal: " + this.Nombre);
        }
    }
}
