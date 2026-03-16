using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implementa CuentaCorriente: Permite un sobregiro de hasta $500.

namespace Ejercicio_2_poon_.Clases
{
    // Heredamos de CuentaBancaria
    internal class CuentaCorriente : CuentaBancaria
    {
        // Definimos el límite de sobregiro como una constante para que sea fácil de cambiar
        private const double LimiteSobregiro = 500.0;

        public CuentaCorriente(double saldoInicial) : base(saldoInicial, 0)
        {
        }

        // Nuevo método de retiro con lógica de sobregiro
        public void RetirarConSobregiro(double montoARetirar)
        {
            double saldoActual = getSaldo();

            // La lógica cambia: El saldo puede quedar negativo, 
            // siempre que (Saldo - Monto) no sea menor a -500.
            if (saldoActual - montoARetirar >= -LimiteSobregiro)
            {
                double nuevoSaldo = saldoActual - montoARetirar;
                setSaldo(nuevoSaldo);

                Console.WriteLine($"Retiro de ${montoARetirar} autorizado.");
                Console.WriteLine($"Saldo actual: ${getSaldo()} {(getSaldo() < 0 ? "(En sobregiro)" : "")}");
            }
            else
            {
                Console.WriteLine("--- RETIRO RECHAZADO ---");
                Console.WriteLine($"El monto excede el límite de sobregiro permitido ($500).");
                Console.WriteLine($"Saldo disponible con sobregiro: ${saldoActual + LimiteSobregiro}");
            }
        }
    }
}
