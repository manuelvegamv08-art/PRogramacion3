using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_1.Ejercicios__poo_
{
    class Empleado
    {
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }

    }
}
