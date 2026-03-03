using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_1.Ejercicios__poo_
{
    internal class Vendedor: Empleado
    {
        public double comision { get; set; }
        public int ventasRealizadas { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase + (comision * ventasRealizadas);
        }
    }
}
