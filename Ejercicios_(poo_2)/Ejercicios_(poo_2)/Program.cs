using Ejercicios__poo_2_.CuentaBancaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__poo_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria ahorro = new CuentaAhorros(1000);
            CuentaBancaria corriente = new CuentaCorriente(1000);

            Console.WriteLine("=== CUENTA AHORROS ===");
            ahorro.Retirar(1200);   // No permite
            ahorro.Depositar(500);
            ahorro.Retirar(300);

            Console.WriteLine("\n=== CUENTA CORRIENTE ===");
            corriente.Retirar(1400);  // Permite hasta -500
            corriente.Retirar(200);   // Puede exceder límite
        }
    }
    
}
