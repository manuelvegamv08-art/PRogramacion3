using Ejercicio_poo_1.Ejercicios__poo_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_poo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            Gerente gerente1 = new Gerente
            {
                Nombre = "Carlos",
                SalarioBase = 3000000,
                BonoFijo = 500000
            };

            Vendedor vendedor1 = new Vendedor
            {
                Nombre = "Ana",
                SalarioBase = 1500000,
                comision = 50000,
                ventasRealizadas = 10
            };

            empleados.Add(gerente1);
            empleados.Add(vendedor1);

            foreach (Empleado emp in empleados)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario Final: {emp.CalcularSalario():C}");
                Console.WriteLine("-------------------------");
            }
        }
    }
    }

