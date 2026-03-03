using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_1.Ejercicios__poo_
{
    internal class Gerente: Empleado
    {
        public double BonoFijo { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase + BonoFijo;
        }
    }
}
